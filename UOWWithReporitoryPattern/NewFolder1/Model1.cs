namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
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
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<CustomerEcdi> CustomerEcdis { get; set; }
        public virtual DbSet<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }
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
        public virtual DbSet<EncOrderHeader> EncOrderHeaders { get; set; }
        public virtual DbSet<EncOrderHeadersHistory> EncOrderHeadersHistories { get; set; }
        public virtual DbSet<EncOrder> EncOrders { get; set; }
        public virtual DbSet<EncOrdersHistory> EncOrdersHistories { get; set; }
        public virtual DbSet<EncOrderStatu> EncOrderStatus { get; set; }
        public virtual DbSet<EncOrderType> EncOrderTypes { get; set; }
        public virtual DbSet<EncProductPrice> EncProductPrices { get; set; }
        public virtual DbSet<EncProduct> EncProducts { get; set; }
        public virtual DbSet<EncProductType> EncProductTypes { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<ExtraProductsAllowed> ExtraProductsAlloweds { get; set; }
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
        public virtual DbSet<LogEntry> LogEntries { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<MiscDownload> MiscDownloads { get; set; }
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
        public virtual DbSet<PublicationDocumentsIndexInfo> PublicationDocumentsIndexInfoes { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<session_details> session_details { get; set; }
        public virtual DbSet<Session1> Sessions1 { get; set; }
        public virtual DbSet<ShippingGuidesCatalog> ShippingGuidesCatalogs { get; set; }
        public virtual DbSet<SynchronizedEntity> SynchronizedEntities { get; set; }
        public virtual DbSet<TankedPublicationInfo> TankedPublicationInfoes { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<USCatalog> USCatalogs { get; set; }
        public virtual DbSet<USCorrection> USCorrections { get; set; }
        public virtual DbSet<USCorrections_Temp> USCorrections_Temp { get; set; }
        public virtual DbSet<VesselCategory> VesselCategories { get; set; }
        public virtual DbSet<VesselCompany> VesselCompanies { get; set; }
        public virtual DbSet<VesselCompanyFileAccess> VesselCompanyFileAccesses { get; set; }
        public virtual DbSet<VesselCompanyFile> VesselCompanyFiles { get; set; }
        public virtual DbSet<VesselCompanyFileType> VesselCompanyFileTypes { get; set; }
        public virtual DbSet<VesselCompanyPublicationCategory> VesselCompanyPublicationCategories { get; set; }
        public virtual DbSet<VesselPosition> VesselPositions { get; set; }
        public virtual DbSet<VesselPositionStatu> VesselPositionStatus { get; set; }
        public virtual DbSet<VesselZone> VesselZones { get; set; }
        public virtual DbSet<WB_Pending> WB_Pending { get; set; }
        public virtual DbSet<activesubscriptions_new> activesubscriptions_new { get; set; }
        public virtual DbSet<BASectV> BASectVs { get; set; }
        public virtual DbSet<CountriesAllowingPaysPlu> CountriesAllowingPaysPlus { get; set; }
        public virtual DbSet<CustomerDeviceInfo> CustomerDeviceInfoes { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<document_types> document_types { get; set; }
        public virtual DbSet<EncBaseCDCoverage> EncBaseCDCoverages { get; set; }
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
        public virtual DbSet<PublicationDocument> PublicationDocuments { get; set; }
        public virtual DbSet<rssNew> rssNews { get; set; }
        public virtual DbSet<VesselPositionsHistory> VesselPositionsHistories { get; set; }
        public virtual DbSet<VesselPositionsHistory2013> VesselPositionsHistory2013 { get; set; }
        public virtual DbSet<VesselPositionsHistory2014> VesselPositionsHistory2014 { get; set; }
        public virtual DbSet<VesselPositionsHistory2015> VesselPositionsHistory2015 { get; set; }
        public virtual DbSet<VesselPositionsHistory2016> VesselPositionsHistory2016 { get; set; }
        public virtual DbSet<XmlNTMData> XmlNTMDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<activesubscription>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<activesubscriptions_backup>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<AdpCoverageArea>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AdpCoverageArea>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<AdpItem>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<AdpItem>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<AdpProduct>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<AdpProduct>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AdpProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<AdpSubscription>()
                .Property(e => e.StartupKey)
                .IsUnicode(false);

            modelBuilder.Entity<AdpSubscription>()
                .Property(e => e.MainActivationKey)
                .IsUnicode(false);

            modelBuilder.Entity<AdpSubscription>()
                .Property(e => e.BackupActivationKey)
                .IsUnicode(false);

            modelBuilder.Entity<AdpSubscription>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CancelledNotice>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.PrimarCountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.VesselCompanies)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Port)
                .IsFixedLength();

            modelBuilder.Entity<customer>()
                .Property(e => e.authcode)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.NaviTabVersion)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.activesubscriptions)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.C_CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomerEcdis)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomerPermitsExtraLines)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomersPositionProviders)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.EncCellCustomerPaysAreas)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.EncCellCustomerPermits)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.EncOrderHeaders)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.FrequentlyUsedEncProducts)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.IssuersCustomerInfoes)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.OrderHeaders)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.PreorderedPublicationInformations)
                .WithOptional(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.Trackings)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.VesselCompanyFileAccesses)
                .WithOptional(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.VesselPositions)
                .WithOptional(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerEcdi>()
                .Property(e => e.UserPermit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomerEcdi>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPermitsExtraLine>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPermitsExtraLine>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.DNID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.MemberNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersPositionProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersPositionProvider>()
                .HasMany(e => e.CustomersInmarsatProviders)
                .WithRequired(e => e.CustomersPositionProvider)
                .HasForeignKey(e => e.CustPosProvId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomVersion>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CustomVersion>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Data_EFS>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EcdisType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EcdisType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EcdisType>()
                .HasMany(e => e.CustomerEcdis)
                .WithRequired(e => e.EcdisType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EcdisType>()
                .HasMany(e => e.CustomerPermitsExtraLines)
                .WithRequired(e => e.EcdisType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EcdisType>()
                .HasMany(e => e.EncCellCustomerPermits)
                .WithRequired(e => e.EcdisType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EFS_PendingData>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EFS_PendingMail>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysArea>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysArea>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysAreasHistory>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysAreasHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermit>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermit>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermitsHistory>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermitsHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellReplacement>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.CellName)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundarySLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryWLon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryNLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryELon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.PolygonPoints)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.GeometryData)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellCustomerPaysAreas)
                .WithRequired(e => e.EncCell)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellCustomerPermits)
                .WithRequired(e => e.EncCell)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellReplacements)
                .WithRequired(e => e.EncCell)
                .HasForeignKey(e => e.ReplacementCellId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellReplacements1)
                .WithRequired(e => e.EncCell1)
                .HasForeignKey(e => e.OriginalCellId);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.CellName)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundarySLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryWLon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryNLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryELon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.PolygonPoints)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.GeometryData)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsInEncProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.OrderedByEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceRef)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceComment)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceBy)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.EncOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.OrderedByEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrder>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncOrder>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrdersHistory>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncOrdersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncOrderStatu)
                .HasForeignKey(e => e.EncOrderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderType>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncOrderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderType>()
                .HasMany(e => e.EncProductPrices)
                .WithRequired(e => e.EncOrderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProductPrice>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncProductPrice>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.ValidLicensePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProduct>()
                .HasMany(e => e.EncProductPrices)
                .WithRequired(e => e.EncProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProductType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncProductType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProductType>()
                .HasMany(e => e.EncProducts)
                .WithRequired(e => e.EncProductType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.BaseCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.ForeignCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ExtraProductsAllowed>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtraProductsAllowed>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ExtraProductsAllowed>()
                .HasMany(e => e.CustomerPermitsExtraLines)
                .WithRequired(e => e.ExtraProductsAllowed)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<file>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<file>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<FlatFeeZone>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FlatFeeZone>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FlatFeeZone>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<FrequentlyUsedEncProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ImoCatalog>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImoCatalog>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImoCatalog>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<ImoCatalog>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ImoCatalog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ImoPublicationCorrection>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImoPublicationCorrection>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ImrayCatalog>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImrayCatalog>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImrayCatalog>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<ImrayCatalog>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ImrayCatalog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<InmarsatProviderHistory>()
                .Property(e => e.DNID)
                .IsUnicode(false);

            modelBuilder.Entity<InmarsatProviderHistory>()
                .Property(e => e.MemberNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InmarsatProviderHistory>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<InmarsatProviderHistory>()
                .Property(e => e.PollInterval)
                .IsUnicode(false);

            modelBuilder.Entity<InmarsatProviderHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<issuer>()
                .Property(e => e.C_IssuerShortName)
                .IsUnicode(false);

            modelBuilder.Entity<issuer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.activesubscriptions)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.C_IssuerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.EncCells)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.EncProducts)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.ExtraProductsAlloweds)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.IssuersAvailableToCustomers)
                .WithOptional(e => e.issuer)
                .HasForeignKey(e => e.IssuerId);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.IssuersCustomerInfoes)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.IssuersVesselCompanyInfoes)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.PublicationCorrectionDocuments)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuersAvailableToCustomer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersCustomerInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.IssuersEncOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuersEncOrderHeadersHistory>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeadersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.IssuersEncOrderHeaderStatu)
                .HasForeignKey(e => e.IssuersEncOrderHeaderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuersVesselCompanyInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<LogEntry>()
                .Property(e => e.Entry)
                .IsUnicode(false);

            modelBuilder.Entity<LogEntry>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<MediaType>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<MediaType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MediaType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<MiscDownload>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<MiscDownload>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupBackgroundImage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupBackgroundImage>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupBackgroundImage>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupBackgroundImage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupCorrection>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupBackgroundImages)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CutomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupCorrections)
                .WithOptional(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupEReaderUsers)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupNaviTabInformations)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupPdfAttachments)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupPendingDownloads)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupPendingPublicationDownloads)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupPublicaitonCatalogInfoes)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupPublicationDocuments)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupSearchSuggestions)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupCustomerInfo>()
                .HasMany(e => e.NaviTabBackupServerInformations)
                .WithRequired(e => e.NaviTabBackupCustomerInfo)
                .HasForeignKey(e => e.CustomerInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupEReaderUser>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupNaviTabInformation>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.LastUsedAnnotationColor)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.LastUsedHighlightColor)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.AnnotationXml)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.BookmarkText)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.BookmarkTextXml)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPdfAttachment>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingDownload>()
                .Property(e => e.SessionKey)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingDownload>()
                .Property(e => e.PackageKey)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingDownload>()
                .Property(e => e.ServerHost)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingDownload>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingDownload>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingPublicationDownload>()
                .Property(e => e.PublicationNauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPendingPublicationDownload>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicaitonCatalogInfo>()
                .Property(e => e.MyFavoriteNauProdIdList)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicaitonCatalogInfo>()
                .Property(e => e.IsJustUpdatedNauProdIdList)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicaitonCatalogInfo>()
                .Property(e => e.IsMarkedForAutoUpdateNauProdIdList)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicaitonCatalogInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicationDocument>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicationDocument>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicationDocument>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupPublicationDocument>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupSearchSuggestion>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupSearchSuggestion>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.ServerHost)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.AuthKey)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.VesselName)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.CatalogPackageFolder)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.DeviceSerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.HardwareId)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.RetryInterval)
                .IsUnicode(false);

            modelBuilder.Entity<NaviTabBackupServerInformation>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_admin_users>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_customversions>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_customversions>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_files>()
                .Property(e => e.sessionid)
                .IsFixedLength();

            modelBuilder.Entity<nept2_files>()
                .Property(e => e.ip)
                .IsFixedLength();

            modelBuilder.Entity<nept2_files>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_fredrik_location>()
                .Property(e => e.loc)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_fredrik_location>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_package>()
                .Property(e => e.sessionid)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_package>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_package>()
                .Property(e => e.arguments)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_package>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_server>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_session>()
                .Property(e => e.sessionid)
                .IsFixedLength();

            modelBuilder.Entity<nept2_session>()
                .Property(e => e.ip)
                .IsFixedLength();

            modelBuilder.Entity<nept2_session>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<nept2_watchlist>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NeptuneVesselIncrementalReport>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NeptuneVesselIncrementalReports_Old>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NeptuneVesselSetting>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NeptuneVesselStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<NorwegianCatalog>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NorwegianCatalog>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<NorwegianCatalog>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<NorwegianCatalog>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<NorwegianCatalog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_BR>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_BR>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.OrderedByEmail)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.InvoiceRef)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.InvoiceComment)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.InvoiceBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OrderHeader>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.OrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderLine>()
                .Property(e => e.ProductReference)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLine>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLine>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.OrderHeaders)
                .WithRequired(e => e.OrderStatu)
                .HasForeignKey(e => e.OrderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.OrderStatu)
                .HasForeignKey(e => e.OrderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<package>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<package>()
                .Property(e => e.arguments)
                .IsUnicode(false);

            modelBuilder.Entity<package>()
                .Property(e => e.pkey)
                .IsUnicode(false);

            modelBuilder.Entity<package>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<package_files>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<package_files>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<package_open>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PackageOpen>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Package1>()
                .Property(e => e.PackageKey)
                .IsUnicode(false);

            modelBuilder.Entity<Package1>()
                .Property(e => e.Arguments)
                .IsUnicode(false);

            modelBuilder.Entity<Package1>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Package1>()
                .HasMany(e => e.PackageOpens)
                .WithRequired(e => e.Package)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaysAreaStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PaysAreaStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PaysAreaStatu>()
                .HasMany(e => e.EncCellCustomerPaysAreas)
                .WithRequired(e => e.PaysAreaStatu)
                .HasForeignKey(e => e.PaysAreaStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PermitStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PermitStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PermitStatu>()
                .HasMany(e => e.CustomerPermitsExtraLines)
                .WithRequired(e => e.PermitStatu)
                .HasForeignKey(e => e.PermitStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PermitStatu>()
                .HasMany(e => e.EncCellCustomerPermits)
                .WithRequired(e => e.PermitStatu)
                .HasForeignKey(e => e.PermitStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<poseidon_access>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_custom_userinformation>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_custom_userinformation>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_custom_userinformation>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_flag>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_group>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_session>()
                .Property(e => e.request)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_session>()
                .Property(e => e.useragent)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_session>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_user>()
                .Property(e => e.displayname)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_user>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_variable>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_variable>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_variable>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<poseidon_watchlist>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PositionProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PositionProvider>()
                .HasMany(e => e.CustomersPositionProviders)
                .WithRequired(e => e.PositionProvider)
                .HasForeignKey(e => e.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionProvider>()
                .HasMany(e => e.VesselPositions)
                .WithRequired(e => e.PositionProvider)
                .HasForeignKey(e => e.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreorderedPublicationInformation>()
                .Property(e => e.ProductId)
                .IsUnicode(false);

            modelBuilder.Entity<PreorderedPublicationInformation>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarCountry>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PrimarCountry>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarCountry>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarCountry>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.PrimarCountry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PrimarSubscriptionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarSubscriptionType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarVesselCategory>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarVesselCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarVesselCategory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PrimarVesselCategory>()
                .HasMany(e => e.VesselCategories)
                .WithOptional(e => e.PrimarVesselCategory)
                .HasForeignKey(e => e.PrimarCategoryId);

            modelBuilder.Entity<ProductGroup>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ProductGroup>()
                .HasMany(e => e.OrderLines)
                .WithRequired(e => e.ProductGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductGroup>()
                .HasMany(e => e.ProductPrices)
                .WithRequired(e => e.ProductGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductPrice>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ProductPrice>()
                .Property(e => e.Currency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductPrice>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationCorrectionDocument>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationCorrectionDocument>()
                .HasMany(e => e.ImoPublicationCorrections)
                .WithRequired(e => e.PublicationCorrectionDocument)
                .HasForeignKey(e => e.CorrectionDocId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PublicationDocumentsIndexInfo>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationDocumentsIndexInfo>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationDocumentsIndexInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Server>()
                .HasMany(e => e.LogEntries)
                .WithRequired(e => e.Server)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Server>()
                .HasMany(e => e.Sessions)
                .WithRequired(e => e.Server)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<session>()
                .Property(e => e.skey)
                .IsFixedLength();

            modelBuilder.Entity<session>()
                .Property(e => e.ip)
                .IsFixedLength();

            modelBuilder.Entity<session>()
                .Property(e => e.server)
                .IsUnicode(false);

            modelBuilder.Entity<session>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<session_details>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<session_details>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Session1>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Session1>()
                .HasMany(e => e.PackageOpens)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session1>()
                .HasMany(e => e.Packages)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session1>()
                .HasMany(e => e.Transfers)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShippingGuidesCatalog>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingGuidesCatalog>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingGuidesCatalog>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<ShippingGuidesCatalog>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<ShippingGuidesCatalog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<SynchronizedEntity>()
                .Property(e => e.EntityName)
                .IsUnicode(false);

            modelBuilder.Entity<SynchronizedEntity>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SynchronizedEntity>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<TankedPublicationInfo>()
                .Property(e => e.DeviceSerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TankedPublicationInfo>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<TankedPublicationInfo>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<TankedPublicationInfo>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<TankedPublicationInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking>()
                .Property(e => e.Ordered)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<USCatalog>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<USCatalog>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<USCatalog>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<USCatalog>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<USCatalog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrection>()
                .Property(e => e.ChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrection>()
                .Property(e => e.IntlChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrection>()
                .Property(e => e.ChartEditionDate)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrection>()
                .Property(e => e.LastNm)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrection>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrections_Temp>()
                .Property(e => e.ChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrections_Temp>()
                .Property(e => e.IntlChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrections_Temp>()
                .Property(e => e.ChartEditionDate)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrections_Temp>()
                .Property(e => e.LastNm)
                .IsUnicode(false);

            modelBuilder.Entity<USCorrections_Temp>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.VismaDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.PrimarCategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompany>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompany>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompany>()
                .HasMany(e => e.IssuersVesselCompanyInfoes)
                .WithRequired(e => e.VesselCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VesselCompanyFileAccess>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompanyFile>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<VesselCompanyFile>()
                .Property(e => e.OriginalFileName)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompanyFile>()
                .Property(e => e.OriginalThumbnailName)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompanyFile>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompanyFile>()
                .HasMany(e => e.VesselCompanyFileAccesses)
                .WithRequired(e => e.VesselCompanyFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VesselCompanyFileType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompanyPublicationCategory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPosition>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionStatu>()
                .HasMany(e => e.VesselPositions)
                .WithOptional(e => e.VesselPositionStatu)
                .HasForeignKey(e => e.VesselPositionStatusId);

            modelBuilder.Entity<VesselZone>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<WB_Pending>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<activesubscriptions_new>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<BASectV>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDeviceInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerGroup>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<document_types>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncBaseCDCoverage>()
                .Property(e => e.CountryCodes)
                .IsUnicode(false);

            modelBuilder.Entity<EncBaseCDCoverage>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EncBaseCDCoverage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<errorlog>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<FilesAddedDate>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ImoPublicationsNoDigital>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<ImoPublicationsNoDigital>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<inactivesubscriptions_not_in_use>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuerPrefix>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<log_sentfiles>()
                .Property(e => e.C_filename)
                .IsFixedLength();

            modelBuilder.Entity<log_sentfiles>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_OptionalFiles>()
                .Property(e => e.C_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_OptionalFiles>()
                .Property(e => e.C_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_OptionalFiles>()
                .Property(e => e.C_Path)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_OptionalFiles>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_XmlNTMData>()
                .Property(e => e.C_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Moved_XmlNTMData>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_AutoReport>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Neptune_AutoReport>()
                .Property(e => e.reportname)
                .IsFixedLength();

            modelBuilder.Entity<Neptune_AutoReport>()
                .Property(e => e.sendstyle)
                .IsFixedLength();

            modelBuilder.Entity<Neptune_AutoReport>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files>()
                .Property(e => e.sessionid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files>()
                .Property(e => e.ip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files>()
                .Property(e => e.customer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files_old>()
                .Property(e => e.sessionid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files_old>()
                .Property(e => e.ip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files_old>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files_old>()
                .Property(e => e.customer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Files_old>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons>()
                .Property(e => e.ip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons>()
                .Property(e => e.customer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons>()
                .Property(e => e.parameters)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons_old>()
                .Property(e => e.ip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons_old>()
                .Property(e => e.customer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons_old>()
                .Property(e => e.parameters)
                .IsUnicode(false);

            modelBuilder.Entity<Neptune_Logons_old>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_AUS>()
                .Property(e => e.LastNtm)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_AUS>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_JP>()
                .Property(e => e.ChartNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_JP>()
                .Property(e => e.LastNtm)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_JP>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_NZ>()
                .Property(e => e.LastNtm)
                .IsUnicode(false);

            modelBuilder.Entity<Ntm_NZ>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OptionalFile>()
                .Property(e => e.C_Type)
                .IsUnicode(false);

            modelBuilder.Entity<OptionalFile>()
                .Property(e => e.C_Number)
                .IsUnicode(false);

            modelBuilder.Entity<OptionalFile>()
                .Property(e => e.C_NauProdID)
                .IsUnicode(false);

            modelBuilder.Entity<OptionalFile>()
                .Property(e => e.C_Path)
                .IsUnicode(false);

            modelBuilder.Entity<OptionalFile>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<prefixtable>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationDocument>()
                .Property(e => e.NauProdId)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationDocument>()
                .Property(e => e.ProdId)
                .IsUnicode(false);

            modelBuilder.Entity<PublicationDocument>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<rssNew>()
                .Property(e => e.C_Content)
                .IsUnicode(false);

            modelBuilder.Entity<rssNew>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionsHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionsHistory2013>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionsHistory2014>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionsHistory2015>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPositionsHistory2016>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<XmlNTMData>()
                .Property(e => e.C_Type)
                .IsUnicode(false);

            modelBuilder.Entity<XmlNTMData>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);
        }
    }
}
