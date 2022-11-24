using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _1._0RestaurantTracking
{
    internal class cStaffs
    {
        cGeneral gnl = new cGeneral();//calss ın nesnesini burda oluşturduk.

        //Sql staff tablosundaki veriler
        #region Fields
        private int _StaffId;
        private string _StaffName;
        private string _StaffSurname;
        private string _StaffNickname;
        private string _StaffPassword;
        private int _PersId;
        #endregion

        //ctrl +  r + e yapılarak public olşturuldu

        #region Properties
        public int StaffId { get => _StaffId; set => _StaffId = value; }
        public string StaffName { get => _StaffName; set => _StaffName = value; }
        public string StaffSurname { get => _StaffSurname; set => _StaffSurname = value; }
        public string StaffNickname { get => _StaffNickname; set => _StaffNickname = value; }
        public string StaffPassword { get => _StaffPassword; set => _StaffPassword = value; }
        public int PersId { get => _PersId; set => _PersId = value; } 
        #endregion

       
        }

    }

