using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklogs
{
    enum TaskStatus
    {
        pending = 1,
        completed = 2,
        failed = 3
    }

    class Tasklog
    {
        public TaskStatus status { get; set; }

        public Object item { get; set; }

        public void processItem()
        {
            try
            {
                this.item = (Int32.Parse((string)this.item) + 1).ToString();
                this.status = TaskStatus.completed;
            }
            catch (Exception)
            {
                this.status = TaskStatus.failed;
            }
        }
    }
}
