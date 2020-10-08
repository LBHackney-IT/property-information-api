using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyInformationApi.V1.Infrastructure
{
    [Table("property", Schema = "dbo")]
    public class UHProperty
    {
        [Key]
        [StringLength(12)]
        [Column("prop_ref")]
        public string PropRef { get; set; }

        [Column("level_code")]
        [StringLength(1)]
        public string LevelCode { get; set; }

        [StringLength(12)]
        [Column("major_ref")]
        public string MajorRef { get; set; }

        [StringLength(11)]
        [Column("man_scheme")]
        public string ManScheme { get; set; }

        [StringLength(10)]
        [Column("post_code")]
        public string PostCode { get; set; }

        [StringLength(60)]
        [Column("post_desig")]
        public string PostDesig { get; set; }

        [StringLength(200)]
        [Column("short_address")]
        public string ShortAddress { get; set; }

        [StringLength(21)]
        [Column("telephone")]
        public string Telephone { get; set; }

        [Column("managed_property")]
        public bool ManagedProperty { get; set; }

        [Required, StringLength(10), Column("ownership")]
        public string Ownership { get; set; }

        [Column("agent"), StringLength(3)]
        public string Agent { get; set; }

        [Column("comments")]
        public string Comments { get; set; }

        [Column("housing_officer"), StringLength(3)]
        public string HousingOfficer { get; set; }

        [Column("area_office"), StringLength(3)]
        public string AreaOffice { get; set; }

        [Column("subtyp_code"), StringLength(3)]
        public string SubtypCode { get; set; }

        [Column("condition_code"), StringLength(1)]
        public string ConditionCode { get; set; }

        [Column("warden_ref"), StringLength(6)]
        public string WardenRef { get; set; }

        [Column("la_ref"), StringLength(3)]
        public string LaRef { get; set; }

        [Column("water_ref"), StringLength(12)]
        public string WaterRef { get; set; }

        [Column("scheme_ref"), StringLength(20)]
        public string SchemeRef { get; set; }

        [Column("insur_policy"), StringLength(20)]
        public string InsurPolicy { get; set; }

        [Column("letable")]
        public bool Letable { get; set; }

        [Column("practical_completion")]
        public DateTime? PracticalCompletion { get; set; }

        [Column("handover")]
        public DateTime? Handover { get; set; }

        [Column("cat_type"), StringLength(3)]
        public string CatType { get; set; }

        [Column("lounge")]
        public bool Lounge { get; set; }
        [Column("laundry")]
        public bool Laundry { get; set; }
        [Column("visitor_bed")]
        public bool VisitorBed { get; set; }
        [Column("store")]
        public bool Store { get; set; }
        [Column("warden_flat")]
        public bool WardenFlat { get; set; }
        [Column("sheltered")]
        public bool Sheltered { get; set; }

        [Column("house_ref"), StringLength(10)]
        public string HouseRef { get; set; }

        [Column("occ_stat"), StringLength(3)]
        public string OccStat { get; set; }
        [Column("cyclical_due")]
        public int? CyclicalDue { get; set; }
        [Column("shower")]
        public bool Shower { get; set; }

        [Column("heating"), StringLength(3)]
        public string Heating { get; set; }

        [Column("rep_area"), StringLength(3)]
        public string RepArea { get; set; }

        [Column("ac_meth"), StringLength(3)]
        public string AcMeth { get; set; }

        [Column("propsize"), StringLength(3)]
        public string Propsize { get; set; }
        [Column("rtb")]
        public bool Rtb { get; set; }
        [Column("ratevalue")]
        public int? Ratevalue { get; set; }

        [Column("post_preamble"), StringLength(60)]
        public string PostPreamble { get; set; }

        [Column("core_shared")]
        public bool CoreShared { get; set; }

        [Column("rep_officer"), StringLength(3)]
        public string RepOfficer { get; set; }
        [Column("ins_value")]
        public int? InsValue { get; set; }

        [Column("u_nom2"), StringLength(10)]
        public string UNom2 { get; set; }

        [Column("region"), StringLength(3)]
        public string Region { get; set; }
        [Column("asbestos")]
        public bool Asbestos { get; set; }
        [Column("accomfund")]
        public decimal? Accomfund { get; set; }
        [Column("candsfund")]
        public decimal? Candsfund { get; set; }
        [Column("property_sid")]
        public int? PropertySid { get; set; }
        [Column("keys")]
        public int? Keys { get; set; }

        [Column("company"), StringLength(11)]
        public string Company { get; set; }

        [Column("lett_area"), StringLength(3)]
        public string LettArea { get; set; }
        [Column("rtb_application")]
        public bool? RtbApplication { get; set; }
        [Column("no_maint")]
        public bool? NoMaint { get; set; }

        [Column("maintresp"), StringLength(3)]
        public string Maintresp { get; set; }

        [Column("leasehold")]
        public bool? Leasehold { get; set; }
        [Column("s125")]
        public bool? S125 { get; set; }

        [Column("planned_repair_area"), StringLength(3)]
        public string PlannedRepairArea { get; set; }

        [Column("lra_ref"), StringLength(10)]
        public string LraRef { get; set; }

        [Column("co_code"), StringLength(3)]
        public string CoCode { get; set; }

        [Column("rep_subarea"), StringLength(6)]
        public string RepSubarea { get; set; }
        [Column("con_key")]
        public int? ConKey { get; set; }
        [Column("walk_no")]
        public int? WalkNo { get; set; }
        [Column("walk_sequence")]
        public int? WalkSequence { get; set; }

        [Column("tstamp")]
        public byte[] Tstamp { get; set; }

        [Column("alinefull")]
        public string Alinefull { get; set; }

        [Column("arr_patch"), StringLength(3)]
        public string ArrPatch { get; set; }

        [Column("arr_officer"), StringLength(3)]
        public string ArrOfficer { get; set; }

        [Column("dh_status"), StringLength(3)]
        public string DhStatus { get; set; }
        [Column("dh_assdate")]
        public DateTime? DhAssdate { get; set; }
        [Column("dh_yearfail")]
        public int? DhYearfail { get; set; }
        [Column("dh_costnow")]
        public int? DhCostnow { get; set; }
        [Column("dh_costatfail")]
        public int? DhCostatfail { get; set; }
        [Column("sap_rating")]
        public int? SapRating { get; set; }
        [Column("nher_rating")]
        public decimal? NherRating { get; set; }
        [Column("num_bedrooms")]
        public int? NumBedrooms { get; set; }
        [Column("comm_lifts")]
        public bool? CommLifts { get; set; }

        [Column("ent_level"), StringLength(3)]
        public string EntLevel { get; set; }

        [Column("int_floors")]
        public int? IntFloors { get; set; }

        [Column("garden_type"), StringLength(3)]
        public string GardenType { get; set; }

        [Column("pets_allowed")]
        public bool? PetsAllowed { get; set; }

        [Column("parking"), StringLength(3)]
        public string Parking { get; set; }
        [Column("minage_restric")]
        public int? MinageRestric { get; set; }
        [Column("family_size")]
        public int? FamilySize { get; set; }
        [Column("child_allowed")]
        public bool? ChildAllowed { get; set; }
        [Column("local_conn")]
        public bool? LocalConn { get; set; }
        [Column("alloc_panel")]
        public bool? AllocPanel { get; set; }
        [Column("num_steps")]
        public int? NumSteps { get; set; }
        [Column("garage")]
        public bool? Garage { get; set; }
        [Column("maxage_restric")]
        public int? MaxageRestric { get; set; }
        [Column("stair_lift")]
        public bool? StairLift { get; set; }
        [Column("through_lift")]
        public bool? ThroughLift { get; set; }
        [Column("acc_shower")]
        public bool? AccShower { get; set; }
        [Column("ramp")]
        public bool? Ramp { get; set; }
        [Column("hand_rails")]
        public bool? HandRails { get; set; }
        [Column("dining_room")]
        public bool? DiningRoom { get; set; }
        [Column("kitchen_dining")]
        public bool? KitchenDining { get; set; }
        [Column("sec_toileta")]
        public bool? SecToileta { get; set; }

        [Column("sec_toiletb"), StringLength(3)]
        public string SecToiletb { get; set; }

        [Column("cooking_fuel"), StringLength(3)]
        public string CookingFuel { get; set; }


        [Column("comp_avail"), StringLength(200)]
        public string CompAvail { get; set; }

        [Column("comp_display"), StringLength(200)]
        public string CompDisplay { get; set; }
        [Column("no_single_beds")]
        public short NoSingleBeds { get; set; }
        [Column("no_double_beds")]
        public short NoDoubleBeds { get; set; }
        [Required]
        [Column("online_repairs")]
        public bool? OnlineRepairs { get; set; }

        [Column("vm_propref"), StringLength(16)]
        public string VmPropref { get; set; }
        [Column("voidman_live")]
        public bool? VoidmanLive { get; set; }
        [Required]
        [Column("repairable")]
        public bool Repairable { get; set; }

        [Column("address1"), StringLength(255)]
        public string Address1 { get; set; }

        [Column("u_prop_zone"), StringLength(3)]
        public string UPropZone { get; set; }

        [Column("u_surveyor_patch"), StringLength(3)]
        public string USurveyorPatch { get; set; }

        [Column("u_estate"), StringLength(16)]
        public string UEstate { get; set; }

        [Column("u_block"), StringLength(16)]
        public string UBlock { get; set; }

        [Column("u_location"), StringLength(16)]
        public string ULocation { get; set; }

        [Column("u_rent_account"), StringLength(12)]
        public string URentAccount { get; set; }

        [Column("u_floors")]
        public int? UFloors { get; set; }

        [Column("u_living_rooms"), StringLength(1)]
        public string ULivingRooms { get; set; }

        [Column("u_access"), StringLength(3)]
        public string UAccess { get; set; }

        [Column("u_amarchetype"), StringLength(16)]
        public string UAmarchetype { get; set; }

        [Column("u_priority_estate")]
        public bool? UPriorityEstate { get; set; }

        [Column("u_comm_entry"), StringLength(50)]
        public string UCommEntry { get; set; }

        [Column("u_consult_stat"), StringLength(3)]
        public string UConsultStat { get; set; }

        [Column("u_corr_width"), StringLength(3)]
        public string UCorrWidth { get; set; }

        [Column("u_dpa_service"), StringLength(3)]
        public string UDpaService { get; set; }

        [Column("u_est_quality"), StringLength(3)]
        public string UEstQuality { get; set; }

        [Column("u_est_security"), StringLength(3)]
        public string UEstSecurity { get; set; }

        [Column("u_ext_decent"), StringLength(3)]
        public string UExtDecent { get; set; }

        [Column("u_gas_comments"), StringLength(3)]
        public string UGasComments { get; set; }
        [Column("u_gas_service_req")]
        public bool? UGasServiceReq { get; set; }
        [Column("u_int_decent"), StringLength(3)]
        public string UIntDecent { get; set; }
        [Column("u_lever_taps"), StringLength(3)]
        public string ULeverTaps { get; set; }
        [Column("u_lift_manufact"), StringLength(3)]
        public string ULiftManufact { get; set; }
        [Column("u_rtb_start")]
        public DateTime? URtbStart { get; set; }
        [Column("u_sold_leased"), StringLength(3)]
        public string USoldLeased { get; set; }
        [Column("u_sold_leased_date")]
        public DateTime? USoldLeasedDate { get; set; }
        [Column("u_disabled_only")]
        public bool? UDisabledOnly { get; set; }
        [Column("u_date_disposed_due")]
        public DateTime? UDateDisposedDue { get; set; }
        [Column("u_leased_from"), StringLength(3)]
        public string ULeasedFrom { get; set; }
        [Column("u_lease_end_date")]
        public DateTime? ULeaseEndDate { get; set; }
        [Column("u_estate_management"), StringLength(3)]
        public string UEstateManagement { get; set; }
        [Column("u_access_floor"), StringLength(3)]
        public string UAccessFloor { get; set; }
        [Column("u_lift_available")]
        public bool? ULiftAvailable { get; set; }
        [Column("u_block_floors"), StringLength(3)]
        public string UBlockFloors { get; set; }
        [Column("u_balcony")]
        public bool? UBalcony { get; set; }
        [Column("u_door_entry")]
        public bool? UDoorEntry { get; set; }
        [Column("u_council_property")]
        public bool? UCouncilProperty { get; set; }
        [Column("u_oap_only")]
        public bool? UOapOnly { get; set; }
        [Column("u_disabled_occupier")]
        public bool? UDisabledOccupier { get; set; }
        [Column("u_estate_map_ref"), StringLength(16)]
        public string UEstateMapRef { get; set; }
        [Column("u_plan_type"), StringLength(3)]
        public string UPlanType { get; set; }
        [Column("u_year_constructed")]
        public int? UYearConstructed { get; set; }
        [Column("u_collection_round"), StringLength(3)]
        public string UCollectionRound { get; set; }
        [Column("u_temporary_accom"), StringLength(10)]
        public string UTemporaryAccom { get; set; }
        [Column("u_window_type"), StringLength(3)]
        public string UWindowType { get; set; }
        [Column("u_quality_index"), StringLength(10)]
        public string UQualityIndex { get; set; }
        [Column("u_asbestos_item"), StringLength(10)]
        public string UAsbestosItem { get; set; }
        [Column("u_disposed_type"), StringLength(3)]
        public string UDisposedType { get; set; }
        [Column("u_rent_subzone"), StringLength(3)]
        public string URentSubzone { get; set; }
        [Column("u_legal_cases"), StringLength(10)]
        public string ULegalCases { get; set; }
        [Column("u_asbestos_date")]
        public DateTime? UAsbestosDate { get; set; }
        [Column("u_llpg_ref"), StringLength(16)]
        public string ULlpgRef { get; set; }
        [Column("u_lift_type"), StringLength(3)]
        public string ULiftType { get; set; }
        [Column("u_ghost_block")]
        public bool? UGhostBlock { get; set; }
        [Column("u_ghost_address"), StringLength(50)]
        public string UGhostAddress { get; set; }
        [Column("u_prop_area_loc"), StringLength(16)]
        public string UPropAreaLoc { get; set; }
        [Column("u_old_finance_code"), StringLength(10)]
        public string UOldFinanceCode { get; set; }
        [Column("u_ha_property")]
        public bool? UHaProperty { get; set; }
        [Column("u_mobility_std"), StringLength(3)]
        public string UMobilityStd { get; set; }
        [Column("u_mobility_wchair"), StringLength(3)]
        public string UMobilityWchair { get; set; }
        [Column("u_no_lifts"), StringLength(3)]
        public string UNoLifts { get; set; }
        [Column("u_northing"), StringLength(12)]
        public string UNorthing { get; set; }
        [Column("u_overall_decent"), StringLength(3)]
        public string UOverallDecent { get; set; }
        [Column("u_prop_sort_key"), StringLength(3)]
        public string UPropSortKey { get; set; }
        [Column("u_raised_sockets")]
        public bool? URaisedSockets { get; set; }
        [Column("u_ramped_access")]
        public bool? URampedAccess { get; set; }
        [Column("u_stair_lift")]
        public bool? UStairLift { get; set; }
        [Column("u_wchair_std"), StringLength(3)]
        public string UWchairStd { get; set; }
        [Column("u_kitchenunit")]
        public bool? UKitchenunit { get; set; }
        [Column("u_reasondisposed"), StringLength(3)]
        public string UReasondisposed { get; set; }
        [Column("u_mraarchetype"), StringLength(20)]
        public string UMraarchetype { get; set; }
        [Column("u_assetarchetype"), StringLength(20)]
        public string UAssetarchetype { get; set; }
        [Column("u_hraarchetype"), StringLength(20)]
        public string UHraarchetype { get; set; }
        [Column("u_lsvtarchetype"), StringLength(20)]
        public string ULsvtarchetype { get; set; }
        [Column("u_beaconcodes"), StringLength(15)]
        public string UBeaconcodes { get; set; }
        [Column("u_llpgref"), StringLength(12)]
        public string ULlpgref1 { get; set; }
        [Column("u_alarm")]
        public bool? UAlarm { get; set; }
        [Column("u_cat_type"), StringLength(3)]
        public string UCatType { get; set; }
        [Column("u_ceiling_hoist"), StringLength(3)]
        public string UCeilingHoist { get; set; }
        [Column("u_disabled_extend"), StringLength(3)]
        public string UDisabledExtend { get; set; }
        [Column("u_dh_ext_prog"), StringLength(50)]
        public string UDhExtProg { get; set; }
        [Column("u_dh_int_prog"), StringLength(50)]
        public string UDhIntProg { get; set; }
        [Column("u_int_balcony"), StringLength(3)]
        public string UIntBalcony { get; set; }
        [Column("u_wchair_int_access"), StringLength(3)]
        public string UWchairIntAccess { get; set; }
        [Column("u_lowered_switches"), StringLength(3)]
        public string ULoweredSwitches { get; set; }
        [Column("u_raised_socket"), StringLength(3)]
        public string URaisedSocket { get; set; }
        [Column("u_front_ramp"), StringLength(3)]
        public string UFrontRamp { get; set; }
        [Column("u_rear_ramp"), StringLength(3)]
        public string URearRamp { get; set; }
        [Column("u_scooter_store"), StringLength(3)]
        public string UScooterStore { get; set; }
        [Column("u_stair_lift_type"), StringLength(3)]
        public string UStairLiftType { get; set; }
        [Column("u_hand_rail_type"), StringLength(3)]
        public string UHandRailType { get; set; }
        [Column("u_rear_ent_steps")]
        public int? URearEntSteps { get; set; }
        [Column("u_through_lift"), StringLength(3)]
        public string UThroughLift { get; set; }
        [Column("u_no_wcs")]
        public int? UNoWcs { get; set; }
        [Column("u_wc_closomat"), StringLength(3)]
        public string UWcClosomat { get; set; }
        [Column("u_widened_doors"), StringLength(3)]
        public string UWidenedDoors { get; set; }
        [Column("owner_conf"), StringLength(3)]
        public string OwnerConf { get; set; }
        [Column("epc_cert_no"), StringLength(25)]
        public string EpcCertNo { get; set; }
        [Column("epc_cert_date")]
        public DateTime? EpcCertDate { get; set; }
        [Column("epc_surv_date")]
        public DateTime? EpcSurvDate { get; set; }
        [Column("epc_rq_date")]
        public DateTime? EpcRqDate { get; set; }
        [Column("epc_rec_date")]
        public DateTime? EpcRecDate { get; set; }
        [Column("epc_energy")]
        public decimal? EpcEnergy { get; set; }
        [Column("epc_co2")]
        public decimal? EpcCo2 { get; set; }
        [Column("sc_sinkfund")]
        public decimal? ScSinkfund { get; set; }
        [Column("u_s20_factor")]
        public decimal? US20Factor { get; set; }
        [Column("u_buy_back_date")]
        public DateTime? UBuyBackDate { get; set; }
        [Column("u_shared_bathroom")]
        public bool? USharedBathroom { get; set; }
        [Column("u_shared_toilet")]
        public bool? USharedToilet { get; set; }
        [Column("u_temp_tenure"), StringLength(3)]
        public string UTempTenure { get; set; }
        [Column("u_disrepair")]
        public bool? UDisrepair { get; set; }
        [Column("u_lha_area"), StringLength(3)]
        public string ULhaArea { get; set; }
        [Column("u_est_man"), StringLength(50)]
        public string UEstMan { get; set; }
        [Column("u_cleaner"), StringLength(50)]
        public string UCleaner { get; set; }
        [Column("u_ahr_cat"), StringLength(3)]
        public string UAhrCat { get; set; }
        [Column("u_shared_kitchen")]
        public bool? USharedKitchen { get; set; }
        [Column("u_rsl_prop_ref"), StringLength(16)]
        public string URslPropRef { get; set; }
        [Column("u_uses_com_boiler")]
        public bool? UUsesComBoiler { get; set; }
        [Column("u_uses_door_ent")]
        public bool? UUsesDoorEnt { get; set; }
        [Column("u_uses_lift")]
        public bool? UUsesLift { get; set; }
        [Column("u_mw_patch"), StringLength(3)]
        public string UMwPatch { get; set; }
        [Column("u_year_built"), StringLength(4)]
        public string UYearBuilt { get; set; }
        [Column("u_hand_back_date")]
        public DateTime? UHandBackDate { get; set; }
        [Column("u_bedroom_bedsize"), StringLength(3)]
        public string UBedroomBedsize { get; set; }
        [Column("u_mkt_info_online"), StringLength(1000)]
        public string UMktInfoOnline { get; set; }
        [Column("u_mkt_info_magazine"), StringLength(1000)]
        public string UMktInfoMagazine { get; set; }

        [Column("dtstamp")]
        public DateTime Dtstamp { get; set; }

        [Column("u_hgas")]
        public int? UHgas { get; set; }
        [Column("u_access_type"), StringLength(3)]
        public string UAccessType { get; set; }
        [Column("u_storage_space"), StringLength(3)]
        public string UStorageSpace { get; set; }
        [Column("u_internal_steps")]
        public int? UInternalSteps { get; set; }
        [Column("u_external_steps")]
        public int? UExternalSteps { get; set; }
        [Column("u_adapted_kitchen"), StringLength(3)]
        public string UFulAdaptdKitchen { get; set; }
        [Column("u_hoists")]
        public bool? UHoists { get; set; }
        [Column("u_intercom")]
        public bool? UIntercom { get; set; }
    }
}
