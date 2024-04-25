using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_6.Source
{
    public class DbService<T> where T : class
    {
        public BindingSource TableBindingSource
        {
            get
            {
                return _tableBindingSource;
            }
            set
            {
                _tableBindingSource = value;
            }
        }
        public DbSet<T> Table 
        { 
            get
            {
                return _context.Set<T>();
            } 
        }

        private BindingSource _tableBindingSource;
        private ApplicationContext _context = new ApplicationContext();

        public DbService()
        {
            _context.Set<T>().Load();
        }
        public DbService(BindingSource dgvSource)
        {
            _tableBindingSource = dgvSource;

            _context.Configuration.ProxyCreationEnabled = false;
            _context.Set<T>().Load();
            _tableBindingSource.DataSource = _context.Set<T>().Local.ToBindingList();
        }

        public void Add(T entity)
        {
            _tableBindingSource.DataSource = _context.Set<T>().Local.ToBindingList();
            _context.Set<T>().Add(entity);
            SaveChanges();
        }

        public bool Remove(int index)
        {
            var dialogResult = MessageBox.Show("Вы уверены, что хотите удалить данные? Этот процесс необратим"
                , "Предупреждение!"
                , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return false;
            }

            _tableBindingSource.RemoveAt(index);
            SaveChanges();
            return true;
        }

        public void FilterData(IQueryable<T> filter)
        {
            _tableBindingSource.DataSource = filter.ToList();
        }

        public void SaveChanges()
        {
            _tableBindingSource.EndEdit();
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
