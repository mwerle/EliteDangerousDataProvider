﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace EddiDataDefinitions
{
    /// <summary>
    /// Material definitions
    /// </summary>
    public class Material
    {
        private static readonly List<Material> MATERIALS = new List<Material>();

        public string category { get; private set; }

        public string EDName { get; private set; }

        public Rarity rarity { get; private set; }

        public string name { get; private set; }

        // Only for elements
        public string symbol { get; private set; }

        public decimal? goodpctbody { get; private set; }

        public decimal? greatpctbody { get; private set; }

        private Material(string EDName, string category, string name, Rarity rarity, string symbol = null, decimal? goodpctbody = null, decimal? greatpctbody = null)
        {
            this.EDName = EDName;
            this.category = category;
            this.symbol= symbol;
            this.name = name;
            this.rarity = rarity;
            this.goodpctbody = goodpctbody;
            this.greatpctbody = greatpctbody;

            MATERIALS.Add(this);
        }

        public static readonly Material Carbon = new Material("carbon", "Element", "Carbon", Rarity.VeryCommon, "C", 17.5M, 22.5M);
        public static readonly Material Iron = new Material("iron", "Element", "Iron", Rarity.VeryCommon, "Fe", 20, 35);
        public static readonly Material Nickel = new Material("nickel", "Element", "Nickel", Rarity.VeryCommon, "Ni", 17.5M, 25);
        public static readonly Material Phosphorus = new Material("phosphorus", "Element", "Phosphorus", Rarity.VeryCommon, "P", 12.5M, 15);
        public static readonly Material Sulphur = new Material("sulphur", "Element", "Sulphur", Rarity.VeryCommon, "S", 22.5M, 27.5M);

        public static readonly Material Chromium = new Material("chromium", "Element", "Chromium", Rarity.Common, "Cr", 10, 15);
        public static readonly Material Germanium = new Material("germanium", "Element", "Germanium", Rarity.Common, "Ge", 5, 6);
        public static readonly Material Manganese = new Material("manganese", "Element", "Manganese", Rarity.Common, "Mn", 10, 15);
        public static readonly Material Vanadium = new Material("vanadium", "Element", "Vanadium", Rarity.Common, "V", 5, 9);
        public static readonly Material Zinc = new Material("zinc", "Element", "Zinc", Rarity.Common, "Zn", 5, 9);

        public static readonly Material Arsenic = new Material("arsenic", "Element", "Arsenic", Rarity.Standard, "As", 1.8M, 2.4M);
        public static readonly Material Niobium = new Material("niobium", "Element", "Niobium", Rarity.Standard, "Nb", 1, 2);
        public static readonly Material Selenium = new Material("selenium", "Element", "Selenium", Rarity.Standard, "Se", 3.5M, 4.3M);
        public static readonly Material Tungsten = new Material("tungsten", "Element", "Tungsten", Rarity.Standard, "W", 1, 1.8M);
        public static readonly Material Zirconium = new Material("zirconium", "Element", "Zirconium", Rarity.Standard, "Zr", 2.5M, 4);

        public static readonly Material Cadmium = new Material("cadmium", "Element", "Cadmiun", Rarity.Rare, "Cd", 1.6M, 2);
        public static readonly Material Mercury = new Material("mercury", "Element", "Mercury", Rarity.Rare, "Hg", 1, 1.5M);
        public static readonly Material Molybdenum = new Material("molybdenum", "Element", "Molybdenum", Rarity.Rare, "Mo", 1.5M, 2);
        public static readonly Material Tin = new Material("tin", "Element", "Tin", Rarity.Rare, "Sn", 1.3M, 2);
        public static readonly Material Yttrium = new Material("yttrium", "Element", "Yttrium", Rarity.Rare, "Y", 1, 1.5M);

        public static readonly Material Antimony = new Material("antimony", "Element", "Antimony", Rarity.VeryRare, "Sb", 1, 1.3M);
        public static readonly Material Polonium = new Material("polonium", "Element", "Polonium", Rarity.VeryRare, "Po", 0.5M, 1);
        public static readonly Material Ruthenium = new Material("ruthenium", "Element", "Ruthenium", Rarity.VeryRare, "Ru", 1.4M, 2);
        public static readonly Material Technetium = new Material("technetium", "Element", "Technetium", Rarity.VeryRare, "Tc", 0.8M, 1);
        public static readonly Material Tellurium = new Material("tellurium", "Element", "Tellurium", Rarity.VeryRare, "Te", 1, 1.4M);

        public static readonly Material AnomalousBulkScanData = new Material("bulkscandata", "Data", "Anomalous bulk scan data", Rarity.VeryCommon);
        public static readonly Material AtypicalDisruptedWakeEchoes = new Material("disruptedwakeechoes", "Data", "Atypical Disrupted Wake Echoes", Rarity.VeryCommon);
        public static readonly Material DistortedShieldCycleRecordings = new Material("shieldcyclerecordings", "Data", "Distorted Shield Cycle Recordings", Rarity.VeryCommon);
        public static readonly Material ExceptionalScrambledEmissionData = new Material("scrambledemissiondata", "Data", "Exceptional Scrambled Emission Data", Rarity.VeryCommon);
        public static readonly Material SpecialisedLegacyFirmware = new Material("legacyfirmware", "Data", "Specialised Legacy Firmware", Rarity.VeryCommon);
        public static readonly Material UnusualEncryptedFiles = new Material("encryptedfiles", "Data", "Unusual Encrypted Files", Rarity.VeryCommon);

        public static readonly Material AnomalousFSDTelemetry = new Material("fsdtelemetry", "Data", "Anomalous FSD Telemetry", Rarity.Common);
        public static readonly Material InconsistentShieldSoakAnalysis = new Material("shieldsoakanalysis", "Data", "Inconsistent Shield Soak Analysis", Rarity.Common);
        public static readonly Material IrregularEmissionData = new Material("archivedemissiondata", "Data", "Irregular Emission Data", Rarity.Common);
        public static readonly Material ModifiedConsumerFirmware = new Material("consumerfirmware", "Data", "Modified Consumer Firmware", Rarity.Common);
        public static readonly Material TaggedEncryptionCodes = new Material("encryptioncodes", "Data", "Tagged Encryption Codes", Rarity.Common);
        public static readonly Material UnidentifiedScanArchives = new Material("scanarchives", "Data", "Unidentified Scan Archives", Rarity.Common);

        public static readonly Material ClassifiedScanDatabanks = new Material("scandatabanks", "Data", "Classified Scan Databanks", Rarity.Standard);
        public static readonly Material CrackedIndustrialFirmware = new Material("industrialfirmware", "Data", "Cracked Industrial Firmware", Rarity.Standard);
        public static readonly Material OpenSymmetricKeys = new Material("symmetrickeys", "Data", "Open Symmetric Keys", Rarity.Standard);
        public static readonly Material StrangeWakeSolutions = new Material("wakesolutions", "Data", "Strange Wake Solutions", Rarity.Standard);
        public static readonly Material UnexpectedEmissionData = new Material("emissiondata", "Data", "Unexpected Emission Data", Rarity.Standard);
        public static readonly Material UntypicalShieldScans = new Material("shielddensityreports", "Data", "Untypical Shield Scans", Rarity.Standard);

        public static readonly Material AberrantShieldPatternAnalysis = new Material("shieldpatternanalysis", "Data", "Aberrant Shield Pattern Analysis", Rarity.Rare);
        public static readonly Material AtypicalEncryptionArchives = new Material("encryptionarchives", "Data", "Atypical Encryption Archives", Rarity.Rare);
        public static readonly Material DecodedEmissionData = new Material("decodedemissiondata", "Data", "Decoded Emission Data", Rarity.Rare);
        public static readonly Material DivergentScanData = new Material("encodedscandata", "Data", "Divergent Scan Data", Rarity.Rare);
        public static readonly Material EccentricHyperspaceTrajectories = new Material("hyperspacetrajectories", "Data", "Eccentric Hyperspace Trajectories", Rarity.Rare);
        public static readonly Material SecurityFirmwarePatch = new Material("securityfirmware", "Data", "Security Firmware Patch", Rarity.Rare);

        public static readonly Material AbnormalCompactEmissionData = new Material("compactemissionsdata", "Data", "Abnormal Compact Emission Data", Rarity.VeryRare);
        public static readonly Material AdaptiveEncryptorsCapture = new Material("adaptiveencryptors", "Data", "Adaptive Encryptors Capture", Rarity.VeryRare);
        public static readonly Material ClassifiedScanFragment = new Material("classifiedscandata", "Data", "Classified Scan Fragment", Rarity.VeryRare);
        public static readonly Material DataminedWakeExceptions = new Material("dataminedwake", "Data", "Datamined Wake Exceptions", Rarity.VeryRare);
        public static readonly Material ModifiedEmbeddedFirmware = new Material("embeddedfirmware", "Data", "Modified Embedded Firmware", Rarity.VeryRare);
        public static readonly Material PeculiarShieldFrequencyData = new Material("shieldfrequencydata", "Data", "Peculiar Shield Frequency Data", Rarity.VeryRare);

        public static readonly Material BasicConductors = new Material("basicconductors", "Manufactured", "Basic Conductors", Rarity.VeryCommon);
        public static readonly Material ChemicalStorageUnits = new Material("", "Manufactured", "Chemical Storage Units", Rarity.VeryCommon);
        public static readonly Material CompactComposites = new Material("", "Manufactured", "Compact Composites", Rarity.VeryCommon);
        public static readonly Material CrystalShards = new Material("crystalshards", "Manufactured", "Crystal Shards", Rarity.VeryCommon);
        public static readonly Material GridResistors = new Material("gridresistors", "Manufactured", "Grid Resistors", Rarity.VeryCommon);
        public static readonly Material HeatConductionWiring = new Material("heatconductionwiring", "Manufactured", "Heat Conduction Wiring", Rarity.VeryCommon);
        public static readonly Material MechanicalScrap = new Material("mechanicalscrap", "Manufactured", "Mechanical Scrap", Rarity.VeryCommon);
        public static readonly Material SalvagedAlloys = new Material("salvagedalloys", "Manufactured", "Salvaged Alloys", Rarity.VeryCommon);
        public static readonly Material TemperedAlloys = new Material("", "Manufactured", "Tempered Alloys", Rarity.VeryCommon);
        public static readonly Material WornShieldEmitters = new Material("wornshieldemitters", "Manufactured", "Worn Shield Emitters", Rarity.VeryCommon);

        public static readonly Material ChemicalProcessors = new Material("chemicalprocessors", "Manufactured", "Chemical Processors", Rarity.Common);
        public static readonly Material ConductiveComponents = new Material("conductivecomponents", "Manufactured", "Conductive Components", Rarity.Common);
        public static readonly Material FilamentComposites = new Material("", "Manufactured", "Filament Composites", Rarity.Common);
        public static readonly Material FlawedFocusCrystals = new Material("uncutfocuscrystals", "Manufactured", "Flawed Focus Crystals", Rarity.Common);
        public static readonly Material GalvanisingAlloys = new Material("galvanisingalloys", "Manufactured", "Galvanising Alloys", Rarity.Common);
        public static readonly Material HeatDispersionPlate = new Material("heatdispersionplate", "Manufactured", "Heat Dispersion Plate", Rarity.Common);
        public static readonly Material HeatResistantCeramics = new Material("heatresistantceramics", "Manufactured", "Heat Resistant Ceramics", Rarity.Common);
        public static readonly Material HybridCapacitors = new Material("hybridcapacitors", "Manufactured", "Hybrid Capacitors", Rarity.Common);
        public static readonly Material MechanicalEquipment = new Material("mechanicalequipment", "Manufactured", "Mechanical Equipment", Rarity.Common);
        public static readonly Material ShieldEmitters = new Material("shieldemitters", "Manufactured", "Shield Emitters", Rarity.Common);

        public static readonly Material ChemicalDistillery = new Material("chemicaldistillery", "Manufactured", "Chemical Distillery", Rarity.Standard);
        public static readonly Material ConductiveCeramics = new Material("conductiveceramics", "Manufactured", "Conductive Ceramics", Rarity.Standard);
        public static readonly Material ElectrochemicalArrays = new Material("electrochemicalarrays", "Manufactured", "Electrochemical Arrays", Rarity.Standard);
        public static readonly Material FocusCrystals = new Material("focuscrystals", "Manufactured", "Focus Crystals", Rarity.Standard);
        public static readonly Material HeatExchangers = new Material("heatexchangers", "Manufactured", "Heat Exchangers", Rarity.Standard);
        public static readonly Material HighDensityComposites = new Material("highdensitycomposites", "Manufactured", "High Density Composites", Rarity.Standard);
        public static readonly Material MechanicalComponents = new Material("mechanicalcomponents", "Manufactured", "Mechanical Components", Rarity.Standard);
        public static readonly Material PhaseAlloys = new Material("phasealloys", "Manufactured", "Phase Alloys", Rarity.Standard);
        public static readonly Material PrecipitatedAlloys = new Material("precipitatedalloys", "Manufactured", "Precipitated Alloys", Rarity.Standard);
        public static readonly Material ShieldingSensors = new Material("shieldingsensors", "Manufactured", "Shielding Sensors", Rarity.Standard);

        public static readonly Material ChemicalManipulators = new Material("chemicalmanipulators", "Manufactured", "Chemical Manipulators", Rarity.Rare);
        public static readonly Material CompoundShielding = new Material("compoundshielding", "Manufactured", "Compound Shielding", Rarity.Rare);
        public static readonly Material ConductivePolymers = new Material("conductivepolymers", "Manufactured", "Conductive Polymers", Rarity.Rare);
        public static readonly Material ConfigurableComponents = new Material("configurablecomponents", "Manufactured", "Configurable Components", Rarity.Rare);
        public static readonly Material HeatVanes = new Material("heatvanes", "Manufactured", "Heat Vanes", Rarity.Rare);
        public static readonly Material PolymerCapacitors = new Material("polymercapacitors", "Manufactured", "Polymer Capacitors", Rarity.Rare);
        public static readonly Material ProprietaryComposites = new Material("fedproprietarycomposites", "Manufactured", "Proprietary Composites", Rarity.Rare);
        public static readonly Material ProtoLightAlloys = new Material("protolightalloys", "Manufactured", "Proto Light Alloys", Rarity.Rare);
        public static readonly Material RefinedFocusCrystals = new Material("refinedfocuscrystals", "Manufactured", "Refined Focus Crystals", Rarity.Rare);
        public static readonly Material ThermicAlloys = new Material("thermicalloys", "Manufactured", "Thermic Alloys", Rarity.Rare);

        public static readonly Material BiotechConductors = new Material("biotechconductors", "Manufactured", "Biotech Conductors", Rarity.VeryRare);
        public static readonly Material CoreDynamicsComposites = new Material("fedcorecomposites", "Manufactured", "Core Dynamics Composites", Rarity.VeryRare);
        public static readonly Material ExquisiteFocusCrystals = new Material("exquisitefocuscrystals", "Manufactured", "Exquisite Focus Crystals", Rarity.VeryRare);
        public static readonly Material ImperialShielding = new Material("imperialshielding", "Manufactured", "Imperial Shielding", Rarity.VeryRare);
        public static readonly Material ImprovisedComponents = new Material("improvisedcomponents", "Manufactured", "Improvised Components", Rarity.VeryRare);
        public static readonly Material MilitaryGradeAlloys = new Material("militarygradealloys", "Manufactured", "Military Grade Alloys", Rarity.VeryRare);
        public static readonly Material MilitarySupercapacitors = new Material("militarysupercapacitors", "Manufactured", "Military Supercapacitors", Rarity.VeryRare);
        public static readonly Material PharmaceuticalIsolators = new Material("pharmaceuticalisolators", "Manufactured", "Pharmaceutical Isolators", Rarity.VeryRare);
        public static readonly Material ProtoHeatRadiators = new Material("protoheatradiators", "Manufactured", "Proto Heat Radiators", Rarity.VeryRare);
        public static readonly Material ProtoRadiolicAlloys = new Material("protoradiolicalloys", "Manufactured", "Proto Radiolic Alloys", Rarity.VeryRare);
        public static readonly Material UnknownFragment = new Material("unknownenergysource", "Manufactured", "Unknown Fragment", Rarity.VeryRare);

        public static Material FromName(string from)
        {
            Material result = MATERIALS.FirstOrDefault(v => v.name == from);
            if (result == null)
            {
                Logging.Report("Unknown material name " + from);
            }
            return result;
        }

        public static Material FromEDName(string from)
        {
            string tidiedFrom = from == null ? null : from.ToLowerInvariant();
            Material result = MATERIALS.FirstOrDefault(v => v.EDName.ToLowerInvariant() == tidiedFrom);
            if (result == null)
            {
                Logging.Report("Unknown material ED name " + from);
                result = new Material(from, "Unknown", tidiedFrom, Rarity.Unknown);
            }
            return result;
        }

        public static Material FromSymbol(string from)
        {
            Material result = MATERIALS.FirstOrDefault(v => v.symbol == from);
            if (result == null)
            {
                Logging.Report("Unknown material symbol " + from);
            }
            return result;
        }
    }
}
