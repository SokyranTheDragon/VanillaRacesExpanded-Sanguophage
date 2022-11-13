﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;

namespace VanillaRacesExpandedSanguophage
{
    [DefOf]
    public static class InternalDefOf
    {
        public static HediffDef VRE_ConsumedAnimalHemogen;
        public static HediffDef VRE_ConsumedCorpseHemogen;
        public static HediffDef VRE_ConsumedSanguophageHemogen;

        public static ThoughtDef VRE_Ecstasy;

        public static GeneDef VRE_AnimalFeeder;
        public static GeneDef VRE_CorpseFeeder;
        public static GeneDef VRE_SanguoFeeder;

        public static JobDef VRE_ExtractHemogenAnimal;
        public static JobDef VRE_ExtractHemogenCorpse;
        public static JobDef VRE_ExtractHemogenSanguophage;

        public static ThingDef VRE_HemogenPack_Animal;
        public static ThingDef VRE_HemogenPack_Corpse;
        public static ThingDef VRE_HemogenPack_Sanguophage;

        public static EffecterDef VRE_BloodEvaporation;

    }
}