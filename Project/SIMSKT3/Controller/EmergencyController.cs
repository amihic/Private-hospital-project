using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using SIMSKT3;


namespace Classes.Controller
{
    public class EmergencyController
    {


        EmergencyService emergencyService = new EmergencyService();

       
        public void delete(int id)
        {
            emergencyService.removePatient(id);
        }

        
    }
}

