﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AActivity.Models
{
    public class TripBooking
    {
        public int Id { get; set; }

        [Display(Name = "رقم الرحلة المجدولة "), Required(ErrorMessage = "{0} مطلوب")]
        public int SchedulingTripDetailId { get; set; }
        [ForeignKey("SchedulingTripDetailId")]
        public SchedulingTripDetail SchedulingTripDetail { get; set; }

        [Display(Name = "المدينة "), Required(ErrorMessage = "{0} مطلوب")]
        public int CityId { get; set; }
        [Display(Name = "المدينة ")]
        public City City { get; set; }

        [Display(Name = " الى تاريخ   "), Required(ErrorMessage = "{0} مطلوب"),
DataType(DataType.Date, ErrorMessage = "المدخل يجب ان يكون تاريخ"),
DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TripToDate { get; set; }

        [Display(Name = "عدد الأيام ")]
        public int TripQtyDays { get; set; }

        [Display(Name = "المكان "), Required(ErrorMessage = "{0} مطلوب")]

        public string TripLocationName { get; set; } 
    }
}
