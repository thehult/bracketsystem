﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace DÖMDBrackets
{
    public partial class Form1 : Form
    {
        TeamListView teamListView = new TeamListView();


        public Form1()
        {
            InitializeComponent();

            //int teamAmount = 2 * JSONHandler.JSONgetNoMatches("[{\"id\":1,\"roundID\":1,\"teams\":[\"Aristocats 1\",\"Fylleblasten\"],\"winner\":\"Aristocats 1\",\"timestamp\":1366450082},{\"id\":2,\"roundID\":1,\"teams\":[\"H.E.S.T - Leif\",\"x-stig\"],\"winner\":\"x-stig\",\"timestamp\":1366450082},{\"id\":3,\"roundID\":1,\"teams\":[\"Sectra\",\"Spettsnutt\"],\"winner\":\"Sectra\",\"timestamp\":1366450309},{\"id\":4,\"roundID\":1,\"teams\":[\"DAUEMEHTI\",\"B\u00e4bi6\"],\"winner\":\"DAUEMEHTI\",\"timestamp\":1366451878},{\"id\":5,\"roundID\":1,\"teams\":[\"STABEN 2\",\"Team Midget\"],\"winner\":\"STABEN 2\",\"timestamp\":1366450082},{\"id\":6,\"roundID\":1,\"teams\":[\"Knivens Pilsner-Pojkar\",\"[HektoGram]\"],\"winner\":\"Knivens Pilsner-Pojkar\",\"timestamp\":1366451020},{\"id\":7,\"roundID\":1,\"teams\":[\"Dude, Where's My Dart\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366451128},{\"id\":8,\"roundID\":1,\"teams\":[\"Dan dolme och r\u00f6rryttarna\",\"och XXX-Group p\u00e5 bana 9\"],\"winner\":\"och XXX-Group p\u00e5 bana 9\",\"timestamp\":1366450082},{\"id\":9,\"roundID\":1,\"teams\":[\"Cavagruppen\",\"Flubzers\"],\"winner\":\"Flubzers\",\"timestamp\":1366450082},{\"id\":10,\"roundID\":1,\"teams\":[\"DA \u00d6rat\",\"Ruski\"],\"winner\":\"DA \u00d6rat\",\"timestamp\":1366450082},{\"id\":11,\"roundID\":1,\"teams\":[\"Oralspex\",\"Dartattack\"],\"winner\":\"Oralspex\",\"timestamp\":1366450082},{\"id\":12,\"roundID\":1,\"teams\":[\"Johannas lag\",\"De tre v\u00e4nnerna & Kjell\"],\"winner\":\"Johannas lag\",\"timestamp\":1366451039},{\"id\":13,\"roundID\":1,\"teams\":[\"Maria Bondsson och de ensamma mammorna\",\"Gekkos disciples\"],\"winner\":\"Maria Bondsson och de ensamma mammorna\",\"timestamp\":1366450363},{\"id\":14,\"roundID\":1,\"teams\":[\"Pilipz\",\"G\u00f6tt mos AB\"],\"winner\":\"Pilipz\",\"timestamp\":1366450748},{\"id\":15,\"roundID\":1,\"teams\":[\"CCCPil\",\"B\u00f6gpalatset\"],\"winner\":\"B\u00f6gpalatset\",\"timestamp\":1366450193},{\"id\":16,\"roundID\":1,\"teams\":[\"\u00d6stman p\u00e5 korvfabriken\",\"- \"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366451944},{\"id\":17,\"roundID\":1,\"teams\":[\"Grill-Britts Grabbar\",\"Utfrysta\"],\"winner\":\"Grill-Britts Grabbar\",\"timestamp\":1366450082},{\"id\":18,\"roundID\":1,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"De tre v\u00e4nnerna och bj\u00f6rn\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366450557},{\"id\":19,\"roundID\":1,\"teams\":[\"Petter sitter n\u00e4r han kissar\",\"DartyDeeds\"],\"winner\":\"DartyDeeds\",\"timestamp\":1366450082},{\"id\":20,\"roundID\":1,\"teams\":[\"LoB-FestU\",\"A-Laget\"],\"winner\":\"A-Laget\",\"timestamp\":1366451659},{\"id\":21,\"roundID\":1,\"teams\":[\"CM \",\"Saftblandarna\"],\"winner\":\"Saftblandarna\",\"timestamp\":1366450363},{\"id\":22,\"roundID\":1,\"teams\":[\"Y6 \",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1366450748},{\"id\":23,\"roundID\":1,\"teams\":[\"Temp\",\"Team STHLM\"],\"winner\":\"Temp\",\"timestamp\":1366450530},{\"id\":24,\"roundID\":1,\"teams\":[\"Satan sprit och v\u00e5ld\",\"PilLow Fighters\"],\"winner\":\"PilLow Fighters\",\"timestamp\":1366451020},{\"id\":25,\"roundID\":1,\"teams\":[\"Cajlendern 2.0\",\"Velociraptors\"],\"winner\":\"Cajlendern 2.0\",\"timestamp\":1366450082},{\"id\":26,\"roundID\":1,\"teams\":[\"Mario dart\",\"T\u00e5jt\"],\"winner\":\"T\u00e5jt\",\"timestamp\":1366450309},{\"id\":27,\"roundID\":1,\"teams\":[\"Buster mc thunder sticks h\u00e4rliga g\u00e4ng\",\"Team Edward\"],\"winner\":\"Team Edward\",\"timestamp\":1366452222},{\"id\":28,\"roundID\":1,\"teams\":[\"Quizbert\",\"Mordin\"],\"winner\":\"Mordin\",\"timestamp\":1366453957},{\"id\":29,\"roundID\":1,\"teams\":[\"Radovic och g\u00e4nget\",\"H\u00e5rdkoda\"],\"winner\":\"Radovic och g\u00e4nget\",\"timestamp\":1366452855},{\"id\":30,\"roundID\":1,\"teams\":[\"Kapeten nemos kringresande cirkus\",\"B\u00e4ttre \u00e4n inget\"],\"winner\":\"Kapeten nemos kringresande cirkus\",\"timestamp\":1366455658},{\"id\":31,\"roundID\":1,\"teams\":[\"Three darts one girl\",\"Pilsner\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366453100},{\"id\":32,\"roundID\":1,\"teams\":[\"Tiny and the giants\",\"Arvids lag\"],\"winner\":\"Arvids lag\",\"timestamp\":1366452543},{\"id\":33,\"roundID\":1,\"teams\":[\"Aristocats 2\",\"Bibo ergosum\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366452832},{\"id\":34,\"roundID\":1,\"teams\":[\"En svensk, en \u00e4lg och tv\u00e5 danskar\",\"Ranbow buttmonkeys\"],\"winner\":\"Ranbow buttmonkeys\",\"timestamp\":1366455658},{\"id\":35,\"roundID\":1,\"teams\":[\"Ericsson\",\"L\u00c4Kert\"],\"winner\":\"L\u00c4Kert\",\"timestamp\":1366452667},{\"id\":36,\"roundID\":1,\"teams\":[\"Dartlings\",\"Deltaforce\"],\"winner\":\"Deltaforce\",\"timestamp\":1366451723},{\"id\":37,\"roundID\":1,\"teams\":[\"STABEN 3\",\"Dartvaders\"],\"winner\":\"Dartvaders\",\"timestamp\":1366453402},{\"id\":38,\"roundID\":1,\"teams\":[\"Korvfezzt\",\"Ultrakollektivet 158A\"],\"winner\":\"Ultrakollektivet 158A\",\"timestamp\":1366452374},{\"id\":39,\"roundID\":1,\"teams\":[\"Filipino jalapeno\",\"GanBei\"],\"winner\":\"GanBei\",\"timestamp\":1366452887},{\"id\":40,\"roundID\":1,\"teams\":[\"Appative 2\",\"Frank & The Tanks\"],\"winner\":\"Frank & The Tanks\",\"timestamp\":1366452832},{\"id\":41,\"roundID\":1,\"teams\":[\"Tyskarna kommen zur\u00fcck\",\"Pil och flingor\"],\"winner\":\"Pil och flingor\",\"timestamp\":1366455771},{\"id\":42,\"roundID\":1,\"teams\":[\"Kinas Puffar\",\"Tommiefylla ft. WB\"],\"winner\":\"Kinas Puffar\",\"timestamp\":1366453934},{\"id\":43,\"roundID\":1,\"teams\":[\"F1 R\u00d6J\",\"Sparkly Flying Rainbow Space Unicorns\"],\"winner\":\"F1 R\u00d6J\",\"timestamp\":1366453150},{\"id\":44,\"roundID\":1,\"teams\":[\"Dans dansbandslandslag\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366452076},{\"id\":45,\"roundID\":1,\"teams\":[\"D-Styret\",\"V\u00e4stg\u00f6ta vikings\"],\"winner\":\"D-Styret\",\"timestamp\":1366452923},{\"id\":46,\"roundID\":1,\"teams\":[\"!=y\",\"The bouncing tacos\"],\"winner\":\"!=y\",\"timestamp\":1366452282},{\"id\":47,\"roundID\":1,\"teams\":[\"BABSan\",\"Thai Shiny Spice\"],\"winner\":\"BABSan\",\"timestamp\":1366453091},{\"id\":48,\"roundID\":1,\"teams\":[\"dgroup 07/08\",\"K\u00e4rnkraftsreaktorh\u00e4st\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366452705},{\"id\":49,\"roundID\":1,\"teams\":[\"Bend it like Becca\",\"Pojkar vill, killar kan\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366452222},{\"id\":50,\"roundID\":1,\"teams\":[\"yolo mannen swag\",\"Original Goat and Friends\"],\"winner\":\"Original Goat and Friends\",\"timestamp\":1366453298},{\"id\":51,\"roundID\":1,\"teams\":[\"Pl\u00e4p\",\"Dartaingenj\u00f6rerna\"],\"winner\":\"Dartaingenj\u00f6rerna\",\"timestamp\":1366453213},{\"id\":52,\"roundID\":1,\"teams\":[\"Utan tandemcyklar i Bangladesh\",\"Ida Infront\"],\"winner\":\"Utan tandemcyklar i Bangladesh\",\"timestamp\":1366455658},{\"id\":53,\"roundID\":1,\"teams\":[\"SCB Red socks\",\"The swaggers\"],\"winner\":\"The swaggers\",\"timestamp\":1366455879},{\"id\":54,\"roundID\":1,\"teams\":[\"L\u00c4X\",\"TT \"],\"winner\":\"L\u00c4X\",\"timestamp\":1366456220},{\"id\":55,\"roundID\":1,\"teams\":[\"F-sektionen LTH\",\"Med tandemcyklar i Bangladesh\"],\"winner\":\"F-sektionen LTH\",\"timestamp\":1366456220},{\"id\":56,\"roundID\":1,\"teams\":[\"Ped6\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366453366},{\"id\":57,\"roundID\":1,\"teams\":[\"Pricks\u00e4kra Pension\u00e4rer\",\"Ryttarna runt den r\u00f6da pongen\"],\"winner\":\"Ryttarna runt den r\u00f6da pongen\",\"timestamp\":1366456220},{\"id\":58,\"roundID\":1,\"teams\":[\"GP \",\"Tomtefylla\"],\"winner\":\"Tomtefylla\",\"timestamp\":1392042375},{\"id\":59,\"roundID\":1,\"teams\":[\"- \",\"K\u00f6tt\u00e5get\"],\"winner\":\"K\u00f6tt\u00e5get\",\"timestamp\":1366451944},{\"id\":60,\"roundID\":1,\"teams\":[\"Xingjiao\",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366456220},{\"id\":61,\"roundID\":1,\"teams\":[\"2pac iz alive iz back\",\"STRAIGHT SHOOTER FR\u00c5GETECKEN HASHTAG\"],\"winner\":\"2pac iz alive iz back\",\"timestamp\":1366456220},{\"id\":62,\"roundID\":1,\"teams\":[\"Merta bryde sig inte ens\",\"\u00d6r\u00e5det\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366454500},{\"id\":63,\"roundID\":1,\"teams\":[\"Slippery Nipples\",\"Team Emma\"],\"winner\":\"Team Emma\",\"timestamp\":1366456299},{\"id\":64,\"roundID\":1,\"teams\":[\"Der Igel\",\"- \"],\"winner\":\"Der Igel\",\"timestamp\":1366456329},{\"id\":65,\"roundID\":2,\"teams\":[\"Aristocats 1\",\"x-stig\"],\"winner\":\"Aristocats 1\",\"timestamp\":1366457372},{\"id\":66,\"roundID\":2,\"teams\":[\"Sectra\",\"DAUEMEHTI\"],\"winner\":\"Sectra\",\"timestamp\":1366457372},{\"id\":67,\"roundID\":2,\"teams\":[\"STABEN 2\",\"Knivens Pilsner-Pojkar\"],\"winner\":\"STABEN 2\",\"timestamp\":1366457372},{\"id\":68,\"roundID\":2,\"teams\":[\"Diphallios vagina\",\"och XXX-Group p\u00e5 bana 9\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366457372},{\"id\":69,\"roundID\":2,\"teams\":[\"Flubzers\",\"DA \u00d6rat\"],\"winner\":\"Flubzers\",\"timestamp\":1366457372},{\"id\":70,\"roundID\":2,\"teams\":[\"Oralspex\",\"Johannas lag\"],\"winner\":\"Oralspex\",\"timestamp\":1366457372},{\"id\":71,\"roundID\":2,\"teams\":[\"Maria Bondsson och de ensamma mammorna\",\"Pilipz\"],\"winner\":\"Pilipz\",\"timestamp\":1366457372},{\"id\":72,\"roundID\":2,\"teams\":[\"B\u00f6gpalatset\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366457372},{\"id\":73,\"roundID\":2,\"teams\":[\"Grill-Britts Grabbar\",\" Appative ligger alltid \u00f6verst \"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366457372},{\"id\":74,\"roundID\":2,\"teams\":[\"DartyDeeds\",\"A-Laget\"],\"winner\":\"DartyDeeds\",\"timestamp\":1366457372},{\"id\":75,\"roundID\":2,\"teams\":[\"Saftblandarna\",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1366457372},{\"id\":76,\"roundID\":2,\"teams\":[\"Temp\",\"PilLow Fighters\"],\"winner\":\"PilLow Fighters\",\"timestamp\":1366457372},{\"id\":77,\"roundID\":2,\"teams\":[\"Cajlendern 2.0\",\"T\u00e5jt\"],\"winner\":\"Cajlendern 2.0\",\"timestamp\":1366457372},{\"id\":78,\"roundID\":2,\"teams\":[\"Team Edward\",\"Mordin\"],\"winner\":\"Team Edward\",\"timestamp\":1366458423},{\"id\":79,\"roundID\":2,\"teams\":[\"Radovic och g\u00e4nget\",\"Kapeten nemos kringresande cirkus\"],\"winner\":\"Kapeten nemos kringresande cirkus\",\"timestamp\":1366458423},{\"id\":80,\"roundID\":2,\"teams\":[\"Three darts one girl\",\"Arvids lag\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366457372},{\"id\":81,\"roundID\":2,\"teams\":[\"Aristocats 2\",\"Ranbow buttmonkeys\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366457372},{\"id\":82,\"roundID\":2,\"teams\":[\"L\u00c4Kert\",\"Deltaforce\"],\"winner\":\"L\u00c4Kert\",\"timestamp\":1366457372},{\"id\":83,\"roundID\":2,\"teams\":[\"Dartvaders\",\"Ultrakollektivet 158A\"],\"winner\":\"Dartvaders\",\"timestamp\":1366457372},{\"id\":84,\"roundID\":2,\"teams\":[\"GanBei\",\"Frank & The Tanks\"],\"winner\":\"Frank & The Tanks\",\"timestamp\":1366458423},{\"id\":85,\"roundID\":2,\"teams\":[\"Pil och flingor\",\"Kinas Puffar\"],\"winner\":\"Pil och flingor\",\"timestamp\":1366457513},{\"id\":86,\"roundID\":2,\"teams\":[\"F1 R\u00d6J\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366458424},{\"id\":87,\"roundID\":2,\"teams\":[\"D-Styret\",\"!=y\"],\"winner\":\"!=y\",\"timestamp\":1366457372},{\"id\":88,\"roundID\":2,\"teams\":[\"BABSan\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366457412},{\"id\":89,\"roundID\":2,\"teams\":[\"Bend it like Becca\",\"Original Goat and Friends\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366457372},{\"id\":90,\"roundID\":2,\"teams\":[\"Dartaingenj\u00f6rerna\",\"Utan tandemcyklar i Bangladesh\"],\"winner\":\"Utan tandemcyklar i Bangladesh\",\"timestamp\":1366457457},{\"id\":91,\"roundID\":2,\"teams\":[\"The swaggers\",\"L\u00c4X\"],\"winner\":\"L\u00c4X\",\"timestamp\":1366458424},{\"id\":92,\"roundID\":2,\"teams\":[\"F-sektionen LTH\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366457372},{\"id\":93,\"roundID\":2,\"teams\":[\"Ryttarna runt den r\u00f6da pongen\",\"GP \"],\"winner\":\"GP \",\"timestamp\":1366458846},{\"id\":94,\"roundID\":2,\"teams\":[\"K\u00f6tt\u00e5get\",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366457372},{\"id\":95,\"roundID\":2,\"teams\":[\"2pac iz alive iz back\",\"Merta bryde sig inte ens\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366457372},{\"id\":96,\"roundID\":2,\"teams\":[\"Team Emma\",\"Der Igel\"],\"winner\":\"Der Igel\",\"timestamp\":1366458424},{\"id\":97,\"roundID\":3,\"teams\":[\"Aristocats 1\",\"Sectra\"],\"winner\":\"Sectra\",\"timestamp\":1366459679},{\"id\":98,\"roundID\":3,\"teams\":[\"STABEN 2\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366459679},{\"id\":99,\"roundID\":3,\"teams\":[\"Flubzers\",\"Oralspex\"],\"winner\":\"Flubzers\",\"timestamp\":1366459714},{\"id\":100,\"roundID\":3,\"teams\":[\"Pilipz\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366459679},{\"id\":101,\"roundID\":3,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"DartyDeeds\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366459679},{\"id\":102,\"roundID\":3,\"teams\":[\"Grill-Britts Grabbar\",\"PilLow Fighters\"],\"winner\":\"Grill-Britts Grabbar\",\"timestamp\":1366459679},{\"id\":103,\"roundID\":3,\"teams\":[\"Cajlendern 2.0\",\"Team Edward\"],\"winner\":\"Team Edward\",\"timestamp\":1366459679},{\"id\":104,\"roundID\":3,\"teams\":[\"Kapeten nemos kringresande cirkus\",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366460598},{\"id\":105,\"roundID\":3,\"teams\":[\"Aristocats 2\",\"L\u00c4Kert\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366459679},{\"id\":106,\"roundID\":3,\"teams\":[\"Dartvaders\",\"Frank & The Tanks\"],\"winner\":\"Dartvaders\",\"timestamp\":1366459679},{\"id\":107,\"roundID\":3,\"teams\":[\"Pil och flingor\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366459679},{\"id\":108,\"roundID\":3,\"teams\":[\"!=y\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366459679},{\"id\":109,\"roundID\":3,\"teams\":[\"Bend it like Becca\",\"Utan tandemcyklar i Bangladesh\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366459679},{\"id\":110,\"roundID\":3,\"teams\":[\"L\u00c4X\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366460599},{\"id\":111,\"roundID\":3,\"teams\":[\"GP \",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366460599},{\"id\":112,\"roundID\":3,\"teams\":[\"Merta bryde sig inte ens\",\"Der Igel\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366459679},{\"id\":113,\"roundID\":4,\"teams\":[\"Sectra\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366462199},{\"id\":114,\"roundID\":4,\"teams\":[\"Flubzers\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366462802},{\"id\":115,\"roundID\":4,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"Grill-Britts Grabbar\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366462802},{\"id\":116,\"roundID\":4,\"teams\":[\"Team Edward\",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366462527},{\"id\":117,\"roundID\":4,\"teams\":[\"Aristocats 2\",\"Dartvaders\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366461650},{\"id\":118,\"roundID\":4,\"teams\":[\"och XXX-Group p\u00e5 bana 9\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366461650},{\"id\":119,\"roundID\":4,\"teams\":[\"Bend it like Becca\",\"Hest\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366462527},{\"id\":120,\"roundID\":4,\"teams\":[\"STABEN 1\",\"Merta bryde sig inte ens\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366461979},{\"id\":121,\"roundID\":5,\"teams\":[\"Diphallios vagina\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366464248},{\"id\":122,\"roundID\":5,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366464248},{\"id\":123,\"roundID\":5,\"teams\":[\"Aristocats 2\",\"dgroup 07/08\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366464248},{\"id\":124,\"roundID\":5,\"teams\":[\"Bend it like Becca\",\"Merta bryde sig inte ens\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366464248},{\"id\":125,\"roundID\":6,\"teams\":[\"Diphallios vagina\",\"Three darts one girl\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366465644},{\"id\":126,\"roundID\":6,\"teams\":[\"Aristocats 2\",\"Bend it like Becca\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366465644},{\"id\":127,\"roundID\":7,\"teams\":[\"Diphallios vagina\",\"Aristocats 2\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366632877},{\"id\":128,\"roundID\":8,\"teams\":[\"och XXX-Group p\u00e5 bana 9\",\"Jymden\"],\"winner\":null,\"timestamp\":1392044321},{\"id\":129,\"roundID\":8,\"teams\":[\"Bend it like Becca\",\"Hest\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1392044382},{\"id\":130,\"roundID\":8,\"teams\":[\"PilLow Fighters\",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1392044382},{\"id\":131,\"roundID\":8,\"teams\":[\"Oralspex\",\"STABEN 1\"],\"winner\":null,\"timestamp\":null},{\"id\":132,\"roundID\":9,\"teams\":[\"Hest\",\"D-Styret\"],\"winner\":null,\"timestamp\":null},{\"id\":133,\"roundID\":9,\"teams\":[\"PilLow Fighters\",\"Original Goat and Friends\"],\"winner\":null,\"timestamp\":null},{\"id\":134,\"roundID\":10,\"teams\":[\"[hg] 2 /DRUK\",\"Bend it like Becca\"],\"winner\":null,\"timestamp\":null},{\"id\":135,\"roundID\":10,\"teams\":[\"A-Laget\",\"Knivens Pilsner-Pojkar\"],\"winner\":null,\"timestamp\":null},{\"id\":136,\"roundID\":10,\"teams\":[\"Oralspex\",\"DAUEMEHTI\"],\"winner\":null,\"timestamp\":null},{\"id\":137,\"roundID\":10,\"teams\":[\"\u00d6stman p\u00e5 korvfabriken\",\"DA \u00d6rat\"],\"winner\":null,\"timestamp\":null},{\"id\":138,\"roundID\":10,\"teams\":[\"Ultrakollektivet 158A\",\"STABEN 2\"],\"winner\":null,\"timestamp\":null},{\"id\":139,\"roundID\":10,\"teams\":[\"2pac iz alive iz back\",\"Aristocats 1\"],\"winner\":null,\"timestamp\":null}]");
            //startBracketBox(getBestScreen(), teamAmount);
            //JSONHandler.loadJSON("[{\"id\":1,\"roundID\":1,\"teams\":[\"Aristocats 1\",\"Fylleblasten\"],\"winner\":\"Aristocats 1\",\"timestamp\":1366450082},{\"id\":2,\"roundID\":1,\"teams\":[\"H.E.S.T - Leif\",\"x-stig\"],\"winner\":\"x-stig\",\"timestamp\":1366450082},{\"id\":3,\"roundID\":1,\"teams\":[\"Sectra\",\"Spettsnutt\"],\"winner\":\"Sectra\",\"timestamp\":1366450309},{\"id\":4,\"roundID\":1,\"teams\":[\"DAUEMEHTI\",\"B\u00e4bi6\"],\"winner\":\"DAUEMEHTI\",\"timestamp\":1366451878},{\"id\":5,\"roundID\":1,\"teams\":[\"STABEN 2\",\"Team Midget\"],\"winner\":\"STABEN 2\",\"timestamp\":1366450082},{\"id\":6,\"roundID\":1,\"teams\":[\"Knivens Pilsner-Pojkar\",\"[HektoGram]\"],\"winner\":\"Knivens Pilsner-Pojkar\",\"timestamp\":1366451020},{\"id\":7,\"roundID\":1,\"teams\":[\"Dude, Where's My Dart\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366451128},{\"id\":8,\"roundID\":1,\"teams\":[\"Dan dolme och r\u00f6rryttarna\",\"och XXX-Group p\u00e5 bana 9\"],\"winner\":\"och XXX-Group p\u00e5 bana 9\",\"timestamp\":1366450082},{\"id\":9,\"roundID\":1,\"teams\":[\"Cavagruppen\",\"Flubzers\"],\"winner\":\"Flubzers\",\"timestamp\":1366450082},{\"id\":10,\"roundID\":1,\"teams\":[\"DA \u00d6rat\",\"Ruski\"],\"winner\":\"DA \u00d6rat\",\"timestamp\":1366450082},{\"id\":11,\"roundID\":1,\"teams\":[\"Oralspex\",\"Dartattack\"],\"winner\":\"Oralspex\",\"timestamp\":1366450082},{\"id\":12,\"roundID\":1,\"teams\":[\"Johannas lag\",\"De tre v\u00e4nnerna & Kjell\"],\"winner\":\"Johannas lag\",\"timestamp\":1366451039},{\"id\":13,\"roundID\":1,\"teams\":[\"Maria Bondsson och de ensamma mammorna\",\"Gekkos disciples\"],\"winner\":\"Maria Bondsson och de ensamma mammorna\",\"timestamp\":1366450363},{\"id\":14,\"roundID\":1,\"teams\":[\"Pilipz\",\"G\u00f6tt mos AB\"],\"winner\":\"Pilipz\",\"timestamp\":1366450748},{\"id\":15,\"roundID\":1,\"teams\":[\"CCCPil\",\"B\u00f6gpalatset\"],\"winner\":\"B\u00f6gpalatset\",\"timestamp\":1366450193},{\"id\":16,\"roundID\":1,\"teams\":[\"\u00d6stman p\u00e5 korvfabriken\",\"- \"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366451944},{\"id\":17,\"roundID\":1,\"teams\":[\"Grill-Britts Grabbar\",\"Utfrysta\"],\"winner\":\"Grill-Britts Grabbar\",\"timestamp\":1366450082},{\"id\":18,\"roundID\":1,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"De tre v\u00e4nnerna och bj\u00f6rn\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366450557},{\"id\":19,\"roundID\":1,\"teams\":[\"Petter sitter n\u00e4r han kissar\",\"DartyDeeds\"],\"winner\":\"DartyDeeds\",\"timestamp\":1366450082},{\"id\":20,\"roundID\":1,\"teams\":[\"LoB-FestU\",\"A-Laget\"],\"winner\":\"A-Laget\",\"timestamp\":1366451659},{\"id\":21,\"roundID\":1,\"teams\":[\"CM \",\"Saftblandarna\"],\"winner\":\"Saftblandarna\",\"timestamp\":1366450363},{\"id\":22,\"roundID\":1,\"teams\":[\"Y6 \",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1366450748},{\"id\":23,\"roundID\":1,\"teams\":[\"Temp\",\"Team STHLM\"],\"winner\":\"Temp\",\"timestamp\":1366450530},{\"id\":24,\"roundID\":1,\"teams\":[\"Satan sprit och v\u00e5ld\",\"PilLow Fighters\"],\"winner\":\"PilLow Fighters\",\"timestamp\":1366451020},{\"id\":25,\"roundID\":1,\"teams\":[\"Cajlendern 2.0\",\"Velociraptors\"],\"winner\":\"Cajlendern 2.0\",\"timestamp\":1366450082},{\"id\":26,\"roundID\":1,\"teams\":[\"Mario dart\",\"T\u00e5jt\"],\"winner\":\"T\u00e5jt\",\"timestamp\":1366450309},{\"id\":27,\"roundID\":1,\"teams\":[\"Buster mc thunder sticks h\u00e4rliga g\u00e4ng\",\"Team Edward\"],\"winner\":\"Team Edward\",\"timestamp\":1366452222},{\"id\":28,\"roundID\":1,\"teams\":[\"Quizbert\",\"Mordin\"],\"winner\":\"Mordin\",\"timestamp\":1366453957},{\"id\":29,\"roundID\":1,\"teams\":[\"Radovic och g\u00e4nget\",\"H\u00e5rdkoda\"],\"winner\":\"Radovic och g\u00e4nget\",\"timestamp\":1366452855},{\"id\":30,\"roundID\":1,\"teams\":[\"Kapeten nemos kringresande cirkus\",\"B\u00e4ttre \u00e4n inget\"],\"winner\":\"Kapeten nemos kringresande cirkus\",\"timestamp\":1366455658},{\"id\":31,\"roundID\":1,\"teams\":[\"Three darts one girl\",\"Pilsner\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366453100},{\"id\":32,\"roundID\":1,\"teams\":[\"Tiny and the giants\",\"Arvids lag\"],\"winner\":\"Arvids lag\",\"timestamp\":1366452543},{\"id\":33,\"roundID\":1,\"teams\":[\"Aristocats 2\",\"Bibo ergosum\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366452832},{\"id\":34,\"roundID\":1,\"teams\":[\"En svensk, en \u00e4lg och tv\u00e5 danskar\",\"Ranbow buttmonkeys\"],\"winner\":\"Ranbow buttmonkeys\",\"timestamp\":1366455658},{\"id\":35,\"roundID\":1,\"teams\":[\"Ericsson\",\"L\u00c4Kert\"],\"winner\":\"L\u00c4Kert\",\"timestamp\":1366452667},{\"id\":36,\"roundID\":1,\"teams\":[\"Dartlings\",\"Deltaforce\"],\"winner\":\"Deltaforce\",\"timestamp\":1366451723},{\"id\":37,\"roundID\":1,\"teams\":[\"STABEN 3\",\"Dartvaders\"],\"winner\":\"Dartvaders\",\"timestamp\":1366453402},{\"id\":38,\"roundID\":1,\"teams\":[\"Korvfezzt\",\"Ultrakollektivet 158A\"],\"winner\":\"Ultrakollektivet 158A\",\"timestamp\":1366452374},{\"id\":39,\"roundID\":1,\"teams\":[\"Filipino jalapeno\",\"GanBei\"],\"winner\":\"GanBei\",\"timestamp\":1366452887},{\"id\":40,\"roundID\":1,\"teams\":[\"Appative 2\",\"Frank & The Tanks\"],\"winner\":\"Frank & The Tanks\",\"timestamp\":1366452832},{\"id\":41,\"roundID\":1,\"teams\":[\"Tyskarna kommen zur\u00fcck\",\"Pil och flingor\"],\"winner\":\"Pil och flingor\",\"timestamp\":1366455771},{\"id\":42,\"roundID\":1,\"teams\":[\"Kinas Puffar\",\"Tommiefylla ft. WB\"],\"winner\":\"Kinas Puffar\",\"timestamp\":1366453934},{\"id\":43,\"roundID\":1,\"teams\":[\"F1 R\u00d6J\",\"Sparkly Flying Rainbow Space Unicorns\"],\"winner\":\"F1 R\u00d6J\",\"timestamp\":1366453150},{\"id\":44,\"roundID\":1,\"teams\":[\"Dans dansbandslandslag\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366452076},{\"id\":45,\"roundID\":1,\"teams\":[\"D-Styret\",\"V\u00e4stg\u00f6ta vikings\"],\"winner\":\"D-Styret\",\"timestamp\":1366452923},{\"id\":46,\"roundID\":1,\"teams\":[\"!=y\",\"The bouncing tacos\"],\"winner\":\"!=y\",\"timestamp\":1366452282},{\"id\":47,\"roundID\":1,\"teams\":[\"BABSan\",\"Thai Shiny Spice\"],\"winner\":\"BABSan\",\"timestamp\":1366453091},{\"id\":48,\"roundID\":1,\"teams\":[\"dgroup 07/08\",\"K\u00e4rnkraftsreaktorh\u00e4st\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366452705},{\"id\":49,\"roundID\":1,\"teams\":[\"Bend it like Becca\",\"Pojkar vill, killar kan\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366452222},{\"id\":50,\"roundID\":1,\"teams\":[\"yolo mannen swag\",\"Original Goat and Friends\"],\"winner\":\"Original Goat and Friends\",\"timestamp\":1366453298},{\"id\":51,\"roundID\":1,\"teams\":[\"Pl\u00e4p\",\"Dartaingenj\u00f6rerna\"],\"winner\":\"Dartaingenj\u00f6rerna\",\"timestamp\":1366453213},{\"id\":52,\"roundID\":1,\"teams\":[\"Utan tandemcyklar i Bangladesh\",\"Ida Infront\"],\"winner\":\"Utan tandemcyklar i Bangladesh\",\"timestamp\":1366455658},{\"id\":53,\"roundID\":1,\"teams\":[\"SCB Red socks\",\"The swaggers\"],\"winner\":\"The swaggers\",\"timestamp\":1366455879},{\"id\":54,\"roundID\":1,\"teams\":[\"L\u00c4X\",\"TT \"],\"winner\":\"L\u00c4X\",\"timestamp\":1366456220},{\"id\":55,\"roundID\":1,\"teams\":[\"F-sektionen LTH\",\"Med tandemcyklar i Bangladesh\"],\"winner\":\"F-sektionen LTH\",\"timestamp\":1366456220},{\"id\":56,\"roundID\":1,\"teams\":[\"Ped6\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366453366},{\"id\":57,\"roundID\":1,\"teams\":[\"Pricks\u00e4kra Pension\u00e4rer\",\"Ryttarna runt den r\u00f6da pongen\"],\"winner\":\"Ryttarna runt den r\u00f6da pongen\",\"timestamp\":1366456220},{\"id\":58,\"roundID\":1,\"teams\":[\"GP \",\"Tomtefylla\"],\"winner\":\"Tomtefylla\",\"timestamp\":1392042375},{\"id\":59,\"roundID\":1,\"teams\":[\"- \",\"K\u00f6tt\u00e5get\"],\"winner\":\"K\u00f6tt\u00e5get\",\"timestamp\":1366451944},{\"id\":60,\"roundID\":1,\"teams\":[\"Xingjiao\",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366456220},{\"id\":61,\"roundID\":1,\"teams\":[\"2pac iz alive iz back\",\"STRAIGHT SHOOTER FR\u00c5GETECKEN HASHTAG\"],\"winner\":\"2pac iz alive iz back\",\"timestamp\":1366456220},{\"id\":62,\"roundID\":1,\"teams\":[\"Merta bryde sig inte ens\",\"\u00d6r\u00e5det\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366454500},{\"id\":63,\"roundID\":1,\"teams\":[\"Slippery Nipples\",\"Team Emma\"],\"winner\":\"Team Emma\",\"timestamp\":1366456299},{\"id\":64,\"roundID\":1,\"teams\":[\"Der Igel\",\"- \"],\"winner\":\"Der Igel\",\"timestamp\":1366456329},{\"id\":65,\"roundID\":2,\"teams\":[\"Aristocats 1\",\"x-stig\"],\"winner\":\"Aristocats 1\",\"timestamp\":1366457372},{\"id\":66,\"roundID\":2,\"teams\":[\"Sectra\",\"DAUEMEHTI\"],\"winner\":\"Sectra\",\"timestamp\":1366457372},{\"id\":67,\"roundID\":2,\"teams\":[\"STABEN 2\",\"Knivens Pilsner-Pojkar\"],\"winner\":\"STABEN 2\",\"timestamp\":1366457372},{\"id\":68,\"roundID\":2,\"teams\":[\"Diphallios vagina\",\"och XXX-Group p\u00e5 bana 9\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366457372},{\"id\":69,\"roundID\":2,\"teams\":[\"Flubzers\",\"DA \u00d6rat\"],\"winner\":\"Flubzers\",\"timestamp\":1366457372},{\"id\":70,\"roundID\":2,\"teams\":[\"Oralspex\",\"Johannas lag\"],\"winner\":\"Oralspex\",\"timestamp\":1366457372},{\"id\":71,\"roundID\":2,\"teams\":[\"Maria Bondsson och de ensamma mammorna\",\"Pilipz\"],\"winner\":\"Pilipz\",\"timestamp\":1366457372},{\"id\":72,\"roundID\":2,\"teams\":[\"B\u00f6gpalatset\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366457372},{\"id\":73,\"roundID\":2,\"teams\":[\"Grill-Britts Grabbar\",\" Appative ligger alltid \u00f6verst \"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366457372},{\"id\":74,\"roundID\":2,\"teams\":[\"DartyDeeds\",\"A-Laget\"],\"winner\":\"DartyDeeds\",\"timestamp\":1366457372},{\"id\":75,\"roundID\":2,\"teams\":[\"Saftblandarna\",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1366457372},{\"id\":76,\"roundID\":2,\"teams\":[\"Temp\",\"PilLow Fighters\"],\"winner\":\"PilLow Fighters\",\"timestamp\":1366457372},{\"id\":77,\"roundID\":2,\"teams\":[\"Cajlendern 2.0\",\"T\u00e5jt\"],\"winner\":\"Cajlendern 2.0\",\"timestamp\":1366457372},{\"id\":78,\"roundID\":2,\"teams\":[\"Team Edward\",\"Mordin\"],\"winner\":\"Team Edward\",\"timestamp\":1366458423},{\"id\":79,\"roundID\":2,\"teams\":[\"Radovic och g\u00e4nget\",\"Kapeten nemos kringresande cirkus\"],\"winner\":\"Kapeten nemos kringresande cirkus\",\"timestamp\":1366458423},{\"id\":80,\"roundID\":2,\"teams\":[\"Three darts one girl\",\"Arvids lag\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366457372},{\"id\":81,\"roundID\":2,\"teams\":[\"Aristocats 2\",\"Ranbow buttmonkeys\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366457372},{\"id\":82,\"roundID\":2,\"teams\":[\"L\u00c4Kert\",\"Deltaforce\"],\"winner\":\"L\u00c4Kert\",\"timestamp\":1366457372},{\"id\":83,\"roundID\":2,\"teams\":[\"Dartvaders\",\"Ultrakollektivet 158A\"],\"winner\":\"Dartvaders\",\"timestamp\":1366457372},{\"id\":84,\"roundID\":2,\"teams\":[\"GanBei\",\"Frank & The Tanks\"],\"winner\":\"Frank & The Tanks\",\"timestamp\":1366458423},{\"id\":85,\"roundID\":2,\"teams\":[\"Pil och flingor\",\"Kinas Puffar\"],\"winner\":\"Pil och flingor\",\"timestamp\":1366457513},{\"id\":86,\"roundID\":2,\"teams\":[\"F1 R\u00d6J\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366458424},{\"id\":87,\"roundID\":2,\"teams\":[\"D-Styret\",\"!=y\"],\"winner\":\"!=y\",\"timestamp\":1366457372},{\"id\":88,\"roundID\":2,\"teams\":[\"BABSan\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366457412},{\"id\":89,\"roundID\":2,\"teams\":[\"Bend it like Becca\",\"Original Goat and Friends\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366457372},{\"id\":90,\"roundID\":2,\"teams\":[\"Dartaingenj\u00f6rerna\",\"Utan tandemcyklar i Bangladesh\"],\"winner\":\"Utan tandemcyklar i Bangladesh\",\"timestamp\":1366457457},{\"id\":91,\"roundID\":2,\"teams\":[\"The swaggers\",\"L\u00c4X\"],\"winner\":\"L\u00c4X\",\"timestamp\":1366458424},{\"id\":92,\"roundID\":2,\"teams\":[\"F-sektionen LTH\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366457372},{\"id\":93,\"roundID\":2,\"teams\":[\"Ryttarna runt den r\u00f6da pongen\",\"GP \"],\"winner\":\"GP \",\"timestamp\":1366458846},{\"id\":94,\"roundID\":2,\"teams\":[\"K\u00f6tt\u00e5get\",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366457372},{\"id\":95,\"roundID\":2,\"teams\":[\"2pac iz alive iz back\",\"Merta bryde sig inte ens\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366457372},{\"id\":96,\"roundID\":2,\"teams\":[\"Team Emma\",\"Der Igel\"],\"winner\":\"Der Igel\",\"timestamp\":1366458424},{\"id\":97,\"roundID\":3,\"teams\":[\"Aristocats 1\",\"Sectra\"],\"winner\":\"Sectra\",\"timestamp\":1366459679},{\"id\":98,\"roundID\":3,\"teams\":[\"STABEN 2\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366459679},{\"id\":99,\"roundID\":3,\"teams\":[\"Flubzers\",\"Oralspex\"],\"winner\":\"Flubzers\",\"timestamp\":1366459714},{\"id\":100,\"roundID\":3,\"teams\":[\"Pilipz\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366459679},{\"id\":101,\"roundID\":3,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"DartyDeeds\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366459679},{\"id\":102,\"roundID\":3,\"teams\":[\"Grill-Britts Grabbar\",\"PilLow Fighters\"],\"winner\":\"Grill-Britts Grabbar\",\"timestamp\":1366459679},{\"id\":103,\"roundID\":3,\"teams\":[\"Cajlendern 2.0\",\"Team Edward\"],\"winner\":\"Team Edward\",\"timestamp\":1366459679},{\"id\":104,\"roundID\":3,\"teams\":[\"Kapeten nemos kringresande cirkus\",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366460598},{\"id\":105,\"roundID\":3,\"teams\":[\"Aristocats 2\",\"L\u00c4Kert\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366459679},{\"id\":106,\"roundID\":3,\"teams\":[\"Dartvaders\",\"Frank & The Tanks\"],\"winner\":\"Dartvaders\",\"timestamp\":1366459679},{\"id\":107,\"roundID\":3,\"teams\":[\"Pil och flingor\",\"Jymden\"],\"winner\":\"Jymden\",\"timestamp\":1366459679},{\"id\":108,\"roundID\":3,\"teams\":[\"!=y\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366459679},{\"id\":109,\"roundID\":3,\"teams\":[\"Bend it like Becca\",\"Utan tandemcyklar i Bangladesh\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366459679},{\"id\":110,\"roundID\":3,\"teams\":[\"L\u00c4X\",\"Hest\"],\"winner\":\"Hest\",\"timestamp\":1366460599},{\"id\":111,\"roundID\":3,\"teams\":[\"GP \",\"STABEN 1\"],\"winner\":\"STABEN 1\",\"timestamp\":1366460599},{\"id\":112,\"roundID\":3,\"teams\":[\"Merta bryde sig inte ens\",\"Der Igel\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366459679},{\"id\":113,\"roundID\":4,\"teams\":[\"Sectra\",\"Diphallios vagina\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366462199},{\"id\":114,\"roundID\":4,\"teams\":[\"Flubzers\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"\u00d6stman p\u00e5 korvfabriken\",\"timestamp\":1366462802},{\"id\":115,\"roundID\":4,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"Grill-Britts Grabbar\"],\"winner\":\" Appative ligger alltid \u00f6verst \",\"timestamp\":1366462802},{\"id\":116,\"roundID\":4,\"teams\":[\"Team Edward\",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366462527},{\"id\":117,\"roundID\":4,\"teams\":[\"Aristocats 2\",\"Dartvaders\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366461650},{\"id\":118,\"roundID\":4,\"teams\":[\"och XXX-Group p\u00e5 bana 9\",\"dgroup 07/08\"],\"winner\":\"dgroup 07/08\",\"timestamp\":1366461650},{\"id\":119,\"roundID\":4,\"teams\":[\"Bend it like Becca\",\"Hest\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366462527},{\"id\":120,\"roundID\":4,\"teams\":[\"STABEN 1\",\"Merta bryde sig inte ens\"],\"winner\":\"Merta bryde sig inte ens\",\"timestamp\":1366461979},{\"id\":121,\"roundID\":5,\"teams\":[\"Diphallios vagina\",\"\u00d6stman p\u00e5 korvfabriken\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366464248},{\"id\":122,\"roundID\":5,\"teams\":[\" Appative ligger alltid \u00f6verst \",\"Three darts one girl\"],\"winner\":\"Three darts one girl\",\"timestamp\":1366464248},{\"id\":123,\"roundID\":5,\"teams\":[\"Aristocats 2\",\"dgroup 07/08\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366464248},{\"id\":124,\"roundID\":5,\"teams\":[\"Bend it like Becca\",\"Merta bryde sig inte ens\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1366464248},{\"id\":125,\"roundID\":6,\"teams\":[\"Diphallios vagina\",\"Three darts one girl\"],\"winner\":\"Diphallios vagina\",\"timestamp\":1366465644},{\"id\":126,\"roundID\":6,\"teams\":[\"Aristocats 2\",\"Bend it like Becca\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366465644},{\"id\":127,\"roundID\":7,\"teams\":[\"Diphallios vagina\",\"Aristocats 2\"],\"winner\":\"Aristocats 2\",\"timestamp\":1366632877},{\"id\":128,\"roundID\":8,\"teams\":[\"och XXX-Group p\u00e5 bana 9\",\"Jymden\"],\"winner\":null,\"timestamp\":1392044321},{\"id\":129,\"roundID\":8,\"teams\":[\"Bend it like Becca\",\"Hest\"],\"winner\":\"Bend it like Becca\",\"timestamp\":1392044382},{\"id\":130,\"roundID\":8,\"teams\":[\"PilLow Fighters\",\"[hg] 2 /DRUK\"],\"winner\":\"[hg] 2 /DRUK\",\"timestamp\":1392044382},{\"id\":131,\"roundID\":8,\"teams\":[\"Oralspex\",\"STABEN 1\"],\"winner\":null,\"timestamp\":null},{\"id\":132,\"roundID\":9,\"teams\":[\"Hest\",\"D-Styret\"],\"winner\":null,\"timestamp\":null},{\"id\":133,\"roundID\":9,\"teams\":[\"PilLow Fighters\",\"Original Goat and Friends\"],\"winner\":null,\"timestamp\":null},{\"id\":134,\"roundID\":10,\"teams\":[\"[hg] 2 /DRUK\",\"Bend it like Becca\"],\"winner\":null,\"timestamp\":null},{\"id\":135,\"roundID\":10,\"teams\":[\"A-Laget\",\"Knivens Pilsner-Pojkar\"],\"winner\":null,\"timestamp\":null},{\"id\":136,\"roundID\":10,\"teams\":[\"Oralspex\",\"DAUEMEHTI\"],\"winner\":null,\"timestamp\":null},{\"id\":137,\"roundID\":10,\"teams\":[\"\u00d6stman p\u00e5 korvfabriken\",\"DA \u00d6rat\"],\"winner\":null,\"timestamp\":null},{\"id\":138,\"roundID\":10,\"teams\":[\"Ultrakollektivet 158A\",\"STABEN 2\"],\"winner\":null,\"timestamp\":null},{\"id\":139,\"roundID\":10,\"teams\":[\"2pac iz alive iz back\",\"Aristocats 1\"],\"winner\":null,\"timestamp\":null}]", 128);
            //BracketHandler.updateBracketBox();
            
            
            
            
        }

        public void startBracketBox(Screen otherScreen, int teams) {
            BracketHandler.showBracketView(otherScreen);
            BracketHandler.initBracket(teams);
            BracketHandler.createBracketBox();
            BracketHandler.setFullView();
            if(numericUpDown1.Value > 0) {
                timerView.Interval = (int)numericUpDown1.Value * 1000;
                timerView.Enabled = true;
                timerView.Start();
            }
        }

        public Screen getBestScreen()
        {
            //var myScreen = Screen.FromControl(this);
            //return Screen.AllScreens.FirstOrDefault(s => !s.Equals(myScreen))
              //             ?? myScreen;
            foreach (Screen s in Screen.AllScreens)
            {
                if (s.DeviceName == (string)cbScreens.SelectedItem)
                    return s;
            }
            return Screen.PrimaryScreen;
        }

        private void btnLoadTextFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream s = openFileDialog.OpenFile();
                StreamReader sr = new StreamReader(s);
                int nr = 0;
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    nr++;
                }
                s.Position = 0;
                int rounds = (int)Math.Ceiling(Math.Log(nr, 2));
                int noFirstMatches = (int)Math.Pow(2, rounds);
                startBracketBox(getBestScreen(), noFirstMatches);
                int i = 0;
                while (!sr.EndOfStream)
                {
                    Match tmpMatch = new Match();
                    tmpMatch.id = i;
                    tmpMatch.roundID = 1;
                    tmpMatch.team1 = sr.ReadLine();
                    if (!sr.EndOfStream)
                        tmpMatch.team2 = sr.ReadLine();
                    else
                        tmpMatch.team2 = "-";
                    tmpMatch.timestamp = 0;
                    tmpMatch.needRender = true;
                    BracketHandler.matches[0, i] = tmpMatch;
                    i++;
                }



                BracketHandler.updateBracketBox();
                //this.panelConfiguration.Hide();
                this.panelOffline.Show();
                this.panelOffline.BringToFront();
                this.lblHeader.Text = "Match Management";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Screen s in Screen.AllScreens)
            {
                cbScreens.Items.Add(s.DeviceName);
            }
            cbScreens.SelectedIndex = 0;
            this.panelConfig.Show();
            this.panelConfig.BringToFront();
            
            //this.panelOffline.Show();
            //this.panelOffline.BringToFront();
            //MessageBox.Show(this.btnJSONURL.Parent.Name);
        }

        private void btnLoadJSONFile_Click(object sender, EventArgs e)
        {

        }

        private void btnJSONURL_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadBackup_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Match editMatch = null;
        int editRound = -1;
        int editMatchNr = -1;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtTeam.Text.ToLower();
            for (int r = BracketHandler.getNoRounds() - 1; r >= 0; r--)
            {
                for (int i = 0; i < (int)Math.Pow(2, BracketHandler.getNoRounds() - r - 1); i++)
                {
                    //MessageBox.Show("Checking match in round: " + r + " id: " + i);
                    Match m = BracketHandler.matches[r, i];
                    if (m != null)
                    {
                        if (m.team1.ToLower() == search || m.team2.ToLower() == search)
                        {
                            editRound = r;
                            editMatchNr = i;
                            editMatch = m;
                            lblTeam1.Text = m.team1;
                            lblTeam2.Text = m.team2;
                            radioTeam1.Text = m.team1;
                            radioTeam2.Text = m.team2;
                            if (m.winner.ToLower() == m.team1.ToLower())
                                radioTeam1.Select();
                            else if (m.winner.ToLower() == m.team2.ToLower())
                                radioTeam2.Select();
                            else
                                radioNoWinner.Select();
                            btnSaveMatch.Enabled = true;
                            i = int.MaxValue - 2;
                            r = -1;
                        }
                    }
                }
            }
        }

        private void btnSaveMatch_Click(object sender, EventArgs e)
        {
            if (editMatch != null && editRound != -1 && editMatchNr != -1)
            {
                if (radioTeam1.Checked)
                    editMatch.winner = editMatch.team1;
                else if (radioTeam2.Checked)
                    editMatch.winner = editMatch.team2;
                else
                    editMatch.winner = "-";

                if (BracketHandler.matches[editRound + 1, (int)(editMatchNr / 2)] == null)
                {
                    BracketHandler.matches[editRound + 1, (int)(editMatchNr / 2)] = new Match();
                }

                if (editMatchNr % 2 == 0)
                    BracketHandler.matches[editRound + 1, (int)(editMatchNr / 2)].team1 = editMatch.winner;
                else
                    BracketHandler.matches[editRound + 1, (int)(editMatchNr / 2)].team2 = editMatch.winner;

                BracketHandler.matches[editRound + 1, (int)(editMatchNr / 2)].needRender = true;
                BracketHandler.updateBracketBox();
            }
        }

        private int viewCounter = 0;
        private void timerView_Tick(object sender, EventArgs e)
        {
            viewCounter = (viewCounter + 1) % 5;
            switch (viewCounter)
            {
                case 0:
                    BracketHandler.setFullView();
                    break;
                case 1:
                    BracketHandler.setTopLeftView();
                    break;
                case 2:
                    BracketHandler.setBottomLeftView();
                    break;
                case 3:
                    BracketHandler.setTopRightView();
                    break;
                case 4:
                    BracketHandler.setBottomRightView();
                    break;
                default:
                    BracketHandler.setFullView();
                    break;
            }
            
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            if (openLogoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image img = null;
                    if ((img = Image.FromFile(openLogoDialog.FileName)) != null)
                    {
                        BracketHandler.logoImage = new Bitmap(img);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Invalid image file!");
                }
            }
        }

        private void btnSelectBGColor_Click(object sender, EventArgs e)
        {
            if (colorBGDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BracketHandler.bracketView.BackColor = colorBGDialog.Color;
            }
        }

        private void btnSelectBGPattern_Click(object sender, EventArgs e)
        {
            if (openLogoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image img = null;
                    if ((img = Image.FromFile(openLogoDialog.FileName)) != null)
                    {
                        BracketHandler.bgPatternImage = new Bitmap(img);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Invalid image file!");
                }
            }
        }

        private void btnSelectSponsFolder_Click(object sender, EventArgs e)
        {
            if (folderSponsDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string[] files = Directory.GetFiles(folderSponsDialog.SelectedPath);
                    BracketHandler.sponsImages = new Bitmap[files.Length];
                    Image img = null;
                    for (int i = 0; i < files.Length; i++)
                    {
                        if ((img = Image.FromFile(files[i])) != null)
                        {
                            BracketHandler.sponsImages[i] = new Bitmap(img);
                        }
                        img = null;
                    }
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Invalid image files! Folder must ONLY contain images");
                }
            }
        }

        private void btnTeamListing_Click(object sender, EventArgs e)
        {
            teamListView.Show();
        }

    }
}
