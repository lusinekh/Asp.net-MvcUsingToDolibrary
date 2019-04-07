using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.netMvcUsingToDolibrary.Models
{
    public class ToDo
    {
        public int ID { get; set; }
        public string Discretion { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsDone { get; set; }
        public  ToDo()
        {
            IsDone = false;
        }
    }
}