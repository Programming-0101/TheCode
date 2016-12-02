using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeBook.ConsoleUI
{
    class GradebookGradeRecordingForm
    {
        public StudentEvaluation Gradebook { get; private set; }
        public bool GradesEntered { get; private set; }

        public GradebookGradeRecordingForm(StudentEvaluation gradebook)
        {
            Gradebook = gradebook;
        }

        public void ShowForm()
        {
            // Show the grades at present
            // Menu to allow marks to be entered
            // Save/Exit form
        }
    }
}
