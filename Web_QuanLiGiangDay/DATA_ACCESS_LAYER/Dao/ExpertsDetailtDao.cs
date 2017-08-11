using WCF.BussinessObject.Objects;
using System;
using System.Collections.Generic;
using DataAccessLayer.DataModels;
namespace DataAccessLayer.Dao
{
    public class ExpertsDetailtDao
    {

        public bool Insert(ExpertsDetailtObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_ExpertsDetailt_INSERT(ob.ExId, ob.ExpertId, ob.CoId, ob.Description);
            return true;
        }


        public bool Update(ExpertsDetailtObjects ob)
        {
            var db = new eTrainingScheduleEntities();
            var data = db.sp_tbl_S07_ExpertsDetailt_UPDATE(ob.ExId, ob.ExpertId, ob.CoId, ob.Description);
            return true;
        }


        public List<ExpertsDetailtObjects> GetAll()
        {
            List<ExpertsDetailtObjects> lst = new List<ExpertsDetailtObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_ExpertsDetailt_GetAll();
            foreach (var item in list)
            {
                ExpertsDetailtObjects ob = new ExpertsDetailtObjects();
                ob.ExId = item.ExId; ob.ExpertId = item.ExpertId; ob.CoId = item.CoId; ob.Description = item.Description;
                lst.Add(ob);
            }
            return lst;
        }

        public List<ExpertsDetailtObjects> GetJoin()
        {
            List<ExpertsDetailtObjects> lst = new List<ExpertsDetailtObjects>();
            var db = new eTrainingScheduleEntities();
            var list = db.sp_ExpertsDetailt_Join();
            foreach (var item in list)
            {
                ExpertsDetailtObjects ob = new ExpertsDetailtObjects();
                ob.ExId = item.ExId; ob.ExpertId = item.ExpertId; ob.CoId = item.CoId; ob.Description = item.DescriptionExpertsDetailt;
                ob.CoursesJoin = new CoursesObjects()
                {
                    CoId = (Guid)item.CoId,
                    CourseId = item.CourseId,
                    CourseName = item.CourseName,
                    Deleted = item.DeletedCourses,
                    Description = item.DescriptionCourses,
                    EndDate = item.EndDate,
                    StartDate = item.StartDateCourses,
                    Status = item.StatusCourses,
                    TotalNumber = item.TotalNumber
                };
                ob.ExpertsJoin = new ExpertsObjects()
                {
                    Address = item.Address,
                    Deleted = item.DeletedExperts,
                    Description = item.DescriptionExperts,
                    Email = item.Email,
                    ExpertId = (Guid)item.ExpertId,
                    FullName = item.FullName,
                    Mobile = item.Mobile,
                    Specialize = item.Specialize,
                    StartDate = item.StartDateExperts,
                    Status = item.StatusExperts,
                };
                lst.Add(ob);
            }
            return lst;
        }


        public ExpertsDetailtObjects GetByExId(Guid ExId)
        {
            var db = new eTrainingScheduleEntities();
            var list = db.sp_tbl_S07_ExpertsDetailt_GetByExId(ExId);
            foreach (var item in list)
            {
                ExpertsDetailtObjects obj = new ExpertsDetailtObjects();
                obj.ExId = item.ExId; obj.ExpertId = item.ExpertId; obj.CoId = item.CoId; obj.Description = item.Description;
                return obj;
            }
            return null;
        }


        public bool Delete(Guid ID)
        {
            var db = new eTrainingScheduleEntities();
            var Data = db.sp_tbl_S07_ExpertsDetailt_DELETE(ID);
            return true;
        }
    }
}
