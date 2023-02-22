﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp
{
    internal interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(int grade);
        void AddGrade(char grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
