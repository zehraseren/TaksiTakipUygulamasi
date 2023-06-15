using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi.Classes
{
    internal class Tables
    {
        public class DistrictTable
        {
            public int district_id { get; set; }
            public string district_name { get; set; }
            public int province_id { get; set; }
        }

        public class ProvinceTable
        {
            public int province_id { get; set; }
            public string province_name { get; set; }
        }

        public class AddressTypeTable
        {
            public int address_type_id { get; set; }
            public string address_type_name { get; set; }
        }

        public class CustomerTable
        {
            public int customer_id { get; set; }
            public int customer_priority { get; set; }
            public string customer_firstname { get; set; }
            public string customer_lastname { get; set; }
            public string phone_number { get; set; }
            public bool customer_delete { get; set; }
        }

        public class CustomerAddTable
        {
            public int customer_id { get; set; }
            public string customer_firstname { get; set; }
            public string customer_lastname { get; set; }
            public string phone_number { get; set; }
            public string province { get; set; }
            public string district { get; set; }
            public string address_line { get; set; }
            public bool customer_delete { get; set; }
        }

        public class CustomerAddressTable
        {
            public int address_id { get; set; }
            public int customer_id { get; set; }
            public string address_line { get; set; }
            public int address_type_id { get; set; }
            public int province_id { get; set; }
        }

        public class CustomerPhoneTable
        {
            public int phone_id { get; set; }
            public int customer_id { get; set; }
            public string phone_number { get; set; }
            public int phone_number_type_id { get; set; }
        }

        public class DriverTable
        {
            public int driver_id { get; set; }
            public string driver_id_number { get; set; }
            public string driver_firstname { get; set; }
            public string driver_lastname { get; set; }
            public string phone_number { get; set; }
            public string shift_type_name { get; set; }
            public string station_name { get; set; }
            public string vehicle_licence_plate { get; set; }
            public bool driver_delete { get; set; }
        }

        public class DriverShiftTable
        {
            public int driver_id { get; set; }
            public string driver_firstname { get; set; }
            public string driver_lastname { get; set; }
            public string phone_number { get; set; }
            public string shift_type_name { get; set; }
        }

        public class DriverExpenseTable
        {
            public int driver_expense_id { get; set; }
            public string driver_firstname { get; set; }
            public string driver_lastname { get; set; }
            public string driver_id_number { get; set; }
            public DateTime driver_expense_date { get; set; }        //**************
            public float driver_expense_amount { get; set; }
            public string type_name { get; set; }
            public string payment_type_name { get; set; }
        }

        public class DriverExpenseTypeTable
        {
            public int driver_type_id { get; set; }
            public string type_name { get; set; }
        }

        public class DriverPhoneTable
        {
            public int phone_id { get; set; }
            public int driver_id { get; set; }
            public string phone_number { get; set; }
            public int phone_number_type_id { get; set; }
        }

        public class PaymentTypeTable
        {
            public int payment_type_id { get; set; }
            public string payment_type_name { get; set; }
        }

        public class PhoneNumberTypeTable
        {
            public int phone_number_type_id { get; set; }
            public string type_name { get; set; }
        }

        public class RideTable
        {
            public int ride_id { get; set; }
            public DateTime ride_date { get; set; }
            public decimal ride_distance { get; set; }
            public string customer_firstname { get; set; }
            public string customer_lastname { get; set; }
            public string phone_number { get; set; }
            public string vehicle_licence_plate { get; set; }
            public string driver_firstname { get; set; }
            public string driver_lastname { get; set; }
            public float price { get; set; }
            public bool ride_delete { get; set; }
            //public decimal start_coordinate { get; set; }   //******************
            //public decimal end_coordinate { get; set; }   //******************
        }

        public class RidePaymentTable
        {
            public int payment_id { get; set; }
            public DateTime date_time { get; set; }
            public string description { get; set; }
            public decimal price { get; set; }      //*****************
            public int payment_type_id { get; set; }
        }

        public class ShiftTable
        {
            public int shift_id { get; set; }
            public string shift_type_name { get; set; }
        }

        public class StationTable
        {
            public int station_id { get; set; }
            public string station_name { get; set; }
            public string station_phone { get; set; }
            public string province { get; set; }
            public string district { get; set; }
            public string address_line { get; set; }
            public bool station_delete { get; set; }
            public decimal station_coordinate { get; set; }
        }

        public class StationAddressTable
        {
            public int address_id { get; set; }
            public string address_line { get; set; }
            public int province_id { get; set; }
        }

        public class StationExpenseTable
        {
            public int station_expense_id { get; set; }
            public DateTime station_expense_date { get; set; }        //**************
            public int station_expense_type_id { get; set; }
            public float station_expense_amount { get; set; }      //************
            public int station_expense_station_id { get; set; }
            public int payment_type_id { get; set; }
        }

        public class StationExpenseTypeTable
        {
            public int type_id { get; set; }
            public string type_name { get; set; }
        }

        public class UserAddressTable
        {
            public int address_id { get; set; }
            public int user_id { get; set; }
            public string address_line { get; set; }
            public int address_type_id { get; set; }
            public int province_id { get; set; }
        }

        public class UserPhoneTable
        {
            public int phone_id { get; set; }
            public int user_id { get; set; }
            public string phone_number { get; set; }
            public int phone_number_type_id { get; set; }
        }

        public class UserRoleTable
        {
            public int user_role_id { get; set; }
            public string user_role_name { get; set; }
        }

        public class UserTable
        {
            public int user_id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string user_firstname { get; set; }
            public string user_lastname { get; set; }
            public string phone_number { get; set; }
            public string user_role_name { get; set; }
            public string user_status { get; set; }
            public bool user_delete { get; set; }
        }

        public class VehicleTable
        {
            public int vehicle_id { get; set; }
            public int vehicle_priority { get; set; }
            public string vehicle_licence_plate { get; set; }
            public string vehicle_brand { get; set; }
            public string vehicle_model { get; set; }
            public int vehicle_year { get; set; }
            public bool vehicle_delete { get; set; }
            public string station_name { get; set; }
            public decimal vehicle_coordinate { get; set; } //************************
        }

        public class VehicleExpenseTable
        {
            public int vehicle_expense_id { get; set; }
            public int vehicle_expense_type_id { get; set; }
            public int vehicle_id { get; set; }
            public DateTime vehicle_expense_datetime { get; set; }        //**************
            public float vehicle_expense_price { get; set; }      //************
            public int payment_type_id { get; set; }
        }

        public class VehicleExpenseTypeTable
        {
            public int vehicle_expense_type_id { get; set; }
            public string vehicle_expense_type_name { get; set; }
        }
    }
}
