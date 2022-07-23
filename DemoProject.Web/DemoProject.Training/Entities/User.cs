using DemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Training.Entities
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public string Word { get; set; }
    }
}
