﻿using System;


namespace ClinicApp.Clinic.Equipments
{
    public class EquipmentMovement
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int NewRoomId { get; set; }
        public int Amount { get; set; }
        public DateTime MovementDate { get; set; }
        public bool Done { get; set; }
    }
}
