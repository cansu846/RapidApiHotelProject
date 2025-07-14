namespace RapidApiHotelProject.Dtos
{
    public class VisitRoomDetailDto
    {

        public class Rootobject
        {
            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public Block[] block { get; set; }
            public Preference[] preferences { get; set; }
            public Payment_Detail payment_detail { get; set; }
            public Prepayment_Policies prepayment_policies { get; set; }
            public string cc_required { get; set; }
            public Cancellation_Policies cancellation_policies { get; set; }
            public int hotel_id { get; set; }
            public int is_cpv2_property { get; set; }
            public Room_Recommendation[] room_recommendation { get; set; }
            public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
            public string ai_description_info { get; set; }
            public Min_Room_Distribution min_room_distribution { get; set; }
            public int address_required { get; set; }
            public float cheapest_avail_price_eur { get; set; }
            public int is_tpi_exclusive_property { get; set; }
            public string departure_date { get; set; }
            public int b_legal_use_neutral_color_for_persuasion_legal { get; set; }
            public int total_blocks { get; set; }
            public int max_rooms_in_reservation { get; set; }
            public int qualifies_for_no_cc_reservation { get; set; }
            public Rooms rooms { get; set; }
            public int last_matching_block_index { get; set; }
            public string currency_code { get; set; }
            public int use_new_bui_icon_highlight { get; set; }
            public object[] soldout_rooms { get; set; }
            public int duplicate_rates_removed { get; set; }
            public Property_Policy_Display_Details property_policy_display_details { get; set; }
            public string arrival_date { get; set; }
            public string cvc_required { get; set; }
            public object[] tax_exceptions { get; set; }
            public string recommended_block_title { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
        }

        public class Payment_Detail
        {
            public string model { get; set; }
        }

        public class Prepayment_Policies
        {
            public string _19160501_246100790_2_33_0 { get; set; }
            public string _19160509_246100790_3_34_0 { get; set; }
            public string _19160525_246100790_2_33_0 { get; set; }
            public string _19160519_246100790_2_33_0 { get; set; }
            public string _19160509_246100790_3_33_0 { get; set; }
            public string _19160517_246100790_1_33_0 { get; set; }
            public string _19160510_246100790_2_34_0 { get; set; }
            public string _19160510_246100790_1_33_0 { get; set; }
            public string _19160509_246100790_2_34_0 { get; set; }
            public string _19160517_246100790_3_33_0 { get; set; }
            public string _19160515_246100790_1_33_0 { get; set; }
            public string _19160510_246100790_3_34_0 { get; set; }
            public string _19160510_246100790_2_33_0 { get; set; }
            public string _19160515_246100790_3_33_0 { get; set; }
            public string _19160521_246100790_2_33_0 { get; set; }
            public string _19160519_246100790_1_33_0 { get; set; }
            public string _19160525_246100790_1_33_0 { get; set; }
            public string _19160525_246100790_3_33_0 { get; set; }
            public string _19160509_246100790_2_33_0 { get; set; }
            public string _19160501_246100790_1_33_0 { get; set; }
            public string _19160519_246100790_3_33_0 { get; set; }
            public string _19160501_246100790_2_34_0 { get; set; }
            public string _19160521_246100790_1_33_0 { get; set; }
            public string _19160515_246100790_2_33_0 { get; set; }
            public string _19160517_246100790_2_33_0 { get; set; }
            public string _19160509_246100790_1_33_0 { get; set; }
            public string _19160521_246100790_3_33_0 { get; set; }
            public string _19160510_246100790_3_33_0 { get; set; }
        }

        public class Cancellation_Policies
        {
            public string _19160525_246100790_3_33_0 { get; set; }
            public string _19160525_246100790_1_33_0 { get; set; }
            public string _19160501_246100790_1_33_0 { get; set; }
            public string _19160509_246100790_2_33_0 { get; set; }
            public string _19160501_246100790_2_34_0 { get; set; }
            public string _19160519_246100790_3_33_0 { get; set; }
            public string _19160510_246100790_3_33_0 { get; set; }
            public string _19160521_246100790_3_33_0 { get; set; }
            public string _19160509_246100790_1_33_0 { get; set; }
            public string _19160517_246100790_2_33_0 { get; set; }
            public string _19160515_246100790_2_33_0 { get; set; }
            public string _19160521_246100790_1_33_0 { get; set; }
            public string _19160509_246100790_3_33_0 { get; set; }
            public string _19160525_246100790_2_33_0 { get; set; }
            public string _19160519_246100790_2_33_0 { get; set; }
            public string _19160509_246100790_3_34_0 { get; set; }
            public string _19160501_246100790_2_33_0 { get; set; }
            public string _19160509_246100790_2_34_0 { get; set; }
            public string _19160510_246100790_1_33_0 { get; set; }
            public string _19160510_246100790_2_34_0 { get; set; }
            public string _19160517_246100790_1_33_0 { get; set; }
            public string _19160510_246100790_3_34_0 { get; set; }
            public string _19160510_246100790_2_33_0 { get; set; }
            public string _19160515_246100790_1_33_0 { get; set; }
            public string _19160517_246100790_3_33_0 { get; set; }
            public string _19160519_246100790_1_33_0 { get; set; }
            public string _19160521_246100790_2_33_0 { get; set; }
            public string _19160515_246100790_3_33_0 { get; set; }
        }

        public class Min_Room_Distribution
        {
            public object[] children { get; set; }
            public int adults { get; set; }
        }

        public class Rooms
        {
            public _19160501 _19160501 { get; set; }
            public _19160509 _19160509 { get; set; }
            public _19160510 _19160510 { get; set; }
            public _19160515 _19160515 { get; set; }
            public _19160517 _19160517 { get; set; }
            public _19160519 _19160519 { get; set; }
            public _19160521 _19160521 { get; set; }
            public _19160525 _19160525 { get; set; }
        }

        public class _19160501
        {
            public Facility[] facilities { get; set; }
            public int private_bathroom_count { get; set; }
            public Photo[] photos { get; set; }
            public string description { get; set; }
            public Highlight[] highlights { get; set; }
            public Bed_Configurations[] bed_configurations { get; set; }
            public Children_And_Beds_Text children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight private_bathroom_highlight { get; set; }
        }

        public class Children_And_Beds_Text
        {
            public Age_Intervals[] age_intervals { get; set; }
            public Children_At_The_Property[] children_at_the_property { get; set; }
            public Cribs_And_Extra_Beds[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
        }

        public class Age_Intervals
        {
            public Group_By_Price group_by_price { get; set; }
            public string[][] types_by_price { get; set; }
            public int min_age { get; set; }
            public Crib crib { get; set; }
            public int max_age { get; set; }
            public Extra_Bed extra_bed { get; set; }
        }

        public class Group_By_Price
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Crib
        {
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
            public int price { get; set; }
            public int guaranteed { get; set; }
        }

        public class Extra_Bed
        {
            public string price { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
        }

        public class Children_At_The_Property
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Cribs_And_Extra_Beds
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Private_Bathroom_Highlight
        {
            public int has_highlight { get; set; }
        }

        public class Facility
        {
            public int alt_facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Photo
        {
            public string url_max300 { get; set; }
            public int photo_id { get; set; }
            public string url_square60 { get; set; }
            public string url_640x200 { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
            public string last_update_date { get; set; }
            public string url_max1280 { get; set; }
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
        }

        public class Highlight
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class Bed_Configurations
        {
            public Bed_Types[] bed_types { get; set; }
        }

        public class Bed_Types
        {
            public string description_imperial { get; set; }
            public int count { get; set; }
            public string description { get; set; }
            public string name_with_count { get; set; }
            public object description_localized { get; set; }
            public int bed_type { get; set; }
            public string name { get; set; }
        }

        public class _19160509
        {
            public Bed_Configurations1[] bed_configurations { get; set; }
            public Children_And_Beds_Text1 children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight1 private_bathroom_highlight { get; set; }
            public Facility1[] facilities { get; set; }
            public string ai_description { get; set; }
            public int private_bathroom_count { get; set; }
            public Photo1[] photos { get; set; }
            public string description { get; set; }
            public Highlight1[] highlights { get; set; }
        }

        public class Children_And_Beds_Text1
        {
            public Age_Intervals1[] age_intervals { get; set; }
            public Children_At_The_Property1[] children_at_the_property { get; set; }
            public Cribs_And_Extra_Beds1[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
        }

        public class Age_Intervals1
        {
            public int max_age { get; set; }
            public Crib1 crib { get; set; }
            public int min_age { get; set; }
            public Group_By_Price1 group_by_price { get; set; }
            public string[][] types_by_price { get; set; }
            public Extra_Bed1 extra_bed { get; set; }
        }

        public class Crib1
        {
            public int price { get; set; }
            public int guaranteed { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
        }

        public class Group_By_Price1
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Extra_Bed1
        {
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
            public string price_mode { get; set; }
            public string price { get; set; }
            public int price_type_n { get; set; }
        }

        public class Children_At_The_Property1
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Cribs_And_Extra_Beds1
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Private_Bathroom_Highlight1
        {
            public int has_highlight { get; set; }
        }

        public class Bed_Configurations1
        {
            public Bed_Types1[] bed_types { get; set; }
        }

        public class Bed_Types1
        {
            public string description_imperial { get; set; }
            public int count { get; set; }
            public string name_with_count { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public int bed_type { get; set; }
            public object description_localized { get; set; }
        }

        public class Facility1
        {
            public string name { get; set; }
            public int alt_facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int id { get; set; }
            public int facilitytype_id { get; set; }
        }

        public class Photo1
        {
            public string url_max300 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_640x200 { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
            public string last_update_date { get; set; }
            public string url_max1280 { get; set; }
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
        }

        public class Highlight1
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class _19160510
        {
            public Private_Bathroom_Highlight2 private_bathroom_highlight { get; set; }
            public int sea_view { get; set; }
            public Children_And_Beds_Text2 children_and_beds_text { get; set; }
            public Bed_Configurations2[] bed_configurations { get; set; }
            public Highlight2[] highlights { get; set; }
            public Photo2[] photos { get; set; }
            public string description { get; set; }
            public int private_bathroom_count { get; set; }
            public string ai_description { get; set; }
            public Facility2[] facilities { get; set; }
        }

        public class Private_Bathroom_Highlight2
        {
            public int has_highlight { get; set; }
        }

        public class Children_And_Beds_Text2
        {
            public Age_Intervals2[] age_intervals { get; set; }
            public Children_At_The_Property2[] children_at_the_property { get; set; }
            public Cribs_And_Extra_Beds2[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
        }

        public class Age_Intervals2
        {
            public string[][] types_by_price { get; set; }
            public Group_By_Price2 group_by_price { get; set; }
            public int min_age { get; set; }
            public int max_age { get; set; }
            public Crib2 crib { get; set; }
            public Extra_Bed2 extra_bed { get; set; }
        }

        public class Group_By_Price2
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Crib2
        {
            public int price { get; set; }
            public int guaranteed { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
        }

        public class Extra_Bed2
        {
            public string price_mode { get; set; }
            public string price { get; set; }
            public int price_type_n { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
        }

        public class Children_At_The_Property2
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Cribs_And_Extra_Beds2
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Bed_Configurations2
        {
            public Bed_Types2[] bed_types { get; set; }
        }

        public class Bed_Types2
        {
            public string description { get; set; }
            public string name_with_count { get; set; }
            public int bed_type { get; set; }
            public object description_localized { get; set; }
            public string name { get; set; }
            public string description_imperial { get; set; }
            public int count { get; set; }
        }

        public class Highlight2
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class Photo2
        {
            public string url_max1280 { get; set; }
            public string last_update_date { get; set; }
            public string url_square180 { get; set; }
            public string url_max750 { get; set; }
            public string url_640x200 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_max300 { get; set; }
            public string url_original { get; set; }
            public float ratio { get; set; }
        }

        public class Facility2
        {
            public int alt_facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

        public class _19160515
        {
            public Highlight3[] highlights { get; set; }
            public string description { get; set; }
            public Photo3[] photos { get; set; }
            public int private_bathroom_count { get; set; }
            public string ai_description { get; set; }
            public Facility3[] facilities { get; set; }
            public Private_Bathroom_Highlight3 private_bathroom_highlight { get; set; }
            public Children_And_Beds_Text3 children_and_beds_text { get; set; }
            public int sea_view { get; set; }
            public Bed_Configurations3[] bed_configurations { get; set; }
        }

        public class Private_Bathroom_Highlight3
        {
            public int has_highlight { get; set; }
        }

        public class Children_And_Beds_Text3
        {
            public Cribs_And_Extra_Beds3[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
            public Children_At_The_Property3[] children_at_the_property { get; set; }
            public Age_Intervals3[] age_intervals { get; set; }
        }

        public class Cribs_And_Extra_Beds3
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Children_At_The_Property3
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_Intervals3
        {
            public int min_age { get; set; }
            public Group_By_Price3 group_by_price { get; set; }
            public string[][] types_by_price { get; set; }
            public int max_age { get; set; }
            public Crib3 crib { get; set; }
            public Extra_Bed3 extra_bed { get; set; }
        }

        public class Group_By_Price3
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Crib3
        {
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
            public int price { get; set; }
            public int guaranteed { get; set; }
        }

        public class Extra_Bed3
        {
            public int price_type_n { get; set; }
            public string price { get; set; }
            public string price_mode { get; set; }
            public string price_type { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
        }

        public class Highlight3
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class Photo3
        {
            public string url_square180 { get; set; }
            public string url_max750 { get; set; }
            public string url_max1280 { get; set; }
            public string last_update_date { get; set; }
            public string url_original { get; set; }
            public float ratio { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_max300 { get; set; }
            public string url_640x200 { get; set; }
        }

        public class Facility3
        {
            public string name { get; set; }
            public int alt_facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int id { get; set; }
            public int facilitytype_id { get; set; }
        }

        public class Bed_Configurations3
        {
            public Bed_Types3[] bed_types { get; set; }
        }

        public class Bed_Types3
        {
            public string name { get; set; }
            public int bed_type { get; set; }
            public object description_localized { get; set; }
            public string name_with_count { get; set; }
            public string description { get; set; }
            public int count { get; set; }
            public string description_imperial { get; set; }
        }

        public class _19160517
        {
            public Bed_Configurations4[] bed_configurations { get; set; }
            public Apartment_Configuration[] apartment_configuration { get; set; }
            public int sea_view { get; set; }
            public Children_And_Beds_Text4 children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight4 private_bathroom_highlight { get; set; }
            public Facility4[] facilities { get; set; }
            public string ai_description { get; set; }
            public int private_bathroom_count { get; set; }
            public Photo4[] photos { get; set; }
            public string description { get; set; }
            public Highlight4[] highlights { get; set; }
        }

        public class Children_And_Beds_Text4
        {
            public Children_At_The_Property4[] children_at_the_property { get; set; }
            public Age_Intervals4[] age_intervals { get; set; }
            public Cribs_And_Extra_Beds4[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
        }

        public class Children_At_The_Property4
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Age_Intervals4
        {
            public string[][] types_by_price { get; set; }
            public Group_By_Price4 group_by_price { get; set; }
            public int min_age { get; set; }
            public int max_age { get; set; }
            public Crib4 crib { get; set; }
            public Extra_Bed4 extra_bed { get; set; }
        }

        public class Group_By_Price4
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Crib4
        {
            public int guaranteed { get; set; }
            public int price { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
        }

        public class Extra_Bed4
        {
            public string price { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
        }

        public class Cribs_And_Extra_Beds4
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Private_Bathroom_Highlight4
        {
            public int has_highlight { get; set; }
        }

        public class Bed_Configurations4
        {
            public Bed_Types4[] bed_types { get; set; }
        }

        public class Bed_Types4
        {
            public string name { get; set; }
            public int bed_type { get; set; }
            public string name_with_count { get; set; }
            public string description { get; set; }
            public int count { get; set; }
            public string description_imperial { get; set; }
        }

        public class Apartment_Configuration
        {
            public Apartment_Bed_Setup[] apartment_bed_setup { get; set; }
            public Room_Details[] room_details { get; set; }
        }

        public class Apartment_Bed_Setup
        {
            public string name_withnumber { get; set; }
            public int bed_count { get; set; }
            public string name { get; set; }
            public string desc_imperial_short { get; set; }
            public int apartment_room_id { get; set; }
            public string description_short { get; set; }
            public string room_type { get; set; }
            public string name_alternative { get; set; }
            public int bedtype_id { get; set; }
            public int max_persons { get; set; }
            public int ensuite_bathroom { get; set; }
            public int room_id { get; set; }
            public string desc_imperial { get; set; }
            public string description { get; set; }
        }

        public class Room_Details
        {
            public int ensuite_bathroom { get; set; }
            public string room_type { get; set; }
            public string room_type_translated { get; set; }
        }

        public class Facility4
        {
            public string name { get; set; }
            public int alt_facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public object[] photos { get; set; }
        }

        public class Photo4
        {
            public string url_640x200 { get; set; }
            public string url_max300 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
            public string last_update_date { get; set; }
            public string url_max1280 { get; set; }
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
        }

        public class Highlight4
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
        }

        public class _19160519
        {
            public Highlight5[] highlights { get; set; }
            public string description { get; set; }
            public Photo5[] photos { get; set; }
            public int private_bathroom_count { get; set; }
            public Facility5[] facilities { get; set; }
            public Private_Bathroom_Highlight5 private_bathroom_highlight { get; set; }
            public Children_And_Beds_Text5 children_and_beds_text { get; set; }
            public Bed_Configurations5[] bed_configurations { get; set; }
        }

        public class Private_Bathroom_Highlight5
        {
            public int has_highlight { get; set; }
        }

        public class Children_And_Beds_Text5
        {
            public Children_At_The_Property5[] children_at_the_property { get; set; }
            public Age_Intervals5[] age_intervals { get; set; }
            public int allow_children { get; set; }
            public Cribs_And_Extra_Beds5[] cribs_and_extra_beds { get; set; }
        }

        public class Children_At_The_Property5
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Age_Intervals5
        {
            public int max_age { get; set; }
            public Crib5 crib { get; set; }
            public int min_age { get; set; }
            public string[][] types_by_price { get; set; }
            public Group_By_Price5 group_by_price { get; set; }
            public Extra_Bed5 extra_bed { get; set; }
        }

        public class Crib5
        {
            public int guaranteed { get; set; }
            public int price { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
        }

        public class Group_By_Price5
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Extra_Bed5
        {
            public string price_type { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public int price_type_n { get; set; }
            public string price_mode { get; set; }
            public string price { get; set; }
        }

        public class Cribs_And_Extra_Beds5
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Highlight5
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
            public int id { get; set; }
        }

        public class Photo5
        {
            public string url_max1280 { get; set; }
            public string last_update_date { get; set; }
            public string url_square180 { get; set; }
            public string url_max750 { get; set; }
            public string url_640x200 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_max300 { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
        }

        public class Facility5
        {
            public string name { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public int alt_facilitytype_id { get; set; }
        }

        public class Bed_Configurations5
        {
            public Bed_Types5[] bed_types { get; set; }
        }

        public class Bed_Types5
        {
            public string description_imperial { get; set; }
            public int count { get; set; }
            public string description { get; set; }
            public string name_with_count { get; set; }
            public int bed_type { get; set; }
            public object description_localized { get; set; }
            public string name { get; set; }
        }

        public class _19160521
        {
            public Bed_Configurations6[] bed_configurations { get; set; }
            public Apartment_Configuration1[] apartment_configuration { get; set; }
            public Children_And_Beds_Text6 children_and_beds_text { get; set; }
            public Private_Bathroom_Highlight6 private_bathroom_highlight { get; set; }
            public Facility6[] facilities { get; set; }
            public int private_bathroom_count { get; set; }
            public string ai_description { get; set; }
            public string description { get; set; }
            public Photo6[] photos { get; set; }
            public Highlight6[] highlights { get; set; }
        }

        public class Children_And_Beds_Text6
        {
            public Cribs_And_Extra_Beds6[] cribs_and_extra_beds { get; set; }
            public int allow_children { get; set; }
            public Children_At_The_Property6[] children_at_the_property { get; set; }
            public Age_Intervals6[] age_intervals { get; set; }
        }

        public class Cribs_And_Extra_Beds6
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Children_At_The_Property6
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Age_Intervals6
        {
            public int max_age { get; set; }
            public Crib6 crib { get; set; }
            public int min_age { get; set; }
            public string[][] types_by_price { get; set; }
            public Group_By_Price6 group_by_price { get; set; }
            public Extra_Bed6 extra_bed { get; set; }
        }

        public class Crib6
        {
            public int guaranteed { get; set; }
            public int price { get; set; }
            public int price_type_n { get; set; }
            public string price_mode { get; set; }
            public string price_type { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
        }

        public class Group_By_Price6
        {
            public string[] freeper_night0 { get; set; }
            public string[] fixedper_night2750 { get; set; }
        }

        public class Extra_Bed6
        {
            public string price_mode { get; set; }
            public string price { get; set; }
            public int price_type_n { get; set; }
            public int price_mode_n { get; set; }
            public int id { get; set; }
            public string price_type { get; set; }
        }

        public class Private_Bathroom_Highlight6
        {
            public int has_highlight { get; set; }
        }

        public class Bed_Configurations6
        {
            public Bed_Types6[] bed_types { get; set; }
        }

        public class Bed_Types6
        {
            public string description_imperial { get; set; }
            public int count { get; set; }
            public string description { get; set; }
            public string name_with_count { get; set; }
            public int bed_type { get; set; }
            public string name { get; set; }
        }

        public class Apartment_Configuration1
        {
            public Room_Details1[] room_details { get; set; }
            public Apartment_Bed_Setup1[] apartment_bed_setup { get; set; }
        }

        public class Room_Details1
        {
            public string room_type_translated { get; set; }
            public string room_type { get; set; }
            public int ensuite_bathroom { get; set; }
        }

        public class Apartment_Bed_Setup1
        {
            public string name_withnumber { get; set; }
            public int bed_count { get; set; }
            public string desc_imperial_short { get; set; }
            public string name { get; set; }
            public string description_short { get; set; }
            public int apartment_room_id { get; set; }
            public string room_type { get; set; }
            public int room_id { get; set; }
            public int ensuite_bathroom { get; set; }
            public string desc_imperial { get; set; }
            public string description { get; set; }
            public string name_alternative { get; set; }
            public int max_persons { get; set; }
            public int bedtype_id { get; set; }
        }

        public class Facility6
        {
            public string name { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int facilitytype_id { get; set; }
            public int id { get; set; }
            public int alt_facilitytype_id { get; set; }
            public object[] photos { get; set; }
        }

        public class Photo6
        {
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
            public string last_update_date { get; set; }
            public string url_max1280 { get; set; }
            public string url_original { get; set; }
            public float ratio { get; set; }
            public string url_640x200 { get; set; }
            public string url_max300 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
        }

        public class Highlight6
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class _19160525
        {
            public Private_Bathroom_Highlight7 private_bathroom_highlight { get; set; }
            public Children_And_Beds_Text7 children_and_beds_text { get; set; }
            public Apartment_Configuration2[] apartment_configuration { get; set; }
            public Bed_Configurations7[] bed_configurations { get; set; }
            public Highlight7[] highlights { get; set; }
            public string description { get; set; }
            public Photo7[] photos { get; set; }
            public int private_bathroom_count { get; set; }
            public string ai_description { get; set; }
            public Facility7[] facilities { get; set; }
        }

        public class Private_Bathroom_Highlight7
        {
            public int has_highlight { get; set; }
        }

        public class Children_And_Beds_Text7
        {
            public int allow_children { get; set; }
            public Cribs_And_Extra_Beds7[] cribs_and_extra_beds { get; set; }
            public Children_At_The_Property7[] children_at_the_property { get; set; }
            public Age_Intervals7[] age_intervals { get; set; }
        }

        public class Cribs_And_Extra_Beds7
        {
            public int highlight { get; set; }
            public string text { get; set; }
        }

        public class Children_At_The_Property7
        {
            public string text { get; set; }
            public int highlight { get; set; }
        }

        public class Age_Intervals7
        {
            public string[][] types_by_price { get; set; }
            public Group_By_Price7 group_by_price { get; set; }
            public Extra_Bed7 extra_bed { get; set; }
            public int min_age { get; set; }
            public int max_age { get; set; }
        }

        public class Group_By_Price7
        {
            public string[] fixedper_night2750 { get; set; }
        }

        public class Extra_Bed7
        {
            public string price { get; set; }
            public string price_mode { get; set; }
            public int price_type_n { get; set; }
            public int id { get; set; }
            public int price_mode_n { get; set; }
            public string price_type { get; set; }
        }

        public class Apartment_Configuration2
        {
            public Room_Details2[] room_details { get; set; }
            public Apartment_Bed_Setup2[] apartment_bed_setup { get; set; }
        }

        public class Room_Details2
        {
            public int ensuite_bathroom { get; set; }
            public string room_type_translated { get; set; }
            public string room_type { get; set; }
        }

        public class Apartment_Bed_Setup2
        {
            public string name { get; set; }
            public string desc_imperial_short { get; set; }
            public int apartment_room_id { get; set; }
            public string description_short { get; set; }
            public string room_type { get; set; }
            public int room_id { get; set; }
            public int ensuite_bathroom { get; set; }
            public string desc_imperial { get; set; }
            public string description { get; set; }
            public string name_alternative { get; set; }
            public int bedtype_id { get; set; }
            public int max_persons { get; set; }
            public string name_withnumber { get; set; }
            public int bed_count { get; set; }
        }

        public class Bed_Configurations7
        {
            public Bed_Types7[] bed_types { get; set; }
        }

        public class Bed_Types7
        {
            public int count { get; set; }
            public string description_imperial { get; set; }
            public int bed_type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string name_with_count { get; set; }
        }

        public class Highlight7
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
            public int id { get; set; }
        }

        public class Photo7
        {
            public string url_max750 { get; set; }
            public string url_square180 { get; set; }
            public string last_update_date { get; set; }
            public string url_max1280 { get; set; }
            public float ratio { get; set; }
            public string url_original { get; set; }
            public string url_max300 { get; set; }
            public string url_square60 { get; set; }
            public int photo_id { get; set; }
            public string url_640x200 { get; set; }
        }

        public class Facility7
        {
            public string name { get; set; }
            public int facilitytype_id { get; set; }
            public string alt_facilitytype_name { get; set; }
            public int id { get; set; }
            public int alt_facilitytype_id { get; set; }
            public object[] photos { get; set; }
        }

        public class Property_Policy_Display_Details
        {
            public object legal_cases { get; set; }
        }

        public class Block
        {
            public int max_children_free_age { get; set; }
            public int must_reserve_free_parking { get; set; }
            public int roomtype_id { get; set; }
            public int breakfast_included { get; set; }
            public string refundable_until { get; set; }
            public int all_inclusive { get; set; }
            public Policy_Display_Details policy_display_details { get; set; }
            public int fit_status { get; set; }
            public int is_dormitory { get; set; }
            public int deposit_required { get; set; }
            public int is_domestic_rate { get; set; }
            public int is_last_minute_deal { get; set; }
            public string name_without_policy { get; set; }
            public Fit_Occupancy fit_occupancy { get; set; }
            public Transactional_Policy_Data transactional_policy_data { get; set; }
            public int number_of_bathrooms { get; set; }
            public int extrabed_available { get; set; }
            public int refundable { get; set; }
            public int smoking { get; set; }
            public Block_Text block_text { get; set; }
            public int nr_children { get; set; }
            public string mealplan { get; set; }
            public float room_surface_in_feet2 { get; set; }
            public int max_occupancy { get; set; }
            public int full_board { get; set; }
            public object[] children_ages { get; set; }
            public string name { get; set; }
            public int half_board { get; set; }
            public int number_of_bedrooms { get; set; }
            public int room_id { get; set; }
            public object extrabed_available_amount { get; set; }
            public object is_genius_deal { get; set; }
            public int genius_discount_percentage { get; set; }
            public string room_name { get; set; }
            public int is_smart_deal { get; set; }
            public int nr_adults { get; set; }
            public int pod_ios_migrate_policies_to_smp_fullon { get; set; }
            public int nr_stays { get; set; }
            public object babycots_available_amount { get; set; }
            public int room_surface_in_m2 { get; set; }
            public int is_flash_deal { get; set; }
            public int can_reserve_free_parking { get; set; }
            public int max_children_free { get; set; }
            public object[] b_bsb_campaigns { get; set; }
            public Transactional_Policy_Objects[] transactional_policy_objects { get; set; }
            public int package_id { get; set; }
            public int room_count { get; set; }
            public int babycots_available { get; set; }
            public string block_id { get; set; }
            public Product_Price_Breakdown product_price_breakdown { get; set; }
            public object[] bh_room_highlights { get; set; }
            public Paymentterms paymentterms { get; set; }
            public int is_block_fit { get; set; }
        }

        public class Policy_Display_Details
        {
            public object applied_products { get; set; }
            public Prepayment prepayment { get; set; }
            public Cancellation cancellation { get; set; }
        }

        public class Prepayment
        {
            public Description_Details description_details { get; set; }
            public string policy_type_key { get; set; }
            public string type { get; set; }
            public Title_Details title_details { get; set; }
        }

        public class Description_Details
        {
            public string placeholder_translation { get; set; }
            public string translation { get; set; }
        }

        public class Title_Details
        {
            public string translation { get; set; }
            public string tag { get; set; }
            public int has_html { get; set; }
            public string placeholder_translation { get; set; }
        }

        public class Cancellation
        {
            public Parameters parameters { get; set; }
            public Title_Details1 title_details { get; set; }
            public string is_cost_to_cancel { get; set; }
            public Description_Details1 description_details { get; set; }
            public string policy_type_key { get; set; }
            public string type { get; set; }
        }

        public class Parameters
        {
            public int has_cancellation_fee { get; set; }
        }

        public class Title_Details1
        {
            public string translation { get; set; }
            public string tag { get; set; }
            public string placeholder_translation { get; set; }
        }

        public class Description_Details1
        {
            public string placeholder_translation { get; set; }
            public string translation { get; set; }
        }

        public class Fit_Occupancy
        {
            public object[] children_ages { get; set; }
            public int nr_adults { get; set; }
        }

        public class Transactional_Policy_Data
        {
            public object applied_products { get; set; }
            public Booking_Conditions[] booking_conditions { get; set; }
            public Policy[] policies { get; set; }
        }

        public class Booking_Conditions
        {
            public string description { get; set; }
            public string key { get; set; }
            public string icon { get; set; }
            public string policy_type_key { get; set; }
            public string type { get; set; }
            public string text { get; set; }
        }

        public class Policy
        {
            public string text { get; set; }
            public string type { get; set; }
            public string icon { get; set; }
            public string policy_type_key { get; set; }
            public string key { get; set; }
            public string description { get; set; }
        }

        public class Block_Text
        {
            public Policy1[] policies { get; set; }
        }

        public class Policy1
        {
            public string content { get; set; }
            public string _class { get; set; }
            public string mealplan_vector { get; set; }
        }

        public class Product_Price_Breakdown
        {
            public Gross_Amount_Per_Night gross_amount_per_night { get; set; }
            public All_Inclusive_Amount_Hotel_Currency all_inclusive_amount_hotel_currency { get; set; }
            public int has_long_stays_weekly_rate_price { get; set; }
            public Item[] items { get; set; }
            public All_Inclusive_Amount all_inclusive_amount { get; set; }
            public Gross_Amount_Hotel_Currency gross_amount_hotel_currency { get; set; }
            public Included_Taxes_And_Charges_Amount included_taxes_and_charges_amount { get; set; }
            public Charges_Details charges_details { get; set; }
            public int has_long_stays_monthly_rate_price { get; set; }
            public Excluded_Amount excluded_amount { get; set; }
            public Price_Display_Config[] price_display_config { get; set; }
            public Gross_Amount gross_amount { get; set; }
            public Net_Amount net_amount { get; set; }
            public int nr_stays { get; set; }
            public object[] benefits { get; set; }
        }

        public class Gross_Amount_Per_Night
        {
            public float value { get; set; }
            public string amount_unrounded { get; set; }
            public string currency { get; set; }
            public string amount_rounded { get; set; }
        }

        public class All_Inclusive_Amount_Hotel_Currency
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
        }

        public class All_Inclusive_Amount
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public float value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Gross_Amount_Hotel_Currency
        {
            public string currency { get; set; }
            public string amount_rounded { get; set; }
            public int value { get; set; }
            public string amount_unrounded { get; set; }
        }

        public class Included_Taxes_And_Charges_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public int value { get; set; }
        }

        public class Charges_Details
        {
            public string translated_copy { get; set; }
            public Amount amount { get; set; }
            public string mode { get; set; }
        }

        public class Amount
        {
            public string currency { get; set; }
            public int value { get; set; }
        }

        public class Excluded_Amount
        {
            public string amount_rounded { get; set; }
            public string currency { get; set; }
            public string amount_unrounded { get; set; }
            public float value { get; set; }
        }

        public class Gross_Amount
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Net_Amount
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Item
        {
            public object details { get; set; }
            public Base _base { get; set; }
            public Item_Amount item_amount { get; set; }
            public string inclusion_type { get; set; }
            public string name { get; set; }
            public string kind { get; set; }
        }

        public class Base
        {
            public int base_amount { get; set; }
            public string kind { get; set; }
        }

        public class Item_Amount
        {
            public string amount_unrounded { get; set; }
            public float value { get; set; }
            public string amount_rounded { get; set; }
            public string currency { get; set; }
        }

        public class Price_Display_Config
        {
            public string key { get; set; }
            public int value { get; set; }
        }

        public class Paymentterms
        {
            public Prepayment1 prepayment { get; set; }
            public Cancellation1 cancellation { get; set; }
        }

        public class Prepayment1
        {
            public Timeline timeline { get; set; }
            public string simple_translation { get; set; }
            public string description { get; set; }
            public string extended_type_translation { get; set; }
            public string type_translation { get; set; }
            public string type_extended { get; set; }
            public Info info { get; set; }
            public string type { get; set; }
        }

        public class Timeline
        {
            public int nr_stages { get; set; }
            public string currency_code { get; set; }
            public Stage[] stages { get; set; }
            public string policygroup_instance_id { get; set; }
            public string u_currency_code { get; set; }
        }

        public class Stage
        {
            public int stage_fee { get; set; }
            public string u_stage_fee { get; set; }
            public int is_free { get; set; }
            public int current_stage { get; set; }
            public string limit_from_time { get; set; }
            public string limit_until_time { get; set; }
            public string u_fee { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public string text { get; set; }
            public int b_number { get; set; }
            public int is_effective { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public int fee_remaining { get; set; }
            public string limit_timezone { get; set; }
            public string amount { get; set; }
            public string limit_until { get; set; }
            public string amount_pretty { get; set; }
            public string fee_pretty { get; set; }
            public int fee { get; set; }
            public string limit_until_date { get; set; }
            public int effective_number { get; set; }
            public string u_fee_remaining { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_from_date { get; set; }
            public string stage_fee_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public string b_state { get; set; }
            public string limit_from { get; set; }
            public string fee_remaining_pretty { get; set; }
            public string u_fee_pretty { get; set; }
            public int fee_rounded { get; set; }
            public int after_checkin { get; set; }
        }

        public class Info
        {
            public object timezone { get; set; }
            public object time_before_midnight { get; set; }
            public object time { get; set; }
            public object timezone_offset { get; set; }
            public int prepayment_at_booktime { get; set; }
            public string refundable { get; set; }
            public object date { get; set; }
            public object date_before { get; set; }
            public object is_midnight { get; set; }
        }

        public class Cancellation1
        {
            public string description { get; set; }
            public Timeline1 timeline { get; set; }
            public string type_translation { get; set; }
            public int guaranteed_non_refundable { get; set; }
            public Info1 info { get; set; }
            public string type { get; set; }
            public string bucket { get; set; }
            public int non_refundable_anymore { get; set; }
        }

        public class Timeline1
        {
            public Stage1[] stages { get; set; }
            public string currency_code { get; set; }
            public int nr_stages { get; set; }
            public string policygroup_instance_id { get; set; }
            public string u_currency_code { get; set; }
        }

        public class Stage1
        {
            public int current_stage { get; set; }
            public string limit_from_time { get; set; }
            public string limit_until_time { get; set; }
            public string u_fee { get; set; }
            public string text { get; set; }
            public string u_stage_fee_pretty { get; set; }
            public int b_number { get; set; }
            public string u_fee_remaining_pretty { get; set; }
            public int is_effective { get; set; }
            public float fee_remaining { get; set; }
            public string text_refundable { get; set; }
            public string limit_timezone { get; set; }
            public float stage_fee { get; set; }
            public string u_stage_fee { get; set; }
            public int is_free { get; set; }
            public string limit_until_raw { get; set; }
            public string limit_from_date { get; set; }
            public string stage_fee_pretty { get; set; }
            public string limit_from_raw { get; set; }
            public string b_state { get; set; }
            public string limit_from { get; set; }
            public string fee_remaining_pretty { get; set; }
            public string u_fee_pretty { get; set; }
            public int fee_rounded { get; set; }
            public string stage_translation { get; set; }
            public object amount { get; set; }
            public string limit_until { get; set; }
            public string amount_pretty { get; set; }
            public string fee_pretty { get; set; }
            public string limit_until_date { get; set; }
            public float fee { get; set; }
            public int effective_number { get; set; }
            public string u_fee_remaining { get; set; }
        }

        public class Info1
        {
            public object refundable_date { get; set; }
            public object time { get; set; }
            public object timezone { get; set; }
            public object date_before { get; set; }
            public int refundable { get; set; }
            public object timezone_offset { get; set; }
            public object time_before_midnight { get; set; }
            public object is_midnight { get; set; }
            public object date_before_raw { get; set; }
            public object date_raw { get; set; }
            public object date { get; set; }
        }

        public class Transactional_Policy_Objects
        {
            public string icon { get; set; }
            public string key { get; set; }
            public string text { get; set; }
        }

        public class Preference
        {
            public string text { get; set; }
            public string[] room_ids { get; set; }
            public string id { get; set; }
            public int is_disabled { get; set; }
            public string icon_name { get; set; }
            public Choice[] choices { get; set; }
        }

        public class Choice
        {
            public string on_select_text { get; set; }
            public string text { get; set; }
            public int id { get; set; }
            public int selected { get; set; }
        }

        public class Room_Recommendation
        {
            public int babies { get; set; }
            public int number_of_extra_beds_for_children { get; set; }
            public int extra_babycots_price_in_hotel_currency { get; set; }
            public int number_of_extra_babycots { get; set; }
            public int number_of_extra_beds_and_babycots_total { get; set; }
            public int extra_beds_for_adults_price_in_hotel_currency { get; set; }
            public int extra_beds_for_adults_price { get; set; }
            public int number_of_extra_beds_for_adults { get; set; }
            public int adults { get; set; }
            public int children { get; set; }
            public int extra_beds_for_children_price { get; set; }
            public int extra_beds_for_children_price_in_hotel_currency { get; set; }
            public int extra_babycots_price { get; set; }
            public int total_extra_bed_price { get; set; }
            public int total_extra_bed_price_in_hotel_currency { get; set; }
            public string block_id { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string translated_name { get; set; }
            public string icon { get; set; }
        }

    }
}
