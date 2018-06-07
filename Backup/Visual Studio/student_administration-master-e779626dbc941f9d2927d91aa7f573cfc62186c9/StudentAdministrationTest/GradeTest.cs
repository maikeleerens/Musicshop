using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentAdministration;
using StudentAdministration.Data;
using StudentAdministration.Logic;
using StudentAdministration.Models;

namespace StudentAdministrationTest
{
    [TestClass]
    public class GradeTest
    {
        private GradeRepository gradeRepo;

        [TestInitialize]
        public void Initialize()
        {
            this.gradeRepo = new GradeRepository(new GradeMemoryContext());
        }
    }

    /// <summary>
    /// Mock class to mimic the real database to allow the unit tests to run
    /// without affecting any stored data.
    /// </summary>
    public class GradeMemoryContext : IGradeContext
    {
        // This list holds our grade data: consider this the database the 
        // unit tests will work with
        private Dictionary<Student, Grade> grades = new Dictionary<Student, Grade>();

        public Grade GetForStudent(Student student)
        {
            if (grades.ContainsKey(student))
            {
                return grades[student];
            }
            return null;
        }

        public bool Insert(Student student, Grade grade)
        {
            // The student should exist before grades can be entered: this can
            // be checked by seeing if the Id property has been set
            if (student.Id != -1)
            {
                grades[student] = grade;
                return true;
            }
            return false;
        }
    }
}
