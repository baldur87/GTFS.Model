﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GTFS.Model
{
    /// <summary>
    /// A route is a group of trips that are displayed to riders as a single service.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// The route_id field contains an ID that uniquely identifies a route. The route_id is dataset unique.
        /// </summary>
        [Required, Key]
        public string route_id { get; set; }
        
        /// <summary>
        /// The agency_id field defines an agency for the specified route. This value is referenced from <see cref="GTFS.Model.Feed.Agency"/>. Use this field when you are providing data for routes from more than one agency.
        /// </summary>
        public string agency_id { get; set; }

        /// <summary>
        /// The route_short_name contains the short name of a route. This will often be a short, abstract identifier like "32", "100X", or "Green" that riders use to identify a route, but which doesn't give any indication of what places the route serves. At least one of route_short_name or route_long_name must be specified, or potentially both if appropriate. If the route does not have a short name, please specify a route_long_name and use an empty string as the value for this field.
        /// </summary>
        [Required]
        public string route_short_name { get; set; }

        /// <summary>
        /// The route_long_name contains the full name of a route. This name is generally more descriptive than the route_short_name and will often include the route's destination or stop. At least one of route_short_name or route_long_name must be specified, or potentially both if appropriate. If the route does not have a long name, please specify a route_short_name and use an empty string as the value for this field.
        /// </summary>
        [Required]
        public string route_long_name { get; set; }

        /// <summary>
        /// The route_desc field contains a description of a route. Please provide useful, quality information. Do not simply duplicate the name of the route. For example, "A trains operate between Inwood-207 St, Manhattan and Far Rockaway-Mott Avenue, Queens at all times. Also from about 6AM until about midnight, additional A trains operate between Inwood-207 St and Lefferts Boulevard (trains typically alternate between Lefferts Blvd and Far Rockaway)."
        /// </summary>
        public string route_desc { get; set; }

        /// <summary>
        /// The route_type field describes the type of transportation used on a route. Valid values for this field are:
        /// <list type="bullet">
        /// <item><term>0 </term><description>Tram, Streetcar, Light rail. Any light rail or street level system within a metropolitan area.</description></item>
        /// <item><term>1 </term><description>Subway, Metro. Any underground rail system within a metropolitan area.</description></item>
        /// <item><term>2 </term><description>Rail. Used for intercity or long-distance travel.</description></item>
        /// <item><term>3 </term><description>Bus. Used for short- and long-distance bus routes.</description></item>
        /// <item><term>4 </term><description>Ferry. Used for short- and long-distance boat service.</description></item>
        /// <item><term>5 </term><description>Cable car. Used for street-level cable cars where the cable runs beneath the car.</description></item>
        /// <item><term>6 </term><description>Gondola, Suspended cable car. Typically used for aerial cable cars where the car is suspended from the cable.</description></item>
        /// <item><term>7 </term><description>Funicular. Any rail system designed for steep inclines.</description></item>
        /// </list>
        /// </summary>
        public string route_type { get; set; }

        /// <summary>
        /// The route_url field contains the URL of a web page about that particular route. This should be different from the agency_url.
        /// </summary>
        [Url]
        public Uri route_url { get; set; }

        /// <summary>
        /// In systems that have colors assigned to routes, the route_color field defines a color that corresponds to a route. The color must be provided as a six-character hexadecimal number, for example, 00FFFF. If no color is specified, the default route color is white (FFFFFF).
        /// </summary>
        [RegularExpression(@"[a-fA-F0-9]{6}"), StringLength(6)]
        public string route_color { get; set; }

        /// <summary>
        /// The route_text_color field can be used to specify a legible color to use for text drawn against a background of route_color. The color must be provided as a six-character hexadecimal number, for example, FFD700. If no color is specified, the default text color is black (000000).
        /// </summary>
        [RegularExpression(@"[a-fA-F0-9]{6}"), StringLength(6)]
        public string route_text_color { get; set; }
    }
}
