//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class neptuneEntities1 : DbContext
    {
        public neptuneEntities1()
            : base("name=neptuneEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<activesubscription> activesubscriptions { get; set; }
        public virtual DbSet<activesubscriptions_backup> activesubscriptions_backup { get; set; }
        public virtual DbSet<AdpCoverageArea> AdpCoverageAreas { get; set; }
        public virtual DbSet<AdpItem> AdpItems { get; set; }
        public virtual DbSet<AdpProduct> AdpProducts { get; set; }
        public virtual DbSet<AdpSubscription> AdpSubscriptions { get; set; }
        public virtual DbSet<CancelledNotice> CancelledNotices { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<CustomerEcdi> CustomerEcdis { get; set; }
        public virtual DbSet<CustomerEncVersion> CustomerEncVersions { get; set; }
        public virtual DbSet<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }
        public virtual DbSet<CustomerPermitsPriorToPay> CustomerPermitsPriorToPays { get; set; }
        public virtual DbSet<CustomersInmarsatProvider> CustomersInmarsatProviders { get; set; }
        public virtual DbSet<CustomersPositionProvider> CustomersPositionProviders { get; set; }
        public virtual DbSet<CustomVersion> CustomVersions { get; set; }
        public virtual DbSet<Data_EFS> Data_EFS { get; set; }
        public virtual DbSet<EcdisType> EcdisTypes { get; set; }
        public virtual DbSet<EFS_PendingData> EFS_PendingData { get; set; }
        public virtual DbSet<EFS_PendingMail> EFS_PendingMail { get; set; }
        public virtual DbSet<EncCellCustomerPaysArea> EncCellCustomerPaysAreas { get; set; }
        public virtual DbSet<EncCellCustomerPaysAreasHistory> EncCellCustomerPaysAreasHistories { get; set; }
        public virtual DbSet<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }
        public virtual DbSet<EncCellCustomerPermitsHistory> EncCellCustomerPermitsHistories { get; set; }
        public virtual DbSet<EncCellReplacement> EncCellReplacements { get; set; }
        public virtual DbSet<EncCell> EncCells { get; set; }
        public virtual DbSet<EncCellsHistory> EncCellsHistories { get; set; }
        public virtual DbSet<EncCellsInEncProduct> EncCellsInEncProducts { get; set; }
        public virtual DbSet<EncFileInfo> EncFileInfos { get; set; }
        public virtual DbSet<EncOrderHeader> EncOrderHeaders { get; set; }
        public virtual DbSet<EncOrderHeadersHistory> EncOrderHeadersHistories { get; set; }
        public virtual DbSet<EncOrder> EncOrders { get; set; }
        public virtual DbSet<EncOrdersHistory> EncOrdersHistories { get; set; }
        public virtual DbSet<EncOrderStatu> EncOrderStatus { get; set; }
        public virtual DbSet<EncOrderType> EncOrderTypes { get; set; }
        public virtual DbSet<EncProductPrice> EncProductPrices { get; set; }
        public virtual DbSet<EncProduct> EncProducts { get; set; }
        public virtual DbSet<EncProductType> EncProductTypes { get; set; }
        public virtual DbSet<EncVersion> EncVersions { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<ExtraProductsAllowed> ExtraProductsAlloweds { get; set; }
        public virtual DbSet<FagbokforlagetCatalog> FagbokforlagetCatalogs { get; set; }
        public virtual DbSet<file> files { get; set; }
        public virtual DbSet<FlatFeeZone> FlatFeeZones { get; set; }
        public virtual DbSet<FrequentlyUsedEncProduct> FrequentlyUsedEncProducts { get; set; }
        public virtual DbSet<ImoCatalog> ImoCatalogs { get; set; }
        public virtual DbSet<ImoPublicationCorrection> ImoPublicationCorrections { get; set; }
        public virtual DbSet<ImrayCatalog> ImrayCatalogs { get; set; }
        public virtual DbSet<InmarsatProviderHistory> InmarsatProviderHistories { get; set; }
        public virtual DbSet<issuer> issuers { get; set; }
        public virtual DbSet<IssuersAvailableToCustomer> IssuersAvailableToCustomers { get; set; }
        public virtual DbSet<IssuersCustomerInfo> IssuersCustomerInfoes { get; set; }
        public virtual DbSet<IssuersEncOrderHeader> IssuersEncOrderHeaders { get; set; }
        public virtual DbSet<IssuersEncOrderHeadersHistory> IssuersEncOrderHeadersHistories { get; set; }
        public virtual DbSet<IssuersEncOrderHeaderStatu> IssuersEncOrderHeaderStatus { get; set; }
        public virtual DbSet<IssuersVesselCompanyInfo> IssuersVesselCompanyInfoes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LogBookCatalog> LogBookCatalogs { get; set; }
        public virtual DbSet<LogEntry> LogEntries { get; set; }
        public virtual DbSet<MarpolData> MarpolDatas { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<MiscDownload> MiscDownloads { get; set; }
        public virtual DbSet<NaviLogCustomerDataSyncInformation> NaviLogCustomerDataSyncInformations { get; set; }
        public virtual DbSet<NaviLogLogBookRecord> NaviLogLogBookRecords { get; set; }
        public virtual DbSet<NaviLogPublicationDocumentDetail> NaviLogPublicationDocumentDetails { get; set; }
        public virtual DbSet<NaviLogUserInfo> NaviLogUserInfoes { get; set; }
        public virtual DbSet<NaviManagerCustomerGroup> NaviManagerCustomerGroups { get; set; }
        public virtual DbSet<NaviManagerPasswordResetCode> NaviManagerPasswordResetCodes { get; set; }
        public virtual DbSet<NaviManagerThresholdConfig> NaviManagerThresholdConfigs { get; set; }
        public virtual DbSet<NaviManagerThresholdType> NaviManagerThresholdTypes { get; set; }
        public virtual DbSet<NaviManagerUser> NaviManagerUsers { get; set; }
        public virtual DbSet<NaviManagerUserToken> NaviManagerUserTokens { get; set; }
        public virtual DbSet<NaviTabBackupBackgroundImage> NaviTabBackupBackgroundImages { get; set; }
        public virtual DbSet<NaviTabBackupCorrection> NaviTabBackupCorrections { get; set; }
        public virtual DbSet<NaviTabBackupCustomerInfo> NaviTabBackupCustomerInfoes { get; set; }
        public virtual DbSet<NaviTabBackupEReaderUser> NaviTabBackupEReaderUsers { get; set; }
        public virtual DbSet<NaviTabBackupNaviTabInformation> NaviTabBackupNaviTabInformations { get; set; }
        public virtual DbSet<NaviTabBackupPdfAttachment> NaviTabBackupPdfAttachments { get; set; }
        public virtual DbSet<NaviTabBackupPendingDownload> NaviTabBackupPendingDownloads { get; set; }
        public virtual DbSet<NaviTabBackupPendingPublicationDownload> NaviTabBackupPendingPublicationDownloads { get; set; }
        public virtual DbSet<NaviTabBackupPublicaitonCatalogInfo> NaviTabBackupPublicaitonCatalogInfoes { get; set; }
        public virtual DbSet<NaviTabBackupPublicationDocument> NaviTabBackupPublicationDocuments { get; set; }
        public virtual DbSet<NaviTabBackupSearchSuggestion> NaviTabBackupSearchSuggestions { get; set; }
        public virtual DbSet<NaviTabBackupServerInformation> NaviTabBackupServerInformations { get; set; }
        public virtual DbSet<nept2_admin_users> nept2_admin_users { get; set; }
        public virtual DbSet<nept2_customversions> nept2_customversions { get; set; }
        public virtual DbSet<nept2_files> nept2_files { get; set; }
        public virtual DbSet<nept2_fredrik_location> nept2_fredrik_location { get; set; }
        public virtual DbSet<nept2_package> nept2_package { get; set; }
        public virtual DbSet<nept2_server> nept2_server { get; set; }
        public virtual DbSet<nept2_session> nept2_session { get; set; }
        public virtual DbSet<nept2_watchlist> nept2_watchlist { get; set; }
        public virtual DbSet<NeptuneVesselIncrementalReport> NeptuneVesselIncrementalReports { get; set; }
        public virtual DbSet<NeptuneVesselIncrementalReports_Old> NeptuneVesselIncrementalReports_Old { get; set; }
        public virtual DbSet<NeptuneVesselSetting> NeptuneVesselSettings { get; set; }
        public virtual DbSet<NeptuneVesselStatu> NeptuneVesselStatus { get; set; }
        public virtual DbSet<NorwegianCatalog> NorwegianCatalogs { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }
        public virtual DbSet<Ntm_BR> Ntm_BR { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<package> packages { get; set; }
        public virtual DbSet<package_files> package_files { get; set; }
        public virtual DbSet<package_open> package_open { get; set; }
        public virtual DbSet<PackageOpen> PackageOpens { get; set; }
        public virtual DbSet<Package1> Packages1 { get; set; }
        public virtual DbSet<PaysAreaStatu> PaysAreaStatus { get; set; }
        public virtual DbSet<PermitStatu> PermitStatus { get; set; }
        public virtual DbSet<poseidon_access> poseidon_access { get; set; }
        public virtual DbSet<poseidon_custom_userinformation> poseidon_custom_userinformation { get; set; }
        public virtual DbSet<poseidon_flag> poseidon_flag { get; set; }
        public virtual DbSet<poseidon_group> poseidon_group { get; set; }
        public virtual DbSet<poseidon_session> poseidon_session { get; set; }
        public virtual DbSet<poseidon_user> poseidon_user { get; set; }
        public virtual DbSet<poseidon_variable> poseidon_variable { get; set; }
        public virtual DbSet<poseidon_watchlist> poseidon_watchlist { get; set; }
        public virtual DbSet<PositionProvider> PositionProviders { get; set; }
        public virtual DbSet<PreorderedPublicationInformation> PreorderedPublicationInformations { get; set; }
        public virtual DbSet<PrimarCountry> PrimarCountries { get; set; }
        public virtual DbSet<PrimarSubscriptionType> PrimarSubscriptionTypes { get; set; }
        public virtual DbSet<PrimarVesselCategory> PrimarVesselCategories { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<PublicationCorrectionDocument> PublicationCorrectionDocuments { get; set; }
        public virtual DbSet<PublicationDocument> PublicationDocuments { get; set; }
        public virtual DbSet<PublicationDocumentsIndexInfo> PublicationDocumentsIndexInfoes { get; set; }
        public virtual DbSet<RequiredEncsForSharedRoute> RequiredEncsForSharedRoutes { get; set; }
        public virtual DbSet<RequiredEncsForVoyage> RequiredEncsForVoyages { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<session_details> session_details { get; set; }
        public virtual DbSet<Session1> Sessions1 { get; set; }
        public virtual DbSet<SharedRouteFileInfo> SharedRouteFileInfos { get; set; }
        public virtual DbSet<ShippingGuidesCatalog> ShippingGuidesCatalogs { get; set; }
        public virtual DbSet<SynchronizedEntity> SynchronizedEntities { get; set; }
        public virtual DbSet<TankedPublicationInfo> TankedPublicationInfoes { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<USCatalog> USCatalogs { get; set; }
        public virtual DbSet<USCorrection> USCorrections { get; set; }
        public virtual DbSet<USCorrections_Temp> USCorrections_Temp { get; set; }
        public virtual DbSet<ValueAddedSubscription> ValueAddedSubscriptions { get; set; }
        public virtual DbSet<ValueAddedSubscriptionStatu> ValueAddedSubscriptionStatus { get; set; }
        public virtual DbSet<ValueAddedSubscriptionTypePrice> ValueAddedSubscriptionTypePrices { get; set; }
        public virtual DbSet<ValueAddedSubscriptionType> ValueAddedSubscriptionTypes { get; set; }
        public virtual DbSet<Variable> Variables { get; set; }
        public virtual DbSet<VesselCategory> VesselCategories { get; set; }
        public virtual DbSet<VesselCompany> VesselCompanies { get; set; }
        public virtual DbSet<VesselCompanyFileAccess> VesselCompanyFileAccesses { get; set; }
        public virtual DbSet<VesselCompanyFile> VesselCompanyFiles { get; set; }
        public virtual DbSet<VesselCompanyFileType> VesselCompanyFileTypes { get; set; }
        public virtual DbSet<VesselCompanyPublicationCategory> VesselCompanyPublicationCategories { get; set; }
        public virtual DbSet<VesselPosition> VesselPositions { get; set; }
        public virtual DbSet<VesselPositions_Dummy> VesselPositions_Dummy { get; set; }
        public virtual DbSet<VesselPositionStatu> VesselPositionStatus { get; set; }
        public virtual DbSet<VesselZone> VesselZones { get; set; }
        public virtual DbSet<VoyageDocument> VoyageDocuments { get; set; }
        public virtual DbSet<VoyageRoute> VoyageRoutes { get; set; }
        public virtual DbSet<Voyage> Voyages { get; set; }
        public virtual DbSet<WB_Pending> WB_Pending { get; set; }
        public virtual DbSet<activesubscriptions_new> activesubscriptions_new { get; set; }
        public virtual DbSet<BASectV> BASectVs { get; set; }
        public virtual DbSet<CountriesAllowingPaysPlu> CountriesAllowingPaysPlus { get; set; }
        public virtual DbSet<CustomerDeviceInfo> CustomerDeviceInfoes { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<document_types> document_types { get; set; }
        public virtual DbSet<EncBaseCDCoverage> EncBaseCDCoverages { get; set; }
        public virtual DbSet<EncCells_Dummy> EncCells_Dummy { get; set; }
        public virtual DbSet<errorlog> errorlogs { get; set; }
        public virtual DbSet<FilesAddedDate> FilesAddedDates { get; set; }
        public virtual DbSet<ImoPublicationsNoDigital> ImoPublicationsNoDigitals { get; set; }
        public virtual DbSet<inactivesubscriptions_not_in_use> inactivesubscriptions_not_in_use { get; set; }
        public virtual DbSet<IssuerPrefix> IssuerPrefixes { get; set; }
        public virtual DbSet<log_sentfiles> log_sentfiles { get; set; }
        public virtual DbSet<Moved_OptionalFiles> Moved_OptionalFiles { get; set; }
        public virtual DbSet<Moved_XmlNTMData> Moved_XmlNTMData { get; set; }
        public virtual DbSet<Neptune_AutoReport> Neptune_AutoReport { get; set; }
        public virtual DbSet<Neptune_Files> Neptune_Files { get; set; }
        public virtual DbSet<Neptune_Files_old> Neptune_Files_old { get; set; }
        public virtual DbSet<Neptune_Logons> Neptune_Logons { get; set; }
        public virtual DbSet<Neptune_Logons_old> Neptune_Logons_old { get; set; }
        public virtual DbSet<Ntm_AUS> Ntm_AUS { get; set; }
        public virtual DbSet<Ntm_JP> Ntm_JP { get; set; }
        public virtual DbSet<Ntm_NZ> Ntm_NZ { get; set; }
        public virtual DbSet<OptionalFile> OptionalFiles { get; set; }
        public virtual DbSet<prefixtable> prefixtables { get; set; }
        public virtual DbSet<rssNew> rssNews { get; set; }
        public virtual DbSet<VesselPositionsHistory> VesselPositionsHistories { get; set; }
        public virtual DbSet<VesselPositionsHistory2013> VesselPositionsHistory2013 { get; set; }
        public virtual DbSet<VesselPositionsHistory2014> VesselPositionsHistory2014 { get; set; }
        public virtual DbSet<VesselPositionsHistory2015> VesselPositionsHistory2015 { get; set; }
        public virtual DbSet<VesselPositionsHistory2016> VesselPositionsHistory2016 { get; set; }
        public virtual DbSet<XmlNTMData> XmlNTMDatas { get; set; }
    }
}
