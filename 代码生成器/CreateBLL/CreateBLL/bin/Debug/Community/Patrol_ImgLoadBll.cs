//=============================================================
/*
   类名称:Patrol_ImgLoadDal
   类描述：
   生成日期：2018-09-19 17:05:04
*/              
//=============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hengyun.Areas.BLL;
using Hengyun.Areas.IBLL;
using Hengyun.Areas.IDAL;
using Hengyun.Areas.DAL;
using Hengyun.Areas.MODEL;
namespace  Hengyun.Areas.BLL
{

 public class Patrol_ImgLoadBll: BaseBll<Patrol_ImgLoad>,IPatrol_ImgLoadBll
   {

       public override IBaseDal<Patrol_ImgLoad> Dal
       {
          get   
          {   
             return new Patrol_ImgLoadDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


