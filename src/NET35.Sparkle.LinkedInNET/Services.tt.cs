﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// XML document found at '\src\NET35.Sparkle.LinkedInNET\..\LinkedInApi.xml'
// return types: '0'
// API groups: '1'

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'person'
    /// </summary>
    [Serializable, XmlRoot("person")]
    public class Person
    {
        /// <summary>
        /// Field: 'first-name' (default)
        /// </summary>
        [XmlElement(ElementName = "first-name")]
        public string Firstname { get; set; }

        /// <summary>
        /// Field: 'last-name' (default)
        /// </summary>
        [XmlElement(ElementName = "last-name")]
        public string Lastname { get; set; }

        /// <summary>
        /// Field: 'headline' (default)
        /// Field: 'headline' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Field: 'site-standard-profile-request/url' (default)
        /// </summary>
        [XmlElement(ElementName = "site-standard-profile-request/url")]
        public string SiteStandardProfileRequestUrl { get; set; }

        /// <summary>
        /// Field: 'id' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Field: 'maiden-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "maiden-name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Field: 'formatted-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "formatted-name")]
        public string FormattedName { get; set; }

        /// <summary>
        /// Field: 'phonetic-first-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "phonetic-first-name")]
        public string PhoneticFirstName { get; set; }

        /// <summary>
        /// Field: 'phonetic-last-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "phonetic-last-name")]
        public string PhoneticLastName { get; set; }

        /// <summary>
        /// Field: 'formatted-phonetic-name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "formatted-phonetic-name")]
        public string FormattedPhoneticName { get; set; }

        /// <summary>
        /// Field: 'location:(name)' (on-demand)
        /// Field: 'location:(country:(code))' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Field: 'industry' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "industry")]
        public string Industry { get; set; }

        /// <summary>
        /// Field: 'distance' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "distance")]
        public string Distance { get; set; }

        /// <summary>
        /// Field: 'relation-to-viewer:(distance)' (on-demand)
        /// Field: 'relation-to-viewer:(related-connections)' (on-demand)
        /// Field: 'relation-to-viewer:(connections)' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "relation-to-viewer")]
        public RelationToViewer RelationToViewer { get; set; }

        /// <summary>
        /// Field: 'current-status' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// Field: 'current-status-timestamp' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-status-timestamp")]
        public string CurrentStatusTimestamp { get; set; }

        /// <summary>
        /// Field: 'current-share' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "current-share")]
        public string CurrentShare { get; set; }

        /// <summary>
        /// Field: 'num-connections' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "num-connections")]
        public string NumConnections { get; set; }

        /// <summary>
        /// Field: 'num-connections-capped' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "num-connections-capped")]
        public string NumConnectionsCapped { get; set; }

        /// <summary>
        /// Field: 'summary' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Field: 'specialties' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "specialties")]
        public string Specialties { get; set; }

        /// <summary>
        /// Field: 'positions' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "positions")]
        public string Positions { get; set; }

        /// <summary>
        /// Field: 'picture-url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "picture-url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Field: 'site-standard-profile-request' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "site-standard-profile-request")]
        public string SiteStandardProfileRequest { get; set; }

        /// <summary>
        /// Field: 'api-standard-profile-request:(url)' (on-demand)
        /// Field: 'api-standard-profile-request:(headers)' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "api-standard-profile-request")]
        public ApiStandardProfileRequest ApiStandardProfileRequest { get; set; }

        /// <summary>
        /// Field: 'public-profile-url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "public-profile-url")]
        public string PublicProfileUrl { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'location'
    /// </summary>
    [Serializable, XmlRoot("location")]
    public class Location
    {
        /// <summary>
        /// Field: 'name' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'relation-to-viewer'
    /// </summary>
    [Serializable, XmlRoot("relation-to-viewer")]
    public class RelationToViewer
    {
        /// <summary>
        /// Field: 'distance' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "distance")]
        public string Distance { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Name: 'api-standard-profile-request'
    /// </summary>
    [Serializable, XmlRoot("api-standard-profile-request")]
    public class ApiStandardProfileRequest
    {
        /// <summary>
        /// Field: 'url' (on-demand)
        /// </summary>
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

    }
}

namespace Sparkle.LinkedInNET.Profiles
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;

    /// <summary>
    /// Name: 'Profiles'
    /// </summary>
    public class ProfilesApi : BaseApi
    {
        public ProfilesApi(LinkedInApi linkedInApi)
            : base(linkedInApi)
        {
        }
        
        /// <summary>
        /// the profile of the current user
        /// </summary>
        public Person GetMyProfile(
              UserAuthorization user
        )
        {
            var url = "/v1/people/~";

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            this.ExecuteQuery(context);

            
            ////var response = new System.IO.StreamReader(context.ResponseStream).ReadToEnd();
            var serializer = new XmlSerializer(typeof(Person));
            var result = (Person)serializer.Deserialize(context.ResponseStream);
            return result;
        }
        
        /// <summary>
        /// the profile of a user in the network
        /// </summary>
        public Person GetProfileById(
              UserAuthorization user
            , string memberToken
        )
        {
            const string urlFormat = "/v1/people/id={MemberToken}";
            var url = FormatUrl(urlFormat, "MemberToken", memberToken);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            this.ExecuteQuery(context);

            
            ////var response = new System.IO.StreamReader(context.ResponseStream).ReadToEnd();
            var serializer = new XmlSerializer(typeof(Person));
            var result = (Person)serializer.Deserialize(context.ResponseStream);
            return result;
        }
        
        /// <summary>
        /// the public profile of a user
        /// </summary>
        public Person GetPublicprofile(
              UserAuthorization user
            , string publicProfileUrl
        )
        {
            const string urlFormat = "/v1/people/url={PublicProfileUrl}";
            var url = FormatUrl(urlFormat, "PublicProfileUrl", publicProfileUrl);

            var context = new RequestContext();
            context.UserAuthorization = user;
            context.Method =  "GET";
            context.UrlPath = this.LinkedInApi.Configuration.BaseApiUrl + url;

            this.ExecuteQuery(context);

            
            ////var response = new System.IO.StreamReader(context.ResponseStream).ReadToEnd();
            var serializer = new XmlSerializer(typeof(Person));
            var result = (Person)serializer.Deserialize(context.ResponseStream);
            return result;
        }
        
    }
}

namespace Sparkle.LinkedInNET
{
    using System;
    using System.Xml.Serialization;
    using Sparkle.LinkedInNET.Internals;
    using Sparkle.LinkedInNET.Profiles;

    /// <summary>
    /// </summary>
    public partial class LinkedInApi : BaseApi
    {
        public ProfilesApi Profiles{
            get { return new ProfilesApi(this); }
        }

    }
}


