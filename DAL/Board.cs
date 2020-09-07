using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Board
    {
        private static Board instanse;
        private static List<BaseTask> _tasks;
        private Board()
        {
            //TODO: implement generating task list
        }

        private static Board GetInstance()
        {
            if (instanse == null)
            {
                instanse = new Board();
            }
            return instanse;

        }
    }
}
