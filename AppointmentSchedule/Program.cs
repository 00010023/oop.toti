// See https://aka.ms/new-console-template for more information

using System;
using AppointmentSchedule;

var teacher = new Teacher();
Console.WriteLine("\nTeacher's Perspective");
teacher.AddEvaluation("PhD Math Science");
teacher.AddEvaluation("PhD Physics Science");
teacher.PrintEvaluations();

var hr = new HumanResource(teacher);
Console.WriteLine("\nHuman Resource's Perspective");
hr.RemoveEvaluation("PhD Physics Science");
hr.PrintEvaluations();