﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoPago.DataStructures.Customer
{
    public struct Address
    {
        #region Properties 
        private string _id;
        private string _zip_code;
        private string _street_name;
        private string _street_number;
        #endregion

        #region Accessors
        /// <summary>
        /// Address ID
        /// </summary>
        public string Id { 
            get => _id; 
            set => _id = value; 
        }
        /// <summary>
        /// Zip code
        /// </summary>
        public string ZipCode {
            get => _zip_code; 
            set => _zip_code = value;
        }
        /// <summary>
        /// Street name
        /// </summary>
        public string StreetName { 
            get => _street_name; 
            set => _street_name = value; 
        }
        /// <summary>
        /// Street number
        /// </summary>
        public string StreetNumber { 
            get => _street_number; 
            set => _street_number = value; 
        }
        #endregion
    }
}
