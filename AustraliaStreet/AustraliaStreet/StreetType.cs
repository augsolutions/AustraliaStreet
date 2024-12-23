﻿using System.Collections.Generic;
using static AustraliaStreet.Constants;

namespace AustraliaStreet
{
    public class StreetType : Enumeration
    {
        public static StreetType Alley = new StreetType(1, "ALLY", StreetTypeNormalizedName.Alley);
        public static StreetType Alleyway = new StreetType(2, "ALWY", StreetTypeNormalizedName.Alleyway);
        public static StreetType Amble = new StreetType(3, "AMBL", StreetTypeNormalizedName.Amble);
        public static StreetType Anchorage = new StreetType(4, "ANCG", StreetTypeNormalizedName.Anchorage);
        public static StreetType Approach = new StreetType(5, "APP", StreetTypeNormalizedName.Approach);
        public static StreetType Arcade = new StreetType(6, "ARC", StreetTypeNormalizedName.Arcade);
        public static StreetType Artery = new StreetType(7, "ART", StreetTypeNormalizedName.Artery);
        public static StreetType Avenue = new StreetType(8, "AVE", StreetTypeNormalizedName.Avenue);
        public static StreetType Basin = new StreetType(9, "BASN", StreetTypeNormalizedName.Basin);
        public static StreetType Beach = new StreetType(10, "BCH", StreetTypeNormalizedName.Beach);
        public static StreetType Bend = new StreetType(11, "BEND", StreetTypeNormalizedName.Bend);
        public static StreetType Block = new StreetType(12, "BLK", StreetTypeNormalizedName.Block);
        public static StreetType Boulevard = new StreetType(13, "BVD", StreetTypeNormalizedName.Boulevard);
        public static StreetType Brace = new StreetType(14, "BRCE", StreetTypeNormalizedName.Brace);
        public static StreetType Brae = new StreetType(15, "BRAE", StreetTypeNormalizedName.Brae);
        public static StreetType Break = new StreetType(16, "BRK", StreetTypeNormalizedName.Break);
        public static StreetType Bridge = new StreetType(17, "BDGE", StreetTypeNormalizedName.Bridge);
        public static StreetType Broadway = new StreetType(18, "BDWY", StreetTypeNormalizedName.Broadway);
        public static StreetType Brow = new StreetType(19, "BROW", StreetTypeNormalizedName.Brow);
        public static StreetType Bypass = new StreetType(20, "BYPA", StreetTypeNormalizedName.Bypass);
        public static StreetType Byway = new StreetType(21, "BYWY", StreetTypeNormalizedName.Byway);
        public static StreetType Causeway = new StreetType(22, "CAUS", StreetTypeNormalizedName.Causeway);
        public static StreetType Centre = new StreetType(23, "CTR", StreetTypeNormalizedName.Centre);
        public static StreetType Centreway = new StreetType(24, "CNWY", StreetTypeNormalizedName.Centreway);
        public static StreetType Chase = new StreetType(25, "CH", StreetTypeNormalizedName.Chase);
        public static StreetType Circle = new StreetType(26, "CIR", StreetTypeNormalizedName.Circle);
        public static StreetType Circlet = new StreetType(27, "CLT", StreetTypeNormalizedName.Circlet);
        public static StreetType Circuit = new StreetType(28, "CCT", StreetTypeNormalizedName.Circuit);
        public static StreetType Circus = new StreetType(29, "CRCS", StreetTypeNormalizedName.Circus);
        public static StreetType Close = new StreetType(30, "CL", StreetTypeNormalizedName.Close);
        public static StreetType Colonnade = new StreetType(31, "CLDE", StreetTypeNormalizedName.Colonnade);
        public static StreetType Common = new StreetType(32, "CMMN", StreetTypeNormalizedName.Common);
        public static StreetType Concourse = new StreetType(33, "CON", StreetTypeNormalizedName.Concourse);
        public static StreetType Copse = new StreetType(34, "CPS", StreetTypeNormalizedName.Copse);
        public static StreetType Corner = new StreetType(35, "CNR", StreetTypeNormalizedName.Corner);
        public static StreetType Corso = new StreetType(36, "CSO", StreetTypeNormalizedName.Corso);
        public static StreetType Court = new StreetType(37, "CT", StreetTypeNormalizedName.Court);
        public static StreetType Courtyard = new StreetType(38, "CTYD", StreetTypeNormalizedName.Courtyard);
        public static StreetType Cove = new StreetType(39, "COVE", StreetTypeNormalizedName.Cove);
        public static StreetType Crescent = new StreetType(40, "CRES", StreetTypeNormalizedName.Crescent);
        public static StreetType Crest = new StreetType(41, "CRST", StreetTypeNormalizedName.Crest);
        public static StreetType Cross = new StreetType(42, "CRSS", StreetTypeNormalizedName.Cross);
        public static StreetType Crossing = new StreetType(43, "CRSG", StreetTypeNormalizedName.Crossing);
        public static StreetType Crossroad = new StreetType(44, "CRD", StreetTypeNormalizedName.Crossroad);
        public static StreetType Crossway = new StreetType(45, "COWY", StreetTypeNormalizedName.Crossway);
        public static StreetType Cruiseway = new StreetType(46, "CUWY", StreetTypeNormalizedName.Cruiseway);
        public static StreetType CulDeSac = new StreetType(47, "CDS", StreetTypeNormalizedName.CulDeSac);
        public static StreetType Cutting = new StreetType(48, "CTTG", StreetTypeNormalizedName.Cutting);
        public static StreetType Dale = new StreetType(49, "DALE", StreetTypeNormalizedName.Dale);
        public static StreetType Dell = new StreetType(50, "DELL", StreetTypeNormalizedName.Dell);
        public static StreetType Deviation = new StreetType(51, "DEVN", StreetTypeNormalizedName.Deviation);
        public static StreetType Dip = new StreetType(52, "DIP", StreetTypeNormalizedName.Dip);
        public static StreetType Distributor = new StreetType(53, "DSTR", StreetTypeNormalizedName.Distributor);
        public static StreetType Drive = new StreetType(54, "DR", StreetTypeNormalizedName.Drive);
        public static StreetType Driveway = new StreetType(55, "DRWY", StreetTypeNormalizedName.Driveway);
        public static StreetType Edge = new StreetType(56, "EDGE", StreetTypeNormalizedName.Edge);
        public static StreetType Elbow = new StreetType(57, "ELB", StreetTypeNormalizedName.Elbow);
        public static StreetType End = new StreetType(58, "END", StreetTypeNormalizedName.End);
        public static StreetType Entrance = new StreetType(59, "ENT", StreetTypeNormalizedName.Entrance);
        public static StreetType Esplanade = new StreetType(60, "ESP", StreetTypeNormalizedName.Esplanade);
        public static StreetType Firetrail = new StreetType(65, "FITR", StreetTypeNormalizedName.Firetrail);
        public static StreetType Flat = new StreetType(66, "FLAT", StreetTypeNormalizedName.Flat);
        public static StreetType Follow = new StreetType(67, "FOLW", StreetTypeNormalizedName.Follow);
        public static StreetType Footway = new StreetType(68, "FTWY", StreetTypeNormalizedName.Footway);
        public static StreetType Foreshore = new StreetType(69, "FSHR", StreetTypeNormalizedName.Foreshore);
        public static StreetType Formation = new StreetType(70, "FORM", StreetTypeNormalizedName.Formation);
        public static StreetType Freeway = new StreetType(71, "FWY", StreetTypeNormalizedName.Freeway);
        public static StreetType Front = new StreetType(72, "FRNT", StreetTypeNormalizedName.Front);
        public static StreetType Frontage = new StreetType(73, "FRTG", StreetTypeNormalizedName.Frontage);
        public static StreetType Gap = new StreetType(74, "GAP", StreetTypeNormalizedName.Gap);
        public static StreetType Garden = new StreetType(75, "GDN", StreetTypeNormalizedName.Garden);
        public static StreetType Gate = new StreetType(76, "GTE", StreetTypeNormalizedName.Gate);
        public static StreetType Gardens = new StreetType(77, "GDNS", StreetTypeNormalizedName.Gardens);
        public static StreetType Gates = new StreetType(78, "GTES", StreetTypeNormalizedName.Gates);
        public static StreetType Glade = new StreetType(79, "GLD", StreetTypeNormalizedName.Glade);
        public static StreetType Glen = new StreetType(80, "GLEN", StreetTypeNormalizedName.Glen);
        public static StreetType Grange = new StreetType(81, "GRA", StreetTypeNormalizedName.Grange);
        public static StreetType Green = new StreetType(82, "GRN", StreetTypeNormalizedName.Green);
        public static StreetType Ground = new StreetType(83, "GRND", StreetTypeNormalizedName.Ground);
        public static StreetType Grove = new StreetType(84, "GR", StreetTypeNormalizedName.Grove);
        public static StreetType Gully = new StreetType(85, "GLY", StreetTypeNormalizedName.Gully);
        public static StreetType Heights = new StreetType(86, "HTS", StreetTypeNormalizedName.Heights);
        public static StreetType Highroad = new StreetType(87, "HRD", StreetTypeNormalizedName.Highroad);
        public static StreetType Highway = new StreetType(88, "HWY", StreetTypeNormalizedName.Highway);
        public static StreetType Hill = new StreetType(89, "HILL", StreetTypeNormalizedName.Hill);
        public static StreetType Interchange = new StreetType(90, "INTG", StreetTypeNormalizedName.Interchange);
        public static StreetType Intersection = new StreetType(91, "INTN", StreetTypeNormalizedName.Intersection);
        public static StreetType Junction = new StreetType(92, "JNC", StreetTypeNormalizedName.Junction);
        public static StreetType Key = new StreetType(93, "KEY", StreetTypeNormalizedName.Key);
        public static StreetType Landing = new StreetType(94, "LDG", StreetTypeNormalizedName.Landing);
        public static StreetType Lane = new StreetType(95, "LANE", StreetTypeNormalizedName.Lane);
        public static StreetType Laneway = new StreetType(96, "LNWY", StreetTypeNormalizedName.Laneway);
        public static StreetType Lees = new StreetType(97, "LEES", StreetTypeNormalizedName.Lees);
        public static StreetType Line = new StreetType(98, "LINE", StreetTypeNormalizedName.Line);
        public static StreetType Link = new StreetType(99, "LINK", StreetTypeNormalizedName.Link);
        public static StreetType Little = new StreetType(100, "LT", StreetTypeNormalizedName.Little);
        public static StreetType Lookout = new StreetType(101, "LKT", StreetTypeNormalizedName.Lookout);
        public static StreetType Loop = new StreetType(102, "LOOP", StreetTypeNormalizedName.Loop);
        public static StreetType Lower = new StreetType(103, "LWR", StreetTypeNormalizedName.Lower);
        public static StreetType Mall = new StreetType(104, "MALL", StreetTypeNormalizedName.Mall);
        public static StreetType Meander = new StreetType(105, "MNDR", StreetTypeNormalizedName.Meander);
        public static StreetType Mew = new StreetType(106, "MEW", StreetTypeNormalizedName.Mew);
        public static StreetType Mews = new StreetType(107, "MEWS", StreetTypeNormalizedName.Mews);
        public static StreetType Motorway = new StreetType(108, "MWY", StreetTypeNormalizedName.Motorway);
        public static StreetType Mount = new StreetType(109, "MT", StreetTypeNormalizedName.Mount);
        public static StreetType Nook = new StreetType(110, "NOOK", StreetTypeNormalizedName.Nook);
        public static StreetType Outlook = new StreetType(111, "OTLK", StreetTypeNormalizedName.Outlook);
        public static StreetType Parade = new StreetType(112, "PDE", StreetTypeNormalizedName.Parade);
        public static StreetType Park = new StreetType(113, "PARK", StreetTypeNormalizedName.Park);
        public static StreetType Parklands = new StreetType(114, "PKLD", StreetTypeNormalizedName.Parklands);
        public static StreetType Parkway = new StreetType(115, "PKWY", StreetTypeNormalizedName.Parkway);
        public static StreetType Part = new StreetType(116, "PART", StreetTypeNormalizedName.Part);
        public static StreetType Pass = new StreetType(117, "PASS", StreetTypeNormalizedName.Pass);
        public static StreetType Path = new StreetType(118, "PATH", StreetTypeNormalizedName.Path);
        public static StreetType Pathway = new StreetType(119, "PHWY", StreetTypeNormalizedName.Pathway);
        public static StreetType Piazza = new StreetType(120, "PIAZ", StreetTypeNormalizedName.Piazza);
        public static StreetType Place = new StreetType(121, "PL", StreetTypeNormalizedName.Place);
        public static StreetType Plateau = new StreetType(122, "PLAT", StreetTypeNormalizedName.Plateau);
        public static StreetType Plaza = new StreetType(123, "PLZA", StreetTypeNormalizedName.Plaza);
        public static StreetType Pocket = new StreetType(124, "PKT", StreetTypeNormalizedName.Pocket);
        public static StreetType Point = new StreetType(125, "PNT", StreetTypeNormalizedName.Point);
        public static StreetType Port = new StreetType(126, "PORT", StreetTypeNormalizedName.Port);
        public static StreetType Promenade = new StreetType(127, "PROM", StreetTypeNormalizedName.Promenade);
        public static StreetType Quad = new StreetType(128, "QUAD", StreetTypeNormalizedName.Quad);
        public static StreetType Quadrangle = new StreetType(129, "QDGL", StreetTypeNormalizedName.Quadrangle);
        public static StreetType Quadrant = new StreetType(130, "QDRT", StreetTypeNormalizedName.Quadrant);
        public static StreetType Quay = new StreetType(131, "QY", StreetTypeNormalizedName.Quay);
        public static StreetType Quays = new StreetType(132, "QYS", StreetTypeNormalizedName.Quays);
        public static StreetType Ramble = new StreetType(133, "RMBL", StreetTypeNormalizedName.Ramble);
        public static StreetType Ramp = new StreetType(134, "RAMP", StreetTypeNormalizedName.Ramp);
        public static StreetType Range = new StreetType(135, "RNGE", StreetTypeNormalizedName.Range);
        public static StreetType Reach = new StreetType(136, "RCH", StreetTypeNormalizedName.Reach);
        public static StreetType Reserve = new StreetType(137, "RES", StreetTypeNormalizedName.Reserve);
        public static StreetType Rest = new StreetType(138, "REST", StreetTypeNormalizedName.Rest);
        public static StreetType Retreat = new StreetType(139, "RTT", StreetTypeNormalizedName.Retreat);
        public static StreetType Ride = new StreetType(140, "RIDE", StreetTypeNormalizedName.Ride);
        public static StreetType Ridge = new StreetType(141, "RDGE", StreetTypeNormalizedName.Ridge);
        public static StreetType Ridgeway = new StreetType(142, "RGWY", StreetTypeNormalizedName.Ridgeway);
        public static StreetType Right = new StreetType(143, "ROWY", StreetTypeNormalizedName.Right);
        public static StreetType Ring = new StreetType(144, "RING", StreetTypeNormalizedName.Ring);
        public static StreetType Rise = new StreetType(145, "RISE", StreetTypeNormalizedName.Rise);
        public static StreetType River = new StreetType(146, "RVR", StreetTypeNormalizedName.River);
        public static StreetType Riverway = new StreetType(147, "RVWY", StreetTypeNormalizedName.Riverway);
        public static StreetType Riviera = new StreetType(148, "RVRA", StreetTypeNormalizedName.Riviera);
        public static StreetType Road = new StreetType(149, "RD", StreetTypeNormalizedName.Road);
        public static StreetType Roads = new StreetType(150, "RDS", StreetTypeNormalizedName.Roads);
        public static StreetType Roadside = new StreetType(151, "RDSD", StreetTypeNormalizedName.Roadside);
        public static StreetType Roadway = new StreetType(152, "RDWY", StreetTypeNormalizedName.Roadway);
        public static StreetType Ronde = new StreetType(153, "RNDE", StreetTypeNormalizedName.Ronde);
        public static StreetType Rosebowl = new StreetType(154, "RSBL", StreetTypeNormalizedName.Rosebowl);
        public static StreetType Rotary = new StreetType(155, "RTY", StreetTypeNormalizedName.Rotary);
        public static StreetType Round = new StreetType(156, "RND", StreetTypeNormalizedName.Round);
        public static StreetType Route = new StreetType(157, "RTE", StreetTypeNormalizedName.Route);
        public static StreetType Row = new StreetType(158, "ROW", StreetTypeNormalizedName.Row);
        public static StreetType Rue = new StreetType(159, "RUE", StreetTypeNormalizedName.Rue);
        public static StreetType Run = new StreetType(160, "RUN", StreetTypeNormalizedName.Run);
        public static StreetType Service = new StreetType(161, "SWY", StreetTypeNormalizedName.Service);
        public static StreetType Siding = new StreetType(162, "SDNG", StreetTypeNormalizedName.Siding);
        public static StreetType Slope = new StreetType(163, "SLPE", StreetTypeNormalizedName.Slope);
        public static StreetType Sound = new StreetType(164, "SND", StreetTypeNormalizedName.Sound);
        public static StreetType Spur = new StreetType(165, "SPUR", StreetTypeNormalizedName.Spur);
        public static StreetType Square = new StreetType(166, "SQ", StreetTypeNormalizedName.Square);
        public static StreetType Stairs = new StreetType(167, "STRS", StreetTypeNormalizedName.Stairs);
        public static StreetType State = new StreetType(168, "SHWY", StreetTypeNormalizedName.State);
        public static StreetType Steps = new StreetType(169, "STPS", StreetTypeNormalizedName.Steps);
        public static StreetType Strand = new StreetType(170, "STRA", StreetTypeNormalizedName.Strand);
        public static StreetType Street = new StreetType(171, "ST", StreetTypeNormalizedName.Street);
        public static StreetType Strip = new StreetType(172, "STRP", StreetTypeNormalizedName.Strip);
        public static StreetType Subway = new StreetType(173, "SBWY", StreetTypeNormalizedName.Subway);
        public static StreetType Tarn = new StreetType(174, "TARN", StreetTypeNormalizedName.Tarn);
        public static StreetType Terrace = new StreetType(175, "TCE", StreetTypeNormalizedName.Terrace);
        public static StreetType Thoroughfare = new StreetType(176, "THOR", StreetTypeNormalizedName.Thoroughfare);
        public static StreetType Tollway = new StreetType(177, "TLWY", StreetTypeNormalizedName.Tollway);
        public static StreetType Top = new StreetType(178, "TOP", StreetTypeNormalizedName.Top);
        public static StreetType Tor = new StreetType(179, "TOR", StreetTypeNormalizedName.Tor);
        public static StreetType Towers = new StreetType(180, "TWRS", StreetTypeNormalizedName.Towers);
        public static StreetType Track = new StreetType(181, "TRK", StreetTypeNormalizedName.Track);
        public static StreetType Trail = new StreetType(182, "TRL", StreetTypeNormalizedName.Trail);
        public static StreetType Trailer = new StreetType(183, "TRLR", StreetTypeNormalizedName.Trailer);
        public static StreetType Triangle = new StreetType(184, "TRI", StreetTypeNormalizedName.Triangle);
        public static StreetType Trunkway = new StreetType(185, "TKWY", StreetTypeNormalizedName.Trunkway);
        public static StreetType Turn = new StreetType(186, "TURN", StreetTypeNormalizedName.Turn);
        public static StreetType Underpass = new StreetType(187, "UPAS", StreetTypeNormalizedName.Underpass);
        public static StreetType Upper = new StreetType(188, "UPR", StreetTypeNormalizedName.Upper);
        public static StreetType Vale = new StreetType(189, "VALE", StreetTypeNormalizedName.Vale);
        public static StreetType Viaduct = new StreetType(190, "VDCT", StreetTypeNormalizedName.Viaduct);
        public static StreetType View = new StreetType(191, "VIEW", StreetTypeNormalizedName.View);
        public static StreetType Villas = new StreetType(192, "VLLS", StreetTypeNormalizedName.Villas);
        public static StreetType Vista = new StreetType(193, "VSTA", StreetTypeNormalizedName.Vista);
        public static StreetType Wade = new StreetType(194, "WADE", StreetTypeNormalizedName.Wade);
        public static StreetType Walk = new StreetType(195, "WALK", StreetTypeNormalizedName.Walk);
        public static StreetType Walkway = new StreetType(196, "WKWY", StreetTypeNormalizedName.Walkway);
        public static StreetType Way = new StreetType(197, "WAY", StreetTypeNormalizedName.Way);
        public static StreetType Wharf = new StreetType(198, "WHRF", StreetTypeNormalizedName.Wharf);
        public static StreetType Wynd = new StreetType(199, "WYND", StreetTypeNormalizedName.Wynd);
        public static StreetType Yard = new StreetType(200, "YARD", StreetTypeNormalizedName.Yard);

        public StreetType(int id, string abbreviation, string name) : base(id, abbreviation, name)
        {
        }

        public IList<StreetType> GetAll()
        {
            StreetType.
        }
    }
}

