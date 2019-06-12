// ==============================================================================
//
//  This file is part of the Campusoft Loja Cia. Ltda. code samples.
//
//  Copyright (C) Campusoft Loja Cia. Ltda.  All rights reserved.
//
//  This source code is intended only as a supplement to Campusoft
//  Development Team.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// This file was auto-generated from http://json2csharp.com/ with QuickType option
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ConsoleAppBannerTest;
//    var welcome = Welcome.FromJson(jsonString);
// 
// ===============================================================================



namespace ConsoleAppBannerTest
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PersonFromJson
    {
        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("citizenshipCountry")]
        public object CitizenshipCountry { get; set; }

        [JsonProperty("citizenshipStatus")]
        public CitizenshipStatus CitizenshipStatus { get; set; }

        [JsonProperty("countryOfBirth")]
        public object CountryOfBirth { get; set; }

        [JsonProperty("credentials")]
        public List<Credential> Credentials { get; set; }

        [JsonProperty("dateDeceased")]
        public object DateDeceased { get; set; }

        [JsonProperty("dateOfBirth")]
        public DateTimeOffset? DateOfBirth { get; set; }

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; }

        [JsonProperty("ethnicity")]
        public object Ethnicity { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("identityDocuments")]
        public object IdentityDocuments { get; set; }

        [JsonProperty("interests")]
        public object Interests { get; set; }

        [JsonProperty("languages")]
        public object Languages { get; set; }

        [JsonProperty("maritalStatus")]
        public MaritalStatus MaritalStatus { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("phones")]
        public List<Phone> Phones { get; set; }

        [JsonProperty("privacyStatus")]
        public PrivacyStatus PrivacyStatus { get; set; }

        [JsonProperty("races")]
        public object Races { get; set; }

        [JsonProperty("religion")]
        public object Religion { get; set; }

        [JsonProperty("roles")]
        public List<RoleElement> Roles { get; set; }

        [JsonProperty("veteranStatus")]
        public object VeteranStatus { get; set; }

        [JsonProperty("legadoidext", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Legadoidext { get; set; }

        [JsonProperty("rucext", NullValueHandling = NullValueHandling.Ignore)]
        public string Rucext { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("address")]
        public Detail AddressAddress { get; set; }

        [JsonProperty("endOn")]
        public object EndOn { get; set; }

        [JsonProperty("startOn")]
        public object StartOn { get; set; }

        [JsonProperty("type")]
        public AddressType Type { get; set; }
    }

    public partial class Detail
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }

    public partial class AddressType
    {
        [JsonProperty("addressType")]
        public AddressTypeEnum TypeAddressType { get; set; }

        [JsonProperty("detail")]
        public Detail Detail { get; set; }
    }

    public partial class CitizenshipStatus
    {
        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("detail")]
        public Detail Detail { get; set; }
    }

    public partial class Credential
    {
        [JsonProperty("endOn")]
        public object EndOn { get; set; }

        [JsonProperty("startOn")]
        public object StartOn { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("preference")]
        public Preference? Preference { get; set; }

        [JsonProperty("type")]
        public EmailType Type { get; set; }
    }

    public partial class EmailType
    {
        [JsonProperty("detail")]
        public Detail Detail { get; set; }

        [JsonProperty("emailType")]
        public EmailTypeEnum TypeEmailType { get; set; }
    }

    public partial class MaritalStatus
    {
        [JsonProperty("detail")]
        public Detail Detail { get; set; }

        [JsonProperty("maritalCategory")]
        public MaritalCategory MaritalCategory { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public object LastNamePrefix { get; set; }

        [JsonProperty("middleName")]
        public object MiddleName { get; set; }

        [JsonProperty("pedigree")]
        public object Pedigree { get; set; }

        [JsonProperty("preference")]
        public object Preference { get; set; }

        [JsonProperty("professionalAbbreviations")]
        public List<object> ProfessionalAbbreviations { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("type")]
        public CitizenshipStatus Type { get; set; }
    }

    public partial class Phone
    {
        [JsonProperty("countryCallingCode")]
        public object CountryCallingCode { get; set; }

        [JsonProperty("extension")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Extension { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("preference")]
        public object Preference { get; set; }

        [JsonProperty("type")]
        public PhoneType Type { get; set; }
    }

    public partial class PhoneType
    {
        [JsonProperty("detail")]
        public Detail Detail { get; set; }

        [JsonProperty("phoneType")]
        public PhoneTypeEnum TypePhoneType { get; set; }
    }

    public partial class PrivacyStatus
    {
        [JsonProperty("privacyCategory")]
        public PrivacyCategory PrivacyCategory { get; set; }
    }

    public partial class RoleElement
    {
        [JsonProperty("endOn")]
        public DateTimeOffset EndOn { get; set; }

        [JsonProperty("role")]
        public RoleEnum Role { get; set; }

        [JsonProperty("startOn")]
        public DateTimeOffset StartOn { get; set; }
    }

    public enum AddressTypeEnum { Branch, Home, Shipping, Support };

    public enum Category { Citizen, Legal };

    public enum TypeEnum { BannerId, BannerSourcedId, BannerUdcId, BannerUserName, TaxIdentificationNumber };

    public enum Preference { Primary };

    public enum EmailTypeEnum { Personal, School };

    public enum Gender { Female, Male, Unknown };

    public enum MaritalCategory { Divorced, Married, Separated, Single };

    public enum PhoneTypeEnum { Family, Mobile };

    public enum PrivacyCategory { Unrestricted };

    public enum RoleEnum { Advisor, Instructor, Student };

    public partial class Welcome
    {
        public static List<Welcome> FromJson(string json) => JsonConvert.DeserializeObject<List<Welcome>>(json, ConsoleAppBannerTest.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Welcome> self) => JsonConvert.SerializeObject(self, ConsoleAppBannerTest.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AddressTypeEnumConverter.Singleton,
                CategoryConverter.Singleton,
                TypeEnumConverter.Singleton,
                PreferenceConverter.Singleton,
                EmailTypeEnumConverter.Singleton,
                GenderConverter.Singleton,
                MaritalCategoryConverter.Singleton,
                PhoneTypeEnumConverter.Singleton,
                PrivacyCategoryConverter.Singleton,
                RoleEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AddressTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressTypeEnum) || t == typeof(AddressTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "branch":
                    return AddressTypeEnum.Branch;
                case "home":
                    return AddressTypeEnum.Home;
                case "shipping":
                    return AddressTypeEnum.Shipping;
                case "support":
                    return AddressTypeEnum.Support;
            }
            throw new Exception("Cannot unmarshal type AddressTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressTypeEnum)untypedValue;
            switch (value)
            {
                case AddressTypeEnum.Branch:
                    serializer.Serialize(writer, "branch");
                    return;
                case AddressTypeEnum.Home:
                    serializer.Serialize(writer, "home");
                    return;
                case AddressTypeEnum.Shipping:
                    serializer.Serialize(writer, "shipping");
                    return;
                case AddressTypeEnum.Support:
                    serializer.Serialize(writer, "support");
                    return;
            }
            throw new Exception("Cannot marshal type AddressTypeEnum");
        }

        public static readonly AddressTypeEnumConverter Singleton = new AddressTypeEnumConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "citizen":
                    return Category.Citizen;
                case "legal":
                    return Category.Legal;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.Citizen:
                    serializer.Serialize(writer, "citizen");
                    return;
                case Category.Legal:
                    serializer.Serialize(writer, "legal");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bannerId":
                    return TypeEnum.BannerId;
                case "bannerSourcedId":
                    return TypeEnum.BannerSourcedId;
                case "bannerUdcId":
                    return TypeEnum.BannerUdcId;
                case "bannerUserName":
                    return TypeEnum.BannerUserName;
                case "taxIdentificationNumber":
                    return TypeEnum.TaxIdentificationNumber;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.BannerId:
                    serializer.Serialize(writer, "bannerId");
                    return;
                case TypeEnum.BannerSourcedId:
                    serializer.Serialize(writer, "bannerSourcedId");
                    return;
                case TypeEnum.BannerUdcId:
                    serializer.Serialize(writer, "bannerUdcId");
                    return;
                case TypeEnum.BannerUserName:
                    serializer.Serialize(writer, "bannerUserName");
                    return;
                case TypeEnum.TaxIdentificationNumber:
                    serializer.Serialize(writer, "taxIdentificationNumber");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class PreferenceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Preference) || t == typeof(Preference?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "primary")
            {
                return Preference.Primary;
            }
            throw new Exception("Cannot unmarshal type Preference");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Preference)untypedValue;
            if (value == Preference.Primary)
            {
                serializer.Serialize(writer, "primary");
                return;
            }
            throw new Exception("Cannot marshal type Preference");
        }

        public static readonly PreferenceConverter Singleton = new PreferenceConverter();
    }

    internal class EmailTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmailTypeEnum) || t == typeof(EmailTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "personal":
                    return EmailTypeEnum.Personal;
                case "school":
                    return EmailTypeEnum.School;
            }
            throw new Exception("Cannot unmarshal type EmailTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EmailTypeEnum)untypedValue;
            switch (value)
            {
                case EmailTypeEnum.Personal:
                    serializer.Serialize(writer, "personal");
                    return;
                case EmailTypeEnum.School:
                    serializer.Serialize(writer, "school");
                    return;
            }
            throw new Exception("Cannot marshal type EmailTypeEnum");
        }

        public static readonly EmailTypeEnumConverter Singleton = new EmailTypeEnumConverter();
    }

    internal class GenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gender) || t == typeof(Gender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return Gender.Female;
                case "male":
                    return Gender.Male;
                case "unknown":
                    return Gender.Unknown;
            }
            throw new Exception("Cannot unmarshal type Gender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gender)untypedValue;
            switch (value)
            {
                case Gender.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case Gender.Male:
                    serializer.Serialize(writer, "male");
                    return;
                case Gender.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type Gender");
        }

        public static readonly GenderConverter Singleton = new GenderConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class MaritalCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MaritalCategory) || t == typeof(MaritalCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "divorced":
                    return MaritalCategory.Divorced;
                case "married":
                    return MaritalCategory.Married;
                case "separated":
                    return MaritalCategory.Separated;
                case "single":
                    return MaritalCategory.Single;
            }
            throw new Exception("Cannot unmarshal type MaritalCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MaritalCategory)untypedValue;
            switch (value)
            {
                case MaritalCategory.Divorced:
                    serializer.Serialize(writer, "divorced");
                    return;
                case MaritalCategory.Married:
                    serializer.Serialize(writer, "married");
                    return;
                case MaritalCategory.Separated:
                    serializer.Serialize(writer, "separated");
                    return;
                case MaritalCategory.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }
            throw new Exception("Cannot marshal type MaritalCategory");
        }

        public static readonly MaritalCategoryConverter Singleton = new MaritalCategoryConverter();
    }

    internal class PhoneTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PhoneTypeEnum) || t == typeof(PhoneTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "family":
                    return PhoneTypeEnum.Family;
                case "mobile":
                    return PhoneTypeEnum.Mobile;
            }
            throw new Exception("Cannot unmarshal type PhoneTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PhoneTypeEnum)untypedValue;
            switch (value)
            {
                case PhoneTypeEnum.Family:
                    serializer.Serialize(writer, "family");
                    return;
                case PhoneTypeEnum.Mobile:
                    serializer.Serialize(writer, "mobile");
                    return;
            }
            throw new Exception("Cannot marshal type PhoneTypeEnum");
        }

        public static readonly PhoneTypeEnumConverter Singleton = new PhoneTypeEnumConverter();
    }

    internal class PrivacyCategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PrivacyCategory) || t == typeof(PrivacyCategory?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "unrestricted")
            {
                return PrivacyCategory.Unrestricted;
            }
            throw new Exception("Cannot unmarshal type PrivacyCategory");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PrivacyCategory)untypedValue;
            if (value == PrivacyCategory.Unrestricted)
            {
                serializer.Serialize(writer, "unrestricted");
                return;
            }
            throw new Exception("Cannot marshal type PrivacyCategory");
        }

        public static readonly PrivacyCategoryConverter Singleton = new PrivacyCategoryConverter();
    }

    internal class RoleEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RoleEnum) || t == typeof(RoleEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "advisor":
                    return RoleEnum.Advisor;
                case "instructor":
                    return RoleEnum.Instructor;
                case "student":
                    return RoleEnum.Student;
            }
            throw new Exception("Cannot unmarshal type RoleEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RoleEnum)untypedValue;
            switch (value)
            {
                case RoleEnum.Advisor:
                    serializer.Serialize(writer, "advisor");
                    return;
                case RoleEnum.Instructor:
                    serializer.Serialize(writer, "instructor");
                    return;
                case RoleEnum.Student:
                    serializer.Serialize(writer, "student");
                    return;
            }
            throw new Exception("Cannot marshal type RoleEnum");
        }

        public static readonly RoleEnumConverter Singleton = new RoleEnumConverter();
    }
}
