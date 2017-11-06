using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiaInsertionBrowser
{
    class Data
    {
        public static readonly string rawdata = @"<?xml version=""1.0"" encoding=""utf-8""?>
<EpisodeList xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <episodes>
    <Episode name=""The Darkness Demo"" number=""1"" length=""194"" ytlink=""https://www.youtube.com/watch?v=eWS9_nrKOPA"" date=""2007-07-24T17:00:00"">
      <introsong band=""Stevie Wonder"" wpband=""Stevie Wonder"" song=""Superstition"" wpsong=""Superstition (song)"" />
      <outrosong band=""The Polyphonic Spree"" wpband=""The Polyphonic Spree"" song=""Section 12 (Hold Me Now)"" />
      <reviewed name=""The Darkness"" wpname=""The Darkness (video game)"" />
      <teaser>""A short experimental film in which I attempt to make a video using only recorded speech and static images. In this one I give a rundown of my first attempt to play the demo of the Darkness.""</teaser>
    </Episode>
    <Episode name=""Fable: The Lost Chapters"" number=""2"" length=""220"" ytlink=""https://www.youtube.com/watch?v=jYQLR7dE5k4"" date=""2007-07-29T17:00:00"">
      <introsong band=""Richard Wagner"" wpband=""Richard Wagner"" song=""Götterdämmerung"" wpsong=""Götterdämmerung"" />
      <outrosong band=""The Vapors"" wpband=""The Vapors"" song=""Turning Japanese"" wpsong=""Turning Japanese"" />
      <reviewed name=""Fable: The Lost Chapters"" wpname=""Fable (video game)"" />
      <teaser>A retrospective video review of Fable: The Lost Chapters.</teaser>
    </Episode>
    <Episode name=""Zero Punctuation (Episode)"" number=""3"" length=""39"" originalname=""Zero Punctuation"" ytlink=""https://www.youtube.com/watch?v=ZOBTN67K0Zw"" date=""2007-08-13T17:00:00"">
      <introsong band=""Stevie Wonder"" wpband=""Stevie Wonder"" song=""Superstition"" wpsong=""Superstition (song)"" />
      <teaser>""A sort of announcement trailer thing introducing the new series of video reviews I've been contracted to do for The Escapist.""</teaser>
    </Episode>
    <Episode name=""Heavenly Sword and Other Stuff"" number=""4"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1-Heavenly-Sword-and-Other-Stuff"" originalname=""Heavenly Sword and Other Stuff"" ytlink=""https://www.youtube.com/watch?v=_w6wU2KPPwk"" date=""2007-08-15T17:00:00"">
      <outrosong band=""Norman Greenbaum"" wpband=""Norman Greenbaum"" song=""Spirit in the Sky"" wpsong=""Spirit in the Sky"" />
      <reviewed name=""Heavenly Sword"" wpname=""Heavenly Sword"" />
      <reviewed name=""Resident Evil 5"" wpname=""Resident Evil 5"" awardname=""The Razor Blade Filled Vagina Award for Fastest Reversal of Fortune"" awardepisode=""Awards for 2009"">
        <seealso>Resident Evil 5</seealso>
      </reviewed>
      <teaser>Yahtzee Croshaw, in his debut video review for The Escapist, skewers Heavenly Sword, the Resident Evil 5 trailer, and more.</teaser>
    </Episode>
    <Episode name=""Psychonauts"" number=""5"" length=""279"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2-Psychonauts"" originalname=""Psychonauts"" ytlink=""https://www.youtube.com/watch?v=IkmBPtglbDs"" date=""2007-08-22T16:00:00"">
      <introsong band=""Jimi Hendrix"" wpband=""Jimi Hendrix"" song=""Purple Haze"" wpsong=""Purple Haze"" />
      <outrosong band=""R. Kelly"" wpband=""R. Kelly"" song=""I Believe I Can Fly"" wpsong=""I Believe I Can Fly"" />
      <reviewed name=""Psychonauts"" wpname=""Psychonauts"" />
      <teaser>This week, in honor of The Escapist's Game Circle game of the month, Yahtzee throws down on Psychonauts and you, the consumer.</teaser>
    </Episode>
    <Episode name=""Console Rundown"" number=""6"" length=""253"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3-Console-Rundown"" originalname=""Console Rundown"" ytlink=""https://www.youtube.com/watch?v=Wxr89gxP9Dg"" date=""2007-08-29T16:00:00"">
      <reissue date=""2008-06-11T00:00:00"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/84-Console-Rundown"" ytlink=""https://www.youtube.com/watch?v=wkscwBH90sU"" />
      <introsong band=""Edwin Starr"" wpband=""Edwin Starr"" song=""War"" wpsong=""War (Edwin Starr song)"" />
      <outrosong band=""Village People"" wpband=""Village People"" song=""In the Navy"" wpsong=""In the Navy"" />
      <reviewed name=""Wii"" wpname=""Wii"" />
      <reviewed name=""Playstation 3"" wpname=""PlayStation 3"" />
      <reviewed name=""Xbox 360"" wpname=""Xbox 360"" />
      <teaser>This week on Zero Punctuation, Yahtzee takes a look at the ongoing console war.</teaser>
    </Episode>
    <Episode name=""BioShock"" number=""7"" length=""241"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4-BioShock"" originalname=""BioShock"" ytlink=""https://www.youtube.com/watch?v=vGxo2X4B_LE"" date=""2007-09-05T16:00:00"">
      <introsong band=""The Beatles"" wpband=""The Beatles"" song=""Octopuss Garden"" wpsong=""Octopuss Garden"" />
      <outrosong band=""Scissor Sisters"" wpband=""Scissor Sisters"" song=""I Cant Decide"" />
      <reviewed name=""BioShock"" wpname=""BioShock"" />
      <teaser>This week, The Escapist's Zero Punctuation reviews BioShock.</teaser>
    </Episode>
    <Episode name=""Tomb Raider: Anniversary"" number=""8"" length=""224"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5-Tomb-Raider-Anniversary"" originalname=""Tomb Raider Anniversary"" ytlink=""https://www.youtube.com/watch?v=4fLRDDGj_wI"" date=""2007-09-12T16:00:00"">
      <introsong band=""The Jam"" wpband=""The Jam"" song=""Going Underground"" wpsong=""Going Underground"" />
      <outrosong band=""Queen"" wpband=""Queen (band)"" song=""Fat Bottomed Girls"" />
      <reviewed name=""Tomb Raider Anniversary"" wpname=""Tomb Raider: Anniversary"" />
      <teaser>This week, The Escapist's Zero Punctuation reviews Tomb Raider: Anniversary.</teaser>
    </Episode>
    <Episode name=""Manhunt"" number=""9"" length=""220"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6-Manhunt"" originalname=""Manhunt"" ytlink=""https://www.youtube.com/watch?v=HYmVlpgT3pM"" date=""2007-09-19T16:00:00"">
      <introsong band=""Lesley Gore"" wpband=""Lesley Gore"" song=""Sunshine, Lollipops, and Rainbows"" wpsong=""Sunshine, Lollipops, and Rainbows"" />
      <outrosong band=""Suede"" wpband=""Suede (band)"" song=""Filmstar"" wpsong=""Filmstar (song)"" />
      <reviewed name=""Manhunt"" wpname=""Manhunt (video game)"" />
      <teaser>This week, The Escapist's Zero Punctuation reviews Manhunt.</teaser>
    </Episode>
    <Episode name=""Peggle"" number=""10"" length=""223"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7-Peggle"" originalname=""Peggle"" ytlink=""https://www.youtube.com/watch?v=sKOp4vcb6RA"" date=""2007-09-26T16:00:00"">
      <introsong band=""The Four Seasons"" wpband=""The Four Seasons (band)"" song=""Stay (Just a Little bit Longer)"" wpsong=""Stay (Maurice Williams song)"" />
      <outrosong band=""Lynyrd Skynyrd"" wpband=""Lynyrd Skynyrd"" song=""Free Bird"" wpsong=""Free Bird"" />
      <reviewed name=""Peggle"" wpname=""Peggle"" />
      <teaser>This week, Yahtzee, against his own better judgment, reviews Peggle, the monstrously popular casual game from the monstrously successful PopCap.</teaser>
    </Episode>
    <Episode name=""Halo 3"" number=""11"" length=""231"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8-Halo-3"" originalname=""Halo 3"" ytlink=""https://www.youtube.com/watch?v=Sa6WLMt-3oQ"" date=""2007-10-03T16:00:00"">
      <introsong band=""The Beatles"" wpband=""The Beatles"" song=""Hello Goodbye"" wpsong=""Hello, Goodbye"" />
      <outrosong band=""Sarah Brightman"" wpband=""Sarah Brightman"" song=""I Lost My Heart to a Starship Trooper"" wpsong=""I Lost My Heart to a Starship Trooper"" />
      <reviewed name=""Halo 3"" wpname=""Halo 3"" />
      <teaser>This week, by popular demand, Yahtzee throws down on the most important media property of the year, Halo 3.</teaser>
    </Episode>
    <Episode name=""Tabula Rasa"" number=""12"" length=""220"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9-Tabula-Rasa"" originalname=""Tabula Rasa"" ytlink=""https://www.youtube.com/watch?v=aSQBuorvgXI"" date=""2007-10-10T17:01:00"">
      <introsong band=""R.E.M."" wpband=""R.E.M."" song=""Its the End of the World as We Know It (And I Feel Fine)"" wpsong=""Its the End of the World as We Know It (And I Feel Fine)"" />
      <outrosong band=""The Levellers"" wpband=""Levellers (band)"" song=""Fantasy"" wpsong=""Fantasy (Mariah Carey song)"" />
      <reviewed name=""Tabula Rasa"" wpname=""Tabula Rasa (video game)"" />
      <teaser>This week, Richard Garriott's Magnum Opus gets a little love.</teaser>
    </Episode>
    <Episode name=""The Orange Box"" number=""13"" length=""264"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10-The-Orange-Box"" originalname=""The Orange Box"" ytlink=""https://www.youtube.com/watch?v=_dlEm_2ke8k"" date=""2007-10-17T16:00:00"">
      <introsong band=""Small Faces"" wpband=""Small Faces"" song=""Itchycoo Park"" wpsong=""Itchycoo Park"" />
      <outrosong band=""Tenacious D"" wpband=""Tenacious D"" song=""Tribute"" wpsong=""Tribute (song)"" />
      <reviewed name=""The Orange Box"" wpname=""The Orange Box"" />
      <reviewed name=""Half-Life 2: Episode Two"" wpname=""Half-Life 2: Episode Two"" />
      <reviewed name=""Team Fortress 2"" wpname=""Team Fortress 2"" />
      <reviewed name=""Portal"" wpname=""Portal (video game)"" />
      <teaser>This week, Yahtzee opens the Orange Box.</teaser>
    </Episode>
    <Episode name=""Super Paper Mario"" number=""14"" length=""245"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/11-Super-Paper-Mario"" originalname=""Super Paper Mario"" ytlink=""https://www.youtube.com/watch?v=CdfrF4Q6TkQ"" date=""2007-10-24T16:00:00"">
      <introsong band=""Italian national anthem"" song=""Il Canto degli Italiani"" wpsong=""Il Canto degli Italiani"" />
      <outrosong band=""Anita Bryant"" wpband=""Anita Bryant"" song=""Paper Roses"" wpsong=""Paper Roses"" />
      <reviewed name=""Super Paper Mario"" wpname=""Super Paper Mario"" />
      <teaser>This week, Zero Punctuation unwraps Super Paper Mario.</teaser>
    </Episode>
    <Episode name=""Medal of Honor: Airborne"" number=""15"" length=""260"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/12-MOH-Airborne"" originalname=""MOH Airborne"" ytlink=""https://www.youtube.com/watch?v=G9vtof44lKs"" date=""2007-10-31T16:00:00"">
      <introsong band=""Guns N' Roses"" wpband=""Guns N' Roses"" song=""Civil War"" wpsong=""Civil War (song)"" />
      <outrosong band=""D.V.D.A"" wpband=""DVDA (band)"" song=""America, Fuck Yeah"" />
      <reviewed name=""Medal of Honor: Airborne"" wpname=""Medal of Honor: Airborne"" />
      <teaser>This week on Zero Punctuation, Yahtzee parachutes into EA's Medal of Honor Airborne.</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: Phantom Hourglass"" number=""16"" length=""235"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/13-Zelda-Phantom-Hourglass"" originalname=""Zelda Phantom Hourglass"" ytlink=""https://www.youtube.com/watch?v=wO0w9Vl2HjI"" date=""2007-11-07T16:00:00"">
      <introsong band=""Benny Goodman"" wpband=""Benny Goodman"" song=""(Id Like to Get You on a) Slow Boat to China"" wpsong=""(Id Like to Get You on a) Slow Boat to China"" />
      <outrosong band=""Aerosmith"" wpband=""Aerosmith"" song=""Dude (Looks Like a Lady)"" wpsong=""Dude (Looks Like a Lady)"" />
      <reviewed name=""The Legend of Zelda: Phantom Hourglass"" wpname=""The Legend of Zelda: Phantom Hourglass"" />
      <teaser>Yahtzee explores the pirate boat adventures of Link in the DS title: Legend of Zelda Phantom Hourglass.</teaser>
    </Episode>
    <Episode name=""Clive Barker's Jericho"" number=""17"" length=""274"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/14-Clive-Barkers-Jericho"" originalname=""Clive Barker's Jericho"" ytlink=""https://www.youtube.com/watch?v=ZCnUTIaDIRY"" date=""2007-11-14T16:00:00"">
      <introsong band=""Bobby Pickett"" wpband=""Bobby Pickett"" song=""Monster Mash"" wpsong=""Monster Mash"" />
      <outrosong band=""My Chemical Romance"" wpband=""My Chemical Romance"" song=""Blood"" />
      <reviewed name=""Clive Barker's Jericho"" wpname=""Clive Barker's Jericho"" />
      <teaser>This week's Zero Punctuation takes a long, bloody look at Clive Barker's Jericho (by Clive Barker).</teaser>
    </Episode>
    <Episode name=""F.E.A.R. Perseus Mandate"" number=""18"" length=""235"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/15-F-E-A-R-Perseus-Mandate"" originalname=""F.E.A.R. Perseus Mandate"" ytlink=""https://www.youtube.com/watch?v=J-k0qdoZYQI"" date=""2007-11-28T16:15:00"">
      <introsong band=""Ray Parker, Jr."" wpband=""Ray Parker, Jr."" song=""Ghostbusters"" wpsong=""Ghostbusters (song)"" />
      <outrosong band=""Butterfingers"" wpband=""Butterfingers (Australian band)"" song=""Yo Mamma"" />
      <reviewed name=""F.E.A.R. Perseus Mandate"" wpname=""F.E.A.R. Perseus Mandate"" />
      <teaser>Yahtzee faces F.E.A.R. Perseus Mandate.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed"" number=""19"" length=""285"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/16-Assassins-Creed"" originalname=""Assassin's Creed"" ytlink=""https://www.youtube.com/watch?v=C70wWScZWgo"" date=""2007-12-05T16:09:00"">
      <introsong band=""The Clash"" wpband=""The Clash"" song=""I Fought The Law"" wpsong=""I Fought the Law"" />
      <outrosong band=""Boots Randolph"" wpband=""Boots Randolph"" song=""Yakety Sax"" wpsong=""Yakety Sax"" />
      <reviewed name=""Assassin's Creed"" wpname=""Assassin's Creed (video game)"" />
      <teaser>This week on Zero Punctuation, Yahtzee gets stabby with Assassin's Creed.</teaser>
    </Episode>
    <Episode name=""Guitar Hero III: Legends of Rock"" number=""20"" length=""237"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/17-Guitar-Hero-III"" originalname=""Guitar Hero III"" ytlink=""https://www.youtube.com/watch?v=7NNBQJm18fI"" date=""2007-12-12T16:12:00"">
      <introsong band=""Ramones"" wpband=""Ramones"" song=""I Wanna Be Sedated"" wpsong=""I Wanna Be Sedated"" />
      <outrosong band=""Eric Johnson"" wpband=""Eric Johnson"" song=""Cliffs of Dover"" wpsong=""Cliffs of Dover (composition)"" />
      <reviewed name=""Guitar Hero III: Legends of Rock"" wpname=""Guitar Hero III: Legends of Rock"" />
      <teaser>This week on Zero Punctuation, Yahtzee gaily shreds Guitar Hero III.</teaser>
    </Episode>
    <Episode name=""Mass Effect"" number=""21"" length=""245"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/18-Mass-Effect"" originalname=""Mass Effect"" ytlink=""https://www.youtube.com/watch?v=_ydrCwyvtYE"" date=""2007-12-19T16:28:00"">
      <introsong band=""Elvis Presley"" wpband=""Elvis Presley"" song=""A Little Less Conversation"" wpsong=""A Little Less Conversation"" />
      <outrosong band=""Babylon Zoo"" wpband=""Babylon Zoo"" song=""Spaceman"" wpsong=""Spaceman (Babylon Zoo song)"" />
      <reviewed name=""Mass Effect"" wpname=""Mass Effect (video game)"" />
      <teaser>This week on Zero Punctuation, Mass Effect.</teaser>
    </Episode>
    <Episode name=""Super Mario Galaxy"" number=""22"" length=""258"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/19-Super-Mario-Galaxy"" originalname=""Super Mario Galaxy"" ytlink=""https://www.youtube.com/watch?v=WH6cvKf5ttY"" date=""2008-01-02T16:00:00"">
      <introsong band=""Frank Sinatra"" wpband=""Frank Sinatra"" song=""Fly Me to the Moon"" wpsong=""Fly Me to the Moon"" />
      <outrosong band=""Smash Mouth"" wpband=""Smash Mouth"" song=""Walkin on the Sun"" wpsong=""Walkin on the Sun"" />
      <reviewed name=""Super Mario Galaxy"" wpname=""Super Mario Galaxy"" />
      <teaser>This week on Zero Punctuation, Yahtzee takes on the plumber.</teaser>
    </Episode>
    <Episode name=""Silent Hill: Origins"" number=""23"" length=""226"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/20-Silent-Hill-Origins"" originalname=""Silent Hill Origins"" ytlink=""https://www.youtube.com/watch?v=VS26wbFePSk"" date=""2008-01-09T15:54:00"">
      <introsong band=""Björk"" wpband=""Björk"" song=""Its Oh So Quiet"" wpsong=""Its Oh So Quiet"" />
      <outrosong band=""Radiohead"" wpband=""Radiohead"" song=""Just"" wpsong=""Just (song)"" />
      <reviewed name=""Silent Hill Origins"" wpname=""Silent Hill: Origins"" />
      <teaser>This week on Zero Punctuation, Yahtzee visits Silent Hill.</teaser>
    </Episode>
    <Episode name=""Crysis"" number=""24"" length=""227"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/21-Crysis"" originalname=""Crysis"" ytlink=""https://www.youtube.com/watch?v=JyTS-gfwcJQ"" date=""2008-01-16T16:08:00"">
      <introsong band=""Weezer"" wpband=""Weezer"" song=""Island in the Sun"" wpsong=""Island in the Sun (song)"" />
      <outrosong band=""Electric Six"" wpband=""Electric Six"" song=""Dance Commander"" />
      <reviewed name=""Crysis"" wpname=""Crysis"" />
      <teaser>This week on Zero Punctuation, Crysis.</teaser>
    </Episode>
    <Episode name=""The Witcher"" number=""25"" length=""355"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/22-The-Witcher"" originalname=""The Witcher"" ytlink=""https://www.youtube.com/watch?v=P0dXtOVi2yo"" date=""2008-01-23T16:03:00"">
      <introsong band=""The Offspring"" wpband=""The Offspring"" song=""Pretty Fly (For a White Guy)"" wpsong=""Pretty Fly (for a White Guy)"" />
      <outrosong band=""Avenged Sevenfold"" wpband=""Avenged Sevenfold"" song=""Beast and the Harlot"" wpsong=""Beast and the Harlot"" />
      <reviewed name=""The Witcher"" wpname=""The Witcher (video game)"" />
      <teaser>This week on Zero Punctuation, Yahtzee roleplays a pale, lanky misogynist.</teaser>
    </Episode>
    <Episode name=""Resident Evil: The Umbrella Chronicles"" number=""26"" length=""251"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/23-Resident-Evil-Umbrella-Chronicles"" originalname=""Resident Evil: Umbrella Chronicles"" ytlink=""https://www.youtube.com/watch?v=EkQchMzvWDY"" date=""2008-01-30T16:08:00"">
      <introsong band=""Dio"" wpband=""Dio (band)"" song=""Shoot Shoot"" />
      <outrosong band=""Soul Asylum"" wpband=""Soul Asylum"" song=""Runaway Train"" wpsong=""Runaway Train (Soul Asylum song)"" />
      <reviewed name=""Resident Evil: The Umbrella Chronicles"" wpname=""Resident Evil: The Umbrella Chronicles"" />
      <teaser>This week on Zero Punctuation, Yahtzee goes underground with the Umbrella Corporation.</teaser>
    </Episode>
    <Episode name=""Call of Duty 4: Modern Warfare"" number=""27"" length=""245"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/24-Call-of-Duty-4"" originalname=""Call of Duty 4"" ytlink=""https://www.youtube.com/watch?v=xnZ-5DZhySg"" date=""2008-02-06T16:01:00"">
      <introsong band=""The White Stripes"" wpband=""The White Stripes"" song=""Seven Nation Army"" wpsong=""Seven Nation Army"" />
      <outrosong band=""Rage Against the Machine"" wpband=""Rage Against the Machine"" song=""Killing in the Name"" wpsong=""Killing in the Name"" />
      <reviewed name=""Call of Duty 4: Modern Warfare"" wpname=""Call of Duty 4: Modern Warfare"" />
      <teaser>This week on Zero Punctuation, the most requested review of all time, Call of Duty 4.</teaser>
    </Episode>
    <Episode name=""SimCity Societies"" number=""28"" length=""306"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/25-Sim-City-Societies"" originalname=""Sim City Societies"" ytlink=""https://www.youtube.com/watch?v=_ApdGizJECo"" date=""2008-02-13T16:05:00"">
      <introsong band=""Stevie Wonder"" wpband=""Stevie Wonder"" song=""Living for the City"" wpsong=""Living for the City"" />
      <outrosong band=""AC/DC"" wpband=""AC/DC"" song=""Highway to Hell"" wpsong=""Highway to Hell"" />
      <reviewed name=""Sim City Societies"" wpname=""SimCity Societies"" />
      <teaser>This week on Zero Punctuation, Yahtzee compares Sim City to Nazi Germany.</teaser>
    </Episode>
    <Episode name=""Yahtzee Goes to GDC"" number=""29"" length=""306"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/26-Yahtzee-Goes-to-GDC"" originalname=""Yahtzee Goes to GDC"" ytlink=""https://www.youtube.com/watch?v=a2ZiNAr_xZk"" date=""2008-02-21T03:59:00"">
      <introsong band=""Scott Joplin"" wpband=""Scott Joplin"" song=""The Entertainer"" wpsong=""The Entertainer (rag)"" />
      <outrosong band=""Scott Joplin"" song=""The Entertainer"" />
      <teaser>This week on Zero Punctuation, Yahtzee goes to GDC: a special presentation of Yahtzee's Developer's Choice Awards Videos from GDC 2008.</teaser>
    </Episode>
    <Episode name=""Uncharted: Drake's Fortune"" number=""30"" length=""242"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/27-Uncharted-Drakes-Fortune"" originalname=""Uncharted: Drake's Fortune"" ytlink=""https://www.youtube.com/watch?v=12FMjfFJrG0"" date=""2008-02-27T16:12:00"">
      <introsong band=""Spandau Ballet"" wpband=""Spandau Ballet"" song=""Gold"" wpsong=""Gold (Spandau Ballet song)"" />
      <outrosong band=""Stevie Wonder and Paul McCartney"" song=""Ebony and Ivory"" wpsong=""Ebony and Ivory"" />
      <reviewed name=""Uncharted: Drake's Fortune"" wpname=""Uncharted: Drake's Fortune"" />
      <teaser>This week on Zero Punctuation, Yahtzee goes treasure hunting with Uncharted.</teaser>
    </Episode>
    <Episode name=""Devil May Cry 4"" number=""31"" length=""265"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/28-Devil-May-Cry-4"" originalname=""Devil May Cry 4"" ytlink=""https://www.youtube.com/watch?v=jtvWcPJq3po"" date=""2008-03-05T16:03:00"">
      <introsong band=""The Rolling Stones"" wpband=""The Rolling Stones"" song=""Sympathy For The Devil"" wpsong=""Sympathy for the Devil"" />
      <outrosong band=""Fatboy Slim"" wpband=""Norman Cook"" song=""Weapon of Choice"" wpsong=""Star 69 / Weapon of Choice#.22Weapon of Choice.22"" />
      <reviewed name=""Devil May Cry 4"" wpname=""Devil May Cry 4"" />
      <teaser>This week on Zero Punctuation, Yahtzee sheds a single emo tear for his gigantic sword in Devil May Cry 4.</teaser>
    </Episode>
    <Episode name=""Burnout: Paradise"" number=""32"" length=""249"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/29-Burnout-Paradise"" originalname=""Burnout: Paradise"" ytlink=""https://www.youtube.com/watch?v=U5-2VQH8t3c"" date=""2008-03-12T16:09:00"">
      <introsong band=""Dave Matthews Band"" wpband=""Dave Matthews Band"" song=""Crash into Me"" wpsong=""Crash into Me"" />
      <outrosong band=""The Devotchkas"" wpband=""The Devotchkas"" song=""Live Fast, Die Young"" />
      <reviewed name=""Burnout: Paradise"" wpname=""Burnout Paradise"" />
      <teaser>This week on Zero Punctuation, Yahtzee takes Burnout: Paradise for a spin.</teaser>
    </Episode>
    <Episode name=""Turok"" number=""33"" length=""237"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/30-Turok"" originalname=""Turok"" ytlink=""https://www.youtube.com/watch?v=Fh1n-TuJTQo"" date=""2008-03-19T16:03:00"">
      <introsong band=""John Williams"" wpband=""John Williams"" song=""Theme from Jurassic Park"" wpsong=""Jurassic Park (film score)"" />
      <outrosong band=""Social Distortion"" wpband=""Social Distortion"" song=""Through These Eyes"" />
      <reviewed name=""Turok"" wpname=""Turok (video game)"" />
      <teaser>This week on Zero Punctuation, Yahtzee goes dinosaur hunting, with Turok.</teaser>
    </Episode>
    <Episode name=""Zack &amp; Wiki: Quest for Barbaros' Treasure"" number=""34"" length=""229"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/31-Zack-Wiki-Quest-for-Barbaros-Treasure"" originalname=""Zack &amp; Wiki: Quest for Barbaros' Treasure"" ytlink=""https://www.youtube.com/watch?v=oRMPJfberWc"" date=""2008-03-26T16:01:00"">
      <introsong band=""Tom Edmundson"" song=""Captain Pugwash Theme"" wpsong=""Captain Pugwash"" />
      <outrosong band=""The Rolling Stones"" wpband=""The Rolling Stones"" song=""Beast of Burden"" wpsong=""Beast of Burden (song)"" />
      <reviewed name=""Zack &amp; Wiki: Quest for Barbaros' Treasure"" wpname=""Zack &amp; Wiki: Quest for Barbaros' Treasure"" />
      <teaser>This week on Zero Punctuation, Zack &amp; Wiki and a whole lot of dongs.</teaser>
    </Episode>
    <Episode name=""Army of Two"" number=""35"" length=""235"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/32-Army-of-Two"" originalname=""Army of Two"" ytlink=""https://www.youtube.com/watch?v=uvaryF1EhfA"" date=""2008-04-02T16:08:00"">
      <introsong band=""Rolf Harris"" wpband=""Rolf Harris"" song=""Two Little Boys"" wpsong=""Two Little Boys"" />
      <outrosong band=""Queen"" wpband=""Queen (band)"" song=""Youre My Best Friend"" wpsong=""Youre My Best Friend (Queen song)"" />
      <reviewed name=""Army of Two"" wpname=""Army of Two"" />
      <teaser>This week on Zero Punctuation, Yahtzee tries to cut down on the gay jokes while reviewing Army of Two.</teaser>
    </Episode>
    <Episode name=""No More Heroes"" number=""36"" length=""235"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/33-No-More-Heroes"" originalname=""No More Heroes"" ytlink=""https://www.youtube.com/watch?v=BOW8SzPcUeY"" date=""2008-04-09T15:59:00"">
      <introsong band=""The Stranglers"" wpband=""The Stranglers"" song=""No More Heroes"" wpsong=""No More Heroes (The Stranglers song)"" />
      <outrosong band=""Muse"" wpband=""Muse (band)"" song=""Assassin"" wpsong=""Assassin (Muse song)"" />
      <reviewed name=""No More Heroes"" wpname=""No More Heroes (video game)"" />
      <teaser>This week on Zero Punctuation, Yahtzee reviews No More Heroes.</teaser>
    </Episode>
    <Episode name=""Condemned 2: Bloodshot"" number=""37"" length=""276"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/34-Condemned-2-Bloodshot"" originalname=""Condemned 2: Bloodshot"" ytlink=""https://www.youtube.com/watch?v=P7MYcR7wdz4"" date=""2008-04-16T16:09:00"">
      <introsong band=""The Specials"" wpband=""The Specials"" song=""Ghost Town"" wpsong=""Ghost Town (song)"" />
      <outrosong band=""Ian Dury and The Blockheads"" wpband=""The Blockheads"" song=""Hit Me With Your Rhythm Stick"" wpsong=""Hit Me with Your Rhythm Stick"" />
      <reviewed name=""Condemned 2: Bloodshot"" wpname=""Condemned 2: Bloodshot"" />
      <teaser>This week on Zero Punctuation, Condemned 2: Bloodshot and the phrase ""errant turds.""</teaser>
    </Episode>
    <Episode name=""Super Smash Bros. Brawl"" number=""38"" length=""260"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/35-Super-Smash-Bros-Brawl"" originalname=""Super Smash Bros. Brawl"" ytlink=""https://www.youtube.com/watch?v=Vk0MGPjWbtE"" date=""2008-04-23T16:03:00"">
      <introsong band=""Survivor"" wpband=""Survivor (band)"" song=""Eye of the Tiger"" wpsong=""Eye of the Tiger"" />
      <outrosong band=""Green Day"" wpband=""Green Day"" song=""Minority"" wpsong=""Minority (Green Day song)"" />
      <reviewed name=""Super Smash Bros. Brawl"" wpname=""Super Smash Bros. Brawl"" />
      <teaser>This week on Zero Punctuation, Super Smash Bros. Brawl.</teaser>
    </Episode>
    <Episode name=""God of War: Chains of Olympus"" number=""39"" length=""230"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/36-God-of-War-Chains-of-Olympus"" originalname=""God of War: Chains of Olympus"" ytlink=""https://www.youtube.com/watch?v=8n16i8M3hqE"" date=""2008-04-30T16:09:00"">
      <introsong band=""Stone Sour"" wpband=""Stone Sour"" song=""Kill Everybody"" />
      <outrosong band=""Matchbox Twenty"" wpband=""Matchbox Twenty"" song=""Angry"" />
      <reviewed name=""God of War: Chains of Olympus"" wpname=""God of War: Chains of Olympus"" />
      <teaser>This week on Zero Punctuation, God of War: Chains of Olympus.</teaser>
    </Episode>
    <Episode name=""Mailbag Showdown"" number=""40"" length=""278"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/37-Mailbag-Showdown"" originalname=""Mailbag Showdown"" ytlink=""https://www.youtube.com/watch?v=mv04aKBhZ9U"" date=""2008-05-07T16:00:00"">
      <introsong band=""The Marvelettes"" wpband=""The Marvelettes"" song=""Please Mr. Postman"" wpsong=""Please Mr. Postman"" />
      <outrosong band=""The Proclaimers"" wpband=""The Proclaimers"" song=""Letter from America"" wpsong=""Letter from America (song)"" />
      <teaser>This week Yahtzee turns the angry, yellow eye on you, the viewer. Particularly those of you who have sent him email crying about the Super Smash Bros. Brawl review.</teaser>
    </Episode>
    <Episode name=""Grand Theft Auto IV"" number=""41"" length=""268"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/48-Grand-Theft-Auto-IV"" originalname=""Grand Theft Auto IV"" ytlink=""https://www.youtube.com/watch?v=5AXeKZBBYvw"" date=""2008-05-14T16:04:00"">
      <introsong band=""Serbian national anthem"" song=""Bože pravde"" wpsong=""Bože pravde"" />
      <outrosong band=""Skid Row"" wpband=""Skid Row (American band)"" song=""18 and Life"" wpsong=""18 and Life"" />
      <reviewed name=""Grand Theft Auto IV"" wpname=""Grand Theft Auto IV"" awardname=""The &quot;Turd in a Chocolate Box&quot; Award for Surprising Poor Quality"" awardepisode=""Awards for 2008"" />
      <teaser>This week, Grand Theft Auto IV.</teaser>
    </Episode>
    <Episode name=""Painkiller"" number=""42"" length=""244"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57-Painkiller"" originalname=""Painkiller"" ytlink=""https://www.youtube.com/watch?v=qk7DlYcQ0uM"" date=""2008-05-21T17:54:00"">
      <introsong band=""Led Zeppelin"" wpband=""Led Zeppelin"" song=""Stairway to Heaven"" wpsong=""Stairway to Heaven"" />
      <outrosong band=""King Missile"" wpband=""King Missile"" song=""Detachable Penis"" wpsong=""Detachable Penis"" />
      <reviewed name=""Painkiller"" wpname=""Painkiller (video game)"" />
      <teaser>This week, a Painkiller retrospective.</teaser>
    </Episode>
    <Episode name=""The World Ends With You"" number=""43"" length=""254"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/67-The-World-Ends-With-You"" originalname=""The World Ends With You"" ytlink=""https://www.youtube.com/watch?v=Vtu0_wwMtgg"" date=""2008-05-28T16:00:00"">
      <introsong band=""The Kinks"" wpband=""The Kinks"" song=""Dedicated Follower of Fashion"" wpsong=""Dedicated Follower of Fashion"" />
      <outrosong band=""R.E.M."" wpband=""R.E.M."" song=""Its the End of the World as We Know It (And I Feel Fine)"" wpsong=""Its the End of the World as We Know It (And I Feel Fine)"" />
      <reviewed name=""The World Ends With You"" wpname=""The World Ends with You"" />
      <teaser>This week, Yahtzee tempts fate and risks insanity by reviewing a JRPG.</teaser>
    </Episode>
    <Episode name=""The Elder Scrolls IV: Oblivion"" number=""44"" length=""278"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/75-Oblivion"" originalname=""Oblivion"" ytlink=""https://www.youtube.com/watch?v=qvz3ANcAvSc"" date=""2008-06-04T15:23:00"">
      <introsong band=""The Kinks"" wpband=""The Kinks"" song=""The Village Green Preservation Society"" />
      <outrosong band=""Supertramp"" wpband=""Supertramp"" song=""Its Raining Again"" wpsong=""Its Raining Again"" />
      <reviewed name=""The Elder Scrolls IV: Oblivion"" wpname=""The Elder Scrolls IV: Oblivion"" />
      <teaser>Hold on tight - Yahtzee is reviewing an RPG.</teaser>
    </Episode>
    <Episode name=""Haze"" number=""45"" length=""224"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/93-Haze"" originalname=""Haze"" ytlink=""https://www.youtube.com/watch?v=DvJ-wegyQNk"" date=""2008-06-18T16:03:00"">
      <introsong band=""Afroman"" wpband=""Afroman"" song=""Because I Got High"" wpsong=""Because I Got High (song)"" />
      <outrosong band=""White Rose Movement"" wpband=""White Rose Movement"" song=""Idiot Drugs"" />
      <reviewed name=""Haze"" wpname=""Haze (video game)"" />
      <teaser>Drug-addled mercenaries wearing glowing power armor trudging through the jungle with guns. What could possibly go wrong?</teaser>
    </Episode>
    <Episode name=""Metal Gear Solid 4"" number=""46"" length=""264"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/99-Metal-Gear-Solid-4"" originalname=""Metal Gear Solid 4"" ytlink=""https://www.youtube.com/watch?v=W3vPq047-8s"" date=""2008-06-25T16:09:00"">
      <introsong band=""Lenny Kravitz"" wpband=""Lenny Kravitz"" song=""Confused"" />
      <outrosong band=""Robbie Williams"" wpband=""Robbie Williams"" song=""Old Before I Die"" wpsong=""Old Before I Die"" />
      <reviewed name=""Metal Gear Solid 4: Guns of the Patriots"" wpname=""Metal Gear Solid 4: Guns of the Patriots"" awardname=""The &quot;Indiana Jones in a Fridge&quot; Award for Franchise Murder"" awardepisode=""Awards for 2008"" />
      <teaser>Yahtzee reviews Metal Gear Solid 4: Guns of the Patriots: Tactical Espionage Action.</teaser>
    </Episode>
    <Episode name=""Webcomics"" number=""47"" length=""261"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/108-Webcomics"" originalname=""Webcomics"" ytlink=""https://www.youtube.com/watch?v=5t4xS2PqFFA"" date=""2008-07-02T16:00:00"">
      <introsong band=""The J. Geils Band"" wpband=""The J. Geils Band"" song=""Centerfold"" wpsong=""Centerfold (song)"" />
      <outrosong band=""Status Quo"" wpband=""Status Quo (band)"" song=""Pictures of Matchstick Men"" wpsong=""Pictures of Matchstick Men"" />
      <teaser>This week, Yahtzee takes apart the making of a successful gaming webcomic, or: how to make millions of gamers happy with the minimum amount of effort.</teaser>
    </Episode>
    <Episode name=""Lego Indiana Jones: The Original Adventures"" number=""48"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/123-LEGO-Indy"" originalname=""LEGO Indy"" ytlink=""https://www.youtube.com/watch?v=JvCyPTrnVrY"" date=""2008-07-09T15:55:00"">
      <reviewed name=""Lego Indiana Jones: The Original Adventures"" wpname=""Lego Indiana Jones: The Original Adventures"" />
      <teaser>This week, Yahtzee plays with LEGOs and re-lives childhood horrors about Indiana Jones.</teaser>
    </Episode>
    <Episode name=""Alone in the Dark"" number=""49"" length=""309"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/130-Alone-in-the-Dark"" originalname=""Alone in the Dark"" ytlink=""https://www.youtube.com/watch?v=VtK7HdsH_ZU"" date=""2008-07-16T15:59:00"">
      <reviewed name=""Alone in the Dark"" wpname=""Alone in the Dark (2008 video game)"" />
      <teaser>Yahtzee reviews Alone in the Dark while surprisingly neither alone nor in the dark.</teaser>
    </Episode>
    <Episode name=""Age of Conan: Hyborian Adventures"" number=""50"" length=""281"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/138-Age-of-Conan"" originalname=""Age of Conan"" ytlink=""https://www.youtube.com/watch?v=1hAwxS4kXJE"" date=""2008-07-23T16:05:00"">
      <reviewed name=""Age of Conan"" wpname=""Age of Conan"" />
      <teaser>This week, Yahtzee dons the loincloth and fuzzy, horned hat to review Age of Conan.</teaser>
    </Episode>
    <Episode name=""The E3 Trailer Park"" number=""51"" length=""281"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/157-The-E3-Trailer-Park"" originalname=""The E3 Trailer Park"" ytlink=""https://www.youtube.com/watch?v=3wdfFuO3Rqs"" date=""2008-07-30T16:00:00"">
      <teaser>Yahtzee gives a rundown on the biggest titles and announcements from E3 2008.</teaser>
    </Episode>
    <Episode name=""Ninja Gaiden II"" number=""52"" length=""272"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/175-Ninja-Gaiden-2"" originalname=""Ninja Gaiden 2"" ytlink=""https://www.youtube.com/watch?v=z4heiQC6RxA"" date=""2008-08-06T16:03:00"">
      <reviewed name=""Ninja Gaiden 2"" wpname=""Ninja Gaiden II"" />
      <teaser>This week, Yahtzee unravels the mystery of the Ninja. Well, at least the mystery of Ninja Gaiden 2.</teaser>
    </Episode>
    <Episode name=""Prince of Persia Retrospective"" number=""53"" length=""301"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/183-Prince-of-Persia-Retrospective"" originalname=""Prince of Persia Retrospective"" ytlink=""https://www.youtube.com/watch?v=Hyoy1aRprsY"" date=""2008-08-13T16:03:00"">
      <reviewed name=""Prince of Persia 3D"" wpname=""Prince of Persia 3D"" />
      <reviewed name=""Prince of Persia: The Sands of Time"" wpname=""Prince of Persia: The Sands of Time"" />
      <reviewed name=""Prince of Persia: Warrior Within"" wpname=""Prince of Persia: Warrior Within"" />
      <reviewed name=""Prince of Persia: The Two Thrones"" wpname=""Prince of Persia: The Two Thrones"" />
      <teaser>Yahtzee takes the time to explain his remarks about the awesomeness of the Prince of Persia series.</teaser>
    </Episode>
    <Episode name=""Soulcalibur IV"" number=""54"" length=""283"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/189-Soul-Calibur-IV"" originalname=""Soul Calibur IV"" ytlink=""https://www.youtube.com/watch?v=ebdjnuAYotc"" date=""2008-08-20T16:03:00"">
      <reviewed name=""Soul Calibur IV"" wpname=""Soulcalibur IV"" />
      <teaser>It's hard to hate fighting games. For Yahtzee, it's also hard to like them.</teaser>
    </Episode>
    <Episode name=""Braid"" number=""55"" length=""266"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/203-Braid"" originalname=""Braid"" ytlink=""https://www.youtube.com/watch?v=ggLqL61z-I4"" date=""2008-08-27T15:57:00"">
      <reviewed name=""Braid"" wpname=""Braid (video game)"" />
      <teaser>Yahtzee takes on Braid, the long-awaited indie darling finally available on Xbox Live.</teaser>
    </Episode>
    <Episode name=""EVE Online"" number=""56"" length=""279"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/208-Eve-Online"" originalname=""Eve Online"" ytlink=""https://www.youtube.com/watch?v=VMK8ID4RLZQ"" date=""2008-09-03T16:08:00"">
      <reviewed name=""Eve Online"" wpname=""Eve Online"" />
      <teaser>This week, Yahtzee hits the final frontier in search of a truly different MMO. Instead, he finds Eve.</teaser>
    </Episode>
    <Episode name=""Too Human"" number=""57"" length=""281"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/213-Too-Human"" originalname=""Too Human"" ytlink=""https://www.youtube.com/watch?v=z6gbXInzO-g"" date=""2008-09-10T16:00:00"">
      <reviewed name=""Too Human"" wpname=""Too Human"" />
      <teaser>This week, Zero Punctuation dies and is resurrected - over and over and over - in Too Human.</teaser>
    </Episode>
    <Episode name=""Spore"" number=""58"" length=""270"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/218-Spore"" originalname=""Spore"" ytlink=""https://www.youtube.com/watch?v=34no2HhOVGQ"" date=""2008-09-17T15:58:00"">
      <reviewed name=""Spore"" wpname=""Spore (2008 video game)"" />
      <teaser>This week Zero Punctuation reviews Spore.</teaser>
    </Episode>
    <Episode name=""XBLA Double Bill"" number=""59"" length=""284"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/222-XBLA-Double-Bill"" originalname=""XBLA Double Bill"" ytlink=""https://www.youtube.com/watch?v=bZvMzyDbidc"" date=""2008-09-24T16:01:00"">
      <reviewed name=""Bionic Commando: Rearmed"" wpname=""Bionic Commando Rearmed"" />
      <reviewed name=""Castle Crashers"" wpname=""Castle Crashers"" />
      <teaser>Yahtzee reviews Bionic Commando: Rearmed, Castle Crashers, and the retro games in general.</teaser>
    </Episode>
    <Episode name=""Mercenaries 2: World in Flames"" number=""60"" length=""286"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/231-Mercenaries-2"" originalname=""Mercenaries 2"" ytlink=""https://www.youtube.com/watch?v=VwvR-B2xKrs"" date=""2008-10-01T16:15:00"">
      <reviewed name=""Mercenaries 2: World in Flames"" wpname=""Mercenaries 2: World in Flames"" />
      <teaser>This week Zero Punctuation blows stuff up for money.</teaser>
    </Episode>
    <Episode name=""Star Wars: The Force Unleashed"" number=""61"" length=""291"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/251-Star-Wars-The-Force-Unleashed"" originalname=""Star Wars: The Force Unleashed"" ytlink=""https://www.youtube.com/watch?v=6ll-_rxky2k"" date=""2008-10-08T16:01:00"">
      <reviewed name=""Star Wars: The Force Unleashed"" wpname=""Star Wars: The Force Unleashed"" />
      <teaser>This week Zero Punctuation pushes around hapless Stormtroopers in Star Wars: The Force Unleashed.</teaser>
    </Episode>
    <Episode name=""S.T.A.L.K.E.R.: Clear Sky"" number=""62"" length=""288"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/271-S-T-A-L-K-E-R-Clear-Sky"" originalname=""S.T.A.L.K.E.R.: Clear Sky"" ytlink=""https://www.youtube.com/watch?v=BHDGQtu5hB4"" date=""2008-10-15T16:03:00"">
      <reviewed name=""S.T.A.L.K.E.R.: Clear Sky"" wpname=""S.T.A.L.K.E.R.: Clear Sky"" />
      <teaser>This week Zero Punctuation goes in the zone to nuke S.T.A.L.K.E.R.: Clear Sky.</teaser>
    </Episode>
    <Episode name=""Silent Hill: Homecoming"" number=""63"" length=""434"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/284-Silent-Hill-Homecoming"" originalname=""Silent Hill Homecoming"" ytlink=""https://www.youtube.com/watch?v=GpmgP9DcOU8"" date=""2008-10-22T16:01:00"">
      <reviewed name=""Silent Hill Homecoming"" wpname=""Silent Hill: Homecoming"" />
      <teaser>This week Yahtzee's ass remains safe while he reviews Silent Hill Homecoming.</teaser>
    </Episode>
    <Episode name=""Saints Row 2"" number=""64"" length=""283"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/312-Saints-Row-2"" originalname=""Saints Row 2"" ytlink=""https://www.youtube.com/watch?v=pWXuzZ26yp0"" date=""2008-10-29T16:01:00"">
      <reviewed name=""Saints Row 2"" wpname=""Saints Row 2"" awardname=""The &quot;Copulating Jelly Baby&quot; Award for Fucking Sweet Game"" awardepisode=""Awards for 2008"" />
      <teaser>Zero Punctuation reviews this week's sandbox crime game, Saints Row 2.</teaser>
    </Episode>
    <Episode name=""Dead Space"" number=""65"" length=""279"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/333-Dead-Space"" originalname=""Dead Space"" ytlink=""https://www.youtube.com/watch?v=b5GFyIHhpgg"" date=""2008-11-05T16:01:00"">
      <reviewed name=""Dead Space"" wpname=""Dead Space (2008 video game)"" />
      <teaser>This week Zero Punctuation explores the USS Kill Beast Buffet and reviews Dead Space.</teaser>
    </Episode>
    <Episode name=""Fable II"" number=""66"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/346-Fable-2"" originalname=""Fable 2"" ytlink=""https://www.youtube.com/watch?v=pLXOp0bHDOs"" date=""2008-11-12T16:03:00"">
      <reviewed name=""Fable 2"" wpname=""Fable II"" />
      <teaser>This week Zero Punctuation reviews Peter Molyneux's latest action rpg adventure, Fable 2.</teaser>
    </Episode>
    <Episode name=""Fallout 3"" number=""67"" length=""265"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/420-Fallout-3"" originalname=""Fallout 3"" ytlink=""https://www.youtube.com/watch?v=BJiSuztcwL4"" date=""2008-11-19T16:01:00"">
      <reviewed name=""Fallout 3"" wpname=""Fallout 3"" />
      <teaser>This week Zero Punctuation wanders the post-apocalyptic wasteland in Fallout 3.</teaser>
    </Episode>
    <Episode name=""Guitar Hero: World Tour"" number=""68"" length=""332"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/452-Guitar-Hero-World-Tour"" originalname=""Guitar Hero World Tour"" ytlink=""https://www.youtube.com/watch?v=3PBaGj2jpkA"" date=""2008-11-26T16:01:00"">
      <reviewed name=""Guitar Hero World Tour"" wpname=""Guitar Hero World Tour"" />
      <teaser>This week, will Zero Punctuation's rock star fantasies be fulfilled with Guitar Hero World Tour?</teaser>
    </Episode>
    <Episode name=""Mirror's Edge"" number=""69"" length=""269"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/457-Mirrors-Edge"" originalname=""Mirror's Edge"" ytlink=""https://www.youtube.com/watch?v=MqTreOK5YUQ"" date=""2008-12-03T16:01:00"">
      <reviewed name=""Mirror's Edge"" wpname=""Mirror's Edge"" />
      <teaser>This week Zero Punctuation reviews Mirror's Edge.</teaser>
    </Episode>
    <Episode name=""Left 4 Dead"" number=""70"" length=""255"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/459-Left-4-Dead"" originalname=""Left 4 Dead"" ytlink=""https://www.youtube.com/watch?v=uLNOtLdvSsc"" date=""2008-12-10T16:00:00"">
      <reviewed name=""Left 4 Dead"" wpname=""Left 4 Dead"" />
      <teaser>This week Zero Punctuation dines on the finest brains Valve has to offer in Left 4 Dead.</teaser>
    </Episode>
    <Episode name=""Sonic Unleashed"" number=""71"" length=""347"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/472-Sonic-Unleashed"" originalname=""Sonic Unleashed"" ytlink=""https://www.youtube.com/watch?v=UM28uXIkPWk"" date=""2008-12-17T16:01:00"">
      <reviewed name=""Sonic Unleashed"" wpname=""Sonic Unleashed"" awardname=""The &quot;Turd in a Turd&quot; Award for Unsurprising Poor Quality"" awardepisode=""Awards for 2008"" />
      <teaser>Zero Punctuation review Sonic Unleashed in order to unwind during this stressful Christmas period.</teaser>
    </Episode>
    <Episode name=""The Year in Review - 2008"" number=""72"" length=""258"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/476-The-Year-in-Review-2008"" originalname=""The Year in Review - 2008"" ytlink=""https://www.youtube.com/watch?v=W1QU2Vao0Jo"" date=""2008-12-24T16:01:00"">
      <teaser>This week, a series of our favorite Zero Punctuation jokes. Sorry for the clip show, but we'll make it up to you with a contest for a shiny new badge!</teaser>
    </Episode>
    <Episode name=""Prince of Persia"" number=""73"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/482-Prince-of-Persia"" originalname=""Prince of Persia"" ytlink=""https://www.youtube.com/watch?v=F2XQUzKsxNg"" date=""2008-12-31T16:01:00"">
      <reviewed name=""Prince of Persia"" wpname=""Prince of Persia (2008 video game)"" awardname=""The &quot;Proximity to Jason Voorhees&quot; Award for Stupidest Main Character"" awardepisode=""Awards for 2008"" />
      <teaser>This week Zero Punctuation reviews Ubisoft's latest addition to the Prince of Persia series.</teaser>
    </Episode>
    <Episode name=""Awards for 2008"" number=""74"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/486-Awards-for-2008"" originalname=""Awards for 2008"" ytlink=""https://www.youtube.com/watch?v=jDC2pI1lMcY"" date=""2009-01-07T16:01:00"">
      <teaser>This week Yahtzee gives out his game awards for 2008.</teaser>
    </Episode>
    <Episode name=""Tomb Raider: Underworld"" number=""75"" length=""280"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/502-Tomb-Raider-Underworld"" originalname=""Tomb Raider: Underworld"" ytlink=""https://www.youtube.com/watch?v=ESl6t7Or-z8"" date=""2009-01-14T16:01:00"">
      <reviewed name=""Tomb Raider: Underworld"" wpname=""Tomb Raider: Underworld"" awardname=""The &quot;Attention Deficit&quot; Award for Games I Haven't Reviewed Yet"" awardepisode=""Awards for 2008"" />
      <teaser>This week Zero Punctuation gives the old girl another chance and reviews Tomb Raider: Underworld.</teaser>
    </Episode>
    <Episode name=""Far Cry 2"" number=""76"" length=""296"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/510-Far-Cry-2"" originalname=""Far Cry 2"" ytlink=""https://www.youtube.com/watch?v=LsY7vLqIi-c"" date=""2009-01-21T16:00:00"">
      <reviewed name=""Far Cry 2"" wpname=""Far Cry 2"" awardname=""The &quot;Attention Deficit&quot; Award for Games I Haven't Reviewed Yet"" awardepisode=""Awards for 2008"" />
      <teaser>This week Zero Punctuation travels to Fictionesia, Africa for Far Cry 2.</teaser>
    </Episode>
    <Episode name=""Gears of War 2"" number=""77"" length=""292"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/525-Gears-of-War-2"" originalname=""Gears of War 2"" ytlink=""https://www.youtube.com/watch?v=v4rQSykog5Y"" date=""2009-01-28T16:01:00"">
      <reviewed name=""Gears of War 2"" wpname=""Gears of War 2"" awardname=""The &quot;Attention Deficit&quot; Award for Games I Haven't Reviewed Yet"" awardepisode=""Awards for 2008"" />
      <teaser>This week Zero Punctuation reviews Gears of War 2, but only for all you big manly men.</teaser>
    </Episode>
    <Episode name=""LittleBigPlanet"" number=""78"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/530-Little-Big-Planet"" originalname=""Little Big Planet"" ytlink=""https://www.youtube.com/watch?v=_ik61qj_G04"" date=""2009-02-04T16:01:00"">
      <reviewed name=""Little Big Planet"" wpname=""LittleBigPlanet (2009 video game)"" />
      <teaser>This week Zero Punctuation reviews Little Big Planet.</teaser>
    </Episode>
    <Episode name=""Thief: The Dark Project"" number=""79"" length=""279"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/544-Thief-The-Dark-Project"" originalname=""Thief: The Dark Project"" ytlink=""https://www.youtube.com/watch?v=BQqcFtvFtno"" date=""2009-02-11T16:01:00"">
      <reviewed name=""Thief: The Dark Project"" wpname=""Thief: The Dark Project"" />
      <teaser>This week Zero Punctuation has to be a sneaky bastard in order to review Thief: The Dark Project.</teaser>
    </Episode>
    <Episode name=""Skate 2"" number=""80"" length=""294"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/553-Skate-2"" originalname=""Skate 2"" ytlink=""https://www.youtube.com/watch?v=uLQogkaPUpg"" date=""2009-02-18T16:01:00"">
      <reviewed name=""Skate 2"" wpname=""Skate 2"" />
      <teaser>This week Zero Punctuation breaks a few bones to review Skate 2.</teaser>
    </Episode>
    <Episode name=""F.E.A.R. 2"" number=""81"" length=""289"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/565-Fear-2"" originalname=""Fear 2"" ytlink=""https://www.youtube.com/watch?v=4ncBtYuoO_w"" date=""2009-02-25T16:00:00"">
      <reviewed name=""F.E.A.R. 2: Project Origin"" wpname=""F.E.A.R. 2: Project Origin"" />
      <teaser>Bullet time, scary little girls and quick time events. What's not to love about this week's Zero Punctuation review of Fear 2?</teaser>
    </Episode>
    <Episode name=""Spider-Man: Web of Shadows"" number=""82"" length=""290"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/584-Spiderman-Web-of-Shadows"" originalname=""Spiderman: Web of Shadows"" ytlink=""https://www.youtube.com/watch?v=ngjDggdB9J4"" date=""2009-03-04T16:00:00"">
      <reviewed name=""Spiderman: Web of Shadows"" wpname=""Spider-Man: Web of Shadows"" />
      <teaser>This week Zero Punctuation reviews Spiderman's latest web swinging adventure, Spiderman: Web of Shadows.</teaser>
    </Episode>
    <Episode name=""The House of the Dead: Overkill"" number=""83"" length=""281"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/600-House-of-the-Dead-Overkill"" originalname=""House of the Dead: Overkill"" ytlink=""https://www.youtube.com/watch?v=XKRrPQAbic4"" date=""2009-03-11T16:00:00"">
      <reviewed name=""The House of the Dead: Overkill"" wpname=""The House of the Dead: Overkill"" />
      <reviewed name=""Killzone 2"" wpname=""Killzone 2"" />
      <teaser>This week, House of the Dead: Overkill versus Killzone 2. Place your bets.</teaser>
    </Episode>
    <Episode name=""50 Cent: Blood on the Sand"" number=""84"" length=""296"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/616-50-Cent-Blood-on-the-Sand"" originalname=""50 Cent: Blood on the Sand"" ytlink=""https://www.youtube.com/watch?v=EI1hXU6R3IQ"" date=""2009-03-18T16:00:00"">
      <reviewed name=""50 Cent: Blood on the Sand"" wpname=""50 Cent: Blood on the Sand"" />
      <teaser>This week Zero Punctuation reviews a rapper shooting up the Middle East to find his prized jeweled skull in 50 Cent: Blood on the Sand.</teaser>
    </Episode>
    <Episode name=""Resident Evil 5"" number=""85"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/624-Resident-Evil-5"" originalname=""Resident Evil 5"" ytlink=""https://www.youtube.com/watch?v=VxmvKj3SJGw"" date=""2009-03-25T16:00:00"">
      <reviewed name=""Resident Evil 5"" wpname=""Resident Evil 5"" awardname=""The Razor Blade Filled Vagina Award for Fastest Reversal of Fortune"" awardepisode=""Awards for 2009"">
        <seealso>Heavenly Sword and Other Stuff</seealso>
      </reviewed>
      <reviewed name=""Resident Evil 4"" wpname=""Resident Evil 4"" />
      <teaser>This week, Zero Punctuation reviews Resident Evil 5.</teaser>
    </Episode>
    <Episode name=""X-Blades/Halo Wars"" number=""86"" length=""454"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/645-Halo-Wars"" originalname=""Halo Wars"" ytlink=""https://www.youtube.com/watch?v=P6JNqMjouNc"" date=""2009-04-01T16:00:00"">
      <reviewed name=""X-Blades"" wpname=""X-Blades"" />
      <reviewed name=""Halo Wars"" wpname=""Halo Wars"" />
      <teaser>This week, Zero Punctuation reviews Halo Wars and Unskippable guest reviews X-Blades. See Yahtzee's crossover appearance in Unskippable: Star Ocean.</teaser>
    </Episode>
    <Episode name=""Grand Theft Auto: Chinatown Wars"" number=""87"" length=""302"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/657-Grand-Theft-Auto-Chinatown-Wars"" originalname=""Grand Theft Auto: Chinatown Wars"" date=""2009-04-08T16:00:00"">
      <reviewed name=""Grand Theft Auto: Chinatown Wars"" wpname=""Grand Theft Auto: Chinatown Wars"" />
      <teaser>This week, Zero Punctuation reviews Grand Theft Auto: Chinatown Wars.</teaser>
    </Episode>
    <Episode name=""MadWorld"" number=""88"" length=""287"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/673-MadWorld"" originalname=""MadWorld"" ytlink=""https://www.youtube.com/watch?v=ResWBN47PGk"" date=""2009-04-15T16:00:00"">
      <reviewed name=""MadWorld"" wpname=""MadWorld"" />
      <teaser>This week, Zero Punctuation reviews MadWorld.</teaser>
    </Episode>
    <Episode name=""Tom Clancy's H.A.W.X"" number=""89"" length=""291"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/689-Tom-Clancys-H-A-W-X"" originalname=""Tom Clancy's H.A.W.X."" ytlink=""https://www.youtube.com/watch?v=XSuqCI8VFWE"" date=""2009-04-22T16:00:00"">
      <reviewed name=""Tom Clancy's H.A.W.X."" wpname=""Tom Clancy's H.A.W.X"" />
      <teaser>This week, Zero Punctuation reviews Tom Clancy's H.A.W.X.</teaser>
    </Episode>
    <Episode name=""Siren: Blood Curse"" number=""90"" length=""287"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/696-Siren-Blood-Curse"" originalname=""Siren Blood Curse"" ytlink=""https://www.youtube.com/watch?v=9JNvRes8kec"" date=""2009-04-29T16:00:00"">
      <reviewed name=""Siren Blood Curse"" wpname=""Siren: Blood Curse"" />
      <teaser>This week, Zero Punctuation reviews Siren Blood Curse.</teaser>
    </Episode>
    <Episode name=""The Chronicles of Riddick: Assault on Dark Athena"" number=""91"" length=""267"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/714-The-Chronicles-of-Riddick-Assault-on-Dark-Athena"" originalname=""The Chronicles of Riddick: Assault on Dark Athena"" ytlink=""https://www.youtube.com/watch?v=brOZoC30oPY"" date=""2009-05-06T16:00:00"">
      <reviewed name=""The Chronicles of Riddick: Assault on Dark Athena"" wpname=""The Chronicles of Riddick: Assault on Dark Athena"" />
      <teaser>This week, Zero Punctuation reviews The Chronicles of Riddick: Assault on Dark Athena.</teaser>
    </Episode>
    <Episode name=""Valkyria Chronicles"" number=""92"" length=""285"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/724-Valkyria-Chronicles"" originalname=""Valkyria Chronicles"" ytlink=""https://www.youtube.com/watch?v=awxuj9bTJrc"" date=""2009-05-13T16:00:00"">
      <reviewed name=""Valkyria Chronicles"" wpname=""Valkyria Chronicles"" />
      <teaser>This week, Zero Punctuation reviews Valkryia Chronicles.</teaser>
    </Episode>
    <Episode name=""Velvet Assassin"" number=""93"" length=""272"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/739-Velvet-Assassin"" originalname=""Velvet Assassin"" ytlink=""https://www.youtube.com/watch?v=6TsIMHvugV8"" date=""2009-05-20T16:01:00"">
      <reviewed name=""Velvet Assassin"" wpname=""Velvet Assassin"" />
      <teaser>This week, Zero Punctuation reviews Velvet Assassin.</teaser>
    </Episode>
    <Episode name=""Duke Nukem Forever"" number=""94"" length=""274"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/748-Duke-Nukem-Forever"" originalname=""Duke Nukem Forever"" ytlink=""https://www.youtube.com/watch?v=kj-O-FnpGjQ"" date=""2009-05-27T16:00:00"">
      <reissue date=""2010-09-01T00:00:00"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1968-Viewers-Choice-Duke-Nukem-Forever"" ytlink=""https://www.youtube.com/watch?v=kx1fglFeX7k"" />
      <reviewed name=""Duke Nukem Forever"" wpname=""Duke Nukem Forever"" awardname=""Second Worst of 2011"" awardepisode=""Top 5 of 2011"">
        <seealso>Duke Nukem Forever (for real this time)</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Duke Nukem Forever.</teaser>
    </Episode>
    <Episode name=""Bionic Commando"" number=""95"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/759-Bionic-Commando"" originalname=""Bionic Commando"" ytlink=""https://www.youtube.com/watch?v=b4dspwogDzw"" date=""2009-06-03T16:00:00"">
      <reviewed name=""Bionic Commando"" wpname=""Bionic Commando (2009 video game)"" />
      <teaser>This week, Zero Punctuation reviews Bionic Commando.</teaser>
    </Episode>
    <Episode name=""InFamous"" number=""96"" length=""260"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/767-inFamous"" originalname=""inFamous"" ytlink=""https://www.youtube.com/watch?v=iShzMnR7-qo"" date=""2009-06-10T16:00:00"">
      <reviewed name=""inFamous"" wpname=""Infamous (video game)"">
        <seealso>Prototype</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews inFamous.</teaser>
    </Episode>
    <Episode name=""The Second Annual E3 Hype Massacre"" number=""97"" length=""265"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/779-The-Second-Annual-E3-Hype-Massacre"" originalname=""The Second Annual E3 Hype Massacre"" ytlink=""https://www.youtube.com/watch?v=TxdPduFWP2c"" date=""2009-06-17T16:00:00"">
      <teaser>This week, Zero Punctuation shares some thoughts on games hyped at E3 2009.</teaser>
    </Episode>
    <Episode name=""Prototype"" number=""98"" length=""270"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/789-Prototype"" originalname=""Prototype"" ytlink=""https://www.youtube.com/watch?v=bpx3SDsnfYY"" date=""2009-06-24T16:00:00"">
      <reviewed name=""Prototype"" wpname=""Prototype (video game)"" />
      <reviewed name=""inFamous"" wpname=""Infamous (video game)"">
        <seealso>InFamous</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Prototype in a head-to-head cage match against inFamous.</teaser>
    </Episode>
    <Episode name=""The Sims 3"" number=""99"" length=""272"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/800-The-Sims-3"" originalname=""The Sims 3"" ytlink=""https://www.youtube.com/watch?v=IAsaFD9MQ8I"" date=""2009-07-01T16:00:00"">
      <extrap title=""Yahtzee's Prototype vs. InFamous Challenge"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6228-Yahtzee-s-Prototype-vs-InFamous-Challenge"" date=""2009-07-03T08:37:00"" />
      <reviewed name=""The Sims 3"" wpname=""The Sims 3"" />
      <teaser>This week, Zero Punctuation reviews The Sims 3.</teaser>
    </Episode>
    <Episode name=""Ghostbusters: The Video Game"" number=""100"" length=""266"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/811-Ghostbusters-The-Video-Game"" originalname=""Ghostbusters: The Video Game"" ytlink=""https://www.youtube.com/watch?v=TzbqiXi645M"" date=""2009-07-08T16:00:00"">
      <reviewed name=""Ghostbusters: The Video Game"" wpname=""Ghostbusters: The Video Game"" />
      <teaser>This week, Zero Punctuation reviews Ghostbusters: The Video Game.</teaser>
    </Episode>
    <Episode name=""Overlord 2"" number=""101"" length=""267"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/822-Overlord-2"" originalname=""Overlord 2"" ytlink=""https://www.youtube.com/watch?v=fqCt55WOfzY"" date=""2009-07-15T16:00:00"">
      <extrap title=""Overlord 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6271-Overlord-2"" date=""2009-07-17T17:00:00"" />
      <reviewed name=""Overlord 2"" wpname=""Overlord II"" />
      <teaser>This week, Zero Punctuation reviews Overlord 2.</teaser>
    </Episode>
    <Episode name=""Red Faction Guerrilla"" number=""102"" length=""267"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/834-Red-Faction-Guerrilla"" originalname=""Red Faction Guerrilla"" ytlink=""https://www.youtube.com/watch?v=rFr9HIEOQBc"" date=""2009-07-22T16:00:00"">
      <extrap title=""Red Faction: Guerilla"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6303-Red-Faction-Guerilla"" date=""2009-07-24T17:30:00"" />
      <reviewed name=""Red Faction Guerrilla"" wpname=""Red Faction: Guerrilla"" />
      <teaser>This week, Zero Punctuation reviews Red Faction Guerrilla.</teaser>
    </Episode>
    <Episode name=""Wii Sports Resort"" number=""103"" length=""255"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/844-Wii-Sports-Resort"" originalname=""Wii Sports Resort"" ytlink=""https://www.youtube.com/watch?v=7L1NoPe4CKM"" date=""2009-07-29T16:00:00"">
      <extrap title=""Wii Sports Resort"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6325-Wii-Sports-Resort"" date=""2009-07-31T17:00:00"" />
      <reviewed name=""Wii Sports Resort"" wpname=""Wii Sports Resort"" />
      <teaser>This week, Zero Punctuation reviews Wii Sports Resort.</teaser>
    </Episode>
    <Episode name=""Call of Juarez: Bound in Blood"" number=""104"" length=""361"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/860-Call-of-Juarez-Bound-in-Blood"" originalname=""Call of Juarez: Bound in Blood"" ytlink=""https://www.youtube.com/watch?v=_w1EFWcTEJo"" date=""2009-08-05T16:00:00"">
      <extrap title=""Call of Juarez: Bound in Blood"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6340-Call-of-Juarez-Bound-in-Blood"" date=""2009-08-07T16:00:00"" />
      <reviewed name=""Call of Juarez: Bound in Blood"" wpname=""Call of Juarez: Bound in Blood"" />
      <teaser>This week, Zero Punctuation reaches 100 videos and reviews Call of Juarez: Bound in Blood.</teaser>
    </Episode>
    <Episode name=""The Conduit"" number=""105"" length=""281"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/869-The-Conduit"" originalname=""The Conduit"" ytlink=""https://www.youtube.com/watch?v=MeyoejMwqiw"" date=""2009-08-12T16:00:00"">
      <extrap title=""The Conduit"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6372-The-Conduit"" date=""2009-08-14T17:00:00"" />
      <reviewed name=""The Conduit"" wpname=""The Conduit"" />
      <teaser>This week, Zero Punctuation reviews The Conduit.</teaser>
    </Episode>
    <Episode name=""Silent Hill 2"" number=""106"" length=""292"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/878-Silent-Hill-2"" originalname=""Silent Hill 2"" ytlink=""https://www.youtube.com/watch?v=7jbhCOCdHUw"" date=""2009-08-19T16:00:00"">
      <extrap title=""Silent Hill 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6400-Silent-Hill-2"" date=""2009-08-21T17:00:00"" />
      <reviewed name=""Silent Hill 2"" wpname=""Silent Hill 2"" />
      <teaser>This week, Zero Punctuation reviews Silent Hill 2.</teaser>
    </Episode>
    <Episode name=""2.5-D Hoedown"" number=""107"" length=""272"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/892-2-5D-Hoedown"" originalname=""2.5D Hoedown"" ytlink=""https://www.youtube.com/watch?v=QecWVgFl2l4"" date=""2009-08-26T16:00:00"">
      <extrap title=""'Splosion Man"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6432-Splosion-Man"" date=""2009-08-28T17:00:00"" />
      <reviewed name=""Trine"" wpname=""Trine (video game)"" />
      <reviewed name=""'Splosion Man"" wpname=""'Splosion Man"" />
      <teaser>This week, Zero Punctuation reviews 'Splosion Man and Trine.</teaser>
    </Episode>
    <Episode name=""Tales of Monkey Island"" number=""108"" length=""265"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/901-Tales-of-Monkey-Island"" originalname=""Tales of Monkey Island"" ytlink=""https://www.youtube.com/watch?v=3eDO57Hf3rs"" date=""2009-09-02T16:00:00"">
      <extrap title=""On Sequels"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6474-On-Sequels"" date=""2009-09-04T17:00:00"" />
      <reviewed name=""Tales of Monkey Island"" wpname=""Tales of Monkey Island"" />
      <teaser>This week, Zero Punctuation reviews Tales of Monkey Island.</teaser>
    </Episode>
    <Episode name=""Wolfenstein"" number=""109"" length=""262"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/916-Wolfenstein"" originalname=""Wolfenstein"" ytlink=""https://www.youtube.com/watch?v=zHnYFP73MKE"" date=""2009-09-09T16:00:00"">
      <extrap title=""On Generic Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6516-On-Generic-Games"" date=""2009-09-11T17:00:00"" />
      <reviewed name=""Wolfenstein"" wpname=""Wolfenstein (2009 video game)"" awardname=""The Quadruple Amputee Kindergarten Award for Least Necessary Sandbox"" awardepisode=""Awards for 2009"" />
      <teaser>This week, Zero Punctuation reviews Wolfenstein.</teaser>
    </Episode>
    <Episode name=""Batman: Arkham Asylum"" number=""110"" length=""288"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/926-Batman-Arkham-Asylum"" originalname=""Batman Arkham Asylum"" ytlink=""https://www.youtube.com/watch?v=zL8SB1YHzFU"" date=""2009-09-16T16:00:00"">
      <extrap title=""Supersoldiers"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6530-Supersoldiers"" date=""2009-09-18T17:00:00"" />
      <reviewed name=""Batman Arkham Asylum"" wpname=""Batman: Arkham Asylum"" awardname=""The Golden Dog Biscuit Award for Genuinely Best Game"" awardepisode=""Awards for 2009"" />
      <teaser>This week, Zero Punctuation reviews Batman Arkham Asylum.</teaser>
    </Episode>
    <Episode name=""Beatles Rock Band &amp; Guitar Hero 5"" number=""111"" length=""282"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/941-Beatles-Rock-Band-and-Guitar-Hero-5"" originalname=""Beatles Rock Band and Guitar Hero 5"" ytlink=""https://www.youtube.com/watch?v=_1X2aAdd2Ao"" date=""2009-09-23T16:00:00"">
      <extrap title=""On the Left 4 Dead Ban"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6549-On-the-Left-4-Dead-Ban"" date=""2009-09-25T17:00:00"" />
      <reviewed name=""The Beatles: Rock Band"" wpname=""The Beatles: Rock Band"" />
      <reviewed name=""Guitar Hero 5"" wpname=""Guitar Hero 5"" />
      <teaser>This week, Zero Punctuation reviews Beatles Rock Band and Guitar Hero 5.</teaser>
    </Episode>
    <Episode name=""Darkest of Days"" number=""112"" length=""293"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/957-Darkest-of-Days"" originalname=""Darkest of Days"" ytlink=""https://www.youtube.com/watch?v=gIT1AoTKASs"" date=""2009-09-30T16:00:00"">
      <extrap title=""On RPG Elements"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6588-On-RPG-Elements"" date=""2009-10-06T17:00:00"" />
      <reviewed name=""Darkest of Days"" wpname=""Darkest of Days"" />
      <teaser>This week, Zero Punctuation reviews Darkest of Days.</teaser>
    </Episode>
    <Episode name=""Scribblenauts"" number=""113"" length=""280"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/969-Scribblenauts"" originalname=""Scribblenauts"" ytlink=""https://www.youtube.com/watch?v=6j_kr1zALJs"" date=""2009-10-07T16:00:00"">
      <extrap title=""Scribblenauts"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6635-Scribblenauts"" date=""2009-10-13T17:00:00"" />
      <reviewed name=""Scribblenauts"" wpname=""Scribblenauts"" />
      <teaser>This week, Zero Punctuation reviews Scribblenauts.</teaser>
    </Episode>
    <Episode name=""Wet"" number=""114"" length=""276"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/981-Wet"" originalname=""Wet"" ytlink=""https://www.youtube.com/watch?v=V6iEh73ojCw"" date=""2009-10-14T16:00:00"">
      <extrap title=""Wet"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6662-Wet"" date=""2009-10-20T17:00:00"" />
      <reviewed name=""Wet"" wpname=""Wet (video game)"" awardname=""The Cement Block On A Racecourse Award for Biggest Non Starter"" awardepisode=""Awards for 2009"" />
      <teaser>This week, Zero Punctuation reviews Wet.</teaser>
    </Episode>
    <Episode name=""Mario &amp; Luigi: Bowser's Inside Story"" number=""115"" length=""289"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1007-Mario-Luigi-Bowsers-Inside-Story"" originalname=""Mario &amp; Luigi: Bowser's Inside Story"" date=""2009-10-21T16:00:00"">
      <extrap title=""Mario &amp; Luigi"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6706-Mario-Luigi"" date=""2009-10-27T17:00:00"" />
      <reviewed name=""Mario &amp; Luigi: Bowser's Inside Story"" wpname=""Mario &amp; Luigi: Bowser's Inside Story"" />
      <teaser>This week, Zero Punctuation reviews Mario &amp; Luigi: Bowser's Inside Story.</teaser>
    </Episode>
    <Episode name=""Brutal Legend"" number=""116"" length=""277"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1044-Brutal-Legend"" originalname=""Brutal Legend"" ytlink=""https://www.youtube.com/watch?v=HmueO3GtP6A"" date=""2009-10-28T16:00:00"">
      <extrap title=""A Study of Tim Schafer"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6714-A-Study-of-Tim-Schafer"" date=""2009-11-03T16:00:00"" />
      <reviewed name=""Brütal Legend"" wpname=""Brütal Legend"" />
      <teaser>This week, Zero Punctuation reviews Brutal Legend.</teaser>
    </Episode>
    <Episode name=""Washington D.C."" number=""117"" length=""419"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1060-Washington-DC"" originalname=""Washington DC"" ytlink=""https://www.youtube.com/watch?v=VzcPmlbhiDc"" date=""2009-11-04T16:00:00"">
      <extrap title=""Guitar Hero: Rock Opera"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6762-Guitar-Hero-Rock-Opera"" date=""2009-11-10T17:00:00"" />
      <reviewed name=""Washington DC"" wpname=""Washington, D.C."" />
      <teaser>This week, Ben ""Yahtzee"" Croshaw visits Washington DC.</teaser>
    </Episode>
    <Episode name=""Uncharted 2: Among Thieves"" number=""118"" length=""266"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1078-Uncharted-2-Among-Thieves"" originalname=""Uncharted 2: Among Thieves"" ytlink=""https://www.youtube.com/watch?v=2I1IPb2LLDM"" date=""2009-11-11T16:00:00"">
      <extrap title=""Uncharted 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6793-Uncharted-2"" date=""2009-11-18T20:57:00"" />
      <reviewed name=""Uncharted 2: Among Thieves"" wpname=""Uncharted 2: Among Thieves"" />
      <teaser>This week, Zero Punctuation reviews Uncharted 2: Among Thieves.</teaser>
    </Episode>
    <Episode name=""Dragon Age: Origins"" number=""119"" length=""354"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1096-Dragon-Age-Origins"" originalname=""Dragon Age: Origins"" ytlink=""https://www.youtube.com/watch?v=nJlDkGUA2YA"" date=""2009-11-18T16:00:00"">
      <extrap title=""On Dialogue Menus"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6813-On-Dialogue-Menus"" date=""2009-11-24T17:00:00"" />
      <reviewed name=""Dragon Age: Origins"" wpname=""Dragon Age: Origins"" />
      <teaser>This week, Zero Punctuation reviews Dragon Age: Origins.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Modern Warfare 2"" number=""120"" length=""267"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1118-Call-of-Duty-Modern-Warfare-2"" originalname=""Call of Duty: Modern Warfare 2"" ytlink=""https://www.youtube.com/watch?v=ukcaVYsgvJg"" date=""2009-11-25T16:00:00"">
      <extrap title=""On Multiplayer"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6832-On-Multiplayer"" date=""2009-12-01T17:00:00"" />
      <reviewed name=""Call of Duty: Modern Warfare 2"" wpname=""Call of Duty: Modern Warfare 2"" />
      <teaser>This week, Zero Punctuation reviews Call of Duty: Modern Warfare 2.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed 2"" number=""121"" length=""295"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1148-Assassins-Creed-2"" originalname=""Assassin's Creed 2"" ytlink=""https://www.youtube.com/watch?v=MfRB57_BDMU"" date=""2009-12-02T16:00:00"">
      <extrap title=""On His Voice"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6863-On-His-Voice"" date=""2009-12-08T17:00:00"" />
      <reviewed name=""Assassin's Creed 2"" wpname=""Assassin's Creed II"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed 2.</teaser>
    </Episode>
    <Episode name=""Left 4 Dead 2 &amp; New Super Mario Bros. Wii"" number=""122"" length=""296"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1191-Left-4-Dead-2-New-Super-Mario-Bros-Wii"" originalname=""Left 4 Dead 2 &amp; New Super Mario Bros Wii"" ytlink=""https://www.youtube.com/watch?v=haH4XvlDHTI"" date=""2009-12-09T16:00:00"">
      <extrap title=""On Remakes and Nostalgia"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6903-On-Remakes-and-Nostalgia"" date=""2009-12-15T17:00:00"" />
      <reviewed name=""Left 4 Dead 2"" wpname=""Left 4 Dead 2"" />
      <reviewed name=""New Super Mario Bros Wii"" wpname=""New Super Mario Bros. Wii"" />
      <teaser>This week, Zero Punctuation reviews Left 4 Dead 2 and New Super Mario Bros Wii.</teaser>
    </Episode>
    <Episode name=""Demon's Souls"" number=""123"" length=""291"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1321-Demons-Souls"" originalname=""Demon's Souls"" ytlink=""https://www.youtube.com/watch?v=vQSCKAPqxoo"" date=""2009-12-16T16:00:00"">
      <extrap title=""Demon's Souls"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6923-Demon-s-Souls"" date=""2009-12-22T17:00:00"" />
      <reviewed name=""Demon's Souls"" wpname=""Demon's Souls"" />
      <teaser>This week, Zero Punctuation reviews Demon's Souls.</teaser>
    </Episode>
    <Episode name=""Holiday 2009"" number=""124"" length=""24"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1340-Holiday-2009"" originalname=""Holiday 2009"" ytlink=""https://www.youtube.com/watch?v=yJBnZ2rzxeU"" date=""2009-12-23T16:00:00"">
      <teaser>This week, Yahtzee takes a look at Holiday 2009.</teaser>
    </Episode>
    <Episode name=""The Saboteur"" number=""125"" length=""287"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1353-Saboteur"" originalname=""Saboteur"" ytlink=""https://www.youtube.com/watch?v=ci84XpISE7Q"" date=""2009-12-30T16:00:00"">
      <extrap title=""On Nazis"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/6972-On-Nazis"" date=""2010-01-05T17:00:00"" />
      <reviewed name=""The Saboteur"" wpname=""The Saboteur"" />
      <teaser>This week, Zero Punctuation reviews Saboteur.</teaser>
    </Episode>
    <Episode name=""Awards for 2009"" number=""126"" length=""301"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1367-Awards-for-2009"" originalname=""Awards for 2009"" ytlink=""https://www.youtube.com/watch?v=zHV4XVqnSHE"" date=""2010-01-06T16:00:00"">
      <extrap title=""Best of 2009"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7003-Best-of-2009"" date=""2010-01-12T17:00:00"" />
      <teaser>This week, Zero Punctuation gives out awards for 2009.</teaser>
    </Episode>
    <Episode name=""Torchlight"" number=""127"" length=""288"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1385-Torchlight"" originalname=""Torchlight"" ytlink=""https://www.youtube.com/watch?v=_QEtbDrZwrg"" date=""2010-01-13T16:00:00"">
      <extrap title=""Role-Playing Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7038-Role-Playing-Games"" date=""2010-01-19T17:00:00"" />
      <reviewed name=""Torchlight"" wpname=""Torchlight"" />
      <teaser>This week, Zero Punctuation reviews Torchlight.</teaser>
    </Episode>
    <Episode name=""Darksiders"" number=""128"" length=""304"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1404-Darksiders"" originalname=""Darksiders"" ytlink=""https://www.youtube.com/watch?v=EWTSeTxKLJo"" date=""2010-01-20T16:00:00"">
      <extrap title=""Darksiders"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7071-Darksiders"" date=""2010-01-26T17:00:00"" />
      <reviewed name=""Darksiders"" wpname=""Darksiders"" />
      <teaser>This week, Zero Punctuation reviews Darksiders.</teaser>
    </Episode>
    <Episode name=""Bayonetta"" number=""129"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1420-Bayonetta"" originalname=""Bayonetta"" ytlink=""https://www.youtube.com/watch?v=8zgOYZDS1Tg"" date=""2010-01-27T16:00:00"">
      <extrap title=""Character Design"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7114-Character-Design"" date=""2010-02-02T17:00:00"" />
      <reviewed name=""Bayonetta"" wpname=""Bayonetta"" />
      <teaser>This week, Zero Punctuation reviews Bayonetta.</teaser>
    </Episode>
    <Episode name=""Dark Void"" number=""130"" length=""287"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1433-Dark-Void"" originalname=""Dark Void"" ytlink=""https://www.youtube.com/watch?v=im9oFIVtvcc"" date=""2010-02-03T16:00:00"">
      <extrap title=""Space, Flying and Space Flying"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7141-Space-Flying-and-Space-Flying"" date=""2010-02-09T17:00:00"" />
      <reviewed name=""Dark Void"" wpname=""Dark Void"" />
      <teaser>This week, Zero Punctuation reviews Dark Void.</teaser>
    </Episode>
    <Episode name=""Borderlands"" number=""131"" length=""292"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1448-Borderlands"" originalname=""Borderlands"" ytlink=""https://www.youtube.com/watch?v=sRY3dKpRskE"" date=""2010-02-10T16:00:00"">
      <extrap title=""Goth Mercenaries"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7170-Goth-Mercenaries"" date=""2010-02-16T17:00:00"" />
      <reviewed name=""Borderlands"" wpname=""Borderlands (video game)"" />
      <teaser>This week, Zero Punctuation reviews Borderlands.</teaser>
    </Episode>
    <Episode name=""Mass Effect 2"" number=""132"" length=""284"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1461-Mass-Effect-2"" originalname=""Mass Effect 2"" ytlink=""https://www.youtube.com/watch?v=QLNM_cW1SWk"" date=""2010-02-17T16:00:00"">
      <extrap title=""Connectivity"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7198-Connectivity"" date=""2010-02-23T17:00:00"" />
      <reviewed name=""Mass Effect 2"" wpname=""Mass Effect 2"" />
      <teaser>This week, Zero Punctuation reviews Mass Effect 2.</teaser>
    </Episode>
    <Episode name=""Dante's Inferno"" number=""133"" length=""302"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1472-Dantes-Inferno"" originalname=""Dante's Inferno"" ytlink=""https://www.youtube.com/watch?v=_0ujx2JnjkA"" date=""2010-02-24T16:00:00"">
      <extrap title=""Dante's Inferno"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7239-Dante-s-Inferno"" date=""2010-03-02T17:00:00"" />
      <reviewed name=""Dante's Inferno"" wpname=""Dante's Inferno (video game)"" />
      <teaser>This week, Zero Punctuation reviews Dante's Inferno.</teaser>
    </Episode>
    <Episode name=""BioShock 2"" number=""134"" length=""298"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1494-BioShock-2"" originalname=""BioShock 2"" ytlink=""https://www.youtube.com/watch?v=gm9Eta491O8"" date=""2010-03-03T16:00:00"">
      <extrap title=""Interactivity"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7268-Interactivity"" date=""2010-03-09T17:00:00"" />
      <reviewed name=""BioShock 2"" wpname=""BioShock 2"" awardname=""Fifth Worst of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews BioShock 2.</teaser>
    </Episode>
    <Episode name=""Aliens vs Predator"" number=""135"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1516-Aliens-vs-Predator"" originalname=""Aliens vs Predator"" ytlink=""https://www.youtube.com/watch?v=90srRJ_ks6o"" date=""2010-03-10T16:00:00"">
      <extrap title=""On Audio Logs"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7289-On-Audio-Logs"" date=""2010-03-16T17:00:00"" />
      <reviewed name=""Aliens vs Predator"" wpname=""Aliens vs. Predator (2010 video game)"" />
      <teaser>This week, Zero Punctuation reviews Aliens vs Predator.</teaser>
    </Episode>
    <Episode name=""Heavy Rain"" number=""136"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1528-Heavy-Rain"" originalname=""Heavy Rain"" ytlink=""https://www.youtube.com/watch?v=cj_Nrx0kQ34"" date=""2010-03-17T16:00:00"">
      <extrap title=""Interactive Storytelling"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7319-Interactive-Storytelling"" date=""2010-03-23T17:00:00"" />
      <reviewed name=""Heavy Rain"" wpname=""Heavy Rain"" />
      <teaser>This week, Zero Punctuation reviews Heavy Rain.</teaser>
    </Episode>
    <Episode name=""Battlefield: Bad Company 2"" number=""137"" length=""303"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1546-Battlefield-Bad-Company-2"" originalname=""Battlefield: Bad Company 2"" ytlink=""https://www.youtube.com/watch?v=GBJsFocwVWA"" date=""2010-03-24T16:00:00"">
      <extrap title=""Betrayal"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7353-Betrayal"" date=""2010-03-30T17:00:00"" />
      <reviewed name=""Battlefield: Bad Company 2"" wpname=""Battlefield: Bad Company 2"" />
      <teaser>This week, Zero Punctuation reviews Battlefield: Bad Company 2.</teaser>
    </Episode>
    <Episode name=""Final Fantasy XIII"" number=""138"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1569-Final-Fantasy-XIII"" originalname=""Final Fantasy XIII"" ytlink=""https://www.youtube.com/watch?v=KmnAL60mfSg"" date=""2010-03-31T16:00:00"">
      <extrap title=""Yahtzee vs. the JRPG"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7379-Yahtzee-vs-the-JRPG"" date=""2010-04-06T17:00:00"" />
      <reviewed name=""Final Fantasy XIII"" wpname=""Final Fantasy XIII"" awardname=""Fourth Worst of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Final Fantasy XIII.</teaser>
    </Episode>
    <Episode name=""April Fools 2010"" number=""139"" length=""59"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1591-April-Fools"" originalname=""April Fools"" ytlink=""https://www.youtube.com/watch?v=7dS6n1LBuhs"" date=""2010-04-02T18:00:00"">
      <teaser>For all those who missed Yahtzee's April Fool's joke hidden on the site.</teaser>
    </Episode>
    <Episode name=""God of War III"" number=""140"" length=""312"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1595-God-of-War-III"" originalname=""God of War III"" ytlink=""https://www.youtube.com/watch?v=S-Xz7D2GcYA"" date=""2010-04-07T16:00:00"">
      <extrap title=""Kratos"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7417-Kratos"" date=""2010-04-13T17:00:00"" />
      <reviewed name=""God of War III"" wpname=""God of War III"" />
      <teaser>This week, Zero Punctuation reviews God of War III.</teaser>
    </Episode>
    <Episode name=""Red Steel 2"" number=""141"" length=""291"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1610-Red-Steel-2"" originalname=""Red Steel 2"" ytlink=""https://www.youtube.com/watch?v=yrChttkOoZU"" date=""2010-04-14T16:00:00"">
      <extrap title=""Revenge"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7447-Revenge"" date=""2010-04-20T17:00:00"" />
      <reviewed name=""Red Steel 2"" wpname=""Red Steel 2"" />
      <teaser>This week, Zero Punctuation reviews Red Steel 2.</teaser>
    </Episode>
    <Episode name=""Just Cause 2"" number=""142"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1632-Just-Cause-2"" originalname=""Just Cause 2"" ytlink=""https://www.youtube.com/watch?v=PZ2cnlDKVPI"" date=""2010-04-21T16:00:00"">
      <extrap title=""Videogames as Art"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7473-Videogames-as-Art"" date=""2010-04-27T17:00:00"" />
      <reviewed name=""Just Cause 2"" wpname=""Just Cause 2"" awardname=""Best game of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Just Cause 2.</teaser>
    </Episode>
    <Episode name=""Silent Hill: Shattered Memories"" number=""143"" length=""300"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1651-Silent-Hill-Shattered-Memories"" originalname=""Silent Hill: Shattered Memories"" ytlink=""https://www.youtube.com/watch?v=8dJD9l3E7Gg"" date=""2010-04-28T16:00:00"">
      <extrap title=""Silent Hill: Shattered Memories"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7510-Silent-Hill-Shattered-Memories"" date=""2010-05-04T17:00:00"" />
      <reviewed name=""Silent Hill: Shattered Memories"" wpname=""Silent Hill: Shattered Memories"" />
      <teaser>This week, Zero Punctuation reviews Silent Hill: Shattered Memories.</teaser>
    </Episode>
    <Episode name=""Splinter Cell: Conviction"" number=""144"" length=""307"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1684-Splinter-Cell-Conviction"" originalname=""Splinter Cell: Conviction"" ytlink=""https://www.youtube.com/watch?v=rqFf7-SKRR4"" date=""2010-05-05T16:00:00"">
      <extrap title=""Stealth"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7535-Stealth"" date=""2010-05-11T17:00:00"" />
      <reviewed name=""Tom Clancy's Splinter Cell: Conviction"" wpname=""Tom Clancy's Splinter Cell: Conviction"" />
      <teaser>This week, Zero Punctuation reviews Splinter Cell: Conviction.</teaser>
    </Episode>
    <Episode name=""Nier"" number=""145"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1703-Nier"" originalname=""Nier"" ytlink=""https://www.youtube.com/watch?v=ve_a4vweeyQ"" date=""2010-05-12T16:00:00"">
      <extrap title=""Character Names"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7564-Character-Names"" date=""2010-05-18T17:00:00"" />
      <reviewed name=""Nier"" wpname=""Nier (video game)"" />
      <teaser>This week, Zero Punctuation reviews Nier.</teaser>
    </Episode>
    <Episode name=""Dead to Rights: Retribution"" number=""146"" length=""351"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1717-Dead-to-Rights-Retribution"" originalname=""Dead to Rights: Retribution"" ytlink=""https://www.youtube.com/watch?v=IYkuBw7saOE"" date=""2010-05-19T16:00:00"">
      <extrap title=""Male Protagonists"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7597-Male-Protagonists"" date=""2010-05-25T17:00:00"" />
      <reviewed name=""Dead to Rights: Retribution"" wpname=""Dead to Rights: Retribution"" />
      <teaser>This week, Zero Punctuation reviews Dead to Rights: Retribution.</teaser>
    </Episode>
    <Episode name=""Monster Hunter Tri"" number=""147"" length=""304"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1732-Monster-Hunter-Tri"" originalname=""Monster Hunter Tri"" ytlink=""https://www.youtube.com/watch?v=LgqSFD1Uxrg"" date=""2010-05-26T16:00:00"">
      <extrap title=""Monster Hunter Tri"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7635-Monster-Hunter-Tri"" date=""2010-06-01T17:00:00"" />
      <reviewed name=""Monster Hunter Tri"" wpname=""Monster Hunter Tri"" />
      <teaser>This week, Zero Punctuation reviews Monster Hunter Tri.</teaser>
    </Episode>
    <Episode name=""Alan Wake"" number=""148"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1756-Alan-Wake"" originalname=""Alan Wake"" ytlink=""https://www.youtube.com/watch?v=Fk48G6aG7lo"" date=""2010-06-02T16:00:00"">
      <extrap title=""The Common Mistakes of Horror Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7658-The-Common-Mistakes-of-Horror-Games"" date=""2010-06-08T17:00:00"" />
      <reviewed name=""Alan Wake"" wpname=""Alan Wake"" />
      <teaser>This week, Zero Punctuation reviews Alan Wake.</teaser>
    </Episode>
    <Episode name=""Red Dead Redemption"" number=""149"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1776-Red-Dead-Redemption"" originalname=""Red Dead Redemption"" ytlink=""https://www.youtube.com/watch?v=4cHap89_lFk"" date=""2010-06-09T16:00:00"">
      <extrap title=""Red Dead Redemption"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7699-Red-Dead-Redemption"" date=""2010-06-15T17:00:00"" />
      <reviewed name=""Red Dead Redemption"" wpname=""Red Dead Redemption"" awardname=""Third Best of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Red Dead Redemption.</teaser>
    </Episode>
    <Episode name=""Alpha Protocol"" number=""150"" length=""309"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1801-Alpha-Protocol"" originalname=""Alpha Protocol"" ytlink=""https://www.youtube.com/watch?v=K9ZkY-6M5qw"" date=""2010-06-16T16:00:00"">
      <extrap title=""Boss Fights"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7726-Boss-Fights"" date=""2010-06-22T17:00:00"" />
      <reviewed name=""Alpha Protocol"" wpname=""Alpha Protocol"" />
      <teaser>This week, Zero Punctuation reviews Alpha Protocol.</teaser>
    </Episode>
    <Episode name=""Prince of Persia: The Forgotten Sands"" number=""151"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1815-Prince-of-Persia-The-Forgotten-Sands"" originalname=""Prince of Persia: The Forgotten Sands"" date=""2010-06-23T16:00:00"">
      <extrap title=""What Sands of Time Gets Right"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7773-What-Sands-of-Time-Gets-Right"" date=""2010-06-29T17:00:00"" />
      <reviewed name=""Prince of Persia: The Forgotten Sands"" wpname=""Prince of Persia: The Forgotten Sands"" />
      <teaser>This week, Zero Punctuation reviews Prince of Persia: The Forgotten Sands.</teaser>
    </Episode>
    <Episode name=""E3 2010"" number=""152"" length=""309"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1838-E3-2010"" originalname=""E3 2010"" ytlink=""https://www.youtube.com/watch?v=U8hfs9zWMVc"" date=""2010-06-30T16:00:00"">
      <extrap title=""On Kinect and PlayStation Move"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7794-On-Kinect-and-PlayStation-Move"" date=""2010-07-06T17:00:00"" />
      <teaser>This week, Zero Punctuation digs into the news from E3 2010.</teaser>
    </Episode>
    <Episode name=""No More Heroes 2: Desperate Struggle"" number=""153"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1856-No-More-Heroes-2-Desperate-Struggle"" originalname=""No More Heroes 2: Desperate Struggle"" ytlink=""https://www.youtube.com/watch?v=KsVv2Su3Ab4"" date=""2010-07-07T16:00:00"">
      <extrap title=""On Difficulty Levels"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7820-On-Difficulty-Levels"" date=""2010-07-13T17:00:00"" />
      <reviewed name=""No More Heroes 2: Desperate Struggle"" wpname=""No More Heroes 2: Desperate Struggle"" />
      <teaser>This week, Zero edPunctuation reviews No More Heroes 2: Desperate Struggle.</teaser>
    </Episode>
    <Episode name=""Super Mario Galaxy 2"" number=""154"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1871-Super-Mario-Galaxy-2"" originalname=""Super Mario Galaxy 2"" ytlink=""https://www.youtube.com/watch?v=TJyyyBJoKXU"" date=""2010-07-14T16:00:00"">
      <extrap title=""Super Mario Galaxy 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7856-Super-Mario-Galaxy-2"" date=""2010-07-20T17:00:00"" />
      <reviewed name=""Super Mario Galaxy 2"" wpname=""Super Mario Galaxy 2"" />
      <teaser>This week, Zero Punctuation reviews Super Mario Galaxy 2.</teaser>
    </Episode>
    <Episode name=""Singularity"" number=""155"" length=""298"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1883-Singularity"" originalname=""Singularity"" ytlink=""https://www.youtube.com/watch?v=TBeXP-MSt8I"" date=""2010-07-21T16:00:00"">
      <extrap title=""On Time Travel"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7905-On-Time-Travel"" date=""2010-07-27T17:00:00"" />
      <reviewed name=""Singularity"" wpname=""Singularity (video game)"" />
      <teaser>This week, Zero Punctuation reviews Singularity.</teaser>
    </Episode>
    <Episode name=""Crackdown 2"" number=""156"" length=""297"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1897-Crackdown-2"" originalname=""Crackdown 2"" ytlink=""https://www.youtube.com/watch?v=SeyBGbJRRe8"" date=""2010-07-28T16:00:00"">
      <extrap title=""On RTS Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7938-On-RTS-Games"" date=""2010-08-03T17:00:00"" />
      <reviewed name=""Crackdown 2"" wpname=""Crackdown 2"" />
      <teaser>This week, Zero Punctuation reviews Crackdown 2.</teaser>
    </Episode>
    <Episode name=""DeathSpank &amp; Limbo"" number=""157"" length=""296"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1908-DeathSpank-Limbo"" originalname=""DeathSpank &amp; Limbo"" ytlink=""https://www.youtube.com/watch?v=iBmDJunE4vU"" date=""2010-08-04T16:00:00"">
      <extrap title=""On Arty 2D Platformers"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/7975-On-Arty-2D-Platformers"" date=""2010-08-10T21:00:00"" />
      <reviewed name=""DeathSpank"" wpname=""DeathSpank"" />
      <reviewed name=""Limbo"" wpname=""Limbo (video game)"" awardname=""Fifth Best of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews DeathSpank and Limbo.</teaser>
    </Episode>
    <Episode name=""Shadow of the Colossus"" number=""158"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1924-Shadow-of-the-Colossus"" originalname=""Shadow of the Colossus"" ytlink=""https://www.youtube.com/watch?v=jUo5bRJjqZ8"" date=""2010-08-11T16:00:00"">
      <extrap title=""On Exploration"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8002-On-Exploration"" date=""2010-08-17T17:00:00"" />
      <reviewed name=""Shadow of the Colossus"" wpname=""Shadow of the Colossus"" />
      <teaser>This week, Zero Punctuation reviews Shadow of the Colossus.</teaser>
    </Episode>
    <Episode name=""Split Second: Velocity"" number=""159"" length=""300"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1939-Split-Second-Velocity"" originalname=""Split Second: Velocity"" ytlink=""https://www.youtube.com/watch?v=IW3lfpHNI20"" date=""2010-08-18T16:00:00"">
      <extrap title=""Don't Use the Word &quot;Gamer&quot;"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8031-Don-t-Use-the-Word-Gamer"" date=""2010-08-24T17:00:00"" />
      <reviewed name=""Split/Second"" wpname=""Split/Second"" />
      <teaser>This week, Zero Punctuation reviews Split/Second: Velocity</teaser>
    </Episode>
    <Episode name=""Transformers: War for Cybertron"" number=""160"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1951-Transformers-War-for-Cybertron"" originalname=""Transformers: War for Cybertron"" ytlink=""https://www.youtube.com/watch?v=JFM_npgUD2c"" date=""2010-08-25T16:00:00"">
      <extrap title=""Hideo Kojima and Women"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8079-Hideo-Kojima-and-Women"" date=""2010-09-07T17:00:00"" />
      <reviewed name=""Transformers: War for Cybertron"" wpname=""Transformers: War for Cybertron"" />
      <teaser>This week, Zero Punctuation reviews Transformers: War for Cybertron.</teaser>
    </Episode>
    <Episode name=""Kane &amp; Lynch 2: Dog Days"" number=""161"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1976-Kane-Lynch-2-Dog-Days"" originalname=""Kane &amp; Lynch 2: Dog Days"" ytlink=""https://www.youtube.com/watch?v=8oRSpyFvPkY"" date=""2010-09-08T16:00:00"">
      <extrap title=""Duke Nukem Forever"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8112-Duke-Nukem-Forever"" date=""2010-09-14T17:00:00"" />
      <reviewed name=""Kane &amp; Lynch 2: Dog Days"" wpname=""Kane &amp; Lynch 2: Dog Days"" awardname=""Worst game of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Kane &amp; Lynch 2: Dog Days.</teaser>
    </Episode>
    <Episode name=""Mafia II"" number=""162"" length=""289"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1988-Mafia-II"" originalname=""Mafia II"" ytlink=""https://www.youtube.com/watch?v=rlPTPavbJ10"" date=""2010-09-15T16:00:00"">
      <extrap title=""On Endings"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8127-On-Endings"" date=""2010-09-21T17:00:00"" />
      <reviewed name=""Mafia II"" wpname=""Mafia II"" />
      <teaser>This week, Zero Punctuation reviews Mafia II.</teaser>
    </Episode>
    <Episode name=""Metroid: Other M"" number=""163"" length=""306"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2015-Metroid-Other-M"" originalname=""Metroid Other M"" ytlink=""https://www.youtube.com/watch?v=9XSkRuPuthY"" date=""2010-09-22T16:00:00"">
      <extrap title=""On Silent Protagonists"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8156-On-Silent-Protagonists"" date=""2010-09-28T17:00:00"" />
      <reviewed name=""Metroid Other M"" wpname=""Metroid: Other M"" awardname=""Second Worst of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Metroid Other M.</teaser>
    </Episode>
    <Episode name=""Video Game Voters Network"" number=""164"" length=""134"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/1742-Video-Game-Voters-Network"" originalname=""Video Game Voters Network"" ytlink=""https://www.youtube.com/watch?v=agDpp41mItw"" date=""2010-09-24T16:00:00"">
      <teaser>This special episode of Zero Punctuation is a public service announcement brought to you by the ESA and the Video Game Voters Network.</teaser>
    </Episode>
    <Episode name=""Amnesia: The Dark Descent"" number=""165"" length=""283"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2092-Amnesia-The-Dark-Descent"" originalname=""Amnesia: The Dark Descent"" ytlink=""https://www.youtube.com/watch?v=IXuIZstyM7E"" date=""2010-09-29T16:00:00"">
      <extrap title=""Sanity Meters"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8178-Sanity-Meters"" date=""2010-10-05T17:00:00"" />
      <reviewed name=""Amnesia: The Dark Descent"" wpname=""Amnesia: The Dark Descent"" awardname=""Fourth Best of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Amnesia: The Dark Descent.</teaser>
    </Episode>
    <Episode name=""Halo: Reach"" number=""166"" length=""292"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2136-Halo-Reach"" originalname=""Halo: Reach"" ytlink=""https://www.youtube.com/watch?v=kZzjsbIMGaI"" date=""2010-10-06T16:00:00"">
      <extrap title=""More on Halo: Reach"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8198-More-on-Halo-Reach"" date=""2010-10-12T17:00:00"" />
      <reviewed name=""Halo: Reach"" wpname=""Halo: Reach"" />
      <teaser>This week, Zero Punctuation reviews Halo: Reach.</teaser>
    </Episode>
    <Episode name=""Dead Rising 2"" number=""167"" length=""293"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2176-Dead-Rising-2"" originalname=""Dead Rising 2"" ytlink=""https://www.youtube.com/watch?v=bqkGrfc_lng"" date=""2010-10-13T16:00:00"">
      <extrap title=""Dead Rising 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8224-Dead-Rising-2"" date=""2010-10-19T17:00:00"" />
      <reviewed name=""Dead Rising 2"" wpname=""Dead Rising 2"" awardname=""Second Best of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Dead Rising 2.</teaser>
    </Episode>
    <Episode name=""Spider-Man: Shattered Dimensions"" number=""168"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2213-Spider-Man-Shattered-Dimensions"" originalname=""Spider-Man: Shattered Dimensions"" ytlink=""https://www.youtube.com/watch?v=y1yjjd1iUJc"" date=""2010-10-20T16:00:00"">
      <extrap title=""A Handy Glossary of Yahtzee Terms"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8243-A-Handy-Glossary-of-Yahtzee-Terms"" date=""2010-10-26T17:00:00"" />
      <reviewed name=""Spider-Man: Shattered Dimensions"" wpname=""Spider-Man: Shattered Dimensions"" />
      <teaser>This week, Zero Punctuation reviews Spider-Man: Shattered Dimensions.</teaser>
    </Episode>
    <Episode name=""Castlevania: Lords of Shadow"" number=""169"" length=""300"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2251-Castlevania-Lords-of-Shadow"" originalname=""Castlevania: Lords of Shadow"" ytlink=""https://www.youtube.com/watch?v=gEV4Ebz4Yts"" date=""2010-10-27T16:00:00"">
      <extrap title=""Shaky Cam Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8266-Shaky-Cam-Games"" date=""2010-11-02T17:00:00"" />
      <reviewed name=""Castlevania: Lords of Shadow"" wpname=""Castlevania: Lords of Shadow"" />
      <teaser>This week, Zero Punctuation reviews Castlevania: Lords of Shadow.</teaser>
    </Episode>
    <Episode name=""Enslaved: Odyssey to the West"" number=""170"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2409-Enslaved-Odyssey-to-the-West"" originalname=""Enslaved: Odyssey to the West"" ytlink=""https://www.youtube.com/watch?v=V6Z_qpqPIl0"" date=""2010-11-03T16:00:00"">
      <extrap title=""Enslaved As It Should Have Been"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8298-Enslaved-As-It-Should-Have-Been"" date=""2010-11-09T17:00:00"" />
      <reviewed name=""Enslaved: Odyssey to the West"" wpname=""Enslaved: Odyssey to the West"" />
      <teaser>This week, Zero Punctuation reviews Enslaved: Odyssey to the West.</teaser>
    </Episode>
    <Episode name=""Fallout: New Vegas"" number=""171"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2435-Fallout-New-Vegas"" originalname=""Fallout: New Vegas"" ytlink=""https://www.youtube.com/watch?v=7XsACXSVhWY"" date=""2010-11-10T16:00:00"">
      <extrap title=""Fallout: New Vegas"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8329-Fallout-New-Vegas"" date=""2010-11-16T17:05:00"" />
      <reviewed name=""Fallout: New Vegas"" wpname=""Fallout: New Vegas"" />
      <teaser>This week, Zero Puncuation reviews Fallout: New Vegas.</teaser>
    </Episode>
    <Episode name=""Star Wars: The Force Unleashed II"" number=""172"" length=""307"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2452-Star-Wars-The-Force-Unleashed-II"" originalname=""Star Wars: The Force Unleashed II"" ytlink=""https://www.youtube.com/watch?v=bB3rwPoDYo4"" date=""2010-11-17T16:00:00"">
      <extrap title=""Force Unleashed 2 Is Too Much"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8358-Force-Unleashed-2-Is-Too-Much"" date=""2010-11-23T17:00:00"" />
      <reviewed name=""Star Wars: The Force Unleashed II"" wpname=""Star Wars: The Force Unleashed II"" awardname=""Third Worst of 2010"" awardepisode=""Top 5 of 2010"" />
      <teaser>This week, Zero Punctuation reviews Star Wars: The Force Unleashed II.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Black Ops"" number=""173"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2486-Call-of-Duty-Black-Ops"" originalname=""Call of Duty: Black Ops"" ytlink=""https://www.youtube.com/watch?v=eP-OLKkbiBc"" date=""2010-11-24T16:00:00"">
      <extrap title=""Why We Love Zombies"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8387-Why-We-Love-Zombies"" date=""2010-11-30T21:15:00"" />
      <reviewed name=""Call of Duty: Black Ops"" wpname=""Call of Duty: Black Ops"" />
      <teaser>This week, Zero Punctuation reviews Call of Duty: Black Ops.</teaser>
    </Episode>
    <Episode name=""IPhone Games"" number=""174"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2506-iPhone-Games"" originalname=""iPhone Games"" ytlink=""https://www.youtube.com/watch?v=pVwzmHx-Q9c"" date=""2010-12-01T16:00:00"">
      <extrap title=""The Best Iphone Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8402-The-Best-Iphone-Games"" date=""2010-12-07T17:00:00"" />
      <reviewed name=""Angry Birds"" wpname=""Angry Birds (video game)"" />
      <reviewed name=""Cut the Rope"" wpname=""Cut the Rope"" />
      <reviewed name=""Fruit Ninja"" wpname=""Fruit Ninja"" />
      <reviewed name=""Doodle God"" wpname=""Doodle God"" />
      <teaser>This week, Zero Punctuations reviews some of the popular iPhone games at this time.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed: Brotherhood"" number=""175"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2519-Assassins-Creed-Brotherhood"" originalname=""Assassin's Creed: Brotherhood"" ytlink=""https://www.youtube.com/watch?v=WmJBp-l4UO4"" date=""2010-12-08T16:00:00"">
      <extrap title=""The Little Touches in Assassin's Creed"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8432-The-Little-Touches-in-Assassin-s-Creed"" date=""2010-12-14T17:00:00"" />
      <reviewed name=""Assassin's Creed: Brotherhood"" wpname=""Assassin's Creed: Brotherhood"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed: Brotherhood.</teaser>
    </Episode>
    <Episode name=""Splatterhouse"" number=""176"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2544-Splatterhouse"" originalname=""Splatterhouse"" ytlink=""https://www.youtube.com/watch?v=KWHF16xjQmg"" date=""2010-12-15T16:00:00"">
      <extrap title=""Splatterhouse in Australia?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8472-Splatterhouse-in-Australia"" date=""2010-12-21T17:00:00"" />
      <reviewed name=""Splatterhouse"" wpname=""Splatterhouse (2010 video game)"" />
      <teaser>This week, Zero Punctuation reviews Splatterhouse.</teaser>
    </Episode>
    <Episode name=""Epic Mickey"" number=""177"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2575-Epic-Mickey"" originalname=""Epic Mickey"" ytlink=""https://www.youtube.com/watch?v=ehqaUjtIul0"" date=""2010-12-22T16:00:00"">
      <reviewed name=""Epic Mickey"" wpname=""Epic Mickey"" />
      <teaser>This week, Zero Punctuation reviews Epic Mickey.</teaser>
    </Episode>
    <Episode name=""Holiday 2010"" number=""178"" length=""261"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2589-Holiday-2010"" originalname=""Holiday 2010"" ytlink=""https://www.youtube.com/watch?v=WJCC-QMu1Bg"" date=""2010-12-29T16:00:00"">
      <extrap title=""Epic Mickey Offers No Choice"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8503-Epic-Mickey-Offers-No-Choice"" date=""2011-01-04T17:00:00"" />
      <teaser>It's that time of year again.</teaser>
    </Episode>
    <Episode name=""Top 5 of 2010"" number=""179"" length=""361"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2607-Top-5-of-2010"" originalname=""Top 5 of 2010"" ytlink=""https://www.youtube.com/watch?v=s8w6hY9DtCQ"" date=""2011-01-05T16:00:00"">
      <extrap title=""Honorable and Dishonorable Mentions"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8534-Honorable-and-Dishonorable-Mentions"" date=""2011-01-11T17:00:00"" />
      <teaser>This week, Zero Punctuation's Yahtzee lists his top 5 best and worst games of 2010.</teaser>
    </Episode>
    <Episode name=""World of Warcraft: Cataclysm"" number=""180"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2634-World-of-Warcraft-Cataclysm"" originalname=""World of Warcraft: Cataclysm"" ytlink=""https://www.youtube.com/watch?v=lMTahXSEw4w"" date=""2011-01-12T16:00:00"">
      <extrap title=""On Multiplayer"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8560-On-Multiplayer"" date=""2011-01-18T17:00:00"" />
      <reviewed name=""World of Warcraft: Cataclysm"" wpname=""World of Warcraft: Cataclysm"" />
      <teaser>This week, Zero Punctuation reviews World of Warcraft: Cataclysm.</teaser>
    </Episode>
    <Episode name=""Fable III"" number=""181"" length=""332"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2652-Fable-3"" originalname=""Fable 3"" ytlink=""https://www.youtube.com/watch?v=lawmA7O16jE"" date=""2011-01-19T16:00:00"">
      <extrap title=""Molyneux's Unfocused Innovation"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8586-Molyneux-s-Unfocused-Innovation"" date=""2011-01-25T17:00:00"" />
      <reviewed name=""Fable 3"" wpname=""Fable III"" />
      <teaser>This week, Zero Punctuation reviews Fable 3.</teaser>
    </Episode>
    <Episode name=""Minecraft"" number=""182"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2680-Minecraft"" originalname=""Minecraft"" ytlink=""https://www.youtube.com/watch?v=4wgQvij3rVE"" date=""2011-01-26T16:00:00"">
      <extrap title=""What Minecraft Is Missing"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8615-What-Minecraft-Is-Missing"" date=""2011-02-01T17:00:00"" />
      <reviewed name=""Minecraft"" wpname=""Minecraft"" />
      <teaser>This week, Zero Punctuation reviews Minecraft.</teaser>
    </Episode>
    <Episode name=""A Shadow's Tale"" number=""183"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2714-A-Shadows-Tale"" originalname=""A Shadow's Tale"" ytlink=""https://www.youtube.com/watch?v=pRO_6-lyiqc"" date=""2011-02-02T16:00:00"">
      <extrap title=""American Box Art Sucks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8631-American-Box-Art-Sucks"" date=""2011-02-08T17:00:00"" />
      <reviewed name=""A Shadow's Tale"" wpname=""Lost in Shadow"" />
      <teaser>This week, Zero Punctuation review A Shadow's Tale.</teaser>
    </Episode>
    <Episode name=""Dead Space 2"" number=""184"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2737-Dead-Space-2"" originalname=""Dead Space 2"" ytlink=""https://www.youtube.com/watch?v=Vw4dkOzpBuE"" date=""2011-02-09T16:00:00"">
      <extrap title=""Dead Space 2 Is No Resident Evil 4"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8653-Dead-Space-2-Is-No-Resident-Evil-4"" date=""2011-02-15T17:00:00"" />
      <reviewed name=""Dead Space 2"" wpname=""Dead Space 2"" />
      <teaser>This week, Zero Punctuation reviews Dead Space 2.</teaser>
    </Episode>
    <Episode name=""DC Universe Online"" number=""185"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2757-DC-Universe-Online"" originalname=""DC Universe Online"" ytlink=""https://www.youtube.com/watch?v=FRXb1Lr4G3c"" date=""2011-02-16T16:00:00"">
      <extrap title=""What if We Leveled Backwards?!"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8661-What-if-We-Leveled-Backwards"" date=""2011-02-22T17:00:00"" />
      <reviewed name=""DC Universe Online"" wpname=""DC Universe Online"" />
      <teaser>This week, Zero Punctuation dresses with underwear on the outside to review DC Universe Online.</teaser>
    </Episode>
    <Episode name=""MindJack"" number=""186"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2793-MindJack"" originalname=""MindJack"" ytlink=""https://www.youtube.com/watch?v=_5zXl93LXIE"" date=""2011-02-23T16:00:00"">
      <extrap title=""Hybrid Multiplayer Mess"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8682-Hybrid-Multiplayer-Mess"" date=""2011-03-01T17:00:00"" />
      <reviewed name=""MindJack"" wpname=""MindJack"" awardname=""Fifth Worst of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, Zero Punctuation makes its opinion on MindJack very very clear.</teaser>
    </Episode>
    <Episode name=""Two Worlds II"" number=""187"" length=""312"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2819-Two-Worlds-II"" originalname=""Two Worlds II"" ytlink=""https://www.youtube.com/watch?v=2Rc_vsIp5tw"" date=""2011-03-02T16:00:00"">
      <extrap title=""Let's Talk About Let's Play"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8703-Let-s-Talk-About-Let-s-Play"" date=""2011-03-08T17:00:00"" />
      <reviewed name=""Two Worlds II"" wpname=""Two Worlds II"" />
      <teaser>This week, Zero Punctuation reviews the sequel to One Worlds One... err Two Worlds One... eh whatever.</teaser>
    </Episode>
    <Episode name=""Bulletstorm"" number=""188"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2863-Bulletstorm"" originalname=""Bulletstorm"" ytlink=""https://www.youtube.com/watch?v=bBkMjskogVE"" date=""2011-03-09T16:00:00"">
      <extrap title=""Why Regenerating Health Sucks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8719-Why-Regenerating-Health-Sucks"" date=""2011-03-15T17:00:00"" />
      <reviewed name=""Bulletstorm"" wpname=""Bulletstorm"" />
      <teaser>This week, Zero Punctuation reviews Bulletstorm, the combined effort from the two developers who brought us Painkiller and Gears of War.</teaser>
    </Episode>
    <Episode name=""Killzone 3"" number=""189"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2915-Killzone-3"" originalname=""Killzone 3"" ytlink=""https://www.youtube.com/watch?v=RwPDRSVcfJo"" date=""2011-03-16T16:00:00"">
      <extrap title=""BAFTAs Are Bollocks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8737-BAFTAs-Are-Bollocks"" date=""2011-03-23T00:00:00"" />
      <reviewed name=""Killzone 3"" wpname=""Killzone 3"" />
      <teaser>This week, Zero Punctuation reviews British space Nazis and Killzone 3.</teaser>
    </Episode>
    <Episode name=""Kirby's Epic Yarn"" number=""190"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2948-Kirbys-Epic-Yarn"" originalname=""Kirby's Epic Yarn"" ytlink=""https://www.youtube.com/watch?v=A8MQMCe1cwE"" date=""2011-03-23T16:00:00"">
      <extrap title=""Death in Videogames"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8753-Death-in-Videogames"" date=""2011-03-29T17:00:00"" />
      <reviewed name=""Kirby's Epic Yarn"" wpname=""Kirby's Epic Yarn"" />
      <teaser>This week, Zero Punctuation reviews Kirby's Epic Yarn and Colorful Apartment Management Simulator 2011, which may in fact be the same game.</teaser>
    </Episode>
    <Episode name=""Dragon Age II"" number=""191"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/2978-Dragon-Age-II"" originalname=""Dragon Age II"" ytlink=""https://www.youtube.com/watch?v=BdsPDIYUxKA"" date=""2011-03-30T16:00:00"">
      <extrap title=""Roleplaying Homosexual in Dragon Age 2"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8768-Roleplaying-Homosexual-in-Dragon-Age-2"" date=""2011-04-05T22:00:00"" />
      <reviewed name=""Dragon Age II"" wpname=""Dragon Age II"" />
      <teaser>This week, Zero Punctuation reviews Dragon Age II.</teaser>
    </Episode>
    <Episode name=""Pokémon White"" number=""192"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3008-Pokemon-White"" originalname=""Pokemon White"" ytlink=""https://www.youtube.com/watch?v=hdt8ZD1N-wk"" date=""2011-04-06T16:00:00"">
      <extrap title=""Pokemon 100 Percenters Are Mad"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8784-Pokemon-100-Percenters-Are-Mad"" date=""2011-04-12T17:00:00"" />
      <reviewed name=""Pokemon White"" wpname=""Pokémon Black and White"" />
      <teaser>This week, Zero Punctuation dispels some notions on why Pokemon hasn't been reviewed before.</teaser>
    </Episode>
    <Episode name=""Yakuza 4"" number=""193"" length=""332"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3035-Yakuza-4"" originalname=""Yakuza 4"" ytlink=""https://www.youtube.com/watch?v=yrvKjrPgeyM"" date=""2011-04-13T16:00:00"">
      <extrap title=""How Yakuza 4 Grabs You"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8807-How-Yakuza-4-Grabs-You"" date=""2011-04-19T17:00:00"" />
      <reviewed name=""Yakuza 4"" wpname=""Yakuza 4"" />
      <teaser>This week, Zero Punctuation reviews Yakuza 4.</teaser>
    </Episode>
    <Episode name=""Crysis 2"" number=""194"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3079-Crysis-2"" originalname=""Crysis 2"" ytlink=""https://www.youtube.com/watch?v=X0MblIn-lVc"" date=""2011-04-20T16:00:00"">
      <extrap title=""An Invisible Protagonist"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8828-An-Invisible-Protagonist"" date=""2011-04-26T17:00:00"" />
      <reviewed name=""Crysis 2"" wpname=""Crysis 2"" />
      <teaser>This week, Zero Punctuation wonders why New York City is such a common destruction target.</teaser>
    </Episode>
    <Episode name=""Nintendo 3DS"" number=""195"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3112-Nintendo-3DS"" originalname=""Nintendo 3DS"" ytlink=""https://www.youtube.com/watch?v=4c9iNfTMUqE"" date=""2011-04-27T16:00:00"">
      <extrap title=""Getting Innovation Wrong"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8837-Getting-Innovation-Wrong"" date=""2011-05-03T17:00:00"" />
      <reviewed name=""Nintendo 3DS"" wpname=""Nintendo 3DS"" />
      <teaser>This week, Zero Punctuation reviews Nintendo's latest cash grab.</teaser>
    </Episode>
    <Episode name=""Portal 2"" number=""196"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3153-Portal-2"" originalname=""Portal 2"" ytlink=""https://www.youtube.com/watch?v=qvhjczPD1DA"" date=""2011-05-04T16:00:00"">
      <extrap title=""Building Sequels Badly"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8857-Building-Sequels-Badly"" date=""2011-05-10T17:00:00"" />
      <reviewed name=""Portal 2"" wpname=""Portal 2"" awardname=""Best game of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, the Zero Punctuation you've been waiting for. Is Portal 2 better than Portal?</teaser>
    </Episode>
    <Episode name=""Castlevania: Symphony of the Night"" number=""197"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3188-Castlevania-Symphony-of-the-Night"" originalname=""Castlevania: Symphony of the Night"" ytlink=""https://www.youtube.com/watch?v=51Zo-tpk5wk"" date=""2011-05-11T16:00:00"">
      <extrap title=""Not All Sequels Suck"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8883-Not-All-Sequels-Suck"" date=""2011-05-17T17:00:00"" />
      <reviewed name=""Castlevania: Symphony of the Night"" wpname=""Castlevania: Symphony of the Night"" />
      <teaser>This week, Zero Punctuation reviews one of the often lauded greatest games of all time, Castlevania: Symphony of the Night.</teaser>
    </Episode>
    <Episode name=""Mortal Kombat"" number=""198"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3250-Mortal-Kombat"" originalname=""Mortal Kombat"" ytlink=""https://www.youtube.com/watch?v=oyQklHNlaaw"" date=""2011-05-18T16:00:00"">
      <extrap title=""Action Is Not Finisher Porn"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8892-Action-Is-Not-Finisher-Porn"" date=""2011-05-24T17:00:00"" />
      <reviewed name=""Mortal Kombat"" wpname=""Mortal Kombat (2011 video game)"" />
      <teaser>This week, Zero Punctuation reviews Mortal Kombat, if he isn't dragged away by the Australian government first.</teaser>
    </Episode>
    <Episode name=""Brink"" number=""199"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3286-Brink"" originalname=""Brink"" ytlink=""https://www.youtube.com/watch?v=35p4wyuzNY0"" date=""2011-05-25T16:00:00"">
      <extrap title=""New Team Fortress 2 Classes"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8910-New-Team-Fortress-2-Classes"" date=""2011-05-31T17:00:00"" />
      <reviewed name=""Brink"" wpname=""Brink (video game)"" />
      <teaser>This week, Zero Punctuation reviews Brink. Also, there is a drinking game involving Team Fortress 2.</teaser>
    </Episode>
    <Episode name=""L.A. Noire"" number=""200"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3347-L-A-Noire"" originalname=""L.A. Noire"" ytlink=""https://www.youtube.com/watch?v=Z2Z7EGPSfDE"" date=""2011-06-01T18:30:00"">
      <extrap title=""L.A. Noire Is a Bad Adventure Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8929-L-A-Noire-Is-a-Bad-Adventure-Game"" date=""2011-06-07T17:00:00"" />
      <reviewed name=""L.A. Noire"" wpname=""L.A. Noire"" />
      <teaser>This week, Zero Punctuation reviews L.A. Confiden... err sorry L.A. Noire.</teaser>
    </Episode>
    <Episode name=""The Witcher 2"" number=""201"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3443-The-Witcher-2-Assassins-of-Kings"" originalname=""The Witcher 2: Assassins of Kings"" ytlink=""https://www.youtube.com/watch?v=Sl_vckONfGs"" date=""2011-06-08T16:00:00"">
      <extrap title=""The Big E3"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8950-The-Big-E3"" date=""2011-06-14T17:00:00"" />
      <reviewed name=""The Witcher 2: Assassins of Kings"" wpname=""The Witcher 2: Assassins of Kings"" />
      <teaser>This week, Zero Punctuation reviews The Witcher 2: Assassins of Kings.</teaser>
    </Episode>
    <Episode name=""Hunted: The Demon's Forge"" number=""202"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3540-Hunted-The-Demons-Forge"" originalname=""Hunted: The Demon's Forge"" ytlink=""https://www.youtube.com/watch?v=bS0XrjNaINQ"" date=""2011-06-15T16:00:00"">
      <extrap title=""Upcoming Games Won't Suck, Hopefully"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8968-Upcoming-Games-Won-t-Suck-Hopefully"" date=""2011-06-21T17:00:00"" />
      <reviewed name=""Hunted: The Demon's Forge"" wpname=""Hunted: The Demon's Forge"" />
      <teaser>This week, Zero Punctuation reviews Hunted: The Demon's Forge and explains why it isn't Duke Nukem Forever yet.</teaser>
    </Episode>
    <Episode name=""Duke Nukem Forever (for real this time)"" number=""203"" length=""312"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3581-Duke-Nukem-Forever-for-real-this-time"" originalname=""Duke Nukem Forever (for real this time)"" ytlink=""https://www.youtube.com/watch?v=hi2xsKHKRUM"" date=""2011-06-22T16:00:00"">
      <extrap title=""What is Mature Anyway?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/8989-What-is-Mature-Anyway"" date=""2011-06-28T17:00:00"" />
      <reviewed name=""Duke Nukem Forever"" wpname=""Duke Nukem Forever"" awardname=""Second Worst of 2011"" awardepisode=""Top 5 of 2011"">
        <seealso>Duke Nukem Forever</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Duke Nukem Forever... again.</teaser>
    </Episode>
    <Episode name=""InFamous 2"" number=""204"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3611-Infamous-2"" originalname=""Infamous 2"" ytlink=""https://www.youtube.com/watch?v=oaWZnjve5cI"" date=""2011-06-29T16:00:00"">
      <extrap title=""Yahtzee Could Have Written Duke Nukem Forever"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9002-Yahtzee-Could-Have-Written-Duke-Nukem-Forever"" date=""2011-07-05T17:00:00"" />
      <reviewed name=""Infamous 2"" wpname=""Infamous 2"" awardname=""Fourth Best of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, Zero Punctuation reviews Infamous 2</teaser>
    </Episode>
    <Episode name=""Alice: Madness Returns"" number=""205"" length=""308"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3652-Alice-Madness-Returns"" originalname=""Alice: Madness Returns"" ytlink=""https://www.youtube.com/watch?v=cyeLHSUEB0w"" date=""2011-07-06T16:00:00"">
      <extrap title=""A Hard Weapon Is Good to Find"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9015-A-Hard-Weapon-Is-Good-to-Find"" date=""2011-07-12T17:00:00"" />
      <reviewed name=""Alice: Madness Returns"" wpname=""Alice: Madness Returns"" />
      <teaser>This week, Zero Punctuation reviews American McGee's sequel adaptation of Lewis Carroll's Alice's Adventures in Wonderland. Now with more creepy baby doll heads!</teaser>
    </Episode>
    <Episode name=""Shadows of the Damned"" number=""206"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3675-Shadows-of-the-Damned"" originalname=""Shadows of the Damned"" ytlink=""https://www.youtube.com/watch?v=Tb6LFSART8M"" date=""2011-07-13T16:00:00"">
      <extrap title=""Alternative Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9027-Alternative-Games"" date=""2011-07-19T17:00:00"" />
      <reviewed name=""Shadows of the Damned"" wpname=""Shadows of the Damned"" />
      <teaser>This week, Zero Punctuation finds out if the Shadows of the Damned developer dream teams pays off or not.</teaser>
    </Episode>
    <Episode name=""F.E.A.R. 3"" number=""207"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3724-FEAR-3"" originalname=""FEAR 3"" ytlink=""https://www.youtube.com/watch?v=uDllxTtbzCA"" date=""2011-07-20T16:00:00"">
      <extrap title=""Mixing Single and Multiplayer"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9035-Mixing-Single-and-Multiplayer"" date=""2011-07-26T17:00:00"" />
      <reviewed name=""FEAR 3"" wpname=""F.E.A.R. 3"" />
      <teaser>This week, Zero Punctuation reviews Fthreear.</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: Ocarina of Time 3D"" number=""208"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3780-The-Legend-of-Zelda-Ocarina-of-Time-3D"" originalname=""The Legend of Zelda: Ocarina of Time 3D"" ytlink=""https://www.youtube.com/watch?v=QO-ATrciXfA"" date=""2011-07-27T16:00:00"">
      <extrap title=""Keeping Old Games Intact"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9053-Keeping-Old-Games-Intact"" date=""2011-08-02T17:00:00"" />
      <reviewed name=""The Legend of Zelda: Ocarina of Time 3D"" wpname=""The Legend of Zelda: Ocarina of Time 3D"" />
      <teaser>This week, prepare for a shock as Zero Punctuation reviews The Legend of Zelda: Ocarina of Time 3D.</teaser>
    </Episode>
    <Episode name=""Call of Juarez: The Cartel"" number=""209"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3801-Call-of-Juarez-The-Cartel"" originalname=""Call of Juarez: The Cartel"" ytlink=""https://www.youtube.com/watch?v=C4csI-Dg0pU"" date=""2011-08-03T16:00:00"">
      <extrap title=""The Rise of Rail Roading"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9063-The-Rise-of-Rail-Roading"" date=""2011-08-09T17:00:00"" />
      <reviewed name=""Call of Juarez: The Cartel"" wpname=""Call of Juarez: The Cartel"" />
      <teaser>This week, Zero Punctuation reviews Call of Juarez: The Cartel.</teaser>
    </Episode>
    <Episode name=""Bastion and From Dust"" number=""210"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3839-Bastion-and-From-Dust"" originalname=""Bastion and From Dust"" ytlink=""https://www.youtube.com/watch?v=4jC67AVcbms"" date=""2011-08-10T16:00:00"">
      <extrap title=""Game Stories Demand Focus"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9074-Game-Stories-Demand-Focus"" date=""2011-08-16T17:00:00"" />
      <reviewed name=""Bastion"" wpname=""Bastion (video game)"" awardname=""Third Best of 2011"" awardepisode=""Top 5 of 2011"" />
      <reviewed name=""From Dust"" wpname=""From Dust"" />
      <teaser>This week, Zero Punctuation does another XBLA double review with Bastion and From Dust.</teaser>
    </Episode>
    <Episode name=""Catherine"" number=""211"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3872-Catherine"" originalname=""Catherine"" ytlink=""https://www.youtube.com/watch?v=h0m-doynMnc"" date=""2011-08-17T16:00:00"">
      <extrap title=""Why No Couples in Games?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9087-Why-No-Couples-in-Games"" date=""2011-08-23T17:00:00"" />
      <reviewed name=""Catherine"" wpname=""Catherine (video game)"" />
      <teaser>This week, Zero Punctuation reviews Catherine. Or is it Katherine? Yeah, that's not going to be confusing.</teaser>
    </Episode>
    <Episode name=""Red Faction: Armageddon"" number=""212"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/3942-Red-Faction-Armageddon"" originalname=""Red Faction Armageddon"" ytlink=""https://www.youtube.com/watch?v=kyPQ-rjXtMQ"" date=""2011-08-24T16:00:00"">
      <extrap title=""Time for Gaming's Physical"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9095-Time-for-Gaming-s-Physical"" date=""2011-08-30T17:00:00"" />
      <reviewed name=""Red Faction Armageddon"" wpname=""Red Faction: Armageddon"" awardname=""Fourth Worst of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, Zero Punctuation reviews Red Faction Armageddon.</teaser>
    </Episode>
    <Episode name=""Deus Ex"" number=""213"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4093-Deus-Ex"" originalname=""Deus Ex"" ytlink=""https://www.youtube.com/watch?v=W_LULRj_f4w"" date=""2011-08-31T16:00:00"">
      <extrap title=""Golden Era of PC Gaming"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9105-Golden-Era-of-PC-Gaming"" date=""2011-09-06T17:00:00"" />
      <reviewed name=""Deus Ex"" wpname=""Deus Ex"" />
      <teaser>This week in preparation for Deus Ex: Human Revolution, Zero Punctuation retrospectively reviews Deus Ex.</teaser>
    </Episode>
    <Episode name=""Deus Ex: Human Revolution"" number=""214"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4137-Deus-Ex-Human-Revolution"" originalname=""Deus Ex: Human Revolution"" ytlink=""https://www.youtube.com/watch?v=8oE54GSVxUQ"" date=""2011-09-07T16:00:00"">
      <extrap title=""What Human Revolution Got Wrong"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9115-What-Human-Revolution-Got-Wrong"" date=""2011-09-13T17:00:00"" />
      <reviewed name=""Deus Ex: Human Revolution"" wpname=""Deus Ex: Human Revolution"" />
      <teaser>Following up on last weeks retrospective on the original Deus Ex, Zero Punctuation reviews Deus Ex: Human Revolution.</teaser>
    </Episode>
    <Episode name=""Driver: San Francisco"" number=""215"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4181-Driver-San-Francisco"" originalname=""Driver: San Francisco"" ytlink=""https://www.youtube.com/watch?v=-OJai9dKraI"" date=""2011-09-14T16:00:00"">
      <extrap title=""Driver San Francisco's Silliness Works"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9131-Driver-San-Francisco-s-Silliness-Works"" date=""2011-09-20T17:00:00"" />
      <reviewed name=""Driver: San Francisco"" wpname=""Driver: San Francisco"" awardname=""Second Best of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, Zero Punctuation is pleasantly surprised by Driver: San Francisco.</teaser>
    </Episode>
    <Episode name=""Dead Island"" number=""216"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4694-Dead-Island"" originalname=""Dead Island"" ytlink=""https://www.youtube.com/watch?v=LSXu7FusSUk"" date=""2011-09-21T16:00:00"">
      <extrap title=""Weapon-Crafting That Works"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9139-Weapon-Crafting-That-Works"" date=""2011-09-27T17:00:00"" />
      <reviewed name=""Dead Island"" wpname=""Dead Island"" awardname=""Third Worst of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, Zero Punctuation returns to the zombie apocalypse, again, for Dead Island.</teaser>
    </Episode>
    <Episode name=""Resistance 3"" number=""217"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4728-Resistance-3"" originalname=""Resistance 3"" ytlink=""https://www.youtube.com/watch?v=ue8TujFWKjQ"" date=""2011-09-28T16:00:00"">
      <extrap title=""Hating Warhammer 40k and Space Marine"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9153-Hating-Warhammer-40k-and-Space-Marine"" date=""2011-10-04T17:00:00"" />
      <reviewed name=""Resistance 3"" wpname=""Resistance 3"" />
      <teaser>This week, Zero Punctuation reviews Resistance 3 with a hint of deja vu.</teaser>
    </Episode>
    <Episode name=""Gears of War 3"" number=""218"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4763-Gears-of-War-3"" originalname=""Gears of War 3"" ytlink=""https://www.youtube.com/watch?v=3jYZ4NF7mHU"" date=""2011-10-05T16:00:00"">
      <extrap title=""Manly Vs. Macho in Gears"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9163-Manly-Vs-Macho-in-Gears"" date=""2011-10-11T17:00:00"" />
      <reviewed name=""Gears of War 3"" wpname=""Gears of War 3"" />
      <teaser>This week, Zero Punctuation reviews thick necked refrigerator armor marine 3.</teaser>
    </Episode>
    <Episode name=""Hard Reset"" number=""219"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4784-Hard-Reset"" originalname=""Hard Reset"" ytlink=""https://www.youtube.com/watch?v=Vbpok1Dw7uI"" date=""2011-10-12T16:00:00"">
      <extrap title=""Shooters of Yore"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9172-Shooters-of-Yore"" date=""2011-10-18T17:00:00"" />
      <reviewed name=""Hard Reset"" wpname=""Hard Reset"" />
      <teaser>This week, Shooter Season 2011 continues as Zero Punctuation reviews Hard Reset.</teaser>
    </Episode>
    <Episode name=""Rage"" number=""220"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4824-Rage"" originalname=""Rage"" ytlink=""https://www.youtube.com/watch?v=mqr3JfXkQig"" date=""2011-10-19T16:00:00"">
      <extrap title=""Sidequests Good and Bad"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9188-Sidequests-Good-and-Bad"" date=""2011-10-25T17:00:00"" />
      <reviewed name=""Rage"" wpname=""Rage (video game)"" />
      <teaser>This week, Zero Punctuation gives some fashion advice for the post-apocalypse.</teaser>
    </Episode>
    <Episode name=""Kinect"" number=""221"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4863-Kinect"" originalname=""Kinect"" ytlink=""https://www.youtube.com/watch?v=WgvFfFK5KFA"" date=""2011-10-26T16:00:00"">
      <extrap title=""What Kinect Can Do"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9198-What-Kinect-Can-Do"" date=""2011-11-01T17:00:00"" />
      <reviewed name=""Kinect"" wpname=""Kinect"" awardname=""The Greater London One-Way System Award for Biggest Dead End"" awardepisode=""Awards for 2009"" />
      <reviewed name=""Child of Eden"" wpname=""Child of Eden"" />
      <reviewed name=""Rise of Nightmares"" wpname=""Rise of Nightmares"" />
      <teaser>This week, Zero Punctuation reviews the Kinect.</teaser>
    </Episode>
    <Episode name=""Batman: Arkham City"" number=""222"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4915-Batman-Arkham-City"" originalname=""Batman: Arkham City"" ytlink=""https://www.youtube.com/watch?v=OfFljXE47wA"" date=""2011-11-02T16:00:00"">
      <extrap title=""The Sandbox Killed Batman"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9212-The-Sandbox-Killed-Batman"" date=""2011-11-08T17:00:00"" />
      <reviewed name=""Batman: Arkham City"" wpname=""Batman: Arkham City"" />
      <teaser>This week, Zero Punctuation returns to the black tights of everyone's favorite caped crusader.</teaser>
    </Episode>
    <Episode name=""Battlefield 3"" number=""223"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4948-Battlefield-3"" originalname=""Battlefield 3"" ytlink=""https://www.youtube.com/watch?v=LTLD20KIiLM"" date=""2011-11-09T16:00:00"">
      <extrap title=""Battlefield 3 Is Scary"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9226-Battlefield-3-Is-Scary"" date=""2011-11-15T17:00:00"" />
      <reviewed name=""Battlefield 3"" wpname=""Battlefield 3"" awardname=""Worst game of 2011 (shared with Call of Duty: Modern Warfare 3)"" awardepisode=""Top 5 of 2011"">
        <seealso>Call of Duty: Modern Warfare 3</seealso>
      </reviewed>
      <teaser>After a brief respite, Shooter Season 2011 returns with Battlefield 3.</teaser>
    </Episode>
    <Episode name=""Uncharted 3: Drake's Deception"" number=""224"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/4972-Uncharted-3-Drakes-Deception"" originalname=""Uncharted 3: Drake's Deception"" ytlink=""https://www.youtube.com/watch?v=TJ5uES4Ry2o"" date=""2011-11-16T16:00:00"">
      <extrap title=""Uncharted 3 Should've Tried Harder"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9235-Uncharted-3-Should-ve-Tried-Harder"" date=""2011-11-22T17:00:00"" />
      <reviewed name=""Uncharted 3: Drake's Deception"" wpname=""Uncharted 3: Drake's Deception"" />
      <teaser>This week, Zero Punctuation returns to the snarky world of treasure hunting with Uncharted 3: Drake's Deception.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Modern Warfare 3"" number=""225"" length=""339"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5006-Call-of-Duty-Modern-Warfare-3"" originalname=""Call of Duty: Modern Warfare 3"" ytlink=""https://www.youtube.com/watch?v=YM4RQHgYpow"" date=""2011-11-23T16:00:00"">
      <extrap title=""What Is the Matter with You People?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9246-What-Is-the-Matter-with-You-People"" date=""2011-11-29T17:00:00"" />
      <reviewed name=""Call of Duty: Modern Warfare 3"" wpname=""Call of Duty: Modern Warfare 3"" awardname=""Worst game of 2011 (shared with Battlefield 3)"" awardepisode=""Top 5 of 2011"" />
      <reviewed name=""Battlefield 3"" wpname=""Battlefield 3"" awardname=""Worst game of 2011 (shared with Call of Duty: Modern Warfare 3)"" awardepisode=""Top 5 of 2011"">
        <seealso>Battlefield 3</seealso>
      </reviewed>
      <teaser>This week, breaks down Call of Duty: Modern Warfare 3 and Battlefield 3.</teaser>
    </Episode>
    <Episode name=""The Elder Scrolls V: Skyrim"" number=""226"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5020-The-Elder-Scrolls-V-Skyrim"" originalname=""The Elder Scrolls V: Skyrim"" ytlink=""https://www.youtube.com/watch?v=lttqPaaCt0s"" date=""2011-11-30T16:00:00"">
      <extrap title=""Too Many Options in Skyrim"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9257-Too-Many-Options-in-Skyrim"" date=""2011-12-06T17:00:00"" />
      <reviewed name=""The Elder Scrolls V: Skyrim"" wpname=""The Elder Scrolls V: Skyrim"" awardname=""Fifth Best of 2011"" awardepisode=""Top 5 of 2011"" />
      <teaser>This week, FUS RO DAH!</teaser>
    </Episode>
    <Episode name=""Saints Row: The Third"" number=""227"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5056-Saints-Row-The-Third"" originalname=""Saints Row: The Third"" ytlink=""https://www.youtube.com/watch?v=fPYofAaVG2g"" date=""2011-12-07T16:00:00"">
      <extrap title=""Context, Challenge and Gratification"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9276-Context-Challenge-and-Gratification"" date=""2011-12-13T17:00:00"" />
      <reviewed name=""Saints Row: The Third"" wpname=""Saints Row: The Third"" />
      <teaser>This week, Zero Punctuation reviews Saints Row: The Third.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed: Revelations"" number=""228"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5114-Assassins-Creed-Revelations"" originalname=""Assassin's Creed: Revelations"" ytlink=""https://www.youtube.com/watch?v=wo5yyMa1BWQ"" date=""2011-12-14T16:00:00"">
      <extrap title=""Assassin's Creed 2.85"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9287-Assassin-s-Creed-2-85"" date=""2011-12-20T17:00:00"" />
      <reviewed name=""Assassin's Creed: Revelations"" wpname=""Assassin's Creed: Revelations"" />
      <teaser>This week, Zero Punctuation takes up the hidden blade, hood and faffing about again.</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: Skyward Sword"" number=""229"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5148-The-Legend-of-Zelda-Skyward-Sword"" originalname=""The Legend of Zelda: Skyward Sword"" date=""2011-12-21T16:00:00"">
      <extrap title=""Skyward Sword"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9308-Skyward-Sword"" date=""2011-12-28T03:00:00"" />
      <reviewed name=""The Legend of Zelda: Skyward Sword"" wpname=""The Legend of Zelda: Skyward Sword"" />
      <teaser>This week, Zero Punctuation reviews The Legend of Zelda: Skyward Sword.</teaser>
    </Episode>
    <Episode name=""Serious Sam 3: BFE"" number=""230"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5184-Serious-Sam-3-BFE"" originalname=""Serious Sam 3: BFE"" ytlink=""https://www.youtube.com/watch?v=CkCi-0llOTY"" date=""2012-01-04T16:00:00"">
      <extrap title=""Non-Violent Game Idea: Puppies in Hell"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9334-Non-Violent-Game-Idea-Puppies-in-Hell"" date=""2012-01-10T17:00:00"" />
      <reviewed name=""Serious Sam 3: BFE"" wpname=""Serious Sam 3: BFE"" />
      <teaser>This week, Zero Punctuation reviews Serious Sam 3: BFE.</teaser>
    </Episode>
    <Episode name=""Top 5 of 2011"" number=""231"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5207-Top-5-of-2011"" originalname=""Top 5 of 2011"" ytlink=""https://www.youtube.com/watch?v=NC9aTJ7m-Qc"" date=""2012-01-11T16:00:00"">
      <extrap title=""The Not Quite Best Games of 2011"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9349-The-Not-Quite-Best-Games-of-2011"" date=""2012-01-17T17:00:00"" />
      <teaser>This week, Zero Punctuation runs down the top 5 best and worst games of 2011.</teaser>
    </Episode>
    <Episode name=""Super Mario 3D Land &amp; Rayman Origins"" number=""232"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5239-Super-Mario-3D-Land-Rayman-Origins"" originalname=""Super Mario 3D Land &amp; Rayman Origins"" ytlink=""https://www.youtube.com/watch?v=_mq97KuraFE"" date=""2012-01-18T16:00:00"">
      <extrap title=""Death Mechanics and Dark Souls"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9361-Death-Mechanics-and-Dark-Souls"" date=""2012-01-24T17:00:00"" />
      <reviewed name=""Super Mario 3D Land"" wpname=""Super Mario 3D Land"" />
      <reviewed name=""Rayman Origins"" wpname=""Rayman Origins"" />
      <teaser>This week, Zero Punctuation reviews Super Mario 3D Land and Rayman Origins.</teaser>
    </Episode>
    <Episode name=""Sonic Generations"" number=""233"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5284-Sonic-Generations"" originalname=""Sonic Generations"" ytlink=""https://www.youtube.com/watch?v=wT2hd51zgwo"" date=""2012-01-25T16:00:00"">
      <extrap title=""Sonic the Poacher"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9378-Sonic-the-Poacher"" date=""2012-01-31T17:00:00"" />
      <reviewed name=""Sonic Generations"" wpname=""Sonic Generations"" />
      <teaser>This week, Zero Punctuation reviews Sonic Generations.</teaser>
    </Episode>
    <Episode name=""Star Wars: The Old Republic"" number=""234"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5323-Star-Wars-The-Old-Republic"" originalname=""Star Wars: The Old Republic"" ytlink=""https://www.youtube.com/watch?v=NbesTMutvzI"" date=""2012-02-01T16:00:00"">
      <extrap title=""Roleplaying The Old Republic"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9396-Roleplaying-The-Old-Republic"" date=""2012-02-07T17:00:00"" />
      <reviewed name=""Star Wars: The Old Republic"" wpname=""Star Wars: The Old Republic"" />
      <teaser>This week, Zero Punctuation reviews Star Wars: The Old Republic.</teaser>
    </Episode>
    <Episode name=""Amy"" number=""235"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5346-Amy"" originalname=""Amy"" ytlink=""https://www.youtube.com/watch?v=ehcU90xJrwE"" date=""2012-02-08T16:00:00"">
      <extrap title=""Escorts Aren't Free"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9413-Escorts-Aren-t-Free"" date=""2012-02-14T17:00:00"" />
      <reviewed name=""Amy"" wpname=""Amy (video game)"" awardname=""Worst game of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Amy.</teaser>
    </Episode>
    <Episode name=""Resident Evil: Revelations"" number=""236"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5373-Resident-Evil-Revelations"" originalname=""Resident Evil: Revelations"" ytlink=""https://www.youtube.com/watch?v=Vf3vn6c38M0"" date=""2012-02-15T16:00:00"">
      <extrap title=""Survival Horror on a Cruise Ship"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9423-Survival-Horror-on-a-Cruise-Ship"" date=""2012-02-21T17:00:00"" />
      <reviewed name=""Resident Evil: Revelations"" wpname=""Resident Evil: Revelations"" />
      <teaser>This week, Zero Punctuation reviews Resident Evil: Revelations.</teaser>
    </Episode>
    <Episode name=""Darkness 2"" number=""237"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5394-Darkness-2"" originalname=""Darkness 2"" ytlink=""https://www.youtube.com/watch?v=EE5HbfUECcE"" date=""2012-02-22T16:00:00"">
      <extrap title=""Why Movie Adaptations of Games Suck"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9443-Why-Movie-Adaptations-of-Games-Suck"" date=""2012-02-28T17:00:00"" />
      <reviewed name=""The Darkness 2"" wpname=""The Darkness II"" />
      <teaser>This week, Zero Punctuation reviews Darkness 2.</teaser>
    </Episode>
    <Episode name=""Kingdoms of Amalur: Reckoning"" number=""238"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5416-Kingdoms-of-Amalur-Reckoning"" originalname=""Kingdoms of Amalur: Reckoning"" ytlink=""https://www.youtube.com/watch?v=XtdurL_bfsc"" date=""2012-02-29T16:00:00"">
      <extrap title=""Elves and Dwarves Don't Define Fantasy"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9460-Elves-and-Dwarves-Don-t-Define-Fantasy"" date=""2012-03-06T17:00:00"" />
      <reviewed name=""Kingdoms of Amalur: Reckoning"" wpname=""Kingdoms of Amalur: Reckoning"" />
      <teaser>This week, Zero Punctuation review Kingdoms of Amalur: Reckoning,</teaser>
    </Episode>
    <Episode name=""NeverDead"" number=""239"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5443-NeverDead"" originalname=""NeverDead"" ytlink=""https://www.youtube.com/watch?v=xbQ-Qwcuehk"" date=""2012-03-07T16:00:00"">
      <extrap title=""How to Make Neverdead Better"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9477-How-to-Make-Neverdead-Better"" date=""2012-03-13T17:00:00"" />
      <reviewed name=""NeverDead"" wpname=""NeverDead"" awardname=""Fourth Worst of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation review NeverDead.</teaser>
    </Episode>
    <Episode name=""Syndicate"" number=""240"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5478-Syndicate"" originalname=""Syndicate"" ytlink=""https://www.youtube.com/watch?v=F0D8xcx1JNg"" date=""2012-03-14T16:00:00"">
      <extrap title=""Syndicate Gets Gimmicky"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9492-Syndicate-Gets-Gimmicky"" date=""2012-03-20T17:00:00"" />
      <reviewed name=""Syndicate"" wpname=""Syndicate (2012 video game)"" />
      <teaser>This week, Zero Punctuation review Syndicate.</teaser>
    </Episode>
    <Episode name=""Mass Effect 3"" number=""241"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5497-Mass-Effect-3"" originalname=""Mass Effect 3"" ytlink=""https://www.youtube.com/watch?v=d-Fh1OFTdVo"" date=""2012-03-21T16:00:00"">
      <extrap title=""Mass Effect 3 Gets An Ending"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9511-Mass-Effect-3-Gets-An-Ending"" date=""2012-03-27T17:00:00"" />
      <reviewed name=""Mass Effect 3"" wpname=""Mass Effect 3"" />
      <teaser>This week, Zero Punctuation reviews Mass Effect 3.</teaser>
    </Episode>
    <Episode name=""Twisted Metal"" number=""242"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5531-Twisted-Metal"" originalname=""Twisted Metal"" ytlink=""https://www.youtube.com/watch?v=xMwTPlBq2J0"" date=""2012-03-28T16:00:00"">
      <extrap title=""When &quot;Dark and Edgy&quot; Goes Too Far"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9528-When-Dark-and-Edgy-Goes-Too-Far"" date=""2012-04-03T17:00:00"" />
      <reviewed name=""Twisted Metal"" wpname=""Twisted Metal (2012 video game)"" />
      <teaser>This week, Zero Punctuation reviews Twisted Metal.</teaser>
    </Episode>
    <Episode name=""Yakuza: Dead Souls"" number=""243"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5558-Yakuza-Dead-Souls"" originalname=""Yakuza: Dead Souls"" ytlink=""https://www.youtube.com/watch?v=wudc8nOSScU"" date=""2012-04-04T16:00:00"">
      <extrap title=""The Growth of the Zombie Myth"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9542-The-Growth-of-the-Zombie-Myth"" date=""2012-04-10T17:00:00"" />
      <reviewed name=""Yakuza: Dead Souls"" wpname=""Yakuza: Dead Souls"" />
      <teaser>The Japanese crime syndicates are not fans of zombies either.</teaser>
    </Episode>
    <Episode name=""Ninja Gaiden 3"" number=""244"" length=""348"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5576-Ninja-Gaiden-3"" originalname=""Ninja Gaiden 3"" ytlink=""https://www.youtube.com/watch?v=LYvPWE696Ms"" date=""2012-04-11T16:00:00"">
      <extrap title=""Why Easy Games Fail Yahtzee's Game Theory"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9557-Why-Easy-Games-Fail-Yahtzee-s-Game-Theory"" date=""2012-04-17T17:00:00"" />
      <reviewed name=""Ninja Gaiden 3"" wpname=""Ninja Gaiden 3"" />
      <teaser>Someone in the games industry needs to reexamine what a curse is.</teaser>
    </Episode>
    <Episode name=""Silent Hill: Downpour"" number=""245"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5595-Silent-Hill-Downpour"" originalname=""Silent Hill: Downpour"" ytlink=""https://www.youtube.com/watch?v=w-cGrPLJvXI"" date=""2012-04-18T16:00:00"">
      <extrap title=""Big Studios Can't Produce Good Horror Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9572-Big-Studios-Can-t-Produce-Good-Horror-Games"" date=""2012-04-24T17:00:00"" />
      <reviewed name=""Silent Hill: Downpour"" wpname=""Silent Hill: Downpour"" />
      <teaser>A step in the right direction for survival combat and exploration but Silent Hill: Downpour fails at the horror half of survival horror.</teaser>
    </Episode>
    <Episode name=""Kid Icarus: Uprising"" number=""246"" length=""332"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5634-Kid-Icarus-Uprising"" originalname=""Kid Icarus: Uprising"" ytlink=""https://www.youtube.com/watch?v=cZMYcfENJE8"" date=""2012-04-25T16:00:00"">
      <extrap title=""Kid Icarus: Uprising and Hurt Nintendo Fans"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9583-Kid-Icarus-Uprising-and-Hurt-Nintendo-Fans"" date=""2012-05-01T17:00:00"" />
      <reviewed name=""Kid Icarus: Uprising"" wpname=""Kid Icarus: Uprising"" />
      <teaser>Kid Icarus plays it fast and loose with Greek mythology.</teaser>
    </Episode>
    <Episode name=""Fez and I Am Alive"" number=""247"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5662-Fez-and-I-Am-Alive"" originalname=""Fez and I Am Alive"" ytlink=""https://www.youtube.com/watch?v=e0StdRykbU4"" date=""2012-05-02T16:00:00"">
      <extrap title=""How to Become a Game Journalist"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9604-How-to-Become-a-Game-Journalist"" date=""2012-05-08T17:00:00"" />
      <reviewed name=""Fez"" wpname=""Fez (video game)"" />
      <reviewed name=""I Am Alive"" wpname=""I Am Alive"" />
      <teaser>This week, Zero Punctuation reveals there are a lot of similarities in indie games.</teaser>
    </Episode>
    <Episode name=""Prototype 2"" number=""248"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5688-Prototype-2"" originalname=""Prototype 2"" ytlink=""https://www.youtube.com/watch?v=tSefw2jWHIo"" date=""2012-05-09T16:00:00"">
      <extrap title=""Prototype's Story Holes"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9615-Prototype-s-Story-Holes"" date=""2012-05-15T17:00:00"" />
      <reviewed name=""Prototype 2"" wpname=""Prototype 2"" />
      <teaser>This week, Zero Punctuation reviews Prototype 2.</teaser>
    </Episode>
    <Episode name=""Risen 2: Dark Waters"" number=""249"" length=""426"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5710-Risen-2-Dark-Waters"" originalname=""Risen 2: Dark Waters"" ytlink=""https://www.youtube.com/watch?v=FEZzVsAabZw"" date=""2012-05-16T16:00:00"">
      <extrap title=""Pirates Are Way More Interesting Than Elves"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9632-Pirates-Are-Way-More-Interesting-Than-Elves"" date=""2012-05-22T17:00:00"" />
      <reviewed name=""Risen 2: Dark Waters"" wpname=""Risen 2: Dark Waters"" />
      <teaser>This week, Zero Punctuation reviews Risen 2: Dark Waters.</teaser>
    </Episode>
    <Episode name=""Sniper Elite V2"" number=""250"" length=""353"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5745-Sniper-Elite-V2"" originalname=""Sniper Elite V2"" ytlink=""https://www.youtube.com/watch?v=SGHqc09Pu-0"" date=""2012-05-23T16:00:00"">
      <extrap title=""What Ethnic Group Will Replace Nazis?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9648-What-Ethnic-Group-Will-Replace-Nazis"" date=""2012-05-29T17:00:00"" />
      <reviewed name=""Sniper Elite V2"" wpname=""Sniper Elite V2"" />
      <teaser>This week, Zero Punctuation reviews Sniper Elite V2.</teaser>
    </Episode>
    <Episode name=""Diablo 3"" number=""251"" length=""339"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5777-Diablo-3"" originalname=""Diablo 3"" ytlink=""https://www.youtube.com/watch?v=E0oZZRBIImQ"" date=""2012-05-30T16:00:00"">
      <extrap title=""Why Randomly Generated Content Sucks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9669-Why-Randomly-Generated-Content-Sucks"" date=""2012-06-05T17:00:00"" />
      <reviewed name=""Diablo 3"" wpname=""Diablo III"" />
      <teaser>This week, Zero Punctiaion reviews Blizzard's latest click-fest Diablo 3.</teaser>
    </Episode>
    <Episode name=""Max Payne 3"" number=""252"" length=""349"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5893-Max-Payne-3"" originalname=""Max Payne 3"" ytlink=""https://www.youtube.com/watch?v=ZKPJvDdAY34"" date=""2012-06-06T16:00:00"">
      <extrap title=""F'ing Up Isn't So Bad"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9733-F-ing-Up-Isn-t-So-Bad"" date=""2012-06-12T17:00:00"" />
      <reviewed name=""Max Payne 3"" wpname=""Max Payne 3"" />
      <teaser>The game went down with practiced bravado. Yellow backgrounds crawled across the sky, laden with foreboding.</teaser>
    </Episode>
    <Episode name=""Dragon's Dogma"" number=""253"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5932-Dragons-Dogma"" originalname=""Dragon's Dogma"" ytlink=""https://www.youtube.com/watch?v=pHUJhBv5nWI"" date=""2012-06-13T16:00:00"">
      <extrap title=""Drop The High Scores"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9754-Drop-The-High-Scores"" date=""2012-06-19T17:00:00"" />
      <reviewed name=""Dragon's Dogma"" wpname=""Dragon's Dogma"" />
      <teaser>This week, Zero Punctuation reviews Dragon's Dogma.</teaser>
    </Episode>
    <Episode name=""E3 2012"" number=""254"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5951-E3-2012"" originalname=""E3 2012"" ytlink=""https://www.youtube.com/watch?v=IIJxsvqF9AE"" date=""2012-06-20T16:00:00"">
      <extrap title=""What Not to Hate About E3"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9768-What-Not-to-Hate-About-E3"" date=""2012-06-26T17:00:00"" />
      <teaser>This week, Zero Punctuation takes a look at the trailers offered at E3 this year.</teaser>
    </Episode>
    <Episode name=""Lollipop Chainsaw"" number=""255"" length=""367"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5977-Lollipop-Chainsaw"" originalname=""Lollipop Chainsaw"" ytlink=""https://www.youtube.com/watch?v=ttzLwR6SrKw"" date=""2012-06-27T16:00:00"">
      <extrap title=""Excessively Excessive"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9781-Excessively-Excessive"" date=""2012-07-03T17:00:00"" />
      <reviewed name=""Lollipop Chainsaw"" wpname=""Lollipop Chainsaw"" />
      <teaser>This week, Zero Punctuation reviews Lollipop Chainsaw.</teaser>
    </Episode>
    <Episode name=""Quantum Conundrum"" number=""256"" length=""338"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/5998-Quantum-Conundrum"" originalname=""Quantum Conundrum"" ytlink=""https://www.youtube.com/watch?v=SniYgg_sfAo"" date=""2012-07-04T16:00:00"">
      <extrap title=""First Person Platforming"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9796-First-Person-Platforming"" date=""2012-07-10T17:00:00"" />
      <reviewed name=""Quantum Conundrum"" wpname=""Quantum Conundrum"" />
      <reviewed name=""Steel Battalion: Heavy Armor"" wpname=""Steel Battalion: Heavy Armor"" awardname=""Third Worst of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Quantum Conundrum and also Steel Battalion: Heavy Armor.</teaser>
    </Episode>
    <Episode name=""Spec Ops: The Line"" number=""257"" length=""353"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6021-Spec-Ops-The-Line"" originalname=""Spec Ops: The Line"" ytlink=""https://www.youtube.com/watch?v=HNhPMjbgkXA"" date=""2012-07-11T16:00:00"">
      <extrap title=""Crossing Spec Ops: The Line"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9810-Crossing-Spec-Ops-The-Line"" date=""2012-07-17T17:00:00"" />
      <reviewed name=""Spec Ops: The Line"" wpname=""Spec Ops: The Line"" awardname=""Best game of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Spec Ops: The Line.</teaser>
    </Episode>
    <Episode name=""Walking Dead"" number=""258"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6044-Walking-Dead"" originalname=""Walking Dead"" ytlink=""https://www.youtube.com/watch?v=U0OvwUlLx08"" date=""2012-07-18T16:00:00"">
      <extrap title=""Traditional Adventure Games Are Rubbish"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9820-Traditional-Adventure-Games-Are-Rubbish"" date=""2012-07-24T17:00:00"" />
      <reviewed name=""The Walking Dead"" wpname=""The Walking Dead (video game)"" awardname=""Fourth Best of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>Zombie adventure game? Is the puzzle solution 'use shotgun'?</teaser>
    </Episode>
    <Episode name=""Inversion"" number=""259"" length=""348"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6083-Inversion"" originalname=""Inversion"" ytlink=""https://www.youtube.com/watch?v=dZ32bP12DoQ"" date=""2012-07-25T16:00:00"">
      <extrap title=""Plot Inversions"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9835-Plot-Inversions"" date=""2012-07-31T17:00:00"" />
      <reviewed name=""Inversion"" wpname=""Inversion (video game)"" />
      <teaser>This week, after the surprise of Spec Ops: The Line, Inversion has us back to being able to judge a game by the cover.</teaser>
    </Episode>
    <Episode name=""The Amazing Spider-Man"" number=""260"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6104-The-Amazing-Spider-Man"" originalname=""The Amazing Spider-Man"" ytlink=""https://www.youtube.com/watch?v=NQrJEXeQ8xk"" date=""2012-08-01T16:00:00"">
      <extrap title=""Spider-Man's Knickers"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9847-Spider-Man-s-Knickers"" date=""2012-08-07T17:00:00"" />
      <reviewed name=""The Amazing Spider-Man"" wpname=""The Amazing Spider-Man (2012 video game)"" />
      <teaser>This week, Zero Punctuation reviews everyone's favorite web slinger.</teaser>
    </Episode>
    <Episode name=""Half-Life"" number=""261"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6126-Half-Life"" originalname=""Half-Life"" ytlink=""https://www.youtube.com/watch?v=9dPX2cRnw_A"" date=""2012-08-08T16:00:00"">
      <extrap title=""Valve's Making Up Half-Life Along the Way"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9862-Valve-s-Making-Up-Half-Life-Along-the-Way"" date=""2012-08-14T17:00:00"" />
      <reviewed name=""Half-Life"" wpname=""Half-Life (video game)"" />
      <teaser>This week, it's time for that game.</teaser>
    </Episode>
    <Episode name=""Wreckateer and Deadlight"" number=""262"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6163-Wreckateer-and-Deadlight"" originalname=""Wreckateer and Deadlight"" ytlink=""https://www.youtube.com/watch?v=x2lHx5HaaLg"" date=""2012-08-15T16:00:00"">
      <extrap title=""The Summer of Arcade Sucks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9877-The-Summer-of-Arcade-Sucks"" date=""2012-08-21T17:00:00"" />
      <reviewed name=""Wreckateer"" wpname=""Wreckateer"" />
      <reviewed name=""Deadlight"" wpname=""Deadlight"" />
      <teaser>This week, Zero Punctuation reviews two offerings from this year's XBLA Summer of Aracade.</teaser>
    </Episode>
    <Episode name=""Steam Roundup"" number=""263"" length=""345"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6190-Steam-Roundup"" originalname=""Steam Roundup"" ytlink=""https://www.youtube.com/watch?v=jrFgv5R_oiI"" date=""2012-08-22T16:00:00"">
      <extrap title=""It's All In Good Humor"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9889-It-s-All-In-Good-Humor"" date=""2012-08-28T17:00:00"" />
      <reviewed name=""Unmechanical"" wpname=""Unmechanical"" />
      <reviewed name=""Orcs Must Die! 2"" wpname=""Orcs Must Die! 2"" />
      <reviewed name=""The Book of Unwritten Tales"" wpname=""The Book of Unwritten Tales"" />
      <teaser>Fall releases are right around the corner, so Zero Punctuation takes this last chance to look at a few recent indie titles released on Steam.</teaser>
    </Episode>
    <Episode name=""Sleeping Dogs"" number=""264"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6224-Sleeping-Dogs"" originalname=""Sleeping Dogs"" ytlink=""https://www.youtube.com/watch?v=G5-W8GqOtSE"" date=""2012-08-29T16:00:00"">
      <extrap title=""Problems With The Sandbox"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9898-Problems-With-The-Sandbox"" date=""2012-09-04T17:00:00"" />
      <reviewed name=""Sleeping Dogs"" wpname=""Sleeping Dogs (video game)"" />
      <teaser>This week, Zero Punctuation reviews Sleeping Dogs.</teaser>
    </Episode>
    <Episode name=""Darksiders 2"" number=""265"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6248-Darksiders-2"" originalname=""Darksiders 2"" ytlink=""https://www.youtube.com/watch?v=3OpiHSpdm0A"" date=""2012-09-05T16:00:00"">
      <extrap title=""The Motivations of Death"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9915-The-Motivations-of-Death"" date=""2012-09-11T17:00:00"" />
      <reviewed name=""Darksiders 2"" wpname=""Darksiders II"" />
      <teaser>This week, Zero Punctuation reviews Darksiders 2.</teaser>
    </Episode>
    <Episode name=""DayZ"" number=""266"" length=""342"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6276-DayZ"" originalname=""DayZ"" ytlink=""https://www.youtube.com/watch?v=TU1E4jwquzU"" date=""2012-09-12T16:00:00"">
      <extrap title=""How to Be a Nethernaut in Minecraft's Hardcore Mode"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9937-How-to-Be-a-Nethernaut-in-Minecraft-s-Hardcore-Mode"" date=""2012-09-25T17:00:00"" />
      <reviewed name=""DayZ"" wpname=""DayZ (video game)"" />
      <teaser>This week, Zero Punctuation reviews DayZ.</teaser>
    </Episode>
    <Episode name=""Guild Wars 2"" number=""267"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6337-Guild-Wars-2"" originalname=""Guild Wars 2"" ytlink=""https://www.youtube.com/watch?v=XM9JBNVYE_w"" date=""2012-09-26T16:00:00"">
      <extrap title=""Reliving Gordon Freeman's Worst Day"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9952-Reliving-Gordon-Freeman-s-Worst-Day"" date=""2012-10-02T17:00:00"" />
      <reviewed name=""Guild Wars 2"" wpname=""Guild Wars 2"" />
      <teaser>This week, Zero Punctuation reviews Guild Wars 2.</teaser>
    </Episode>
    <Episode name=""Borderlands 2"" number=""268"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6364-Borderlands-2"" originalname=""Borderlands 2"" ytlink=""https://www.youtube.com/watch?v=QmAniHMz6Vg"" date=""2012-10-03T16:00:00"">
      <extrap title=""Hating Multiplayer Creep"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9967-Hating-Multiplayer-Creep"" date=""2012-10-09T17:00:00"" />
      <reviewed name=""Borderlands 2"" wpname=""Borderlands 2"" />
      <teaser>This week, Zero Punctuation reviews Borderlands 2.</teaser>
    </Episode>
    <Episode name=""FIFA 13"" number=""269"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6387-FIFA-13"" originalname=""FIFA 13"" ytlink=""https://www.youtube.com/watch?v=ZIn8Uhpm_Ro"" date=""2012-10-10T16:00:00"">
      <extrap title=""Sports Nerds Are Nerds Too"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9982-Sports-Nerds-Are-Nerds-Too"" date=""2012-10-16T17:00:00"" />
      <reviewed name=""Mark of the Ninja"" wpname=""Mark of the Ninja"" />
      <reviewed name=""Anna"" wpname=""Anna (video game)"" />
      <reviewed name=""Tokyo Jungle"" wpname=""Tokyo Jungle"" />
      <teaser>This week, Zero Punctuation reviews FIFA 13, with a twist.</teaser>
    </Episode>
    <Episode name=""Resident Evil 6"" number=""270"" length=""338"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6416-Resident-Evil-6"" originalname=""Resident Evil 6"" ytlink=""https://www.youtube.com/watch?v=rI9wns8HqPU"" date=""2012-10-17T16:00:00"">
      <extrap title=""It's About Characters, Stupid"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/9999-It-s-About-Characters-Stupid"" date=""2012-10-23T17:00:00"" />
      <reviewed name=""Resident Evil 6"" wpname=""Resident Evil 6"" awardname=""Fifth Worst of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Resident Evil 6.</teaser>
    </Episode>
    <Episode name=""Dishonored"" number=""271"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6445-Dishonored"" originalname=""Dishonored"" ytlink=""https://www.youtube.com/watch?v=016dZuob2Dc"" date=""2012-10-24T16:00:00"">
      <extrap title=""Idle Chatter Builds Character"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10016-Idle-Chatter-Builds-Character"" date=""2012-10-30T17:00:00"" />
      <reviewed name=""Dishonored"" wpname=""Dishonored"" awardname=""Fifth Best of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Dishonored.</teaser>
    </Episode>
    <Episode name=""XCOM: Enemy Unknown"" number=""272"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6468-XCOM-Enemy-Unknown"" originalname=""XCOM: Enemy Unknown"" ytlink=""https://www.youtube.com/watch?v=S9QVGtqwhXY"" date=""2012-10-31T16:00:00"">
      <extrap title=""Save Scummer"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10029-Save-Scummer"" date=""2012-11-06T17:00:00"" />
      <reviewed name=""XCOM: Enemy Unknown"" wpname=""XCOM: Enemy Unknown"" awardname=""Second Best of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews XCOM: Enemy Unknown.</teaser>
    </Episode>
    <Episode name=""Medal of Honor: Warfighter &amp; Doom 3: BFG Edition"" number=""273"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6492-Medal-of-Honor-Warfighter-Doom-3-BFG-Edition"" originalname=""Medal of Honor Warfighter &amp; Doom 3 BFG Edition"" ytlink=""https://www.youtube.com/watch?v=vuNN1D-FCjs"" date=""2012-11-07T16:00:00"">
      <extrap title=""Get Rid of the Dang Arrows"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10038-Get-Rid-of-the-Dang-Arrows"" date=""2012-11-13T17:00:00"" />
      <reviewed name=""Medal of Honor Warfighter"" wpname=""Medal of Honor: Warfighter"" awardname=""Second Worst of 2012"" awardepisode=""Top 5 of 2012"" />
      <reviewed name=""Doom 3 BFG Edition"" wpname=""Doom 3 BFG Edition"" />
      <teaser>This week, Zero Punctuation reviews one shooter and one, well you'll see.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed 3"" number=""274"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6516-Assassins-Creed-3"" originalname=""Assassin's Creed 3"" ytlink=""https://www.youtube.com/watch?v=dZimXBB3gUQ"" date=""2012-11-14T16:00:00"">
      <extrap title=""The Assassins and Templars are Idiots"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10051-The-Assassins-and-Templars-are-Idiots"" date=""2012-11-20T17:00:00"" />
      <reviewed name=""Assassin's Creed 3"" wpname=""Assassin's Creed III"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed 3.</teaser>
    </Episode>
    <Episode name=""Halo 4"" number=""275"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6542-Halo-4"" originalname=""Halo 4"" ytlink=""https://www.youtube.com/watch?v=z9jmlBmknIE"" date=""2012-11-21T16:00:00"">
      <extrap title=""How to Title Your Stupid Sequel"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10063-How-to-Title-Your-Stupid-Sequel"" date=""2012-11-27T17:00:00"" />
      <reviewed name=""Halo 4"" wpname=""Halo 4"" />
      <teaser>This week, Zero Punctuation reviews Halo 4.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Black Ops 2"" number=""276"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6565-Call-of-Duty-Black-Ops-2"" originalname=""Call of Duty: Black Ops 2"" ytlink=""https://www.youtube.com/watch?v=QhHFx5UL0xc"" date=""2012-11-28T16:00:00"">
      <extrap title=""Black Ops 2 Is Like A Rich Jerk"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10075-Black-Ops-2-Is-Like-A-Rich-Jerk"" date=""2012-12-04T17:00:00"" />
      <reviewed name=""Call of Duty: Black Ops 2"" wpname=""Call of Duty: Black Ops II"" />
      <teaser>This week, Zero Punctuation reviews Codblops 2.</teaser>
    </Episode>
    <Episode name=""Hitman: Absolution"" number=""277"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6586-Hitman-Absolution"" originalname=""Hitman: Absolution"" ytlink=""https://www.youtube.com/watch?v=GePYJgW1m7E"" date=""2012-12-05T16:00:00"">
      <extrap title=""Humor and Realism Don't Mix"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10090-Humor-and-Realism-Don-t-Mix"" date=""2012-12-11T17:00:00"" />
      <reviewed name=""Hitman: Absolution"" wpname=""Hitman: Absolution"" />
      <teaser>This week, Zero Punctuation reviews Hitman: Absolution.</teaser>
    </Episode>
    <Episode name=""Far Cry 3"" number=""278"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6603-Far-Cry-3"" originalname=""Far Cry 3"" ytlink=""https://www.youtube.com/watch?v=kVCLbIbEKtM"" date=""2012-12-12T16:00:00"">
      <extrap title=""To the Shooters I Treated Badly"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10099-To-the-Shooters-I-Treated-Badly"" date=""2012-12-18T17:00:00"" />
      <reviewed name=""Far Cry 3"" wpname=""Far Cry 3"" awardname=""Third Best of 2012"" awardepisode=""Top 5 of 2012"" />
      <teaser>This week, Zero Punctuation reviews Far Cry 3.</teaser>
    </Episode>
    <Episode name=""ZombiU"" number=""279"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6647-ZombiU"" originalname=""ZombiU"" ytlink=""https://www.youtube.com/watch?v=AxMM7k18tVI"" date=""2012-12-19T16:00:00"">
      <extrap title=""The Upcoming (And Pointless) Console War"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10127-The-Upcoming-And-Pointless-Console-War"" date=""2013-01-01T17:00:00"" />
      <reviewed name=""ZombiU"" wpname=""ZombiU"" />
      <teaser>This week, Zero Punctuation reviews ZombiU.</teaser>
    </Episode>
    <Episode name=""Top 5 of 2012"" number=""280"" length=""382"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6677-Top-5-of-2012"" originalname=""Top 5 of 2012"" ytlink=""https://www.youtube.com/watch?v=6V6MI1ZSRfg"" date=""2013-01-02T16:00:00"">
      <extrap title=""Seriously, Console Wars Are Pointless"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10132-Seriously-Console-Wars-Are-Pointless"" date=""2013-01-08T17:00:00"" />
      <teaser>This week, Zero Punctuation shares the best and worst games that 2012 had to offer.</teaser>
    </Episode>
    <Episode name=""Paper Mario: Sticker Star"" number=""281"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6695-Paper-Mario-Sticker-Star"" originalname=""Paper Mario: Sticker Star"" ytlink=""https://www.youtube.com/watch?v=eFU9Q7NNnGE"" date=""2013-01-09T16:00:00"">
      <extrap title=""The Death of Mario"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10143-The-Death-of-Mario"" date=""2013-01-15T18:00:00"" />
      <reviewed name=""Paper Mario: Sticker Star"" wpname=""Paper Mario: Sticker Star"" />
      <teaser>This week, Zero Punctuation reviews Paper Mario: Sticker Star.</teaser>
    </Episode>
    <Episode name=""Black Knight Sword &amp; Hotline Miami"" number=""282"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6723-Black-Knight-Sword-Hotline-Miami"" originalname=""Black Knight Sword &amp; Hotline Miami"" ytlink=""https://www.youtube.com/watch?v=y079iJ36H4U"" date=""2013-01-16T16:00:00"">
      <extrap title=""Hotline Miami Is Nuts, FTL Is Gambling"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10153-Hotline-Miami-Is-Nuts-FTL-Is-Gambling"" date=""2013-01-22T17:00:00"" />
      <reviewed name=""Black Knight Sword"" wpname=""Black Knight Sword"" />
      <reviewed name=""Hotline Miami"" wpname=""Hotline Miami"" />
      <teaser>This week, Zero Punctuation reviews Black Knight Sword and Hotline Miami</teaser>
    </Episode>
    <Episode name=""Anarchy Reigns"" number=""283"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6738-Anarchy-Reigns"" originalname=""Anarchy Reigns"" ytlink=""https://www.youtube.com/watch?v=uC3jTJnqFgo"" date=""2013-01-23T16:00:00"">
      <extrap title=""Does Online Multiplayer Always Make Sense?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10163-Does-Online-Multiplayer-Always-Make-Sense"" date=""2013-01-29T17:00:00"" />
      <reviewed name=""Anarchy Reigns"" wpname=""Anarchy Reigns"" />
      <teaser>This week, Zero Punctuation reviews Anarchy Reigns.</teaser>
    </Episode>
    <Episode name=""DMC: Devil May Cry"" number=""284"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6765-DMC-Devil-May-Cry"" originalname=""DMC: Devil May Cry"" ytlink=""https://www.youtube.com/watch?v=kowAddykKOk"" date=""2013-01-30T16:00:00"">
      <extrap title=""And The Winner Is...."" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10172-And-The-Winner-Is"" date=""2013-02-05T18:00:00"" />
      <reviewed name=""DMC: Devil May Cry"" wpname=""DmC: Devil May Cry"" />
      <teaser>This week, Zero Punctuation reviews DMC: Devil May Cry.</teaser>
    </Episode>
    <Episode name=""The Cave"" number=""285"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6788-The-Cave"" originalname=""The Cave"" ytlink=""https://www.youtube.com/watch?v=Mbgbp_q9E4o"" date=""2013-02-06T16:00:00"">
      <extrap title=""A Game's Replay Value is Like Chocolate Sauce"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10189-A-Game-s-Replay-Value-is-Like-Chocolate-Sauce"" date=""2013-02-12T17:00:00"" />
      <reviewed name=""The Cave"" wpname=""The Cave (video game)"" />
      <teaser>This week, Zero Punctuation reviews The Cave.</teaser>
    </Episode>
    <Episode name=""Ni No Kuni: Wrath of the White Witch"" number=""286"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6830-Ni-No-Kuni-Wrath-Of-The-White-Witch"" originalname=""Ni No Kuni: Wrath Of The White Witch"" ytlink=""https://www.youtube.com/watch?v=BRv-K1tMD3U"" date=""2013-02-13T16:00:00"">
      <extrap title=""Ni No Kuni: Wrath of the Confusing JRPG"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10198-Ni-No-Kuni-Wrath-of-the-Confusing-JRPG"" date=""2013-02-19T17:00:00"" />
      <reviewed name=""Ni No Kuni: Wrath Of The White Witch"" wpname=""Ni no Kuni: Wrath of the White Witch"" />
      <teaser>This week, Zero Punctuation reviews Ni No Kuni: Wrath Of The White Witch.</teaser>
    </Episode>
    <Episode name=""Dead Space 3"" number=""287"" length=""339"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6891-Dead-Space-3"" originalname=""Dead Space 3"" ytlink=""https://www.youtube.com/watch?v=SMOoJZTy1p0"" date=""2013-02-20T16:00:00"">
      <extrap title=""Real Horror Games Don't Need Co-op"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10209-Real-Horror-Games-Don-t-Need-Co-op"" date=""2013-02-26T17:00:00"" />
      <reviewed name=""Dead Space 3"" wpname=""Dead Space 3"" />
      <teaser>This week, Zero Punctuation reviews Dead Space 3.</teaser>
    </Episode>
    <Episode name=""Aliens: Colonial Marines"" number=""288"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6912-Aliens-Colonial-Marines"" originalname=""Aliens: Colonial Marines"" ytlink=""https://www.youtube.com/watch?v=pPk7gllRZm4"" date=""2013-02-27T16:00:00"">
      <extrap title=""Colonial Marines Developers Should Own Up to Screwing Up"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10218-Colonial-Marines-Developers-Should-Own-Up-to-Screwing-Up"" date=""2013-03-05T17:00:00"" />
      <reviewed name=""Aliens: Colonial Marines"" wpname=""Aliens: Colonial Marines"" awardname=""Third Worst of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Aliens: Colonial Marines.</teaser>
    </Episode>
    <Episode name=""Crysis 3"" number=""289"" length=""342"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6964-Crysis-3"" originalname=""Crysis 3"" ytlink=""https://www.youtube.com/watch?v=mFp67DiTba0"" date=""2013-03-06T16:00:00"">
      <extrap title=""A Storytelling Crysis"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10228-A-Storytelling-Crysis"" date=""2013-03-12T17:00:00"" />
      <reviewed name=""Crysis 3"" wpname=""Crysis 3"" />
      <teaser>This week, Zero Punctuation reviews Crysis 3.</teaser>
    </Episode>
    <Episode name=""Metal Gear Rising: Revengeance"" number=""290"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/6994-Metal-Gear-Rising-Revengeance"" originalname=""Metal Gear Rising: Revengeance"" ytlink=""https://www.youtube.com/watch?v=45Z40zr4BjY"" date=""2013-03-13T16:00:00"">
      <extrap title=""Games With Fake Wars Are Stupid"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10243-Games-With-Fake-Wars-Are-Stupid"" date=""2013-03-19T17:00:00"" />
      <reviewed name=""Metal Gear Rising: Revengeance"" wpname=""Metal Gear Rising: Revengeance"" awardname=""Fifth Best of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Metal Gear Rising: Revengeance.</teaser>
    </Episode>
    <Episode name=""Tomb Raider"" number=""291"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7025-Tomb-Raider"" originalname=""Tomb Raider"" ytlink=""https://www.youtube.com/watch?v=jw-MjVvFjwc"" date=""2013-03-20T16:00:00"">
      <extrap title=""A Quick Time Event By Any Other Name"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10254-A-Quick-Time-Event-By-Any-Other-Name"" date=""2013-03-26T17:00:00"" />
      <reviewed name=""Tomb Raider"" wpname=""Tomb Raider (2013 video game)"" />
      <teaser>This week, Zero Punctuation reviews Tomb Raider.</teaser>
    </Episode>
    <Episode name=""SimCity"" number=""292"" length=""348"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7053-SimCity"" originalname=""SimCity"" ytlink=""https://www.youtube.com/watch?v=yHPOiOr94L8"" date=""2013-03-27T16:00:00"">
      <extrap title=""SimCity Was Never Meant To Be Online"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10268-SimCity-Was-Never-Meant-To-Be-Online"" date=""2013-04-02T17:00:00"" />
      <reviewed name=""SimCity"" wpname=""SimCity (2013 video game)"" awardname=""Fourth Worst of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews SimCity.</teaser>
    </Episode>
    <Episode name=""The Walking Dead: Survival Instinct"" number=""293"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7074-The-Walking-Dead-Survival-Instinct"" originalname=""The Walking Dead: Survival Instinct"" ytlink=""https://www.youtube.com/watch?v=xIXzx5qjy1c"" date=""2013-04-03T16:00:00"">
      <extrap title=""Stealth Games Don't Have to Be About Killing People"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10277-Stealth-Games-Don-t-Have-to-Be-About-Killing-People"" date=""2013-04-09T17:00:00"" />
      <reviewed name=""The Walking Dead: Survival Instinct"" wpname=""The Walking Dead: Survival Instinct"" />
      <teaser>This week, Zero Punctuation reviews The Walking Dead: Survival Instinct.</teaser>
    </Episode>
    <Episode name=""BioShock Infinite"" number=""294"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7105-BioShock-Infinite"" originalname=""BioShock: Infinite"" ytlink=""https://www.youtube.com/watch?v=rciyCHa6J4o"" date=""2013-04-10T16:00:00"">
      <extrap title=""No, BioShock Infinite's Ending Doesn't Suck"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10288-No-BioShock-Infinite-s-Ending-Doesn-t-Suck"" date=""2013-04-16T17:00:00"" />
      <reviewed name=""BioShock: Infinite"" wpname=""BioShock Infinite"" awardname=""Best game of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation review BioShock: Infinite.</teaser>
    </Episode>
    <Episode name=""Lego City Undercover"" number=""295"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7128-Lego-City-Undercover"" originalname=""Lego City Undercover"" ytlink=""https://www.youtube.com/watch?v=1jaLNfKiDRs"" date=""2013-04-17T16:00:00"">
      <extrap title=""We Really, Really Don't Need New Consoles"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10300-We-Really-Really-Don-t-Need-New-Consoles"" date=""2013-04-23T17:00:00"" />
      <reviewed name=""Lego City Undercover"" wpname=""Lego City Undercover"" />
      <teaser>This week, Zero Punctuation reviews Lego City Undercover.</teaser>
    </Episode>
    <Episode name=""Luigi's Mansion: Dark Moon"" number=""296"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7169-Luigis-Mansion-Dark-Moon"" originalname=""Luigi's Mansion: Dark Moon"" ytlink=""https://www.youtube.com/watch?v=530q4-oxL58"" date=""2013-04-24T16:00:00"">
      <extrap title=""Nintendo Needs To Reboot Mario and Luigi"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10307-Nintendo-Needs-To-Reboot-Mario-and-Luigi"" date=""2013-04-30T17:00:00"" />
      <reviewed name=""Luigi's Mansion: Dark Moon"" wpname=""Luigi's Mansion: Dark Moon"" />
      <teaser>This week, Zero Punctuation reviews Luigi's Mansion: Dark Moon.</teaser>
    </Episode>
    <Episode name=""Injustice: Gods Among Us"" number=""297"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7206-Injustice-Gods-Among-Us"" originalname=""Injustice: Gods Among Us"" ytlink=""https://www.youtube.com/watch?v=oZWoQ43Ho1g"" date=""2013-05-01T16:00:00"">
      <extrap title=""It's Time For Mortal Kombat vs. Everyone Else"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10320-It-s-Time-For-Mortal-Kombat-vs-Everyone-Else"" date=""2013-05-07T17:00:00"" />
      <reviewed name=""Injustice: Gods Among Us"" wpname=""Injustice: Gods Among Us"" />
      <teaser>This week, Zero Punctuation reviews Injustice: Gods Among Us.</teaser>
    </Episode>
    <Episode name=""Star Trek"" number=""298"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7247-Star-Trek"" originalname=""Star Trek"" ytlink=""https://www.youtube.com/watch?v=xduIzjF9URo"" date=""2013-05-08T16:00:00"">
      <extrap title=""Why Exactly Do We Care About Star Wars?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10330-Why-Exactly-Do-We-Care-About-Star-Wars"" date=""2013-05-14T17:00:00"" />
      <reviewed name=""Star Trek"" wpname=""Star Trek (2013 video game)"" awardname=""Fifth Worst of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Star Trek.</teaser>
    </Episode>
    <Episode name=""Far Cry 3: Blood Dragon"" number=""299"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7302-Far-Cry-3-Blood-Dragon"" originalname=""Far Cry 3: Blood Dragon"" ytlink=""https://www.youtube.com/watch?v=LMaeHNjoICw"" date=""2013-05-15T16:00:00"">
      <extrap title=""Your Game Music is Bland and You Should Feel Bad"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10340-Your-Game-Music-is-Bland-and-You-Should-Feel-Bad"" date=""2013-05-21T17:00:00"" />
      <reviewed name=""Far Cry 3: Blood Dragon"" wpname=""Far Cry 3: Blood Dragon"" />
      <teaser>This week, Zero Punctuation reviews Far Cry 3: Blood Dragon.</teaser>
    </Episode>
    <Episode name=""System Shock 2"" number=""300"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7356-System-Shock-2"" originalname=""System Shock 2"" ytlink=""https://www.youtube.com/watch?v=6ScjZGArpUs"" date=""2013-05-22T16:00:00"">
      <extrap title=""The Glorious PC Gaming Master Race"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10350-The-Glorious-PC-Gaming-Master-Race"" date=""2013-05-28T17:00:00"" />
      <reviewed name=""System Shock 2"" wpname=""System Shock 2"" />
      <teaser>This week, Zero Punctuation reviews System Shock 2.</teaser>
    </Episode>
    <Episode name=""Metro: Last Light"" number=""301"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7375-Metro-Last-Light"" originalname=""Metro: Last Light"" ytlink=""https://www.youtube.com/watch?v=Sl_vckONfGs"" date=""2013-05-29T16:00:00"">
      <extrap title=""Metro's Bullets Make A Better Currency"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10364-Metro-s-Bullets-Make-A-Better-Currency"" date=""2013-06-04T17:00:00"" />
      <reviewed name=""Metro: Last Light"" wpname=""Metro: Last Light"" />
      <teaser>This week, Zero Punctuation reviews Metro: Last Light.</teaser>
    </Episode>
    <Episode name=""Next Gen Buyer's Guide"" number=""302"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7417-Next-Gen-Buyers-Guide"" originalname=""Next Gen Buyer's Guide"" ytlink=""https://www.youtube.com/watch?v=RUAeYL7eAdI"" date=""2013-06-05T16:00:00"">
      <extrap title=""Sony's Not Ready For User-Made Videos"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10373-Sony-s-Not-Ready-For-User-Made-Videos"" date=""2013-06-11T17:00:00"" />
      <reissue date=""2013-12-25T00:00:00"" />
      <reviewed name=""Wii U"" wpname=""Wii U"" />
      <reviewed name=""Playstation 4"" wpname=""PlayStation 4"" />
      <reviewed name=""Xbox One"" wpname=""Xbox One"" />
      <teaser>This week, Zero Punctuation takes a look at the three next gen consoles.</teaser>
    </Episode>
    <Episode name=""Fuse"" number=""303"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7466-Fuse"" originalname=""Fuse"" ytlink=""https://www.youtube.com/watch?v=VqflNjHk-TU"" date=""2013-06-12T16:00:00"">
      <extrap title=""Gunpoint Game Makes For Great Action Movie Moments"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10441-Gunpoint-Game-Makes-For-Great-Action-Movie-Moments"" date=""2013-06-18T17:00:00"" />
      <reviewed name=""Fuse"" wpname=""Fuse (video game)"" />
      <teaser>This week, Zero Punctuation reviews Fuse.</teaser>
    </Episode>
    <Episode name=""Remember Me"" number=""304"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7542-Remember-Me"" originalname=""Remember Me"" ytlink=""https://www.youtube.com/watch?v=dEThoQxERVw"" date=""2013-06-19T16:00:00"">
      <extrap title=""Remember Me Could Have Been So Much More"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10450-Remember-Me-Could-Have-Been-So-Much-More"" date=""2013-06-25T17:00:00"" />
      <reviewed name=""Remember Me"" wpname=""Remember Me (video game)"" />
      <teaser>This week, Zero Punctuation reviews Remember Me.</teaser>
    </Episode>
    <Episode name=""E3 2013"" number=""305"" length=""393"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7595-E3-2013"" originalname=""E3 2013"" ytlink=""https://www.youtube.com/watch?v=9OrQzrFZeDw"" date=""2013-06-26T16:00:00"">
      <extrap title=""The Tale of M and S"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10460-The-Tale-of-M-and-S"" date=""2013-07-02T17:00:00"" />
      <teaser>This week, Zero Punctuation reviews E3 2013.</teaser>
    </Episode>
    <Episode name=""The Last of Us"" number=""306"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7638-The-Last-of-Us"" originalname=""The Last of Us"" ytlink=""https://www.youtube.com/watch?v=P7mKTItGVzw"" date=""2013-07-03T16:00:00"">
      <extrap title=""Killing is Too Easy"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10467-Killing-is-Too-Easy"" date=""2013-07-09T17:00:00"" />
      <reviewed name=""The Last of Us"" wpname=""The Last of Us"" />
      <teaser>This week, Zero Punctuation reviews The Last of Us.</teaser>
    </Episode>
    <Episode name=""Deadpool"" number=""307"" length=""342"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7691-Deadpool"" originalname=""Deadpool"" ytlink=""https://www.youtube.com/watch?v=dtSlEqUNf1E"" date=""2013-07-10T16:00:00"">
      <extrap title=""Why Can't Comedy Games be Funny to Play?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10476-Why-Can-t-Comedy-Games-be-Funny-to-Play"" date=""2013-07-16T17:00:00"" />
      <reviewed name=""Deadpool"" wpname=""Deadpool (video game)"" />
      <teaser>This week, the Critic with a Mouth takes on the Merc with a Mouth.</teaser>
    </Episode>
    <Episode name=""Animal Crossing: New Leaf"" number=""308"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7738-Animal-Crossing-New-Leaf"" originalname=""Animal Crossing: New Leaf"" ytlink=""https://www.youtube.com/watch?v=hqXkwfV4TGg"" date=""2013-07-17T16:00:00"">
      <extrap title=""Why Do We Even Care About Animal Crossing?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10483-Why-Do-We-Even-Care-About-Animal-Crossing"" date=""2013-07-23T17:00:00"" />
      <reviewed name=""Animal Crossing: New Leaf"" wpname=""Animal Crossing: New Leaf"" />
      <teaser>This week, Zero Punctuation reviews Animal Crossing: New Leaf.</teaser>
    </Episode>
    <Episode name=""Ride to Hell: Retribution"" number=""309"" length=""358"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7785-Ride-to-Hell-Retribution"" originalname=""Ride to Hell: Retribution"" ytlink=""https://www.youtube.com/watch?v=HWxEwdGpIPQ"" date=""2013-07-24T16:00:00"">
      <extrap title=""When Open World Goes Wrong"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10491-When-Open-World-Goes-Wrong"" date=""2013-07-30T17:00:00"" />
      <reviewed name=""Ride to Hell: Retribution"" wpname=""Ride to Hell: Retribution"" awardname=""The Zero Punctuation Lifetime Achievement Award for Total Abhorrence"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Ride to Hell: Retribution.</teaser>
    </Episode>
    <Episode name=""Dark"" number=""310"" length=""351"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7823-Dark"" originalname=""Dark"" ytlink=""https://www.youtube.com/watch?v=SOgXwElNSpU"" date=""2013-07-31T16:00:00"">
      <extrap title=""Bad Games Can Give You Good Ideas"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10502-Bad-Games-Can-Give-You-Good-Ideas"" date=""2013-08-06T17:00:00"" />
      <reviewed name=""Dark"" wpname=""Dark (video game)"" />
      <teaser>This week, Zero Punctuation reviews Dark.</teaser>
    </Episode>
    <Episode name=""Mario &amp; Luigi: Dream Team"" number=""311"" length=""343"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7879-Mario-Luigi-Dream-Team"" originalname=""Mario &amp; Luigi: Dream Team"" ytlink=""https://www.youtube.com/watch?v=CCGcJiY-rD0"" date=""2013-08-07T16:00:00"">
      <extrap title=""Of Metaphors and Mario RPGs"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10515-Of-Metaphors-and-Mario-RPGs"" date=""2013-08-13T17:00:00"" />
      <reviewed name=""Mario &amp; Luigi: Dream Team"" wpname=""Mario &amp; Luigi: Dream Team"" />
      <teaser>This week, Zero Punctuation reviews Mario &amp; Luigi: Dream Team.</teaser>
    </Episode>
    <Episode name=""Rise of the Triad"" number=""312"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7921-Rise-of-the-Triad"" originalname=""Rise of the Triad"" ytlink=""https://www.youtube.com/watch?v=reL2rggfqnI"" date=""2013-08-14T16:00:00"">
      <extrap title=""Remaking the 90s"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10533-Remaking-the-90s"" date=""2013-08-20T17:00:00"" />
      <reviewed name=""Rise of the Triad"" wpname=""Rise of the Triad (2013 video game)"" />
      <teaser>This week, Zero Punctuation reviews Rise of the Triad.</teaser>
    </Episode>
    <Episode name=""Papers, Please &amp; Brothers: A Tale of Two Sons"" number=""313"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7959-Papers-Please-and-Brothers-A-Tale-of-Two-Sons"" originalname=""Papers, Please and Brothers: A Tale of Two Sons"" ytlink=""https://www.youtube.com/watch?v=9Cy0mWziFrI"" date=""2013-08-21T16:00:00"">
      <extrap title=""Bureaucracy-Em-Up"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10550-Bureaucracy-Em-Up"" date=""2013-08-27T17:00:00"" />
      <reviewed name=""Papers, Please"" wpname=""Papers, Please"" awardname=""Second Best of 2013"" awardepisode=""Top 5 of 2013"" />
      <reviewed name=""Brothers: A Tale of Two Sons"" wpname=""Brothers: A Tale of Two Sons"" />
      <teaser>This week, Zero Punctuation reviews Papers, Please and Brothers: A Tale of Two Sons.</teaser>
    </Episode>
    <Episode name=""Pikmin 3"" number=""314"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/7989-Pikmin-3"" originalname=""Pikmin 3"" ytlink=""https://www.youtube.com/watch?v=BssV4DQoEFw"" date=""2013-08-28T16:00:00"">
      <extrap title=""Coming Around to the Wii U"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10569-Coming-Around-to-the-Wii-U"" date=""2013-09-03T17:00:00"" />
      <reviewed name=""Pikmin 3"" wpname=""Pikmin 3"" />
      <teaser>This week, Zero Punctuation reviews Pikmin 3.</teaser>
    </Episode>
    <Episode name=""The Bureau: XCOM Declassified"" number=""315"" length=""351"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8031-The-Bureau-XCOM-Declassified"" originalname=""The Bureau: XCOM Declassified"" ytlink=""https://www.youtube.com/watch?v=QnV07hLEmxI"" date=""2013-09-04T16:00:00"">
      <extrap title=""The Dangers of Dialogue"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10584-The-Dangers-of-Dialogue"" date=""2013-09-10T17:00:00"" />
      <reviewed name=""The Bureau: XCOM Declassified"" wpname=""The Bureau: XCOM Declassified"" />
      <teaser>This week, Zero Punctuation reviews The Bureau: XCOM Declassified.</teaser>
    </Episode>
    <Episode name=""Saints Row 4"" number=""316"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8062-Saints-Row-4"" originalname=""Saints Row 4"" ytlink=""https://www.youtube.com/watch?v=xbbdk68-Mfc"" date=""2013-09-11T16:00:00"">
      <extrap title=""Your Character Could Be Anyone"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10600-Your-Character-Could-Be-Anyone"" date=""2013-09-17T17:00:00"" />
      <reviewed name=""Saints Row 4"" wpname=""Saints Row IV"" awardname=""Third Best of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Saints Row IV.</teaser>
    </Episode>
    <Episode name=""Killer is Dead"" number=""317"" length=""347"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8120-Killer-Is-Dead"" originalname=""Killer Is Dead"" ytlink=""https://www.youtube.com/watch?v=pSUVlJPTJVs"" date=""2013-09-18T16:00:00"">
      <extrap title=""Sexy Characters"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10616-Sexy-Characters"" date=""2013-09-24T17:00:00"" />
      <reviewed name=""Killer Is Dead"" wpname=""Killer Is Dead"" />
      <teaser>This week, Zero Punctuation reviews Killer Is Dead.</teaser>
    </Episode>
    <Episode name=""Amnesia: A Machine for Pigs"" number=""318"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8158-Amnesia-A-Machine-For-Pigs"" originalname=""Amnesia: A Machine For Pigs"" ytlink=""https://www.youtube.com/watch?v=_FKgUZaCzNc"" date=""2013-09-25T16:00:00"">
      <extrap title=""A Machine For Pigs: Daddy, Please Don't Kill Me"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10629-A-Machine-For-Pigs-Daddy-Please-Don-t-Kill-Me"" date=""2013-10-01T17:00:00"" />
      <reviewed name=""Amnesia: A Machine For Pigs"" wpname=""Amnesia: A Machine for Pigs"" />
      <teaser>This week, Zero Punctuation reviews Amnesia: A Machine For Pigs.</teaser>
    </Episode>
    <Episode name=""Grand Theft Auto V"" number=""319"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8193-Grand-Theft-Auto-5"" originalname=""Grand Theft Auto 5"" ytlink=""https://www.youtube.com/watch?v=CcHH13T4mpo"" date=""2013-10-02T16:00:00"">
      <extrap title=""GTAV's Characters Are Just Bad"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10656-GTAV-s-Characters-Are-Just-Bad"" date=""2013-10-15T17:00:00"" />
      <reviewed name=""Grand Theft Auto 5"" wpname=""Grand Theft Auto V"">
        <seealso>Grand Theft Auto Online</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Grand Theft Auto 5.</teaser>
    </Episode>
    <Episode name=""Lost Planet 3"" number=""320"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8279-Lost-Planet-3"" originalname=""Lost Planet 3"" ytlink=""https://www.youtube.com/watch?v=qVbOlAHdasA"" date=""2013-10-16T16:00:00"">
      <extrap title=""Let's Compare Lost Planet 3 to a Good Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10673-Let-s-Compare-Lost-Planet-3-to-a-Good-Game"" date=""2013-10-22T17:00:00"" />
      <reviewed name=""Lost Planet 3"" wpname=""Lost Planet 3"" />
      <teaser>This week, Zero Punctuation reviews Lost Planet 3.</teaser>
    </Episode>
    <Episode name=""Beyond: Two Souls"" number=""321"" length=""344"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8298-Beyond-Two-Souls"" originalname=""Beyond: Two Souls"" ytlink=""https://www.youtube.com/watch?v=xiaB8XJqyLs"" date=""2013-10-23T16:00:00"">
      <extrap title=""Beyond: Two Souls vs. The Stanley Parable"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10695-Beyond-Two-Souls-vs-The-Stanley-Parable"" date=""2013-10-29T17:00:00"" />
      <reviewed name=""Beyond: Two Souls"" wpname=""Beyond: Two Souls"" awardname=""Second Worst of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Beyond: Two Souls</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: The Wind Waker HD"" number=""322"" length=""339"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8347-The-Legend-of-Zelda-The-Windwaker-HD"" originalname=""The Legend of Zelda: The Windwaker HD"" ytlink=""https://www.youtube.com/watch?v=N-z9Cvk0hvg"" date=""2013-10-30T16:00:00"">
      <extrap title=""Wind Waker is Still the Best Zelda, and You're Surprised?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10710-Wind-Waker-is-Still-the-Best-Zelda-and-You-re-Surprised"" date=""2013-11-05T17:00:00"" />
      <reviewed name=""The Legend of Zelda: The Wind Waker HD"" wpname=""The Legend of Zelda: The Wind Waker HD"" />
      <teaser>This week, Zero Punctuation reviews The Legend of Zelda: The Windwaker HD.</teaser>
    </Episode>
    <Episode name=""Batman: Arkham Origins"" number=""323"" length=""347"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8390-Batman-Arkham-Origins"" originalname=""Batman: Arkham Origins"" ytlink=""https://www.youtube.com/watch?v=RvjJZpl6woY"" date=""2013-11-06T16:00:00"">
      <extrap title=""Keeping Batman Original"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10735-Keeping-Batman-Original"" date=""2013-11-12T17:00:00"" />
      <reviewed name=""Batman: Arkham Origins"" wpname=""Batman: Arkham Origins"" />
      <teaser>This week, Zero Punctuation reviews Batman: Arkham Origins.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed IV: Black Flag"" number=""324"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8424-Assassins-Creed-IV-Black-Flag"" originalname=""Assassin's Creed IV: Black Flag"" ytlink=""https://www.youtube.com/watch?v=yHmbweBK2qE"" date=""2013-11-13T16:00:00"">
      <extrap title=""Assassin's Creed Doesn't Have Much of a Story, Does It?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10758-Assassin-s-Creed-Doesn-t-Have-Much-of-a-Story-Does-It"" date=""2013-11-19T17:00:00"" />
      <reviewed name=""Assassin's Creed IV: Black Flag"" wpname=""Assassin's Creed IV: Black Flag"" awardname=""Fourth Best of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed IV: Black Flag.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Ghosts"" number=""325"" length=""398"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8465-Call-of-Duty-Ghosts"" originalname=""Call of Duty: Ghosts"" ytlink=""https://www.youtube.com/watch?v=DCtbhjDcTNI"" date=""2013-11-20T16:00:00"">
      <extrap title=""Complacency in Storytelling"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10777-Complacency-in-Storytelling"" date=""2013-11-26T17:00:00"" />
      <reviewed name=""Call of Duty: Ghosts"" wpname=""Call of Duty: Ghosts"" awardname=""Worst game of 2013"" awardepisode=""Top 5 of 2013"" />
      <teaser>This week, Zero Punctuation reviews Call of Duty: Ghosts.</teaser>
    </Episode>
    <Episode name=""Exclusives Showdown"" number=""326"" length=""353"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8510-Exclusives-Showdown"" originalname=""Exclusives Showdown"" ytlink=""https://www.youtube.com/watch?v=0w4AoUSb_0w"" date=""2013-11-27T16:00:00"">
      <extrap title=""The Design of Consuming Shadow"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10792-The-Design-of-Consuming-Shadow"" date=""2013-12-03T17:30:00"" />
      <teaser>This week, Zero Punctuation reviews a few of the next-gen exclusives.</teaser>
    </Episode>
    <Episode name=""Ryse: Son of Rome"" number=""327"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8525-Ryse-Son-of-Rome"" originalname=""Ryse: Son of Rome"" ytlink=""https://www.youtube.com/watch?v=lbSqkxqIW5I"" date=""2013-12-04T16:00:00"">
      <extrap title=""The Trials and Perils of Returning to PC"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10803-The-Trials-and-Perils-of-Returning-to-PC"" date=""2013-12-10T17:00:00"" />
      <reviewed name=""Ryse: Son of Rome"" wpname=""Ryse: Son of Rome"" />
      <teaser>This week, Zero Punctuation reviews Ryse: Son of Rome.</teaser>
    </Episode>
    <Episode name=""Dead Rising 3"" number=""328"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8568-Dead-Rising-3"" originalname=""Dead Rising 3"" ytlink=""https://www.youtube.com/watch?v=egrN4plxuyQ"" date=""2013-12-11T16:00:00"">
      <extrap title=""Context, Challenge and Catharsis"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10816-Context-Challenge-and-Catharsis"" date=""2013-12-17T17:00:00"" />
      <reviewed name=""Dead Rising 3"" wpname=""Dead Rising 3"" />
      <teaser>This week, Zero Punctuation reviews Dead Rising 3.</teaser>
    </Episode>
    <Episode name=""Super Mario 3D World"" number=""329"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8591-Super-Mario-3D-World"" originalname=""Super Mario 3D World"" ytlink=""https://www.youtube.com/watch?v=o1qfZ8q3ljg"" date=""2013-12-18T16:00:00"">
      <extrap title=""To Hell With Comments"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10857-To-Hell-With-Comments"" date=""2013-12-31T17:00:00"" />
      <reviewed name=""Super Mario 3D World"" wpname=""Super Mario 3D World"" />
      <teaser>This week, Zero Punctuation reviews Super Mario 3D World.</teaser>
    </Episode>
    <Episode name=""Top 5 of 2013"" number=""330"" length=""367"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8642-Top-5-Games-of-2013"" originalname=""Top 5 Games of 2013"" ytlink=""https://www.youtube.com/watch?v=D7rMUvEPXK0"" date=""2014-01-01T16:00:00"">
      <extrap title=""Serious Game Fatigue"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10876-Serious-Game-Fatigue"" date=""2014-01-07T17:00:00"" />
      <teaser>This week, Zero Punctuation takes a look at the top 5 best and worst games of 2013.</teaser>
    </Episode>
    <Episode name=""Knack"" number=""331"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8665-Knack"" originalname=""Knack"" ytlink=""https://www.youtube.com/watch?v=_X5qyu8DPM0"" date=""2014-01-08T16:00:00"">
      <extrap title=""Of Dragons &amp; Ruined Cities"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10900-Of-Dragons-Ruined-Cities"" date=""2014-01-14T17:00:00"" />
      <reviewed name=""Knack"" wpname=""Knack (video game)"" />
      <teaser>This week, Zero Punctuation reviews Knack.</teaser>
    </Episode>
    <Episode name=""Killzone: Shadow Fall"" number=""332"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8696-Killzone-Shadow-Fall"" originalname=""Killzone: Shadow Fall"" ytlink=""https://www.youtube.com/watch?v=pUqbqffYqTs"" date=""2014-01-15T16:00:00"">
      <extrap title=""Hardware is Gimmicks"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10925-Hardware-is-Gimmicks"" date=""2014-01-21T17:00:00"" />
      <reviewed name=""Killzone: Shadow Fall"" wpname=""Killzone Shadow Fall"" />
      <teaser>This week, Zero Punctuation reviews Killzone: Shadow Fall.</teaser>
    </Episode>
    <Episode name=""Survival Special"" number=""333"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8710-Survival-Special-Rust-Starbound-7-Days-to-Die"" originalname=""Survival Special (Rust, Starbound, 7 Days to Die)"" ytlink=""https://www.youtube.com/watch?v=0z2SKnREPEM"" date=""2014-01-22T16:00:00"">
      <extrap title=""Why Do We Love Survival Games?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10939-Why-Do-We-Love-Survival-Games"" date=""2014-01-28T17:00:00"" />
      <reviewed name=""Rust"" wpname=""Rust (video game)"" />
      <reviewed name=""Starbound"" wpname=""Starbound"" />
      <reviewed name=""7 Days to Die"" wpname=""7 Days to Die"" />
      <teaser>This week, Zero Punctuation reviews Rust, Starbound and 7 Days to Die.</teaser>
    </Episode>
    <Episode name=""Broken Age"" number=""334"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8744-Broken-Age"" originalname=""Broken Age"" ytlink=""https://www.youtube.com/watch?v=A1kS5ZpTt9M"" date=""2014-01-29T16:00:00"">
      <extrap title=""The Magic of Old Adventure Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10959-The-Magic-of-Old-Adventure-Games"" date=""2014-02-04T17:00:00"" />
      <reviewed name=""Broken Age"" wpname=""Broken Age"">
        <seealso>Broken Age: Act 2</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Broken Age.</teaser>
    </Episode>
    <Episode name=""Might &amp; Magic X: Legacy"" number=""335"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8758-Might-Magic-X-Legacy"" originalname=""Might &amp; Magic X: Legacy"" ytlink=""https://www.youtube.com/watch?v=vQs1uTTjTAM"" date=""2014-02-05T16:00:00"">
      <extrap title=""The Nostalgia Factor"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/10990-The-Nostalgia-Factor"" date=""2014-02-11T17:00:00"" />
      <reviewed name=""Might &amp; Magic X: Legacy"" wpname=""Might &amp; Magic X: Legacy"" />
      <teaser>This week, Zero Punctuation reviews Might &amp; Magic X: Legacy.</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: A Link Between Worlds"" number=""336"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8789-The-Legend-of-Zelda-A-Link-Between-Worlds"" originalname=""The Legend of Zelda: A Link Between Worlds"" ytlink=""https://www.youtube.com/watch?v=vAJRw4flK40"" date=""2014-02-12T16:00:00"">
      <extrap title=""What Has Nintendo Done Right Lately?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11018-What-Has-Nintendo-Done-Right-Lately"" date=""2014-02-18T15:48:00"" />
      <reviewed name=""The Legend of Zelda: A Link Between Worlds"" wpname=""The Legend of Zelda: A Link Between Worlds"" />
      <teaser>This week, Zero Punctuation reviews The Legend of Zelda: A Link Between Worlds and has a chat with Nintendo.</teaser>
    </Episode>
    <Episode name=""Dark Souls"" number=""337"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8802-Dark-Souls"" originalname=""Dark Souls"" ytlink=""https://www.youtube.com/watch?v=STrYyhEwkbY"" date=""2014-02-19T16:00:00"">
      <extrap title=""A Beginner's Guide to Dark Souls - 7 Steps to Sucking Less"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11045-A-Beginner-s-Guide-to-Dark-Souls-7-Steps-to-Sucking-Less"" date=""2014-02-25T17:00:00"" />
      <reviewed name=""Dark Souls"" wpname=""Dark Souls"" />
      <teaser>This week, Zero Punctuation reviews Dark Souls.</teaser>
    </Episode>
    <Episode name=""Lightning Returns: Final Fantasy XIII"" number=""338"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8828-Lightning-Returns-Final-Fantasy-XIII"" originalname=""Lightning Returns: Final Fantasy XIII"" ytlink=""https://www.youtube.com/watch?v=OGdwvDG5XZA"" date=""2014-02-26T16:00:00"">
      <extrap title=""Bad Timing - How Clocks in Games Ruin the Fun"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11067-Bad-Timing-How-Clocks-in-Games-Ruin-the-Fun"" date=""2014-03-04T17:00:00"" />
      <reviewed name=""Lightning Returns: Final Fantasy XIII"" wpname=""Lightning Returns: Final Fantasy XIII"" awardname=""Fourth Worst of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Lightning Returns: Final Fantasy XIII.</teaser>
    </Episode>
    <Episode name=""Strider"" number=""339"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8855-Strider"" originalname=""Strider"" ytlink=""https://www.youtube.com/watch?v=dJXevs5RkuY"" date=""2014-03-05T16:00:00"">
      <extrap title=""People Make Games, Not Development Studios"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11095-People-Make-Games-Not-Development-Studios"" date=""2014-03-11T17:00:00"" />
      <reviewed name=""Strider"" wpname=""Strider (2014 video game)"" />
      <teaser>This week, Zero Punctuation reviews Strider.</teaser>
    </Episode>
    <Episode name=""Thief"" number=""340"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8891-Thief-Stealing-a-Classic"" originalname=""Thief"" ytlink=""https://www.youtube.com/watch?v=vx2TTzadTaA"" date=""2014-03-12T16:00:00"" subtitle=""Stealing a Classic"">
      <extrap title=""Thief Would Have Worked Better With a Bigger Sandbox"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11120-Thief-Would-Have-Worked-Better-With-a-Bigger-Sandbox"" date=""2014-03-18T17:45:00"" />
      <reviewed name=""Thief"" wpname=""Thief (2014 video game)"" awardname=""Worst game of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Thief.</teaser>
    </Episode>
    <Episode name=""Castlevania: Lords of Shadow 2"" number=""341"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8912-Castlevania-Lords-of-Shadow-2-It-Sucks-Ha"" originalname=""Castlevania: Lords of Shadow 2"" ytlink=""https://www.youtube.com/watch?v=Tl_u30_w6IU"" date=""2014-03-19T16:00:00"" subtitle=""It Sucks, Ha."">
      <extrap title=""Lords of Shadow 2 Might Have Been Good, Had Dracula Been Evil"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11187-Lords-of-Shadow-2-Might-Have-Been-Good-Had-Dracula-Been-Evil"" date=""2014-03-25T17:00:00"" />
      <reviewed name=""Castlevania: Lords of Shadow 2"" wpname=""Castlevania: Lords of Shadow 2"" />
      <teaser>This week, Zero Punctuation reviews Castlevania: Lords of Shadow 2.</teaser>
    </Episode>
    <Episode name=""Dark Souls II"" number=""342"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8945-Dark-Souls-2-Prepare-to-Die-Again"" originalname=""Dark Souls 2"" ytlink=""https://www.youtube.com/watch?v=G9naXmOYAdE"" date=""2014-03-26T16:00:00"" subtitle=""Prepare to Die Again"">
      <extrap title=""Dark Souls 2: Of Missing Monsters and Bustling Bases"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11220-Dark-Souls-2-Of-Missing-Monsters-and-Bustling-Bases"" date=""2014-04-01T17:00:00"" />
      <reviewed name=""Dark Souls 2"" wpname=""Dark Souls II"" awardname=""Fourth Best of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Dark Souls 2.</teaser>
    </Episode>
    <Episode name=""Titanfall"" number=""343"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/8980-Titanfall-Its-Got-Big-Stompy-Robots"" originalname=""Titanfall"" ytlink=""https://www.youtube.com/watch?v=GhQNkcpgBwY"" date=""2014-04-02T16:00:00"" subtitle=""It's Got Big Stompy Robots"">
      <extrap title=""Triple-A Ain't What it Used to Be"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11245-Triple-A-Ain-t-What-it-Used-to-Be"" date=""2014-04-08T17:00:00"" />
      <reviewed name=""Titanfall"" wpname=""Titanfall"" />
      <teaser>This week, Zero Punctuation reviews Titanfall.</teaser>
    </Episode>
    <Episode name=""InFamous: Second Son"" number=""344"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9014-inFAMOUS-Second-Son-Bad-Son-Good-Son"" originalname=""inFAMOUS: Second Son"" ytlink=""https://www.youtube.com/watch?v=tOCMiu4j7aM"" date=""2014-04-09T16:00:00"" subtitle=""Bad Son Good Son"">
      <extrap title=""The Totally Hipster Elements in inFamous: Second Son"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11281-The-Totally-Hipster-Elements-in-inFamous-Second-Son"" date=""2014-04-15T17:00:00"" />
      <reviewed name=""inFAMOUS: Second Son"" wpname=""Infamous Second Son"" />
      <teaser>This week, Zero Punctuation reviews inFAMOUS: Second Son.</teaser>
    </Episode>
    <Episode name=""Metal Gear Solid V: Ground Zeroes"" number=""345"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9053-Metal-Gear-Solid-V-Ground-Zeroes-40-Demo"" originalname=""Metal Gear Solid V: Ground Zeroes"" ytlink=""https://www.youtube.com/watch?v=G9ba7F9gpcc"" date=""2014-04-16T16:00:00"" subtitle=""$40 Demo"">
      <extrap title=""Ground Zeroes is Only Worth What You'll Pay For It"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11330-Ground-Zeroes-is-Only-Worth-What-You-ll-Pay-For-It"" date=""2014-04-22T17:00:00"" />
      <reviewed name=""Metal Gear Solid V: Ground Zeroes"" wpname=""Metal Gear Solid V: Ground Zeroes"" />
      <teaser>This week, Zero Punctuation reviews Metal Gear Solid V: Ground Zeroes.</teaser>
    </Episode>
    <Episode name=""The Elder Scrolls Online"" number=""346"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9083-The-Elder-Scrolls-Online-We-Can-MMO-Too"" originalname=""The Elder Scrolls Online"" ytlink=""https://www.youtube.com/watch?v=r3vYM0hzZ2Y"" date=""2014-04-23T16:00:00"" subtitle=""We Can MMO Too"">
      <extrap title=""MMO Adaptation Will Ruin What You Love About Your Favorite Franchise"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11370-MMO-Adaptation-Will-Ruin-What-You-Love-About-Your-Favorite-Franc"" date=""2014-04-29T17:00:00"" />
      <reviewed name=""The Elder Scrolls Online"" wpname=""The Elder Scrolls Online"" />
      <teaser>This week, Zero Punctuation reviews The Elder Scrolls Online.</teaser>
    </Episode>
    <Episode name=""South Park: The Stick of Truth"" number=""347"" length=""300"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9120-South-Park-The-Stick-of-Truth-Yes-There-Really-Were-Crying-Koalas"" originalname=""South Park: The Stick of Truth"" ytlink=""https://www.youtube.com/watch?v=TnZmRvPU3xY"" date=""2014-04-30T16:00:00"" subtitle=""Yes, There Really Were Crying Koalas"">
      <extrap title=""Taking Lessons From South Park - How To Not Ruin an Adaptation"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11406-Taking-Lessons-From-South-Park-How-To-Not-Ruin-an-Adaptation"" date=""2014-05-06T17:00:00"" />
      <reviewed name=""South Park: The Stick of Truth"" wpname=""South Park: The Stick of Truth"" />
      <teaser>This week, Zero Punctuation reviews South Park: The Stick of Truth.</teaser>
    </Episode>
    <Episode name=""FTL: Faster Than Light"" number=""348"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9157-FTL-Faster-Than-Light-Exploding-Spaceships"" originalname=""FTL: Faster Than Light"" ytlink=""https://www.youtube.com/watch?v=d7DT1Z5523s"" date=""2014-05-07T16:00:00"" subtitle=""Exploding Spaceships"">
      <extrap title=""Why Nobody Has the Time to Make Greenlight Work"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11444-Why-Nobody-Has-the-Time-to-Make-Greenlight-Work"" date=""2014-05-13T17:00:00"" />
      <reviewed name=""FTL: Faster Than Light"" wpname=""FTL: Faster Than Light"" />
      <teaser>This week, Zero Punctuation reviews FTL: Faster Than Light.</teaser>
    </Episode>
    <Episode name=""Child of Day-Light"" number=""349"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9187-Child-of-Day-Light-Horror-and-Whimsy"" originalname=""Child of Day-Light"" ytlink=""https://www.youtube.com/watch?v=43CBx_aANjQ"" date=""2014-05-14T16:00:00"" subtitle=""Horror and Whimsy"">
      <extrap title=""Collective Guilt and Beauty in Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11478-Collective-Guilt-and-Beauty-in-Games"" date=""2014-05-20T17:00:00"" />
      <reviewed name=""Daylight"" wpname=""Daylight (video game)"" />
      <reviewed name=""Child of Light"" wpname=""Child of Light"" />
      <teaser>This week, Zero Punctuation reviews Daylight and Child of Light.</teaser>
    </Episode>
    <Episode name=""The Amazing Spider-Man 2"" number=""350"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9231-The-Amazing-Spider-Man-2"" originalname=""The Amazing Spider Man 2"" ytlink=""https://www.youtube.com/watch?v=8rvsB7lT0e8"" date=""2014-05-21T16:00:00"">
      <extrap title=""Immersion in Games: Are You Into It?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11509-Immersion-in-Games-Are-You-Into-It"" date=""2014-05-27T17:00:00"" />
      <reviewed name=""The Amazing Spider Man 2"" wpname=""The Amazing Spider-Man 2 (2014 video game)"" awardname=""Third Worst of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews The Amazing Spider Man 2.</teaser>
    </Episode>
    <Episode name=""Tesla Effect: A Tex Murphy Adventure"" number=""351"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9272-Tesla-Effect-A-Tex-Murphy-Adventure"" originalname=""Tesla Effect: A Tex Murphy Adventure"" ytlink=""https://www.youtube.com/watch?v=Bbm3A-aJnSQ"" date=""2014-05-28T16:00:00"">
      <extrap title=""On FMV in Games, Gore and Giving a Middle Finger to Censors"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11556-On-FMV-in-Games-Gore-and-Giving-a-Middle-Finger-to-Censors"" date=""2014-06-03T17:00:00"" />
      <reviewed name=""Tesla Effect: A Tex Murphy Adventure"" wpname=""Tesla Effect: A Tex Murphy Adventure"" />
      <teaser>This week, Zero Punctuation reviews Tesla Effect: A Tex Murphy Adventure.</teaser>
    </Episode>
    <Episode name=""Wolfenstein: The New Order"" number=""352"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9301-Wolfenstein-The-New-Order"" originalname=""Wolfenstein: The New Order"" ytlink=""https://www.youtube.com/watch?v=E_exiC9g62E"" date=""2014-06-04T16:00:00"">
      <extrap title=""What the Hell Is Going On With E3?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11645-What-the-Hell-Is-Going-On-With-E3"" date=""2014-06-10T17:01:00"" />
      <reviewed name=""Wolfenstein: The New Order"" wpname=""Wolfenstein: The New Order"" awardname=""Second Best of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Wolfenstein: The New Order.</teaser>
    </Episode>
    <Episode name=""WATCH DOGS"" number=""353"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9351-WATCH-DOGS"" originalname=""WATCH_DOGS"" ytlink=""https://www.youtube.com/watch?v=KWf45wqFJNg"" date=""2014-06-11T16:00:00"">
      <extrap title=""Watch_Dogs: Too Much Sandbox, Too Little Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11745-Watch-Dogs-Too-Much-Sandbox-Too-Little-Game"" date=""2014-06-17T17:00:00"" />
      <reviewed name=""WATCH_DOGS"" wpname=""Watch Dogs"" />
      <teaser>This week, Zero Punctuation reviews WATCH_DOGS.</teaser>
    </Episode>
    <Episode name=""E3 2014"" number=""354"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9439-E3-2014-Deflate-Your-Hype-Balloons"" originalname=""E3 2014"" ytlink=""https://www.youtube.com/watch?v=lF1xi8kEBno"" date=""2014-06-18T16:00:00"" subtitle=""Deflate Your Hype Balloons"">
      <extrap title=""Playing Favorites in Wolfenstein's Semi-Branching Story"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11781-Playing-Favorites-in-Wolfenstein-s-Semi-Branching-Story"" date=""2014-06-24T17:00:00"" />
      <teaser>This week, Zero Punctuation reviews E3 2014.</teaser>
    </Episode>
    <Episode name=""Murdered: Soul Suspect"" number=""355"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9469-Murdered-Soul-Suspect"" originalname=""Murdered: Soul Suspect"" ytlink=""https://www.youtube.com/watch?v=m69QDRw4Vno"" date=""2014-06-25T16:00:00"">
      <extrap title=""Building a Legacy by Standing on the Shoulders of Giants"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11818-Building-a-Legacy-by-Standing-on-the-Shoulders-of-Giants"" date=""2014-07-01T17:00:00"" />
      <reviewed name=""Murdered: Soul Suspect"" wpname=""Murdered: Soul Suspect"" />
      <teaser>This week, Zero Punctuation reviews Murdered: Soul Suspect.</teaser>
    </Episode>
    <Episode name=""Tomodachi Life"" number=""356"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9506-Tomodachi-Life-Nintendo-Life-Simulator"" originalname=""Tomodachi Life"" ytlink=""https://www.youtube.com/watch?v=4UNC4Vcv1e8"" date=""2014-07-02T16:00:00"" subtitle=""Nintendo Life Simulator"">
      <extrap title=""If You Are Going to Hate on a Game Company, Do It For the Right Reasons"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11859-If-You-Are-Going-to-Hate-on-a-Game-Company-Do-It-For-the-Right-R"" date=""2014-07-08T17:00:00"" />
      <reviewed name=""Tomodachi Life"" wpname=""Tomodachi Life"" />
      <teaser>This week, Zero Punctuation reviews Tomodachi Life.</teaser>
    </Episode>
    <Episode name=""Enemy Front &amp; Valiant Hearts: The Great War"" number=""357"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9524-Enemy-Front-Valiant-Hearts-The-Great-War"" originalname=""Enemy Front &amp; Valiant Hearts: The Great War"" ytlink=""https://www.youtube.com/watch?v=RGGv6ntj4Pk"" date=""2014-07-09T16:00:00"">
      <extrap title=""The Lazy Storytelling of Modern Games of Warfare"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11911-The-Lazy-Storytelling-of-Modern-Games-of-Warfare"" date=""2014-07-15T17:00:00"" />
      <reviewed name=""Enemy Front"" wpname=""Enemy Front"" />
      <reviewed name=""Valiant Hearts: The Great War"" wpname=""Valiant Hearts: The Great War"" />
      <teaser>This week, Zero Punctuation reviews Enemy Front and Valiant Hearts: The Great War.</teaser>
    </Episode>
    <Episode name=""Shovel Knight"" number=""358"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9549-Shovel-Knight-Good-NES-Nostalgia"" originalname=""Shovel Knight"" ytlink=""https://www.youtube.com/watch?v=ae8E3ANbB9g"" date=""2014-07-16T16:00:00"" subtitle=""Good NES Nostalgia"">
      <extrap title=""Is That Castlevania in Your Pocket?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/11941-Is-That-Castlevania-in-Your-Pocket"" date=""2014-07-22T17:00:00"" />
      <reviewed name=""Shovel Knight"" wpname=""Shovel Knight"" awardname=""Fifth Best of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Shovel Knight.</teaser>
    </Episode>
    <Episode name=""EarthBound"" number=""359"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9570-EarthBound-Not-Your-Typical-JRPG"" originalname=""EarthBound"" ytlink=""https://www.youtube.com/watch?v=iolLKGbbTrM"" date=""2014-07-23T16:00:00"" subtitle=""Not Your Typical JRPG"">
      <extrap title=""The Sexual Awakening of Ness in EarthBound"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12025-The-Sexual-Awakening-of-Ness-in-EarthBound"" date=""2014-07-29T17:00:00"" />
      <reviewed name=""EarthBound"" wpname=""EarthBound"" />
      <teaser>This week, Zero Punctuation reviews EarthBound.</teaser>
    </Episode>
    <Episode name=""Transistor"" number=""360"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9603-Transistor-Like-Bastion-But"" originalname=""Transistor"" ytlink=""https://www.youtube.com/watch?v=n-7Crx3AiWM"" date=""2014-07-30T16:00:00"" subtitle=""Like Bastion But..."">
      <extrap title=""Taking On &quot;Detrimental&quot; Isometric Game Design"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12056-Taking-On-Detrimental-Isometric-Game-Design"" date=""2014-08-05T17:00:00"" />
      <reviewed name=""Transistor"" wpname=""Transistor (video game)"" />
      <teaser>This week, Zero Punctuation reviews Transistor.</teaser>
    </Episode>
    <Episode name=""E.T."" number=""361"" length=""299"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9625-E-T-The-Worst-Game-Ever"" originalname=""E.T."" ytlink=""https://www.youtube.com/watch?v=F8APwHQUHwY"" date=""2014-08-06T16:00:00"" subtitle=""'The Worst Game Ever'"">
      <extrap title=""Is the AAA Console Games Market Heading for a Crash?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12091-Is-the-AAA-Console-Games-Market-Heading-for-a-Crash"" date=""2014-08-12T17:00:00"" />
      <reviewed name=""E.T. the Extra-Terrestrial"" wpname=""E.T. the Extra-Terrestrial (video game)"" />
      <teaser>This week, Zero Punctuation reviews the worst game ever.</teaser>
    </Episode>
    <Episode name=""Firefall"" number=""362"" length=""302"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9645-Firefall-Proof-That-Jetpacks-Make-Everything-Better"" originalname=""Firefall"" ytlink=""https://www.youtube.com/watch?v=WRxPVxTxzzU"" date=""2014-08-13T16:01:00"" subtitle=""Proof That Jetpacks Make Everything Better?"">
      <extrap title=""How Firefall Changed My Mind About MMO Shooters"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12120-Firefall-Does-Things-Right-For-An-MMO-Shooter"" date=""2014-08-19T17:00:00"" />
      <reviewed name=""Firefall"" wpname=""Firefall (video game)"" />
      <teaser>This week, Zero Punctuation reviews the free-to-play MMO shooter Firefall.</teaser>
    </Episode>
    <Episode name=""Sacred 3"" number=""363"" length=""308"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9664-Sacred-3-Nothing-Is-Sacred"" originalname=""Sacred 3"" ytlink=""https://www.youtube.com/watch?v=5XT36Z5sK-E"" date=""2014-08-20T16:00:00"" subtitle=""Nothing Is Sacred"">
      <extrap title=""Sacred 3: If Someone Asks If You Are a God, You Say Yes!"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12155-Sacred-3-s-God-Complex-Ascendancy-Vs-Seeking-a-Promotion"" date=""2014-08-26T17:00:00"" />
      <reviewed name=""Sacred 3"" wpname=""Sacred 3"" awardname=""Fifth Worst of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews hack and slash Sacred 3.</teaser>
    </Episode>
    <Episode name=""Risen 3: Titan Lords"" number=""364"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9684-Risen-3-Titan-Lords-Pirate-ArrrrRPG"" originalname=""Risen 3: Titan Lords"" ytlink=""https://www.youtube.com/watch?v=GMQyHRoiCUA"" date=""2014-08-27T16:00:00"" subtitle=""Pirate ArrrrRPG"">
      <extrap title=""The Theory That Will Tie All Video Game Stories Together"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12190-The-Grand-Unifying-Theory-of-Video-Games-Ties-the-Story-Lines-of"" date=""2014-09-02T17:00:00"" />
      <reviewed name=""Risen 3: Titan Lords"" wpname=""Risen 3: Titan Lords"" />
      <teaser>This week, Zero Punctuation reviews the pirate RPG Risen 3: Titan Lords.</teaser>
    </Episode>
    <Episode name=""Daikatana"" number=""365"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9699-Daikatana-John-Romeros-B"" originalname=""Daikatana"" ytlink=""https://www.youtube.com/watch?v=JYnbHfwbPQw"" date=""2014-09-03T16:00:00"" subtitle=""John Romero's B****"">
      <extrap title=""Life After Doom - Video Games' Visionaries"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12227-Video-Game-Visionaries-Carmack-American-McGee-and-Tom-Hall"" date=""2014-09-09T17:00:00"" />
      <reviewed name=""Daikatana"" wpname=""Daikatana"" />
      <teaser>This week, Zero Punctuation reviews the epic failure that was Daikatana.</teaser>
    </Episode>
    <Episode name=""Lichdom: Battlemage"" number=""366"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9714-Lichdom-Battlemage"" originalname=""Lichdom: Battlemage"" ytlink=""https://www.youtube.com/watch?v=i5XeyLgYZ-E"" date=""2014-09-10T16:00:00"">
      <extrap title=""Should Every Game Allow You to Choose Your Gender?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12251-Lichdom-Battlemage-Adds-Diversity-to-Its-Game-With-Gender-Choice"" date=""2014-09-16T17:00:00"" />
      <reviewed name=""Lichdom: Battlemage"" wpname=""Lichdom: Battlemage"" />
      <teaser>This week, Zero Punctuation reviews Lichdom: Battlemage.</teaser>
    </Episode>
    <Episode name=""The Sims 4"" number=""367"" length=""315"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9738-The-Sims-4-Player-First"" originalname=""The Sims 4"" ytlink=""https://www.youtube.com/watch?v=_BeVmHbMqAA"" date=""2014-09-17T16:00:00"" subtitle=""Player First!"">
      <extrap title=""How to Make The Sims Double As A Corporate Workplace Simulator"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12296-Suggestions-for-Improving-The-Sims-4-Experience"" date=""2014-09-23T17:00:00"" />
      <reviewed name=""The Sims 4"" wpname=""The Sims 4"" />
      <teaser>This week, Zero Punctuation reviews The Sims 4.</teaser>
    </Episode>
    <Episode name=""Destiny"" number=""368"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9749-Destiny-Always-On-Grind"" originalname=""Destiny"" ytlink=""https://www.youtube.com/watch?v=S5SCXhxNg4A"" date=""2014-09-24T16:00:00"" subtitle=""Always-On Grind"">
      <extrap title=""Destiny Ushers in a New Era of Blatant Cash Grabs"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12337-Destiny-Wants-Your-Money-Not-Your-Love"" date=""2014-09-30T17:00:00"" />
      <reviewed name=""Destiny"" wpname=""Destiny (video game)"" />
      <teaser>This week, Zero Punctuation reviews Destiny.</teaser>
    </Episode>
    <Episode name=""D4: Dark Dreams Don't Die"" number=""369"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9770-D4-Dark-Dreams-Dont-Die"" originalname=""D4: Dark Dreams Don't Die"" ytlink=""https://www.youtube.com/watch?v=9nyFJ-1mjTE"" date=""2014-10-01T16:00:00"">
      <extrap title=""What Defines the Games of Suda 51 and Swery65"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12374-The-Cult-Following-of-the-Games-By-Suda-51-and-Swery65"" date=""2014-10-07T17:00:00"" />
      <reviewed name=""D4: Dark Dreams Don't Die"" wpname=""D4: Dark Dreams Don't Die"" />
      <teaser>This week, Zero Punctuation reviews D4: Dark Dreams Don't Die.</teaser>
    </Episode>
    <Episode name=""Hyrule Warriors"" number=""370"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9788-Hyrule-Warriors-Nintendo-Holding-Pattern"" originalname=""Hyrule Warriors"" ytlink=""https://www.youtube.com/watch?v=NQCuWAaTCP8"" date=""2014-10-08T18:00:00"" subtitle=""Nintendo Holding Pattern?"">
      <extrap title=""Just What Exactly Does the Triforce in Zelda Do?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12442-Laying-Bare-the-Mystery-of-Zelda-s-Triforce-Artifact"" date=""2014-10-14T17:00:00"" />
      <reviewed name=""Hyrule Warriors"" wpname=""Hyrule Warriors"" />
      <teaser>This week, Zero Punctuation reviews Hyrule Warriors.</teaser>
    </Episode>
    <Episode name=""Middle-earth: Shadow of Mordor"" number=""371"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9802-Middle-earth-Shadow-of-Mordor-Mordoooooor"" originalname=""Middle-earth: Shadow of Mordor"" ytlink=""https://www.youtube.com/watch?v=hTyoQb-2EVk"" date=""2014-10-15T18:00:00"" subtitle=""Mordoooooor"">
      <extrap title=""The Compelling Story Within a Story in Shadow of Mordor"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12478-Shadow-of-Mordor-Storytelling-in-a-Middle-earth-Game"" date=""2014-10-21T17:00:00"" />
      <reviewed name=""Middle-earth: Shadow of Mordor"" wpname=""Middle-earth: Shadow of Mordor"" awardname=""Best game of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Shadow of Mordor.</teaser>
    </Episode>
    <Episode name=""Alien Isolation"" number=""372"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9817-Alien-Isolation-Surprising-Survival-Horror"" originalname=""Alien Isolation"" ytlink=""https://www.youtube.com/watch?v=ZssC5Iw4XrA"" date=""2014-10-22T18:00:00"" subtitle=""Surprising Survival Horror"">
      <extrap title=""Why Were Shadow of Mordor and Alien Isolation So Good?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12515-The-Last-Two-Movie-Tie-In-Games-Were-Good-Don-t-Keep-Making-Them"" date=""2014-10-28T17:00:00"" />
      <reviewed name=""Alien Isolation"" wpname=""Alien: Isolation"" awardname=""Third Best of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Alien Isolation.</teaser>
    </Episode>
    <Episode name=""The Evil Within"" number=""373"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9840-The-Evil-Within-As-Bad-as-Bad-Horror-Games-Can-Get"" originalname=""The Evil Within"" ytlink=""https://www.youtube.com/watch?v=11xX5Q2iNZQ"" date=""2014-10-29T18:00:00"" subtitle=""As Bad as Bad Horror Games Can Get"">
      <extrap title=""Why The Evil Within Fails on Multiple Levels"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12558-The-Evil-WithinTries-to-Be-Resident-Evil-or-Silent-Hill-But-Fail"" date=""2014-11-04T17:00:00"" />
      <reviewed name=""The Evil Within"" wpname=""The Evil Within"" />
      <teaser>This week, Zero Punctuation reviews The Evil Within.</teaser>
    </Episode>
    <Episode name=""Bayonetta 2"" number=""374"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9866-Bayonetta-2-Sheer-Joyful-Energy"" originalname=""Bayonetta 2"" ytlink=""https://www.youtube.com/watch?v=z7zXUa22t2I"" date=""2014-11-05T16:00:00"" subtitle=""Sheer Joyful Energy"">
      <extrap title=""How Bayonetta's Gender is Relevant to the Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12596-Bayonetta-s-Gender-is-Woven-Intricately-to-The-Game-s-Plot"" date=""2014-11-11T17:00:00"" />
      <reviewed name=""Bayonetta 2"" wpname=""Bayonetta 2"" />
      <teaser>This week, Zero Punctuation reviews Bayonetta 2.</teaser>
    </Episode>
    <Episode name=""Sunset Overdrive"" number=""375"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9895-Sunset-Overdrive-Trying-Too-Hard"" originalname=""Sunset Overdrive"" ytlink=""https://www.youtube.com/watch?v=u3e2luXezW8"" date=""2014-11-12T16:00:00"" subtitle=""Trying Too Hard?"">
      <extrap title=""Sunset Overdrive and Applying The Rules of Comedy"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12628-Sunset-Overdrive-s-Humor-Fails-Because-It-Doesn-t-Follow-the-Rul"" date=""2014-11-18T17:00:00"" />
      <reviewed name=""Sunset Overdrive"" wpname=""Sunset Overdrive"" />
      <teaser>This week, Zero Punctuation reviews Sunset Overdrive.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Advanced Warfare"" number=""376"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9907-Call-of-Duty-Advanced-Warfare-G-I-Joe-Villain-Kevin-Spacey"" originalname=""Call of Duty: Advanced Warfare"" ytlink=""https://www.youtube.com/watch?v=8w0fhZiY24A"" date=""2014-11-19T16:00:00"" subtitle=""G.I. Joe Villain Kevin Spacey"">
      <extrap title=""The Latest Scourge of AAA Game Design"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12658-Quick-and-Slow-Time-Events-Are-the-Scourge-of-AAA-Game-Design"" date=""2014-11-25T17:00:00"" />
      <reviewed name=""Call of Duty: Advanced Warfare"" wpname=""Call of Duty: Advanced Warfare"" />
      <teaser>This week, Zero Punctuation reviews Call of Duty: Advanced Warfare.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed: Unity"" number=""377"" length=""317"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9920-Assassins-Creed-Unity-From-Pirates-to-Paris"" originalname=""Assassin's Creed: Unity"" ytlink=""https://www.youtube.com/watch?v=TB3DrTkVgHw"" date=""2014-11-26T16:00:00"" subtitle=""From Pirates to Paris"">
      <extrap title=""Trying to Make Sense of Assassin's Creed: Unity's Main Character"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12695-Assassin-s-Creed-Unity-Plot-Holes-Plague-Arno-s-Character"" date=""2014-12-02T17:00:00"" />
      <reviewed name=""Assassin's Creed: Unity"" wpname=""Assassin's Creed Unity"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed: Unity.</teaser>
    </Episode>
    <Episode name=""Far Cry 4"" number=""378"" length=""350"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9930-Far-Cry-4-F-k-Eagles"" originalname=""Far Cry 4"" ytlink=""https://www.youtube.com/watch?v=lkVj1JniLXQ"" date=""2014-12-03T16:00:00"" subtitle=""F**k Eagles"">
      <extrap title=""A New Commandment for Developing Games With RPG Elements"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12727-Developers-Need-to-Stop-Ignoring-RPG-Elements-They-Add-to-Games"" date=""2014-12-09T15:53:00"" />
      <reviewed name=""Far Cry 4"" wpname=""Far Cry 4"" />
      <teaser>This week, Zero Punctuation reviews Far Cry 4.</teaser>
    </Episode>
    <Episode name=""Dragon Age: Inquisition"" number=""379"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9940-Dragon-Age-Inquisition-Fantasy-Commander-Shepard"" originalname=""Dragon Age: Inquisition"" ytlink=""https://www.youtube.com/watch?v=GH2hQKVMK9I"" date=""2014-12-10T16:00:00"" subtitle=""Fantasy Commander Shepard"">
      <extrap title=""Making Faces - A Bioware Story"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12762-Improving-Bioware-s-Conversation-Animations-With-Mocap"" date=""2014-12-16T17:00:00"" />
      <reviewed name=""Dragon Age: Inquisition"" wpname=""Dragon Age: Inquisition"" />
      <teaser>This week, Zero Punctuation reviews Dragon Age: Inquisition.</teaser>
    </Episode>
    <Episode name=""Sonic Boom: Rise of Lyric"" number=""380"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9953-Sonic-Boom-Boom-or-Bust"" originalname=""Sonic Boom"" ytlink=""https://www.youtube.com/watch?v=oESyZXbHNbQ"" date=""2014-12-17T16:00:00"" subtitle=""Boom or Bust"">
      <extrap title=""The Grand Unifying Theory of Games: Adding More Depth"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12806-Grand-Unifying-Theory-of-Video-Games-Ties-55-Stories-Together"" date=""2014-12-30T17:00:00"" />
      <reviewed name=""Sonic Boom: Rise of Lyric"" wpname=""Sonic Boom: Rise of Lyric"" awardname=""Second Worst of 2014"" awardepisode=""Top 5 Games of 2014"" />
      <teaser>This week, Zero Punctuation reviews Sonic Boom.</teaser>
    </Episode>
    <Episode name=""Top 5 Games of 2014"" number=""381"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9973-Top-5-Games-of-2014"" originalname=""Top 5 Games of 2014"" ytlink=""https://www.youtube.com/watch?v=79nhVj8fKNY"" date=""2014-12-31T16:00:00"">
      <extrap title=""The Honorable and Dishonorable Game Mentions For 2014"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12824-Extra-Punctuation-s-2014-Honorable-Mentions-for-Games"" date=""2015-01-06T17:00:00"" />
      <teaser>This week, Zero Punctuation takes a look at the top 5 best and worst games of 2014.</teaser>
    </Episode>
    <Episode name=""The Talos Principle"" number=""382"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9981-Talos-Principle"" originalname=""Talos Principle"" ytlink=""https://www.youtube.com/watch?v=llxR5hbwG4Y"" date=""2015-01-07T16:00:00"">
      <extrap title=""The Talos Principle Comes Out of The Myst and Through a Portal"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12858-The-Talos-Principle-Borrows-From-Portal-With-Some-Pretention"" date=""2015-01-13T17:00:00"" />
      <reviewed name=""The Talos Principle"" wpname=""The Talos Principle"" />
      <teaser>This week, Zero Punctuation reviews Talos Principle.</teaser>
    </Episode>
    <Episode name=""Elite: Dangerous"" number=""383"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/9991-Elite-Dangerous-Space-Truckin"" originalname=""Elite: Dangerous"" ytlink=""https://www.youtube.com/watch?v=aLzW0dl87JY"" date=""2015-01-14T16:00:00"" subtitle=""Space Truckin'"">
      <extrap title=""On the PC Master Race and the Language Police"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12882-The-PC-Master-Race-Discussion-Political-Correctness-vs-Language-"" date=""2015-01-20T17:00:00"" />
      <reviewed name=""Elite: Dangerous"" wpname=""Elite: Dangerous"" awardname=""Second Best of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Elite: Dangerous.</teaser>
    </Episode>
    <Episode name=""Five Nights at Freddy's and This War of Mine"" number=""384"" length=""313"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10005-Five-Nights-at-Freddys-and-This-War-of-Mine"" originalname=""Five Nights at Freddys and This War of Mine"" ytlink=""https://www.youtube.com/watch?v=fkUPA-d-nfc"" date=""2015-01-21T15:00:00"">
      <extrap title=""Five Nights at Freddy's and the Nature of the Jumpscare"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12903-In-Survival-Horror-Anticipation-is-Worse-Than-the-Actual-Scare"" date=""2015-01-27T17:00:00"" />
      <reviewed name=""Five Nights at Freddy's"" wpname=""Five Nights at Freddy's"" />
      <reviewed name=""This War of Mine"" wpname=""This War of Mine"" />
      <teaser>This week, Zero Punctuation takes on indies Five Nights at Freddys and This War of Mine.</teaser>
    </Episode>
    <Episode name=""Lords of the Fallen"" number=""385"" length=""305"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10012-Lords-of-the-Fallen-Imitation-is-Flattery"" originalname=""Lords of the Fallen"" ytlink=""https://www.youtube.com/watch?v=bzaEa3DzYHY"" date=""2015-01-28T16:00:00"" subtitle=""Imitation is Flattery?"">
      <extrap title=""How You Can Make a AAA Game Like Today's Developers"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12931-The-Patchwork-Nature-of-Today-s-AAA-Games"" date=""2015-02-03T17:00:00"" />
      <reviewed name=""Lords of the Fallen"" wpname=""Lords of the Fallen"" />
      <teaser>This week, Zero Punctuation reviews Lords of the Fallen.</teaser>
    </Episode>
    <Episode name=""Saints Row: Gat out of Hell"" number=""386"" length=""303"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10020-Saints-Row-Gat-Out-Of-Hell"" originalname=""Saints Row: Gat Out Of Hell"" ytlink=""https://www.youtube.com/watch?v=qCH9K01RTlE"" date=""2015-02-04T16:00:00"">
      <extrap title=""Expanding the Game: The Semantics of Standalone"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12964-The-Concept-Behind-the-Oxymoronic-Standalone-Expansion"" date=""2015-02-10T17:00:00"" />
      <reviewed name=""Saints Row: Gat Out Of Hell"" wpname=""Saints Row: Gat out of Hell"" />
      <teaser>This week, Zero Punctuation reviews Saints Row: Gat Out Of Hell.</teaser>
    </Episode>
    <Episode name=""Dying Light"" number=""387"" length=""314"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10030-Dying-Light-Yay-More-Zombies"" originalname=""Dying Light"" ytlink=""https://www.youtube.com/watch?v=GbVlTDoO3Ic"" date=""2015-02-11T16:00:00"" subtitle=""Yay, More Zombies"">
      <extrap title=""A Review Scoring System That Would Work"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/12989-Video-Game-Review-Scores-A-System-That-Would-Work"" date=""2015-02-17T17:00:00"" />
      <reviewed name=""Dying Light"" wpname=""Dying Light"" />
      <teaser>This week, Zero Punctuation reviews Dying Light.</teaser>
    </Episode>
    <Episode name=""Grim Fandango"" number=""388"" length=""308"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10038-Grim-Fandango-Does-It-Hold-Up"" originalname=""Grim Fandango"" ytlink=""https://www.youtube.com/watch?v=-Dos1RP-HCE"" date=""2015-02-18T16:00:00"" subtitle=""Does It Hold Up?"">
      <extrap title=""Taking On Remastered Games And The Effects of Nostalgia"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13550-When-Remastering-Classic-Games-Stay-True-to-the-Originals"" date=""2015-02-24T17:00:00"" />
      <reviewed name=""Grim Fandango"" wpname=""Grim Fandango"" />
      <teaser>This week, Zero Punctuation reviews Grim Fandango.</teaser>
    </Episode>
    <Episode name=""Evolve"" number=""389"" length=""304"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10044-Evolve-One-vs-Multiplayer"" originalname=""Evolve"" ytlink=""https://www.youtube.com/watch?v=5i8SyOm3pZw"" date=""2015-02-25T16:00:00"" subtitle=""One vs Multiplayer"">
      <extrap title=""Why Completing All Objectives And Finding All Secrets Are Meaningless"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13573-Filling-the-Bar-The-Meaningless-Progress-of-a-Games-Completionis"" date=""2015-03-03T17:00:00"" />
      <reviewed name=""Evolve"" wpname=""Evolve (video game)"" />
      <teaser>This week, Zero Punctuation reviews Evolve.</teaser>
    </Episode>
    <Episode name=""The Order: 1886"" number=""390"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10051-The-Order-1886-Steampunk-Modern-Warfare"" originalname=""The Order: 1886"" ytlink=""https://www.youtube.com/watch?v=YPI0c_jeqSE"" date=""2015-03-04T16:00:00"" subtitle=""Steampunk Modern Warfare"">
      <extrap title=""The Current Trend of The Anticlimax in Video Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13604-Many-of-Today-s-Video-Games-Are-Anticlimactic-to-a-Fault"" date=""2015-03-10T17:00:00"" />
      <reviewed name=""The Order: 1886"" wpname=""The Order: 1886"" awardname=""Worst game of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews The Order: 1886.</teaser>
    </Episode>
    <Episode name=""The Legend of Zelda: Majora's Mask 3D"" number=""391"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10061-The-Legend-of-Zelda-Majoras-Mask-3D"" originalname=""The Legend of Zelda: Majora's Mask 3D"" ytlink=""https://www.youtube.com/watch?v=nRPdBffBnUI"" date=""2015-03-11T16:00:00"">
      <extrap title=""Why the N64 Majora's Mask Could Not Be Made Today As a AAA Title"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13644-Maximum-Accessibility-Would-Doom-An-N64-Majora-s-Mask-Today"" date=""2015-03-17T17:00:00"" />
      <reviewed name=""The Legend of Zelda: Majora's Mask 3D"" wpname=""The Legend of Zelda: Majora's Mask 3D"" />
      <teaser>This week, Zero Punctuation reviews The Legend of Zelda: Majora's Mask 3D.</teaser>
    </Episode>
    <Episode name=""Resident Evil Revelations 2"" number=""392"" length=""304"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10068-Resident-Evil-Revelations-2-Episodic-Zombies"" originalname=""Resident Evil: Revelations 2"" ytlink=""https://www.youtube.com/watch?v=rwDzjb8r7m0"" date=""2015-03-18T16:00:00"" subtitle=""Episodic Zombies"">
      <extrap title=""The Exploitative Nature of Crafting in Video Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13672-Crafting-as-a-Trend-in-Games-Is-Not-What-It-Should-Be"" date=""2015-03-24T17:00:00"" />
      <reviewed name=""Resident Evil: Revelations 2"" wpname=""Resident Evil: Revelations 2"" />
      <teaser>This week, Zero Punctuation reviews Resident Evil: Revelations 2.</teaser>
    </Episode>
    <Episode name=""Hotline Miami 2: Wrong Number &amp; Ori and the Blind Forest"" number=""393"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10078-Hotline-Miami-2-Wrong-Number-Ori-And-the-Blind-Forest"" originalname=""Hotline Miami 2: Wrong Number &amp; Ori And the Blind Forest"" ytlink=""https://www.youtube.com/watch?v=i-PD7fOhwQ0"" date=""2015-03-25T16:00:00"">
      <extrap title=""Why You Should Be a Bit Disappointed With Ori and the Blind Forest"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13713-Ori-and-the-Blind-Forest-Is-More-Style-Over-Substance"" date=""2015-03-31T17:00:00"" />
      <reviewed name=""Hotline Miami 2: Wrong Number"" wpname=""Hotline Miami 2: Wrong Number"" />
      <reviewed name=""Ori And the Blind Forest"" wpname=""Ori and the Blind Forest"" />
      <teaser>This week, Zero Punctuation reviews Hotline Miami 2: Wrong Number &amp; Ori And the Blind Forest.</teaser>
    </Episode>
    <Episode name=""Battlefield: Hardline"" number=""394"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10086-Battlefield-Hardline-Cops-Robbers"" originalname=""Battlefield: Hardline"" ytlink=""https://www.youtube.com/watch?v=icP1rTgp4Xs"" date=""2015-04-01T16:00:00"" subtitle=""Cops &amp; Robbers"">
      <extrap title=""The Annoying Tendency To Mix Styles of Play In A Single Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13748-Mixing-Gameplay-Styles-in-AAA-Games-Is-A-Bad-Idea"" date=""2015-04-07T17:00:00"" />
      <reviewed name=""Battlefield: Hardline"" wpname=""Battlefield Hardline"" />
      <teaser>This week, Zero Punctuation reviews Battlefield: Hardline.</teaser>
    </Episode>
    <Episode name=""Bloodborne"" number=""395"" length=""332"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10092-Bloodborne-Bloodly-Dark-Souls"" originalname=""Bloodborne"" ytlink=""https://www.youtube.com/watch?v=rQ6v5iFf-rk"" date=""2015-04-08T16:00:00"" subtitle=""Bloodly Dark Souls"">
      <extrap title=""Bloodborne May Seem Like A Dark Souls Game, But Be Warned"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13779-Bloodborne-Will-Make-It-Tougher-To-Replay-Dark-Souls"" date=""2015-04-14T17:00:00"" />
      <reviewed name=""Bloodborne"" wpname=""Bloodborne"" awardname=""Fifth Best of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Bloodborne.</teaser>
    </Episode>
    <Episode name=""Half-Life 2 Update"" number=""396"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10098-Half-Life-2-Update-Gravity-Gun-Modern-FPS"" originalname=""Half-Life 2 Update"" ytlink=""https://www.youtube.com/watch?v=MDDfJJQrpsg"" date=""2015-04-15T16:00:00"" subtitle=""Gravity Gun &gt; Modern FPS"">
      <extrap title=""Will Half-Life 3 Outlive Public Interest Because of Development Time?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13808-Waiting-For-Half-Life-3-Could-Give-Us-Team-Fortress-2-or-DNF"" date=""2015-04-21T17:00:00"" />
      <reviewed name=""Half-Life 2 Update"" />
      <teaser>This week, Zero Punctuation reviews Half-Life 2 Update.</teaser>
    </Episode>
    <Episode name=""Axiom Verge &amp; Stealth Inc 2"" number=""397"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10104-Axiom-Verge-Stealth-Inc-2"" originalname=""Axiom Verge &amp; Stealth Inc 2"" ytlink=""https://www.youtube.com/watch?v=GkJ1nnJPUvE"" date=""2015-04-22T16:00:00"">
      <extrap title=""Alternatives to the Glut of Metroidvania-Style Platformers"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13839-Many-Indie-Platformers-Lately-Have-a-Distinct-Metroidvania-Feel"" date=""2015-04-28T17:00:00"" />
      <reviewed name=""Axiom Verge"" wpname=""Axiom Verge"" />
      <reviewed name=""Stealth Inc 2: A Game of Clones"" wpname=""Stealth Inc 2: A Game of Clones"" />
      <teaser>This week, Zero Punctuation reviews Axiom Verge and Stealth Inc 2.</teaser>
    </Episode>
    <Episode name=""Mortal Kombat X"" number=""398"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10112-Mortal-Kombat-X-Test-Your-Might"" originalname=""Mortal Kombat X"" ytlink=""https://www.youtube.com/watch?v=RpvbhlNDstM"" date=""2015-04-29T16:00:00"" subtitle=""Test Your Might"">
      <extrap title=""Narrative Continuity of Fighting Games is Convoluted, Especially Mortal Kombat X"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13863-Mortal-Kombat-X-Has-A-Convoluted-Narrative"" date=""2015-05-05T17:00:00"" />
      <reviewed name=""Mortal Kombat X"" wpname=""Mortal Kombat X"" />
      <teaser>This week, Zero Punctuation reviews Mortal Kombat X.</teaser>
    </Episode>
    <Episode name=""Grand Theft Auto Online"" number=""399"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10119-Grand-Theft-Auto-Online"" originalname=""Grand Theft Auto Online"" ytlink=""https://www.youtube.com/watch?v=kJ1scW6vbKY"" date=""2015-05-06T16:00:00"">
      <extrap title=""How to Pass the Time While Waiting to Play A Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13907-Four-Solutions-to-In-Game-Waiting-That-Would-Make-the-Experience"" date=""2015-05-12T17:00:00"" />
      <reviewed name=""Grand Theft Auto Online"" wpname=""Grand Theft Auto Online"">
        <seealso>Grand Theft Auto V</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Grand Theft Auto Online.</teaser>
    </Episode>
    <Episode name=""Broken Age: Act 2"" number=""400"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10127-Broken-Age-Act-2"" originalname=""Broken Age: Act 2"" ytlink=""https://www.youtube.com/watch?v=XItguTFFre0"" date=""2015-05-13T16:00:00"">
      <extrap title=""Pondering Adventure Games and Gameplay in Modern Gaming"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13943-Thoughts-on-Adventure-Games-and-Gameplay-in-Modern-Gaming"" date=""2015-05-19T17:00:00"" />
      <reviewed name=""Broken Age"" wpname=""Broken Age"">
        <seealso>Broken Age</seealso>
      </reviewed>
      <teaser>This week, Zero Punctuation reviews Broken Age: Act 2.</teaser>
    </Episode>
    <Episode name=""Wolfenstein: The Old Blood"" number=""401"" length=""350"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10137-Wolfenstein-The-Old-Blood"" originalname=""Wolfenstein: The Old Blood"" ytlink=""https://www.youtube.com/watch?v=bfx19Z5pggU"" date=""2015-05-20T16:00:00"">
      <extrap title=""The Highs and Lows of Gaming in Virtual Reality"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/13970-The-Highs-and-Low-of-VR-Gaming"" date=""2015-05-26T17:00:00"" />
      <reviewed name=""Wolfenstein: The Old Blood"" wpname=""Wolfenstein: The Old Blood"" />
      <teaser>This week, Zero Punctuation reviews Wolfenstein: The Old Blood.</teaser>
    </Episode>
    <Episode name=""Cyberpunk Double"" number=""402"" length=""338"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10149-Cyberpunk-Double-Dex-Invisible-Inc"" originalname=""Cyberpunk Double (Dex &amp; Invisible, Inc.)"" ytlink=""https://www.youtube.com/watch?v=Ik9PKDi1R94"" date=""2015-05-27T16:00:00"">
      <extrap title=""Turning to Turn-Based for Stealth and Other Types of Gameplay"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14004-How-Turn-Based-Gameplay-Could-Work-for-More-than-Combat"" date=""2015-06-02T17:00:00"" />
      <reviewed name=""Dex"" wpname=""Dex (video game)"" />
      <reviewed name=""Invisible, Inc."" wpname=""Invisible, Inc."" />
      <teaser>This week, Zero Punctuation reviews Dex &amp; Invisible, Inc..</teaser>
    </Episode>
    <Episode name=""The Witcher 3: Wild Hunt"" number=""403"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10161-The-Witcher-3-Wild-Hunt"" originalname=""The Witcher 3: Wild Hunt"" ytlink=""https://www.youtube.com/watch?v=tmH_Fai42g8"" date=""2015-06-03T16:00:00"">
      <extrap title=""The Plight of the Mary Sue Character in Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14036-A-Mary-Sue-in-Video-Games-is-Only-As-Skilled-As-the-Player"" date=""2015-06-09T17:00:00"" />
      <reviewed name=""The Witcher 3: Wild Hunt"" wpname=""The Witcher 3: Wild Hunt"" awardname=""Third Best of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews The Witcher 3: Wild Hunt.</teaser>
    </Episode>
    <Episode name=""Splatoon"" number=""404"" length=""345"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10168-Splatoon-Ink-Pun"" originalname=""Splatoon"" ytlink=""https://www.youtube.com/watch?v=jsEERBtMq88"" date=""2015-06-10T16:00:00"" subtitle=""Ink Pun"">
      <extrap title=""Should Games Arbitrarily Withhold Content?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14125-Splatoon-Should-Let-You-Play-More-Than-Two-Maps"" date=""2015-06-16T17:00:00"" />
      <reviewed name=""Splatoon"" wpname=""Splatoon"" />
      <teaser>This week, Zero Punctuation reviews Splatoon.</teaser>
    </Episode>
    <Episode name=""Hatred"" number=""405"" length=""333"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10177-Hatred-Maypole-of-Controversy"" originalname=""Hatred"" ytlink=""https://www.youtube.com/watch?v=2ub4wS_tjY4"" date=""2015-06-17T16:00:00"" subtitle=""Maypole of Controversy"">
      <extrap title=""On Being Deliberately Offensive"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14200-Hatred-And-Postal-Are-Deliberately-Offensive-So-Stop-Caring"" date=""2015-06-23T17:00:00"" />
      <reviewed name=""Hatred"" wpname=""Hatred (video game)"" awardname=""Fourth Worst of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Hatred.</teaser>
    </Episode>
    <Episode name=""E3 2015"" number=""406"" length=""354"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10185-E3-2015-Hype-Train-Is-Back"" originalname=""E3 2015"" ytlink=""https://www.youtube.com/watch?v=pVhA2dnoQCs"" date=""2015-06-24T16:00:00"" subtitle=""Hype Train Is Back"">
      <extrap title=""Did You All Forget To Be On Guard Against E3?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14239-Tips-For-Avoiding-the-E3-Hype-Disease"" date=""2015-06-30T17:00:00"" />
      <teaser>This week, Zero Punctuation reviews E3 2015.</teaser>
    </Episode>
    <Episode name=""Alone in the Dark: Illumination"" number=""407"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10196-Alone-in-the-Dark-Illumination-Like-Left-4-Dead-But"" originalname=""Alone in the Dark: Illumination"" ytlink=""https://www.youtube.com/watch?v=k8eOHNj7Qbs"" date=""2015-07-01T16:00:00"" subtitle=""Like Left 4 Dead But..."">
      <extrap title=""Here's Whats Wrong With Alone in the Dark: Illumination"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14272-Alone-in-the-Dark-Illumination-Review-Here-s-Where-It-s-Broken"" date=""2015-07-07T17:00:00"" />
      <reviewed name=""Alone in the Dark: Illumination"" wpname=""Alone in the Dark: Illumination"" awardname=""Second Worst of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Alone in the Dark: Illumination.</teaser>
    </Episode>
    <Episode name=""Batman: Arkham Knight"" number=""408"" length=""366"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10204-Batman-Arkham-Knight-Being-Rich-Is-a-Super-Power"" originalname=""Batman: Arkham Knight"" ytlink=""https://www.youtube.com/watch?v=PZ-BcdgD-1c"" date=""2015-07-08T16:00:00"" subtitle=""Being Rich Is a Super Power"">
      <extrap title=""Inside the Development of Hatfall"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14306-How-Hatfall-the-Zero-Punctuation-Game-Was-Made"" date=""2015-07-14T17:00:00"" />
      <reviewed name=""Batman: Arkham Knight"" wpname=""Batman: Arkham Knight"" awardname=""Fifth Blandest of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Batman: Arkham Knight.</teaser>
    </Episode>
    <Episode name=""Yoshi's Woolly World"" number=""409"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10217-Yoshis-Woolly-World-Cartoon-Velociraptor"" originalname=""Yoshi's Woolly World"" ytlink=""https://www.youtube.com/watch?v=0_O-La8Fe9Y"" date=""2015-07-15T16:00:00"" subtitle=""Cartoon Velociraptor"">
      <extrap title=""I Never Did Like Yoshi's Island"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14339-Yoshi-s-Island-Wasn-t-Good"" date=""2015-07-21T17:00:00"" />
      <reviewed name=""Yoshi's Woolly World"" wpname=""Yoshi's Woolly World"" />
      <teaser>This week, Zero Punctuation reviews Yoshi's Woolly World.</teaser>
    </Episode>
    <Episode name=""Cave Story"" number=""410"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10270-Cave-Story-Heart-and-Art"" originalname=""Cave Story"" ytlink=""https://www.youtube.com/watch?v=twj5AoWHybU"" date=""2015-07-22T16:00:00"" subtitle=""Heart and Art"">
      <extrap title=""How Intuitive Does A Game Have to Be?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14366-Cave-Story-is-Unintuitive-Dark-Souls-is-Not"" date=""2015-07-28T17:01:00"" />
      <reviewed name=""Cave Story"" wpname=""Cave Story"" />
      <teaser>This week, Zero Punctuation reviews Cave Story.</teaser>
    </Episode>
    <Episode name=""Godzilla"" number=""411"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/10286-Godzilla-God-Awful-Zilla"" originalname=""Godzilla"" ytlink=""https://www.youtube.com/watch?v=5k2UhoYF1qo"" date=""2015-07-29T17:00:00"" subtitle=""God-Awful-Zilla"">
      <extrap title=""What if the Godzilla Game Had Been Good?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14404-How-To-Make-A-Good-Godzilla-Game"" date=""2015-08-04T17:00:00"" />
      <reviewed name=""Godzilla"" wpname=""Godzilla (2014 video game)"" awardname=""Third Worst of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Godzilla.</teaser>
    </Episode>
    <Episode name=""Rocket League &amp; Tembo the Badass Elephant"" number=""412"" length=""309"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57380-Rocket-League-Tembo-The-Badass-Elephant"" originalname=""Rocket League &amp; Tembo The Badass Elephant"" ytlink=""https://www.youtube.com/watch?v=-GvCfIONCY4"" date=""2015-08-05T16:00:00"">
      <extrap title=""Tembo the Badass Elephant is a Bit Desperate, Isn't it?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14430-Tembo-the-Badass-Elephant-Is-A-Bad-Game-Title"" date=""2015-08-11T17:00:00"" />
      <reviewed name=""Rocket League"" wpname=""Rocket League"" />
      <reviewed name=""Tembo The Badass Elephant"" wpname=""Tembo the Badass Elephant"" />
      <teaser>This week, a Zero Punctuation double feature reviews Rocket League and Tembo The Badass Elephant</teaser>
    </Episode>
    <Episode name=""King's Quest: A Knight to Remember"" number=""413"" length=""308"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57396-Kings-Quest-A-Knight-to-Remember"" originalname=""King's Quest: A Knight to Remember"" ytlink=""https://www.youtube.com/watch?v=F3xHo9SXoQI"" date=""2015-08-12T16:00:00"">
      <extrap title=""The Worst Part of Each King's Quest Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14472-Worst-Puzzle-in-Each-King-s-Quest-Game"" date=""2015-08-20T20:00:00"" />
      <reviewed name=""King's Quest: A Knight to Remember"" wpname=""King's Quest (2015 video game)"" />
      <teaser>This week, Zero Punctuation reviews King's Quest.</teaser>
    </Episode>
    <Episode name=""Nom Nom Galaxy &amp; Freedom Planet"" number=""414"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57411-Nom-Nom-Galaxy-Freedom-Planet"" originalname=""Nom Nom Galaxy &amp; Freedom Planet"" ytlink=""https://www.youtube.com/watch?v=kcULtxPjD8s"" date=""2015-08-19T16:00:00"">
      <extrap title=""Upon The Mary Sue Character in Video Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14499-Mary-Sue-Characters-in-Video-Games"" date=""2015-08-25T17:00:00"" />
      <reviewed name=""Nom Nom Galaxy"" />
      <reviewed name=""Freedom Planet"" wpname=""Freedom Planet"" />
      <teaser>This week, Zero Punctuation reviews Nom Nom Galaxy and Freedom Planet.</teaser>
    </Episode>
    <Episode name=""Everybody's Gone To The Rapture"" number=""415"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57425-Everybodys-Gone-To-The-Rapture"" originalname=""Everybody's Gone To The Rapture"" ytlink=""https://www.youtube.com/watch?v=h2ptFY5w91w"" date=""2015-08-26T16:00:00"">
      <extrap title=""The Problem With the &quot;Walking Around Simulator&quot;"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14547-Yahtzee-On-Everybodys-Gone-To-The-Rapture-and-Gone-Home"" date=""2015-09-01T17:00:00"" />
      <reviewed name=""Everybody's Gone To The Rapture"" wpname=""Everybody's Gone to the Rapture"" awardname=""Fourth Blandest of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Everybody's Gone To The Rapture.</teaser>
    </Episode>
    <Episode name=""Volume"" number=""416"" length=""304"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57442-Volume-Robin-Hood"" originalname=""Volume"" ytlink=""https://www.youtube.com/watch?v=cADhLtjWWDg"" date=""2015-09-02T16:00:00"" subtitle=""Robin Hood?"">
      <reviewed name=""Volume"" wpname=""Volume (video game)"" />
      <teaser>This week, Zero Punctuation reviews Volume.</teaser>
    </Episode>
    <Episode name=""Metal Gear Solid V: The Phantom Pain"" number=""417"" length=""312"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57452-Metal-Gear-Solid-V-The-Phantom-Pain"" originalname=""Metal Gear Solid V: The Phantom Pain"" ytlink=""https://www.youtube.com/watch?v=zziU0IbEU-Q"" date=""2015-09-09T17:00:00"">
      <extrap title=""Gotta Love Metal Gear Solid"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14623-Yahtzee-Loves-Metal-Gear-Solid"" date=""2015-09-15T17:00:00"" />
      <reviewed name=""Metal Gear Solid V: The Phantom Pain"" wpname=""Metal Gear Solid V: The Phantom Pain"" />
      <teaser>This week, Zero Punctuation reviews Metal Gear Solid V: The Phantom Pain.</teaser>
    </Episode>
    <Episode name=""Mad Max"" number=""418"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57466-Mad-Max-The-Sandiest-Sand-Box"" originalname=""Mad Max"" ytlink=""https://www.youtube.com/watch?v=UwjNv-VrWDA"" date=""2015-09-16T17:00:00"" subtitle=""The Sandiest Sand Box"">
      <extrap title=""The Perfect Generic Game is Mad Max"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14673-Mad-Max-It-s-Generic-That-Was-Easy"" date=""2015-09-22T17:00:00"" />
      <reviewed name=""Mad Max"" wpname=""Mad Max (2015 video game)"" />
      <teaser>This week, Zero Punctuation reviews Mad Max.</teaser>
    </Episode>
    <Episode name=""Gears of War Ultimate Edition"" number=""419"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57480-Gears-of-War-Ultimate-Edition"" originalname=""Gears of War: Ultimate Edition"" ytlink=""https://www.youtube.com/watch?v=qppmz5JNO2Y"" date=""2015-09-23T16:00:00"">
      <reviewed name=""Gears of War: Ultimate Edition"" wpname=""Gears of War (video game)"" />
      <teaser>This week, Zero Punctuation reviews Gears of War: Ultimate Edition.</teaser>
    </Episode>
    <Episode name=""Until Dawn"" number=""420"" length=""320"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57495-Until-Dawn"" originalname=""Until Dawn"" ytlink=""https://www.youtube.com/watch?v=8n6bqAEyVLA"" date=""2015-09-30T16:30:00"">
      <extrap title=""How to Make A Slasher Video Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14745-A-Better-Horror-Game-Than-Until-Dawn"" date=""2015-10-06T17:00:00"" />
      <reviewed name=""Until Dawn"" wpname=""Until Dawn"" />
      <teaser>This week, Zero Punctuation reviews Until Dawn.</teaser>
    </Episode>
    <Episode name=""Super Mario Maker"" number=""421"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/57514-Super-Mario-Maker"" originalname=""Super Mario Maker"" ytlink=""https://www.youtube.com/watch?v=-5TjeU4xKqE"" date=""2015-10-14T16:00:00"">
      <extrap title=""The Super Mario Apocalypse Will Never Arrive"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14827-Super-Mario-Maker-Is-the-End-of-Mario"" date=""2015-10-20T17:00:00"" />
      <reviewed name=""Super Mario Maker"" wpname=""Super Mario Maker"" />
      <teaser>This week, Zero Punctuation reviews Super Mario Maker.</teaser>
    </Episode>
    <Episode name=""SOMA"" number=""422"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/93321-SOMA"" originalname=""SOMA"" ytlink=""https://www.youtube.com/watch?v=syq_WuOopUU"" date=""2015-10-21T16:00:00"">
      <extrap title=""Undertale May Be This Year's Best Written Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14860-Undertale-for-Best-Written-Game-2015"" date=""2015-10-27T17:00:00"" />
      <reviewed name=""SOMA"" wpname=""Soma (video game)"" awardname=""Fourth Best of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews SOMA.</teaser>
    </Episode>
    <Episode name=""Rock Band 4"" number=""423"" length=""307"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/106791-Rock-Band-4"" originalname=""Rock Band 4"" ytlink=""https://www.youtube.com/watch?v=54QQcnAtz78"" date=""2015-10-28T16:00:00"">
      <reviewed name=""Rock Band 4"" wpname=""Rock Band 4"" />
      <teaser>This week, Zero Punctuation reviews Rock Band 4.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed Syndicate"" number=""424"" length=""324"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/106803-Assassins-Creed-Syndicate"" originalname=""Assassin's Creed Syndicate"" ytlink=""https://www.youtube.com/watch?v=WvpAn6V0hdc"" date=""2015-11-04T16:00:00"">
      <extrap title=""Assassin's Creed is Officially Running on Fumes"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14964-When-Will-Assassins-Creed-End"" date=""2015-11-10T17:00:00"" />
      <reviewed name=""Assassin's Creed Syndicate"" wpname=""Assassin's Creed Syndicate"" awardname=""Second Blandest of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed Syndicate.</teaser>
    </Episode>
    <Episode name=""Halo 5: Guardians"" number=""425"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/106811-Halo-5-Guardians"" originalname=""Halo 5: Guardians"" ytlink=""https://www.youtube.com/watch?v=RYrFrjtGTEE"" date=""2015-11-11T16:00:00"">
      <extrap title=""AAA Games Have Stopped Innovating"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/14994-Yahtzee-Says-AAA-Games-Have-Stopped-Doing-New-Things"" date=""2015-11-17T17:00:00"" />
      <reviewed name=""Halo 5: Guardians"" wpname=""Halo 5: Guardians"" awardname=""Blandest Game of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Halo 5: Guardians.</teaser>
    </Episode>
    <Episode name=""Call of Duty: Black Ops 3"" number=""426"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/106823-Call-of-Duty-Black-Ops-3"" originalname=""Call of Duty: Black Ops 3"" ytlink=""https://www.youtube.com/watch?v=p2Z_GkGPJP0"" date=""2015-11-18T16:00:00"">
      <reviewed name=""Call of Duty: Black Ops 3"" wpname=""Call of Duty: Black Ops III"" />
      <teaser>This week, Zero Punctuation reviews Call of Duty: Black Ops 3.</teaser>
    </Episode>
    <Episode name=""Rise of the Tomb Raider"" number=""427"" length=""334"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/115301-Rise-of-the-Tomb-Raider"" originalname=""Rise of the Tomb Raider"" ytlink=""https://www.youtube.com/watch?v=Gn2eM1Gdu3g"" date=""2015-11-25T16:00:00"">
      <extrap title=""Rise of the Tomb Raider Feels Like A Second Origin Story"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15083-The-Problems-With-Rise-of-the-Tomb-Raider"" date=""2015-12-01T17:00:00"" />
      <reviewed name=""Rise of the Tomb Raider"" wpname=""Rise of the Tomb Raider"" awardname=""Third Blandest of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Rise of the Tomb Raider.</teaser>
    </Episode>
    <Episode name=""Fallout 4"" number=""428"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116433-Fallout-4"" originalname=""Fallout 4"" ytlink=""https://www.youtube.com/watch?v=I7X9S8q1FXQ"" date=""2015-12-02T16:00:00"">
      <reviewed name=""Fallout 4"" wpname=""Fallout 4"" />
      <teaser>This week, Zero Punctuation reviews Fallout 4.</teaser>
    </Episode>
    <Episode name=""Star Wars: Battlefront"" number=""429"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116485-Star-Wars-Battlefront"" originalname=""Star Wars: Battlefront"" ytlink=""https://www.youtube.com/watch?v=p7ABkNF0OO4"" date=""2015-12-09T16:00:00"">
      <extrap title=""Battlefront is Barely Multiplayer At All"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15151-Why-Battlefront-is-Barely-Multiplayer-At-All"" date=""2015-12-15T17:00:00"" />
      <reviewed name=""Star Wars: Battlefront"" wpname=""Star Wars Battlefront (2015 video game)"" awardname=""Fifth Worst of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, Zero Punctuation reviews Star Wars: Battlefront.</teaser>
    </Episode>
    <Episode name=""Just Cause 3"" number=""430"" length=""343"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116524-Just-Cause-3"" originalname=""Just Cause 3"" ytlink=""https://www.youtube.com/watch?v=4hTMZ3G8Hsk"" date=""2015-12-16T16:00:00"">
      <extrap title=""Why Is Every AAA Game Hero Suddenly Your Dad?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15173-AAA-Video-Game-Dadbods"" date=""2015-12-22T17:00:00"" />
      <reviewed name=""Just Cause 3"" wpname=""Just Cause 3"" />
      <teaser>This week, Zero Punctuation reviews Just Cause 3.</teaser>
    </Episode>
    <Episode name=""Fatal Frame: Maiden of Black Water"" number=""431"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116555-Fatal-Frame-Maiden-of-Black-Water"" originalname=""Fatal Frame: Maiden of Black Water"" ytlink=""https://www.youtube.com/watch?v=EAzpn8vsc9k"" date=""2015-12-23T16:00:00"">
      <reviewed name=""Fatal Frame: Maiden of Black Water"" wpname=""Fatal Frame: Maiden of Black Water"" />
      <teaser>This week, Zero Punctuation reviews Fatal Frame: Maiden of Black Water.</teaser>
    </Episode>
    <Episode name=""Top 5 Games of 2015"" number=""432"" length=""462"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116617-Top-5-Games-of-2015"" originalname=""Top 5 Games of 2015"" ytlink=""https://www.youtube.com/watch?v=sCFGU79rX34"" date=""2016-01-06T16:00:00"">
      <extrap title=""Get Out of Your Comfort Zone for 2016"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15250-Top-Fives-and-Getting-Out-of-Your-Star-Wars-Comfort-Zone"" date=""2016-01-12T17:00:00"" />
      <reviewed name=""Undertale"" wpname=""Undertale"" awardname=""Best game of 2015"" awardepisode=""Top 5 Games of 2015"" />
      <teaser>This week, the annual Top 5 lists.</teaser>
    </Episode>
    <Episode name=""Devil's Third"" number=""433"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116642-Devils-Third"" originalname=""Devil's Third"" ytlink=""https://www.youtube.com/watch?v=3zoThqFpVuQ"" date=""2016-01-13T16:00:00"">
      <reviewed name=""Devil's Third"" wpname=""Devil's Third"" awardname=""5th Shitest of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Devil's Third.</teaser>
    </Episode>
    <Episode name=""Mario &amp; Luigi: Paper Jam"" number=""434"" length=""338"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116678-Mario-Luigi-Paper-Jam"" originalname=""Mario &amp; Luigi: Paper Jam"" ytlink=""https://www.youtube.com/watch?v=afVDujZ3iXk"" date=""2016-01-20T16:00:00"">
      <reviewed name=""Mario &amp; Luigi: Paper Jam"" wpname=""Mario &amp; Luigi: Paper Jam"" />
      <teaser>This week, Zero Punctuation reviews Mario &amp; Luigi: Paper Jam.</teaser>
    </Episode>
    <Episode name=""Assassin's Creed Chronicles"" number=""435"" length=""344"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116722-Assassins-Creed-Chronicles"" originalname=""Assassin's Creed: Chronicles"" ytlink=""https://www.youtube.com/watch?v=fGs-4BpWoW8"" date=""2016-01-27T16:00:00"">
      <extrap title=""Assassin's Creed Needs to be Interesting, not Trendy"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15360-Assassin-s-Creed-s-Problems-Need-More-Than-Some-Time-Off"" date=""2016-02-02T17:00:00"" />
      <reviewed name=""Assassin's Creed Chronicles: China"" wpname=""Assassin's Creed Chronicles"" />
      <reviewed name=""Assassin's Creed Chronicles: India"" wpname=""Assassin's Creed Chronicles"" />
      <teaser>This week, Zero Punctuation reviews Assassin's Creed: Chronicles.</teaser>
    </Episode>
    <Episode name=""Xenoblade Chronicles X"" number=""436"" length=""350"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116751-Xenoblade-Chronicles-X"" originalname=""Xenoblade Chronicles X"" ytlink=""https://www.youtube.com/watch?v=w-2hxgeMJrk"" date=""2016-02-03T16:00:00"">
      <extrap title=""Xenoblade Chronicles X Actually Uses the Wii U Gamepad Well"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15406-Xenoblade-Chronicles-X-Makes-the-Wii-U-Gamepad-Useful"" date=""2016-02-09T17:00:00"" />
      <reviewed name=""Xenoblade Chronicles X"" wpname=""Xenoblade Chronicles X"" />
      <teaser>This week, Zero Punctuation reviews Xenoblade Chronicles X.</teaser>
    </Episode>
    <Episode name=""The Witness &amp; Bombshell"" number=""437"" length=""360"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116783-The-Witness-Bombshell"" originalname=""The Witness &amp; Bombshell"" ytlink=""https://www.youtube.com/watch?v=F11UGNm6qfc"" date=""2016-02-10T16:00:00"">
      <reviewed name=""The Witness"" wpname=""The Witness (2016 video game)"" />
      <reviewed name=""Bombshell"" wpname=""Bombshell (video game)"" />
      <teaser>This week, Zero Punctuation reviews The Witness &amp; Bombshell.</teaser>
    </Episode>
    <Episode name=""Gravity Rush"" number=""438"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116793-Gravity-Rush"" originalname=""Gravity Rush"" ytlink=""https://www.youtube.com/watch?v=DSwAhRZV4XY"" date=""2016-02-17T16:00:00"">
      <extrap title=""Gravity Rush Indulges the Need to Fail at Flying Around"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/15612-Gravity-Rush-s-Flying-Physics-Let-You-Fail-in-Style"" date=""2016-02-23T22:00:00"" />
      <reviewed name=""Gravity Rush"" wpname=""Gravity Rush"" />
      <teaser>This week, Zero Punctuation reviews Gravity Rush.</teaser>
    </Episode>
    <Episode name=""XCOM 2"" number=""439"" length=""339"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116803-XCOM-2"" originalname=""XCOM 2"" ytlink=""https://www.youtube.com/watch?v=RFDLjmvNNnU"" date=""2016-02-24T16:00:00"">
      <reviewed name=""XCOM 2"" wpname=""XCOM 2"" />
      <teaser>This week, Zero Punctuation reviews XCOM 2.</teaser>
    </Episode>
    <Episode name=""Firewatch &amp; Layers of Fear"" number=""440"" length=""344"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116814-Firewatch-Layers-of-Fear"" originalname=""Firewatch &amp; Layers of Fear"" ytlink=""https://www.youtube.com/watch?v=ES-r5Pl7LSg"" date=""2016-03-02T17:00:00"">
      <extrap title=""Early Access Isn't Right for Every Game"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/16846-When-is-Early-Access-Appropriate-for-a-Game"" date=""2016-03-09T15:00:00"" />
      <reviewed name=""Firewatch"" wpname=""Firewatch"" />
      <reviewed name=""Layers of Fear"" wpname=""Layers of Fear"" />
      <teaser>This week, Zero Punctuation reviews Firewatch &amp; Layers of Fear.</teaser>
    </Episode>
    <Episode name=""Far Cry Primal"" number=""441"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116820-Far-Cry-Primal"" originalname=""Far Cry Primal"" ytlink=""https://www.youtube.com/watch?v=mfLPlqBmwMU"" date=""2016-03-09T16:00:00"">
      <reviewed name=""Far Cry Primal"" wpname=""Far Cry Primal"" awardname=""2nd Blandest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Far Cry Primal.</teaser>
    </Episode>
    <Episode name=""Stardew Valley &amp; SUPERHOT"" number=""442"" length=""345"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116829-Stardew-Valley-Superhot"" originalname=""Stardew Valley &amp; Superhot"" ytlink=""https://www.youtube.com/watch?v=V9WkvBmieGE"" date=""2016-03-16T16:00:00"">
      <extrap title=""Stardew Valley's Relationships are Really Rather Off-Putting"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/16917-Stardew-Valley-s-Relationships-are-Rather-Off-Putting"" date=""2016-03-22T17:00:00"" />
      <reviewed name=""Stardew Valley"" wpname=""Stardew Valley"" awardname=""3rd Goodest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <reviewed name=""Superhot"" wpname=""Superhot"" />
      <teaser>This week, Zero Punctuation reviews Stardew Valley &amp; Superhot.</teaser>
    </Episode>
    <Episode name=""The Division"" number=""443"" length=""325"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116838-The-Division"" originalname=""The Division"" ytlink=""https://www.youtube.com/watch?v=EpKKOzppQeE"" date=""2016-03-23T16:00:00"">
      <reviewed name=""Tom Clancy's The Division"" wpname=""Tom Clancy's The Division"" awardname=""3rd Shitest of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews The Division.</teaser>
    </Episode>
    <Episode name=""Salt and Sanctuary"" number=""444"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116847-Salt-and-Sanctuary"" originalname=""Salt and Sanctuary"" ytlink=""https://www.youtube.com/watch?v=g-7im-3h91c"" date=""2016-03-30T16:00:00"">
      <extrap title=""Are Games Losing My Interest, or Is it Just Me?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/16979-Are-Games-Losing-My-Interest-or-Is-it-Just-Me"" date=""2016-04-05T17:15:00"" />
      <reviewed name=""Salt and Sanctuary"" wpname=""Salt and Sanctuary"" awardname=""5th Goodest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Salt and Sanctuary.</teaser>
    </Episode>
    <Episode name=""Republique"" number=""445"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116852-Republique"" originalname=""Republique"" ytlink=""https://www.youtube.com/watch?v=B4q6nJrBPBY"" date=""2016-04-06T16:00:00"">
      <reviewed name=""Republique"" />
      <teaser>This week, Zero Punctuation reviews Republique.</teaser>
    </Episode>
    <Episode name=""Shadow Warrior"" number=""446"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116855-Shadow-Warrior"" originalname=""Shadow Warrior"" ytlink=""https://www.youtube.com/watch?v=gvffwBDN30I"" date=""2016-04-13T16:00:00"">
      <reviewed name=""Shadow Warrior"" wpname=""Shadow Warrior"" />
      <teaser>This week, Zero Punctuation reviews Shadow Warrior.</teaser>
    </Episode>
    <Episode name=""Quantum Break"" number=""447"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116859-Quantum-Break"" originalname=""Quantum Break"" ytlink=""https://www.youtube.com/watch?v=-8ZKvCWlQUY"" date=""2016-04-20T16:00:00"">
      <extrap title=""Why Do Branching Storylines Never Deliver on Their Promises?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17011-Branching-Storylines-Never-Deliver-on-Their-Promises"" date=""2016-04-26T17:00:00"" />
      <reviewed name=""Quantum Break"" wpname=""Quantum Break"" awardname=""4th Blandest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Quantum Break.</teaser>
    </Episode>
    <Episode name=""Dark Souls III"" number=""448"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116862-Dark-Souls-III"" originalname=""Dark Souls III"" ytlink=""https://www.youtube.com/watch?v=RQ78aBeURvs"" date=""2016-04-27T16:00:00"">
      <reviewed name=""Dark Souls III"" wpname=""Dark Souls III"" />
      <teaser>This week, Zero Punctuation reviews Dark Souls III.</teaser>
    </Episode>
    <Episode name=""Ratchet &amp; Clank"" number=""449"" length=""326"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116866-Ratchet-Clank"" originalname=""Ratchet &amp; Clank"" ytlink=""https://www.youtube.com/watch?v=QpwjHoYJ7NA"" date=""2016-05-04T16:00:00"">
      <extrap title=""Remaking Old Games is a Fool's Errand"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17038-Rebooting-Old-Games-is-a-Fool-s-Errand"" date=""2016-05-10T17:00:00"" />
      <reviewed name=""Ratchet &amp; Clank"" wpname=""Ratchet &amp; Clank (2016 video game)"" />
      <teaser>This week, Zero Punctuation reviews Ratchet &amp; Clank.</teaser>
    </Episode>
    <Episode name=""Star Fox Zero"" number=""450"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116870-Star-Fox-Zero"" originalname=""Star Fox Zero"" ytlink=""https://www.youtube.com/watch?v=JSVbhZY40BA"" date=""2016-05-11T16:00:00"">
      <reviewed name=""Star Fox Zero"" wpname=""Star Fox Zero"" />
      <teaser>This week, Zero Punctuation reviews Star Fox Zero.</teaser>
    </Episode>
    <Episode name=""Paper Mario: The Thousand-Year Door"" number=""451"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116874-Paper-Mario-The-Thousand-Year-Door"" originalname=""Paper Mario: The Thousand-Year Door"" ytlink=""https://www.youtube.com/watch?v=ztky50T3W2E"" date=""2016-05-18T16:00:00"">
      <extrap title=""Enough of Making Video Games into Movies Already"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17070-Let-s-Stop-Making-Video-Games-into-Movies"" date=""2016-05-24T17:00:00"" />
      <reviewed name=""Paper Mario: The Thousand-Year Door"" wpname=""Paper Mario: The Thousand-Year Door"" />
      <teaser>This week, Zero Punctuation reviews Paper Mario: The Thousand-Year Door.</teaser>
    </Episode>
    <Episode name=""Uncharted 4: A Thief's End"" number=""452"" length=""322"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116877-Uncharted-4-A-Thiefs-End"" originalname=""Uncharted 4: A Thief's End"" ytlink=""https://www.youtube.com/watch?v=qGRglaMRU0Y"" date=""2016-05-25T16:00:00"">
      <reviewed name=""Uncharted 4: A Thief's End"" wpname=""Uncharted 4: A Thief's End"" />
      <teaser>This week, Zero Punctuation reviews Uncharted 4: A Thief's End.</teaser>
    </Episode>
    <Episode name=""Doom"" number=""453"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116880-Doom"" originalname=""Doom"" ytlink=""https://www.youtube.com/watch?v=HQGxC8HKCD4"" date=""2016-06-01T16:00:00"">
      <extrap title=""Interactive Narrative Means Choosing How Invested You Really Want to Be"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17090-Interactive-Narrative-Means-Choosing-How-Invested-You-Want-to-Be"" date=""2016-06-07T17:00:00"" />
      <reviewed name=""Doom"" wpname=""Doom (2016 video game)"" awardname=""1st Goodest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Doom.</teaser>
    </Episode>
    <Episode name=""Homefront: The Revolution"" number=""454"" length=""342"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116884-Homefront-The-Revolution"" originalname=""Homefront The Revolution"" ytlink=""https://www.youtube.com/watch?v=gQHLN8mjrp0"" date=""2016-06-08T16:00:00"">
      <reviewed name=""Homefront: The Revolution"" wpname=""Homefront: The Revolution"" awardname=""1st Shitest of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Homefront The Revolution.</teaser>
    </Episode>
    <Episode name=""Overwatch &amp; Battleborn"" number=""455"" length=""349"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116888-Overwatch-vs-Battleborn"" originalname=""Overwatch vs Battleborn"" ytlink=""https://www.youtube.com/watch?v=fc0u1-Liamk"" date=""2016-06-15T16:00:00"">
      <extrap title=""Investigating Overwatch's Stingy Loot System"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17117-Investigating-the-Stingy-Overwatch-s-Loot-System"" date=""2016-06-21T17:00:00"" />
      <reviewed name=""Overwatch"" wpname=""Overwatch (video game)"" />
      <reviewed name=""Battleborn"" wpname=""Battleborn (video game)"" />
      <teaser>This week, Zero Punctuation pits Overwatch vs Battleborn.</teaser>
    </Episode>
    <Episode name=""Mirror's Edge: Catalyst"" number=""456"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116892-Mirrors-Edge-Catalyst"" originalname=""Mirror's Edge Catalyst"" ytlink=""https://www.youtube.com/watch?v=NPpA7FsvWNM"" date=""2016-06-22T16:00:00"">
      <reviewed name=""Mirror's Edge Catalyst"" wpname=""Mirror's Edge Catalyst"" />
      <teaser>This week, Zero Punctuation reviews Mirror's Edge Catalyst.</teaser>
    </Episode>
    <Episode name=""E3 2016"" number=""457"" length=""352"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116896-E3-2016"" originalname=""E3 2016"" ytlink=""https://www.youtube.com/watch?v=dOVWDXQcu0w"" date=""2016-06-29T16:00:00"">
      <extrap title=""Why Do We Keep E3 Around, Anyway?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17133-Why-Do-We-Keep-E3-Around-Anyway"" date=""2016-07-05T17:00:00"" />
      <teaser>This week, Zero Punctuation reviews E3 2016.</teaser>
    </Episode>
    <Episode name=""Mighty No. 9"" number=""458"" length=""343"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116901-Mighty-No-9"" originalname=""Mighty No. 9"" ytlink=""https://www.youtube.com/watch?v=8mv5NC0HvJ8"" date=""2016-07-06T16:00:00"">
      <reviewed name=""Mighty No. 9"" wpname=""Mighty No. 9"" />
      <teaser>This week, Zero Punctuation reviews Mighty No. 9.</teaser>
    </Episode>
    <Episode name=""Inside &amp; Shadow of the Beast"" number=""459"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116903-Inside-Shadow-of-the-Beast"" originalname=""Inside &amp; Shadow of the Beast"" ytlink=""https://www.youtube.com/watch?v=X164Uy9K-yA"" date=""2016-07-13T16:00:00"">
      <extrap title=""It's Hard to Get Nostalgic About Games You Didn't Grow Up On"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17153-It-is-Hard-to-Get-Nostalgic-About-Games-You-Didn-t-Grow-Up-On"" date=""2016-07-19T17:00:00"" />
      <reviewed name=""Inside"" wpname=""Inside (video game)"" />
      <reviewed name=""Shadow of the Beast"" wpname=""Shadow of the Beast (2016 video game)"" />
      <teaser>This week, Zero Punctuation reviews Inside and Shadow of the Beast.</teaser>
    </Episode>
    <Episode name=""The Technomancer"" number=""460"" length=""340"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116908-The-Technomancer"" originalname=""The Technomancer"" ytlink=""https://www.youtube.com/watch?v=MAULDLsZxnw"" date=""2016-07-20T16:00:00"">
      <reviewed name=""The Technomancer"" wpname=""The Technomancer"" />
      <teaser>This week, Zero Punctuation reviews The Technomancer.</teaser>
    </Episode>
    <Episode name=""Furi &amp; Song of the Deep"" number=""461"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116910-Furi-Song-of-the-Deep"" originalname=""Furi &amp; Song of the Deep"" ytlink=""https://www.youtube.com/watch?v=6aAbgtBzDiw"" date=""2016-07-27T16:00:00"">
      <extrap title=""Let's Get Indie Games Away From the Idea of a Small Child in a Scary World"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17169-Get-Indie-Games-Away-From-the-Idea-of-a-Small-Child-in-a-Scary-W"" date=""2016-08-02T17:00:00"" />
      <reviewed name=""Furi"" wpname=""Furi"" awardname=""2nd Goodest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <reviewed name=""Song of the Deep"" wpname=""Song of the Deep"" />
      <teaser>This week, Zero Punctuation reviews Furi and Song of the Deep.</teaser>
    </Episode>
    <Episode name=""I Am Setsuna"" number=""462"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116914-I-Am-Setsuna"" originalname=""I Am Setsuna"" ytlink=""https://www.youtube.com/watch?v=HurBxdGTIk8"" date=""2016-08-03T18:00:00"">
      <reviewed name=""I Am Setsuna"" wpname=""I Am Setsuna"" />
      <teaser>This week, Zero Punctuation reviews I Am Setsuna.</teaser>
    </Episode>
    <Episode name=""Headlander &amp; Quadrilateral Cowboy"" number=""463"" length=""318"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116915-Headlander-Quadrilateral-Cowboy-Review"" originalname=""Headlander &amp; Quadrilateral Cowboy"" ytlink=""https://www.youtube.com/watch?v=4yjhQJ4zQvE"" date=""2016-08-10T16:00:00"">
      <extrap title=""There's More to Comedy Games than Just Comic Relief Characters"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17184-There-is-More-to-Comedy-Games-than-Just-Comic-Relief-Characters"" date=""2016-08-16T17:00:00"" />
      <reviewed name=""Headlander"" wpname=""Headlander"" />
      <reviewed name=""Quadrilateral Cowboy"" wpname=""Quadrilateral Cowboy"" />
      <teaser>This week, Zero Punctuation reviews Headlander &amp; Quadrilateral Cowboy.</teaser>
    </Episode>
    <Episode name=""Quake"" number=""464"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116919-Quake-Retro-Review"" originalname=""Quake"" ytlink=""https://www.youtube.com/watch?v=0g9SazeaeK0"" date=""2016-08-17T16:00:00"">
      <extrap title=""id Software's History Parallels the Seven Ages of Man and the History of PC Gaming"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17192-id-Software-History-Parallels-the-Seven-Ages-of-Man-and-the-Hist"" date=""2016-08-23T17:00:00"" />
      <reviewed name=""Quake"" wpname=""Quake (video game)"" />
      <teaser>This week, Zero Punctuation reviews Quake.</teaser>
    </Episode>
    <Episode name=""No Man's Sky"" number=""465"" length=""349"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116922-No-Mans-Sky-Review"" originalname=""No Man's Sky"" ytlink=""https://www.youtube.com/watch?v=Lf9egxQsZyY"" date=""2016-08-24T16:00:00"">
      <reviewed name=""No Man's Sky"" wpname=""No Man's Sky"" awardname=""1st Blandest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews No Man's Sky.</teaser>
    </Episode>
    <Episode name=""Grow Up"" number=""466"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116926-Grow-Up-Review"" ytlink=""https://www.youtube.com/watch?v=R5D8SRjgMe8"" date=""2016-08-31T17:00:00"">
      <reviewed name=""Grow Home"" wpname=""Grow Home"" />
      <reviewed name=""Grow Up"" wpname=""Grow Up (video game)"" />
      <teaser>This week, Zero Punctuation reviews Grow Up.</teaser>
    </Episode>
    <Episode name=""Deus Ex: Mankind Divided"" number=""467"" length=""336"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116928-Deus-Ex-Mankind-Divided-Review"" ytlink=""https://www.youtube.com/watch?v=R3RoATfsOYc"" date=""2016-09-07T17:00:00"">
      <reviewed name=""Deus Ex: Mankind Divided"" wpname=""Deus Ex: Mankind Divided"" awardname=""5th Blandest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Deus Ex Mankind Divided.</teaser>
    </Episode>
    <Episode name=""Metroid Prime: Federation Force"" number=""468"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116931-Metroid-Prime-Federation-Force-Review"" ytlink=""https://www.youtube.com/watch?v=-VJ2aK7VYDk"" date=""2016-09-14T17:00:00"">
      <extrap title=""Predicting What's New on the Nostalgia Horizon - The PS1 Era"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17238-Predicting-What-s-New-on-the-Nostalgia-Horizon-The-PS1-Era"" date=""2016-09-20T17:00:00"" />
      <reviewed name=""Metroid Prime: Federation Force"" wpname=""Metroid Prime: Federation Force"" awardname=""4th Shitest of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Metroid Prime Federation Force.</teaser>
    </Episode>
    <Episode name=""The Curious Expedition &amp; Mother Russia Bleeds"" number=""469"" length=""335"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116934-The-Curious-Expedition-and-Mother-Russia-Bleeds-review"" ytlink=""https://www.youtube.com/watch?v=dfQNRvOKQSQ"" date=""2016-09-21T17:00:00"">
      <reviewed name=""The Curious Expedition"" wpname=""The Curious Expedition"" />
      <reviewed name=""Mother Russia Bleeds"" wpname=""Mother Russia Bleeds"" />
      <teaser>This week, Zero Punctuation reviews The Curious Expedition &amp; Mother Russia Bleeds.</teaser>
    </Episode>
    <Episode name=""ReCore"" number=""470"" length=""330"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116937-ReCore-Review"" ytlink=""https://www.youtube.com/watch?v=BWW4kX97wTo"" date=""2016-09-28T17:00:00"">
      <reviewed name=""ReCore"" wpname=""ReCore"" />
      <teaser>This week, Zero Punctuation reviews ReCore.</teaser>
    </Episode>
    <Episode name=""Capcom Five"" number=""471"" length=""343"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116940-Capcom-Five-Review"" ytlink=""https://www.youtube.com/watch?v=HbORw5eXsiM"" date=""2016-10-05T17:00:00"">
      <reviewed name=""Capcom Five"" wpname=""Capcom Five"" />
      <teaser>This week, Zero Punctuation reviews Capcom Five.</teaser>
    </Episode>
    <Episode name=""Clustertruck &amp; Lichtspeer"" number=""472"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116943-Clustertruck-and-Lichtspeer-Review"" ytlink=""https://www.youtube.com/watch?v=UDwjpr7lYK0"" date=""2016-10-12T17:00:00"">
      <extrap title=""This is How You Fix RPG Sidequests"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17273-How-You-Fix-RPG-Sidequests"" date=""2016-10-18T18:00:00"" />
      <reviewed name=""Clustertruck"" wpname=""Clustertruck"" />
      <reviewed name=""Lichtspeer"" wpname=""Lichtspeer"" />
      <teaser>This week, Zero Punctuation reviews Clustertruck &amp; Lichtspeer.</teaser>
    </Episode>
    <Episode name=""Paper Mario: Color Splash"" number=""473"" length=""327"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116946-Paper-Mario-Color-Splash-Review"" ytlink=""https://www.youtube.com/watch?v=p0N5ooeuNEg"" date=""2016-10-19T17:00:00"">
      <reviewed name=""Paper Mario: Color Splash"" wpname=""Paper Mario: Color Splash"" awardname=""3rd Blandest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <teaser>This week, Zero Punctuation reviews Paper Mario Color Splash.</teaser>
    </Episode>
    <Episode name=""Mafia 3"" number=""474"" length=""341"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116949-Mafia-3-Review"" ytlink=""https://www.youtube.com/watch?v=AxxjH4aKbJo"" date=""2016-10-26T17:00:00"">
      <reviewed name=""Mafia 3"" wpname=""Mafia III"" />
      <teaser>This week, Zero Punctuation reviews Mafia 3.</teaser>
    </Episode>
    <Episode name=""Gears of War 4"" number=""475"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116952-Gears-of-War-4-Review"" ytlink=""https://www.youtube.com/watch?v=LCCB0eYNbWI"" date=""2016-11-02T17:00:00"">
      <extrap title=""Suggesting Some Fixed Dialogue for Gears of War 4"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17292-Suggesting-Fixed-Dialogue-for-Gears-of-War-4"" date=""2016-11-08T17:00:00"" />
      <reviewed name=""Gears of War 4"" wpname=""Gears of War 4"" />
      <teaser>This week, Zero Punctuation reviews Gears of War 4.</teaser>
    </Episode>
    <Episode name=""PlayStation VR"" number=""476"" length=""338"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116955-Sony-Playstation-VR-Review"" ytlink=""https://www.youtube.com/watch?v=v8BpSSsMH34"" date=""2016-11-09T17:00:00"">
      <reviewed name=""PlayStation VR"" wpname=""PlayStation VR"" />
      <reviewed name=""Batman Arkham VR"" wpname=""Batman Arkham VR"" awardname=""2nd Shitest of 2016"" awardepisode=""Top 5 of 2016"" />
      <reviewed name=""Here They Lie"" wpname=""Here They Lie"" />
      <reviewed name=""Windlands"" wpname=""Windlands"" />
      <reviewed name=""Eve: Valkyrie"" wpname=""Eve: Valkyrie"" />
      <teaser>This week, Zero Punctuation reviews PlayStation VR.</teaser>
    </Episode>
    <Episode name=""Battlefield 1"" number=""477"" length=""331"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116958-Battlefield-1-Review"" ytlink=""https://www.youtube.com/watch?v=I0HNLkpQbZQ"" date=""2016-11-16T17:00:00"">
      <reviewed name=""Battlefield 1"" wpname=""Battlefield 1"" />
      <teaser>This week, Zero Punctuation reviews Battlefield 1.</teaser>
    </Episode>
    <Episode name=""Titanfall 2 vs Call of Duty Infinite Warfare"" number=""478"" length=""337"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116963-Titanfall-2-and-Call-of-Duty-Infinite-Warfare-Reviews"" ytlink=""https://www.youtube.com/watch?v=F0RSwdinkAI"" date=""2016-11-23T17:00:00"">
      <reviewed name=""Titanfall 2"" wpname=""Titanfall 2"" awardname=""4th Goodest game of 2016"" awardepisode=""Top 5 of 2016"" />
      <reviewed name=""Call of Duty: Infinite Warfare"" wpname=""Call of Duty: Infinite Warfare"" />
      <teaser>This week, Zero Punctuation reviews Titanfall 2 and Call of Duty Infinite Warfare.</teaser>
    </Episode>
    <Episode name=""Dishonored 2"" number=""479"" length=""319"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116966-Dishonored-2-Review"" ytlink=""https://www.youtube.com/watch?v=fn9-Oee6-m4"" date=""2016-11-30T17:00:00"">
      <extrap title=""Dishonored 2 Shouldn't Be Encouraging Comparisons to Thief"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17325-Dishonored-2-Shouldn-t-Encourage-the-Comparisons-to-Thief"" date=""2016-12-06T17:00:00"" />
      <reviewed name=""Dishonored 2"" wpname=""Dishonored 2"" />
      <teaser>This week, Zero Punctuation reviews Dishonored 2.</teaser>
    </Episode>
    <Episode name=""Watch_Dogs 2"" number=""480"" length=""328"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116968-Watch-Dogs-2-Review"" ytlink=""https://www.youtube.com/watch?v=6RoY6NYhQ-c"" date=""2016-12-07T17:00:00"">
      <reviewed name=""Watch_Dogs 2"" wpname=""Watch Dogs 2"" />
      <teaser>This week, Zero Punctuation reviews Watch_Dogs 2.</teaser>
    </Episode>
    <Episode name=""Final Fantasy XV"" number=""481"" length=""329"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116971-Final-Fantasy-XV-Review"" ytlink=""https://www.youtube.com/watch?v=KnQaS-uLfWY"" date=""2016-12-14T17:00:00"">
      <reviewed name=""Final Fantasy XV"" wpname=""Final Fantasy XV"" />
      <teaser>This week, Zero Punctuation reviews Final Fantasy XV.</teaser>
    </Episode>
    <Episode name=""The Last Guardian"" number=""482"" length=""312"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116975-The-Last-Guardian-Review"" ytlink=""https://www.youtube.com/watch?v=-8zFyzmSib0"" date=""2016-12-21T17:00:00"">
      <reviewed name=""The Last Guardian"" wpname=""The Last Guardian"" />
      <teaser>This week, Zero Punctuation reviews The Last Guardian.</teaser>
    </Episode>
    <Episode name=""Top Five Games of 2016"" number=""483"" length=""389"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116977-Best-and-Worst-Games-of-2016"" ytlink=""https://www.youtube.com/watch?v=mhTCqu7e74M"" date=""2017-01-04T17:00:00"">
      <teaser>This week, the annual Top 5 lists.</teaser>
    </Episode>
    <Episode name=""Let It Die"" number=""484"" length=""311"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116981-Let-It-Die-Review"" ytlink=""https://www.youtube.com/watch?v=pGQuHuM3h-0"" date=""2017-01-11T17:00:00"">
      <extrap title=""The Problem with Freemium Games"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17384-What-s-Wrong-with-Freemium-Games"" date=""2017-01-17T17:00:00"" />
      <reviewed name=""Let It Die"" wpname=""Let It Die"" />
      <teaser>This week, Zero Punctuation reviews Let It Die.</teaser>
    </Episode>
    <Episode name=""Dead Rising 4"" number=""485"" length=""310"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116986-Dead-Rising-4-Review"" ytlink=""https://www.youtube.com/watch?v=LrBDgOPCvIk"" date=""2017-01-18T17:00:00"">
      <reviewed name=""Dead Rising 4"" wpname=""Dead Rising 4"" />
      <teaser>This week, Zero Punctuation reviews Dead Rising 4.</teaser>
    </Episode>
    <Episode name=""Hitman"" number=""486"" length=""316"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116989-Hitman-Review"" ytlink=""https://www.youtube.com/watch?v=CoqELw9NXCs"" date=""2017-01-25T17:00:00"">
      <reviewed name=""Hitman"" wpname=""Hitman (2016 video game)"" />
      <teaser>This week, Zero Punctuation reviews Hitman.</teaser>
    </Episode>
    <Episode name=""Gravity Rush 2"" number=""487"" length=""309"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116991-Gravity-Rush-2-Review"" ytlink=""https://www.youtube.com/watch?v=QpgOW0VJMYA"" date=""2017-02-01T17:00:00"">
      <reviewed name=""Gravity Rush 2"" wpname=""Gravity Rush 2"" />
      <teaser>This week, Zero Punctuation reviews Gravity Rush 2.</teaser>
    </Episode>
    <Episode name=""Resident Evil 7"" number=""488"" length=""323"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116995-Resident-Evil-7-Review"" ytlink=""https://www.youtube.com/watch?v=d18tyKjFIbM"" date=""2017-02-08T17:00:00"">
      <extrap title=""Will Resident Evil 7's DLC Manage to Mess Up What the Game Fixed?"" link=""http://www.escapistmagazine.com/articles/view/video-games/columns/extra-punctuation/17439-Will-Resident-Evil-7-DLC-Manage-to-Mess-Up-What-the-Game-Fixed"" date=""2017-02-14T17:00:00"" />
      <reviewed name=""Resident Evil 7"" wpname=""Resident Evil 7: Biohazard"" />
      <teaser>This week, Zero Punctuation reviews Resident Evil 7.</teaser>
    </Episode>
    <Episode name=""Yakuza 0"" number=""489"" length=""321"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/116997-Yakuza-0-Review"" ytlink=""https://www.youtube.com/watch?v=tK5iAzRWR_k"" date=""2017-02-15T17:00:00"">
      <reviewed name=""Yakuza 0"" wpname=""Yakuza 0"" />
      <teaser>This week, Zero Punctuation reviews Yakuza 0.</teaser>
    </Episode>
    <Episode name=""Nioh"" number=""490"" length=""346"" esclink=""http://www.escapistmagazine.com/videos/view/zero-punctuation/117001-Nioh-Review"" originalname=""Nioh"" date=""2017-02-22T17:00:00"">
      <reviewed name=""Nioh"" wpname=""Nioh"" />
      <teaser>This week, Zero Punctuation reviews Nioh.</teaser>
    </Episode>
  </episodes>
</EpisodeList>
";
    }
}
