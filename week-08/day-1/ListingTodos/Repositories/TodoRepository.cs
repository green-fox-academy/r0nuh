﻿using ListingTodos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        private TodoContext todoContext;


    }
}
