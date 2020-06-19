using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TodooData;

namespace TodooLogic
{
    public class DataHandling
    {
        private static TodooRepository todooRepository = new TodooRepository();

        public void addTodoo(DateTime dateTime, string text)
        {
            var newTodoo = new todoo() { date = dateTime, text = text };
            todooRepository.create(newTodoo);
        }

        public List<todoo> findAllUpNext()
        {
            List<todoo> todoos = todooRepository.findAllUpNext();

            return todoos;
        }

        public void deleteTodoo(List<Boolean> checkedList)
        {
            List<todoo> todoos = todooRepository.findAllUpNext();

            for (int i = 0; i < 10; i++)
            {
                if (checkedList[i])
                {
                    todooRepository.deleteOne(todoos[i]);
                }
            }
        }
    }
}
