using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodooData
{
    public class TodooRepository : Repository<todoo>
    {
        TodooEntities entities = new TodooEntities();

        public int create(todoo entity)
        {
            entities.todoo.Add(entity);
            return entities.SaveChanges();
        }

        public List<todoo> findAll()
        {
            throw new NotImplementedException();
        }

        public todoo findOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<todoo> findAllUpNext()
        {
            List<todoo> todoos = new List<todoo>();
            var oneHourMore = DateTime.Now.AddHours(1);
            todoos = entities.todoo.Where(x => x.date >= DateTime.Now && x.date <= oneHourMore).ToList();

            return todoos;
        }

        public void deleteOne(todoo todoo)
        {
            entities.todoo.Remove(todoo);
            entities.SaveChanges();
        }
    }
}
