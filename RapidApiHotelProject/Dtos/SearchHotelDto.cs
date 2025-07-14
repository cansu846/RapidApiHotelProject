namespace RapidApiHotelProject.Dtos
{
    public class SearchHotelDto
    {
            public Data data { get; set; }
            public Meta meta { get; set; }
            public bool status { get; set; }
            public string message { get; set; }
      
        public class Data
        {
            public string __typename { get; set; }
            public Banner[] banners { get; set; }
            public Breadcrumb[] breadcrumbs { get; set; }
            public Carousel[] carousels { get; set; }
            public Destinationlocation destinationLocation { get; set; }
            public bool entireHomesSearchEnabled { get; set; }
            public Dateflexibilityoptions dateFlexibilityOptions { get; set; }
            public Flexibledatesconfig flexibleDatesConfig { get; set; }
            public Filter[] filters { get; set; }
            public Filterstrackonview[] filtersTrackOnView { get; set; }
            public object[] appliedFilterOptions { get; set; }
            public Recommendedfilteroption[] recommendedFilterOptions { get; set; }
            public Pagination pagination { get; set; }
            public object tripTypes { get; set; }
            public Result[] results { get; set; }
            public Searchmeta searchMeta { get; set; }
            public Sorter[] sorters { get; set; }
            public Zeroresultssection zeroResultsSection { get; set; }
            public object rocketmilesSearchUuid { get; set; }
            public Previoussearch[] previousSearches { get; set; }
            public Merchcomponents merchComponents { get; set; }
            public object wishlistData { get; set; }
            public object[] seoThemes { get; set; }
            public string gridViewPreference { get; set; }
            public Advancedsearchwidget advancedSearchWidget { get; set; }
            public object visualFiltersGroups { get; set; }
        }

        public class Destinationlocation
        {
            public string __typename { get; set; }
            public Name name { get; set; }
            public Inname inName { get; set; }
            public string countryCode { get; set; }
            public int ufi { get; set; }
        }

        public class Name
        {
            public string __typename { get; set; }
            public string text { get; set; }
        }

        public class Inname
        {
            public string __typename { get; set; }
            public string text { get; set; }
        }

        public class Dateflexibilityoptions
        {
            public string __typename { get; set; }
            public bool enabled { get; set; }
        }

        public class Flexibledatesconfig
        {
            public string __typename { get; set; }
            public Broaddatescalendar broadDatesCalendar { get; set; }
            public string dateFlexUseCase { get; set; }
            public Daterangecalendar dateRangeCalendar { get; set; }
        }

        public class Broaddatescalendar
        {
            public string __typename { get; set; }
            public object[] checkinMonths { get; set; }
            public object[] los { get; set; }
            public object[] startWeekdays { get; set; }
            public string losType { get; set; }
        }

        public class Daterangecalendar
        {
            public string __typename { get; set; }
            public object flexWindow { get; set; }
            public string[] checkin { get; set; }
            public string[] checkout { get; set; }
        }

        public class Pagination
        {
            public string __typename { get; set; }
            public int nbResultsPerPage { get; set; }
            public int nbResultsTotal { get; set; }
        }

        public class Searchmeta
        {
            public string __typename { get; set; }
            public Availabilityinfo availabilityInfo { get; set; }
            public Boundingbox[] boundingBoxes { get; set; }
            public int[] childrenAges { get; set; }
            public Dates dates { get; set; }
            public int destId { get; set; }
            public string destType { get; set; }
            public Guessedlocation guessedLocation { get; set; }
            public int maxLengthOfStayInDays { get; set; }
            public int nbRooms { get; set; }
            public int nbAdults { get; set; }
            public int nbChildren { get; set; }
            public bool userHasSelectedFilters { get; set; }
            public string customerValueStatus { get; set; }
            public bool isAffiliateBookingOwned { get; set; }
            public int affiliatePartnerChannelId { get; set; }
            public string affiliateVerticalType { get; set; }
            public int geniusLevel { get; set; }
        }

        public class Availabilityinfo
        {
            public string __typename { get; set; }
            public bool hasLowAvailability { get; set; }
            public int unavailabilityPercent { get; set; }
            public int totalAvailableNotAutoextended { get; set; }
            public int totalAutoextendedAvailable { get; set; }
        }

        public class Dates
        {
            public string __typename { get; set; }
            public string checkin { get; set; }
            public string checkout { get; set; }
            public int lengthOfStayInDays { get; set; }
        }

        public class Guessedlocation
        {
            public string __typename { get; set; }
            public int destId { get; set; }
            public string destType { get; set; }
            public string destName { get; set; }
        }

        public class Boundingbox
        {
            public string __typename { get; set; }
            public float swLat { get; set; }
            public float swLon { get; set; }
            public float neLat { get; set; }
            public float neLon { get; set; }
            public string type { get; set; }
        }

        public class Zeroresultssection
        {
            public string __typename { get; set; }
            public object title { get; set; }
            public object primaryAction { get; set; }
            public object[] paragraphs { get; set; }
            public object type { get; set; }
        }

        public class Merchcomponents
        {
            public string __typename { get; set; }
            public Region[] regions { get; set; }
        }

        public class Region
        {
            public string __ref { get; set; }
        }

        public class Advancedsearchwidget
        {
            public string __typename { get; set; }
            public string title { get; set; }
            public string legalDisclaimer { get; set; }
            public string description { get; set; }
            public string placeholder { get; set; }
            public string ctaText { get; set; }
            public string helperText { get; set; }
        }

        public class Banner
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public bool? isDismissible { get; set; }
            public int? showAfterDismissedDuration { get; set; }
            public int position { get; set; }
            public bool? requestAlternativeDates { get; set; }
            public object merchId { get; set; }
            public Title title { get; set; }
            public object imageUrl { get; set; }
            public object paragraphs { get; set; }
            public Metadata[] metadata { get; set; }
            public object pendingReviewInfo { get; set; }
            public object nbDeals { get; set; }
            public Primaryaction primaryAction { get; set; }
            public object secondaryAction { get; set; }
            public object iconName { get; set; }
            public object[] flexibleFilterOptions { get; set; }
            public Trackonview[] trackOnView { get; set; }
            public object[] dateFlexQueryOptions { get; set; }
        }

        public class Title
        {
            public string __typename { get; set; }
            public string text { get; set; }
        }

        public class Primaryaction
        {
            public string __typename { get; set; }
            public Text text { get; set; }
            public Action action { get; set; }
        }

        public class Text
        {
            public string __typename { get; set; }
            public string text { get; set; }
        }

        public class Action
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public Context[] context { get; set; }
        }

        public class Context
        {
            public string __typename { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Metadata
        {
            public string __typename { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Trackonview
        {
            public string __typename { get; set; }
            public int type { get; set; }
            public string experimentHash { get; set; }
            public int value { get; set; }
        }

        public class Breadcrumb
        {
            public string __typename { get; set; }
            public string destType { get; set; }
            public string name { get; set; }
            public string[] urlParts { get; set; }
        }

        public class Carousel
        {
            public string __typename { get; set; }
            public object aggregatedCountsByFilterId { get; set; }
            public int carouselId { get; set; }
            public int position { get; set; }
            public string contentType { get; set; }
            public object hotelId { get; set; }
            public string name { get; set; }
            public object soldoutProperties { get; set; }
            public int priority { get; set; }
            public object themeId { get; set; }
            public object title { get; set; }
            public object slides { get; set; }
        }

        public class Filter
        {
            public string __typename { get; set; }
            public Trackonview1[] trackOnView { get; set; }
            public object[] trackOnClick { get; set; }
            public string name { get; set; }
            public string field { get; set; }
            public string category { get; set; }
            public string filterStyle { get; set; }
            public Title1 title { get; set; }
            public string subtitle { get; set; }
            public Option[] options { get; set; }
            public Filterlayout filterLayout { get; set; }
            public Stepperoption[] stepperOptions { get; set; }
            public Slideroptions sliderOptions { get; set; }
            public Distancetopoidata distanceToPoiData { get; set; }
        }

        public class Title1
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag translationTag { get; set; }
        }

        public class Translationtag
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Filterlayout
        {
            public string __typename { get; set; }
            public bool isCollapsable { get; set; }
            public int collapsedCount { get; set; }
        }

        public class Slideroptions
        {
            public string __typename { get; set; }
            public string min { get; set; }
            public string max { get; set; }
            public string minSelected { get; set; }
            public string maxSelected { get; set; }
            public string minPriceStep { get; set; }
            public string minSelectedFormatted { get; set; }
            public string currency { get; set; }
            public int?[] histogram { get; set; }
            public object selectedRange { get; set; }
        }

        public class Distancetopoidata
        {
            public string __typename { get; set; }
            public object[] options { get; set; }
            public string poiNotFound { get; set; }
            public string poiPlaceholder { get; set; }
            public string poiHelper { get; set; }
            public bool isSelected { get; set; }
            public int selectedOptionValue { get; set; }
            public Selectedplaceid selectedPlaceId { get; set; }
            public Selectedpoitype selectedPoiType { get; set; }
            public string selectedPoiText { get; set; }
            public int selectedPoiLatitude { get; set; }
            public int selectedPoiLongitude { get; set; }
        }

        public class Selectedplaceid
        {
            public string __typename { get; set; }
            public object numValue { get; set; }
            public object stringValue { get; set; }
        }

        public class Selectedpoitype
        {
            public string __typename { get; set; }
            public object destType { get; set; }
            public object source { get; set; }
        }

        public class Trackonview1
        {
            public string __typename { get; set; }
            public int type { get; set; }
            public string experimentHash { get; set; }
            public int value { get; set; }
        }

        public class Option
        {
            public string __typename { get; set; }
            public string parentId { get; set; }
            public string genericId { get; set; }
            public object[] trackOnView { get; set; }
            public object[] trackOnClick { get; set; }
            public Trackonselect[] trackOnSelect { get; set; }
            public object[] trackOnDeSelect { get; set; }
            public object[] trackOnViewPopular { get; set; }
            public object[] trackOnClickPopular { get; set; }
            public object[] trackOnSelectPopular { get; set; }
            public object[] trackOnDeSelectPopular { get; set; }
            public int id { get; set; }
            public int count { get; set; }
            public bool selected { get; set; }
            public string urlId { get; set; }
            public string source { get; set; }
            public string field { get; set; }
            public Additionallabel additionalLabel { get; set; }
            public Value value { get; set; }
            public Starrating starRating { get; set; }
        }

        public class Additionallabel
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag1 translationTag { get; set; }
        }

        public class Translationtag1
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Value
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag2 translationTag { get; set; }
        }

        public class Translationtag2
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Starrating
        {
            public string __typename { get; set; }
            public int value { get; set; }
            public string symbol { get; set; }
            public Caption caption { get; set; }
            public bool showAdditionalInfoIcon { get; set; }
        }

        public class Caption
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Trackonselect
        {
            public string __typename { get; set; }
            public int type { get; set; }
            public string experimentHash { get; set; }
            public int value { get; set; }
        }

        public class Stepperoption
        {
            public string __typename { get; set; }
            public int min { get; set; }
            public int max { get; set; }
            public int _default { get; set; }
            public int selected { get; set; }
            public Title2 title { get; set; }
            public string field { get; set; }
            public Label[] labels { get; set; }
            public object[] trackOnView { get; set; }
            public object[] trackOnClick { get; set; }
            public object[] trackOnSelect { get; set; }
            public object[] trackOnDeSelect { get; set; }
            public object[] trackOnClickDecrease { get; set; }
            public object[] trackOnClickIncrease { get; set; }
            public object[] trackOnDecrease { get; set; }
            public object[] trackOnIncrease { get; set; }
        }

        public class Title2
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag3 translationTag { get; set; }
        }

        public class Translationtag3
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Label
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag4 translationTag { get; set; }
        }

        public class Translationtag4
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Filterstrackonview
        {
            public string __typename { get; set; }
            public int type { get; set; }
            public string experimentHash { get; set; }
            public int value { get; set; }
        }

        public class Recommendedfilteroption
        {
            public string __typename { get; set; }
            public int id { get; set; }
            public int count { get; set; }
            public bool selected { get; set; }
            public string urlId { get; set; }
            public string source { get; set; }
            public string field { get; set; }
            public Additionallabel1 additionalLabel { get; set; }
            public Value1 value { get; set; }
            public Starrating1 starRating { get; set; }
        }

        public class Additionallabel1
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag5 translationTag { get; set; }
        }

        public class Translationtag5
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Value1
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag6 translationTag { get; set; }
        }

        public class Translationtag6
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Starrating1
        {
            public string __typename { get; set; }
            public int value { get; set; }
            public string symbol { get; set; }
            public Caption1 caption { get; set; }
            public bool showAdditionalInfoIcon { get; set; }
        }

        public class Caption1
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Result
        {
            public string __typename { get; set; }
            public bool acceptsWalletCredit { get; set; }
            public Basicpropertydata basicPropertyData { get; set; }
            public object[] badges { get; set; }
            public Custombadges customBadges { get; set; }
            public object description { get; set; }
            public Displayname displayName { get; set; }
            public object geniusInfo { get; set; }
            public Location1 location { get; set; }
            public Mealplanincluded mealPlanIncluded { get; set; }
            public Persuasion persuasion { get; set; }
            public Policies policies { get; set; }
            public object ribbon { get; set; }
            public Recommendeddate recommendedDate { get; set; }
            public bool showGeniusLoginMessage { get; set; }
            public string hostTraderLabel { get; set; }
            public Soldoutinfo soldOutInfo { get; set; }
            public int nbWishlists { get; set; }
            public object[] nonMatchingFlexibleFilterOptions { get; set; }
            public bool? visibilityBoosterEnabled { get; set; }
            public bool showAdLabel { get; set; }
            public bool isNewlyOpened { get; set; }
            public Propertysustainability propertySustainability { get; set; }
            public object[] seoThemes { get; set; }
            public object relocationMode { get; set; }
            public bool bundleRatesAvailable { get; set; }
            public object[] propertyUspBadges { get; set; }
            public Matchingunitconfigurations matchingUnitConfigurations { get; set; }
            public Block[] blocks { get; set; }
            public object[] bookerExperienceContentUIComponentProps { get; set; }
            public object[] topPhotos { get; set; }
            public string generatedPropertyTitle { get; set; }
            public Pricedisplayinfoirene priceDisplayInfoIrene { get; set; }
            public object licenseDetails { get; set; }
            public bool isTpiExclusiveProperty { get; set; }
            public string propertyCribsAvailabilityLabel { get; set; }
            public object mlBookingHomeTags { get; set; }
            public object[] trackOnView { get; set; }
            public string id { get; set; }
        }

        public class Basicpropertydata
        {
            public string __typename { get; set; }
            public int accommodationTypeId { get; set; }
            public int id { get; set; }
            public bool isTestProperty { get; set; }
            public Location location { get; set; }
            public string pageName { get; set; }
            public int ufi { get; set; }
            public Photos photos { get; set; }
            public Reviews reviews { get; set; }
            public Externalreviews externalReviews { get; set; }
            public Starrating2 starRating { get; set; }
            public bool isClosed { get; set; }
            public Paymentconfig paymentConfig { get; set; }
        }

        public class Location
        {
            public string __typename { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string countryCode { get; set; }
        }

        public class Photos
        {
            public string __typename { get; set; }
            public Main main { get; set; }
        }

        public class Main
        {
            public string __typename { get; set; }
            public Highresurl highResUrl { get; set; }
            public Lowresurl lowResUrl { get; set; }
            public Highresjpegurl highResJpegUrl { get; set; }
            public Lowresjpegurl lowResJpegUrl { get; set; }
            public Tag[] tags { get; set; }
        }

        public class Highresurl
        {
            public string __typename { get; set; }
            public string relativeUrl { get; set; }
        }

        public class Lowresurl
        {
            public string __typename { get; set; }
            public string relativeUrl { get; set; }
        }

        public class Highresjpegurl
        {
            public string __typename { get; set; }
            public string relativeUrl { get; set; }
        }

        public class Lowresjpegurl
        {
            public string __typename { get; set; }
            public string relativeUrl { get; set; }
        }

        public class Tag
        {
            public string __ref { get; set; }
        }

        public class Reviews
        {
            public string __typename { get; set; }
            public float totalScore { get; set; }
            public int reviewsCount { get; set; }
            public Totalscoretexttag totalScoreTextTag { get; set; }
            public bool showScore { get; set; }
            public float secondaryScore { get; set; }
            public Secondarytexttag secondaryTextTag { get; set; }
            public bool showSecondaryScore { get; set; }
        }

        public class Totalscoretexttag
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Secondarytexttag
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Externalreviews
        {
            public string __typename { get; set; }
            public float totalScore { get; set; }
            public int reviewsCount { get; set; }
            public bool showScore { get; set; }
            public Totalscoretexttag1 totalScoreTextTag { get; set; }
        }

        public class Totalscoretexttag1
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Starrating2
        {
            public string __typename { get; set; }
            public int value { get; set; }
            public string symbol { get; set; }
            public Caption2 caption { get; set; }
            public Toclink tocLink { get; set; }
            public bool showAdditionalInfoIcon { get; set; }
        }

        public class Caption2
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Toclink
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Paymentconfig
        {
            public string __typename { get; set; }
            public object installments { get; set; }
        }

        public class Custombadges
        {
            public string __typename { get; set; }
            public bool showSkiToDoor { get; set; }
            public bool showBhTravelCreditBadge { get; set; }
            public object showOnlineCheckinBadge { get; set; }
        }

        public class Displayname
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public Translationtag7 translationTag { get; set; }
        }

        public class Translationtag7
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Location1
        {
            public string __typename { get; set; }
            public string displayLocation { get; set; }
            public string mainDistance { get; set; }
            public string mainDistanceDescription { get; set; }
            public string publicTransportDistanceDescription { get; set; }
            public object skiLiftDistance { get; set; }
            public object beachDistance { get; set; }
            public object[] nearbyBeachNames { get; set; }
            public object beachWalkingTime { get; set; }
            public object geoDistanceMeters { get; set; }
            public bool isCentrallyLocated { get; set; }
            public bool isWithinBestLocationScoreArea { get; set; }
            public string popularFreeDistrictName { get; set; }
            public object nearbyUsNaturalParkText { get; set; }
        }

        public class Mealplanincluded
        {
            public string __typename { get; set; }
            public string mealPlanType { get; set; }
            public string text { get; set; }
        }

        public class Persuasion
        {
            public string __typename { get; set; }
            public bool autoextended { get; set; }
            public bool geniusRateAvailable { get; set; }
            public bool highlighted { get; set; }
            public bool preferred { get; set; }
            public bool preferredPlus { get; set; }
            public bool showNativeAdLabel { get; set; }
            public string nativeAdId { get; set; }
            public float? nativeAdsCpc { get; set; }
            public string nativeAdsTracking { get; set; }
            public Sponsoredadsdata sponsoredAdsData { get; set; }
        }

        public class Sponsoredadsdata
        {
            public string __typename { get; set; }
            public bool isDsaCompliant { get; set; }
            public object legalEntityName { get; set; }
            public string designType { get; set; }
        }

        public class Policies
        {
            public string __typename { get; set; }
            public bool showFreeCancellation { get; set; }
            public bool showNoPrepayment { get; set; }
            public bool showPetsAllowedForFree { get; set; }
            public object enableJapaneseUsersSpecialCase { get; set; }
        }

        public class Recommendeddate
        {
            public string __typename { get; set; }
            public string checkin { get; set; }
            public string checkout { get; set; }
            public int lengthOfStay { get; set; }
        }

        public class Soldoutinfo
        {
            public string __typename { get; set; }
            public bool isSoldOut { get; set; }
            public object[] messages { get; set; }
            public object[] alternativeDatesMessages { get; set; }
        }

        public class Propertysustainability
        {
            public string __typename { get; set; }
            public bool isSustainable { get; set; }
            public Certification[] certifications { get; set; }
        }

        public class Certification
        {
            public string __typename { get; set; }
            public string name { get; set; }
        }

        public class Matchingunitconfigurations
        {
            public string __typename { get; set; }
            public Commonconfiguration commonConfiguration { get; set; }
            public Unitconfiguration[] unitConfigurations { get; set; }
        }

        public class Commonconfiguration
        {
            public string __typename { get; set; }
            public object name { get; set; }
            public int unitId { get; set; }
            public Bedconfiguration[] bedConfigurations { get; set; }
            public int nbAllBeds { get; set; }
            public int nbBathrooms { get; set; }
            public int nbBedrooms { get; set; }
            public int nbKitchens { get; set; }
            public int nbLivingrooms { get; set; }
            public int nbUnits { get; set; }
            public Unittypename[] unitTypeNames { get; set; }
            public Localizedarea localizedArea { get; set; }
        }

        public class Localizedarea
        {
            public string __typename { get; set; }
            public string localizedArea { get; set; }
            public string unit { get; set; }
        }

        public class Bedconfiguration
        {
            public string __typename { get; set; }
            public Bed[] beds { get; set; }
            public int nbAllBeds { get; set; }
        }

        public class Bed
        {
            public string __typename { get; set; }
            public int count { get; set; }
            public int type { get; set; }
        }

        public class Unittypename
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Unitconfiguration
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public int unitId { get; set; }
            public Bedconfiguration1[] bedConfigurations { get; set; }
            public Apartmentroom[] apartmentRooms { get; set; }
            public int nbAllBeds { get; set; }
            public int nbBathrooms { get; set; }
            public int nbBedrooms { get; set; }
            public int nbKitchens { get; set; }
            public int nbLivingrooms { get; set; }
            public int nbUnits { get; set; }
            public Unittypename1[] unitTypeNames { get; set; }
            public Localizedarea1 localizedArea { get; set; }
            public int unitTypeId { get; set; }
        }

        public class Localizedarea1
        {
            public string __typename { get; set; }
            public string localizedArea { get; set; }
            public string unit { get; set; }
        }

        public class Bedconfiguration1
        {
            public string __typename { get; set; }
            public Bed1[] beds { get; set; }
            public int nbAllBeds { get; set; }
        }

        public class Bed1
        {
            public string __typename { get; set; }
            public int count { get; set; }
            public int type { get; set; }
        }

        public class Apartmentroom
        {
            public string __typename { get; set; }
            public Config config { get; set; }
            public Tag1 tag { get; set; }
        }

        public class Config
        {
            public string __typename { get; set; }
            public int id { get; set; }
            public string roomType { get; set; }
            public int bedTypeId { get; set; }
            public int count { get; set; }
        }

        public class Tag1
        {
            public string __typename { get; set; }
            public string tag { get; set; }
            public string translation { get; set; }
        }

        public class Unittypename1
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Pricedisplayinfoirene
        {
            public string __typename { get; set; }
            public Badge[] badges { get; set; }
            public Chargesinfo chargesInfo { get; set; }
            public Displayprice displayPrice { get; set; }
            public Averagepricepernight averagePricePerNight { get; set; }
            public Pricebeforediscount priceBeforeDiscount { get; set; }
            public Rewards rewards { get; set; }
            public bool useRoundedAmount { get; set; }
            public Discount[] discounts { get; set; }
            public Excludedcharges excludedCharges { get; set; }
            public object[] taxExceptions { get; set; }
            public Displayconfig[] displayConfig { get; set; }
            public Servertranslation[] serverTranslations { get; set; }
        }

        public class Chargesinfo
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Displayprice
        {
            public string __typename { get; set; }
            public Copy copy { get; set; }
            public Amountperstay amountPerStay { get; set; }
            public object amountPerStayHotelCurr { get; set; }
        }

        public class Copy
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Amountperstay
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Averagepricepernight
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Pricebeforediscount
        {
            public string __typename { get; set; }
            public Copy1 copy { get; set; }
            public Amountperstay1 amountPerStay { get; set; }
        }

        public class Copy1
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Amountperstay1
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Rewards
        {
            public string __typename { get; set; }
            public object[] rewardsList { get; set; }
            public Rewardsaggregated rewardsAggregated { get; set; }
        }

        public class Rewardsaggregated
        {
            public string __typename { get; set; }
            public Amountperstay2 amountPerStay { get; set; }
            public Copy2 copy { get; set; }
        }

        public class Amountperstay2
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public int amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Copy2
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Excludedcharges
        {
            public string __typename { get; set; }
            public Excludechargesaggregated excludeChargesAggregated { get; set; }
            public Excludechargeslist[] excludeChargesList { get; set; }
        }

        public class Excludechargesaggregated
        {
            public string __typename { get; set; }
            public Copy3 copy { get; set; }
            public Amountperstay3 amountPerStay { get; set; }
        }

        public class Copy3
        {
            public string __typename { get; set; }
            public object translation { get; set; }
        }

        public class Amountperstay3
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Excludechargeslist
        {
            public string __typename { get; set; }
            public string chargeMode { get; set; }
            public string chargeInclusion { get; set; }
            public int chargeType { get; set; }
            public Amountperstay4 amountPerStay { get; set; }
        }

        public class Amountperstay4
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Badge
        {
            public string __typename { get; set; }
            public Name1 name { get; set; }
            public Tooltip tooltip { get; set; }
            public string style { get; set; }
            public string identifier { get; set; }
        }

        public class Name1
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Tooltip
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Discount
        {
            public string __typename { get; set; }
            public Amount amount { get; set; }
            public Name2 name { get; set; }
            public Description description { get; set; }
            public string itemType { get; set; }
            public string productId { get; set; }
        }

        public class Amount
        {
            public string __typename { get; set; }
            public string amount { get; set; }
            public string amountRounded { get; set; }
            public float amountUnformatted { get; set; }
            public string currency { get; set; }
        }

        public class Name2
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Description
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Displayconfig
        {
            public string __typename { get; set; }
            public string key { get; set; }
            public bool value { get; set; }
        }

        public class Servertranslation
        {
            public string __typename { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Block
        {
            public string __typename { get; set; }
            public Blockid blockId { get; set; }
            public Finalprice finalPrice { get; set; }
            public Originalprice originalPrice { get; set; }
            public object onlyXLeftMessage { get; set; }
            public object freeCancellationUntil { get; set; }
            public bool hasCrib { get; set; }
            public Blockmatchtags blockMatchTags { get; set; }
            public Thirdpartyinventorycontext thirdPartyInventoryContext { get; set; }
            public Bundle bundle { get; set; }
        }

        public class Blockid
        {
            public string __typename { get; set; }
            public string roomId { get; set; }
            public int occupancy { get; set; }
            public string policyGroupId { get; set; }
            public string packageId { get; set; }
            public int mealPlanId { get; set; }
            public int bundleId { get; set; }
        }

        public class Finalprice
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string currency { get; set; }
        }

        public class Originalprice
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string currency { get; set; }
        }

        public class Blockmatchtags
        {
            public string __typename { get; set; }
            public bool childStaysForFree { get; set; }
            public int?[] freeStayChildrenAges { get; set; }
        }

        public class Thirdpartyinventorycontext
        {
            public string __typename { get; set; }
            public bool isTpiBlock { get; set; }
        }

        public class Bundle
        {
            public string __typename { get; set; }
            public string highlightedText { get; set; }
        }

        public class Sorter
        {
            public string __typename { get; set; }
            public Option1 option { get; set; }
        }

        public class Option1
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public Captiontranslationtag captionTranslationTag { get; set; }
            public Tooltiptranslationtag tooltipTranslationTag { get; set; }
            public bool selected { get; set; }
        }

        public class Captiontranslationtag
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Tooltiptranslationtag
        {
            public string __typename { get; set; }
            public string translation { get; set; }
        }

        public class Previoussearch
        {
            public string __typename { get; set; }
            public object[] childrenAges { get; set; }
        }

        public class Meta
        {
            public int currentPage { get; set; }
            public int limit { get; set; }
            public int totalRecords { get; set; }
            public int totalPage { get; set; }
        }

    }
}
