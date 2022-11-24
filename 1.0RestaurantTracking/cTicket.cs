using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _1._0RestaurantTracking
{
    internal class cTicket
    {
        cGeneral gnl = new cGeneral();
        //Veri tabanındanki alanların eklenmesi
        #region fields 
        private int _TicketId;
        private int _ServiceTypeId;
        private decimal _Price;
        private DateTime _TicketDate;
        private int _PersId;
        private int _TrueFalse;
        #endregion

        //field kısımındaki alanların ctrl+r+e yapılarak propertiesler eklendi
        #region Properties
        public int TicketId { get => _TicketId; set => _TicketId = value; }
        public int ServiceTypeId { get => _ServiceTypeId; set => _ServiceTypeId = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public DateTime TicketDate { get => _TicketDate; set => _TicketDate = value; }
        public int PersId { get => _PersId; set => _PersId = value; }
        public int TrueFalse { get => _TrueFalse; set => _TrueFalse = value; } 
        #endregion






    }
}
