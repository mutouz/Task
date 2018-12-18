//=============================================================
/*
   类名称:StudentBLL
   类描述：
   生成日期：2018-08-21 17:38:17
*/              
//=============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Henyuan.ANJian.BLL;
using Henyuan.ANJian.IBLL;
using Henyuan.ANJian.IDAL;
using Hengyun..ANJian.DAL;
using Hengyun.ANJian.Model;
namespace  Hengyun.BLL
{

 public class StudentBll: BaseBll<Student>,IStudentBll
   {

       public override IBaseDal<Student> Dal
       {
          get   
          {   
             return new StudentDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


