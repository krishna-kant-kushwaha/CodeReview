using ReviewCode.OOPReview.StudentInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewCode.OOPReview
{
    public class StudentLibraryInfo
    {
        public bool SaveStudentInfo(Student stdObj)
        {
            try
            {
                if (stdObj.FirstName == "Ram")
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Student> SaveBulkStudentInfo(List<Student> stdListObj)
        {
            try
            {
                foreach (var item in stdListObj)
                {
                    if (item.FirstName == "Ram")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                return stdListObj;
            }
            catch (Exception ex)
            {
                return stdListObj;
            }
        }
    }
}