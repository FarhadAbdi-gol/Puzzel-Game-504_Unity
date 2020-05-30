// Puzzle_Game_504:
// Game design and programming by Farhad_Abdi_gol
// Email: farhadabdi687@gmail.com 
// Please help me to optimize and upgrade this game.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Storage;

public class JorchinControlerHigh : MonoBehaviour
{
    #region public Variables

    public Text TextVocab;
    public InputField TextWord;
    public Text Text_Timer;

    public AudioClip StartSet;
    public AudioClip TimeOut;
    public AudioSource audioSource;

    public GameObject SetTextButton;
    public GameObject StartGameButton;
    public GameObject WordJorchin;
    public GameObject VocabJorchin;
    public GameObject GamePlay;
    public GameObject Table;
    public GameObject ResultPanel;
    public GameObject RepeatPanel;
    public GameObject[] PanelOpenLevel;
    public GameObject[] PanelLock;

    public Button BackButton;
    public Button[] ButtonsLevels;
    public GameObject ButtonNextLevel;
    public Text Text_Levels1;
    public Text Text_Levels2;

    public Text[] TextMassageTrueH = new Text[21];
    public Text[] TextMassageFalseH = new Text[21];
    public Text[] Text_ScoresH = new Text[21];
    public Text[] Text_DictTrueH = new Text[21];
    public Text[] Text_DictFalseH = new Text[21];
    public Text[] Text_ScoreH = new Text[21];
    public Text[] Text_DictRandomCountH = new Text[21];

    public Dictionary<int, string>[] DictRandomH = new Dictionary<int, string>[21];
    public Dictionary<int, string>[] DictTrueH = new Dictionary<int, string>[21];
    public Dictionary<int, string>[] DictFalseH = new Dictionary<int, string>[21];

    public Dictionary<int, string> WordDicH = new Dictionary<int, string>()
         {
        {0, "abandon" },
        {1, "keen" },
        {2, "jealous" },
        {3, "tact" },
        {4, "oath" },
        {5, "vacant" },
        {6, "hardship" },
        {7, "gallant" },
        {8, "data" },
        {9, "unaccustomed" },
        {10, "bachelor" },
        {11, "qualify" },
        {12 , "corpse" },
        {13 , "conceal" },
        {14 , "dismal" },
        {15 , "frigid" },
        {16 , "inhabit" },
        {17 , "numb" },
        {18 , "peril" },
        {19 , "recline" },
        {20 , "shriek" },
        {21 , "sinister" },
        {22 , "tempt" },
        {23 , "wager" },
          {24 , "typical" },
        {25 , "minimum" },
        {26 , "scarce" },
        {27 , "annual" },
        {28 , "persuade" },
        {29 , "essential" },
        {30 , "blend" },
        {31 , "visible" },
        {32 , "expensive" },
        {33 , "talent" },
        {34 , "devise" },
        {35 , "wholesale" },
          {36 , "vapor" },
        {37 , "eliminate" },
        {38 , "villain" },
        {39 , "dense" },
        {40 , "utilize" },
        {41 , "humid" },
        {42 , "theory" },
        {43 , "descend" },
        {44 , "circulate" },
        {45 , "enormous" },
        {46 , "predict" },
        {47 , "vanish" },
          {48 , "tradition" },
        {49 , "Rural" },
        {50 , "burden" },
        {51 , "campus" },
        {52 , "majority" },
        {53 , "assemble" },
        {54 , "explore" },
        {55 , "topic" },
        {56 , "debate" },
        {57 , "evade" },
        {58 , "probe" },
        {59 , "reform" },
          {60 , "approach" },
        {61 , "detect" },
        {62 , "defect" },
        {63 , "employee" },
        {64 , "neglect" },
        {65 , "deceive" },
        {66 , "undoubtedly" },
        {67 , "popular" },
        {68 , "thorough" },
        {69 , "client" },
        {70 , "comprehensive" },
        {71 , "defraud" },
          {72 , "Postpone" },
        {73 , "consent" },
        {74 , "massive" },
        {75 , "capsule" },
        {76 , "preserve" },
        {77 , "denounce" },
        {78 , "unique" },
        {79 , "torrent" },
        {80 , "resent" },
        {81 , "molest" },
        {82 , "gloomy" },
        {83 , "unforeseen" },
          {84 , "exaggerate" },
        {85 , "amateur" },
        {86 , "mediocre" },
        {87 , "variety" },
        {88 , "valid" },
        {89 , "survive" },
        {90 , "weird" },
        {91 , "prominent" },
        {92 , "security" },
        {93 , "bulky" },
        {94 , "reluctant" },
        {95 , "obvious" },
          {96 , "vicinity" },
        {97 , "century" },
        {98 , "rage" },
        {99 , "document" },
        {100 , "conclude" },
        {101 , "undeniable" },
        {102 , "resist" },
        {103 , "lack" },
        {104 , "ignore" },
        {105 , "challenge" },
        {106 , "miniature" },
        {107 , "source" },
          {108 , "excel" },
        {109 , "feminine" },
        {110 , "mount" },
        {111 , "compete" },
        {112 , "dread" },
        {113 , "masculine" },
        {114 , "menace" },
        {115 , "tendency" },
        {116 , "underestimate" },
        {117 , "victorious" },
        {118 , "numerous" },
        {119 , "flexible" },
          {120 , "evidence" },
        {121 , "solitary" },
        {122 , "vision" },
        {123 , "frequent" },
        {124 , "glimpse" },
        {125 , "recent" },
        {126 , "decade" },
        {127 , "hesitate" },
        {128 , "absurd" },
        {129 , "conflict" },
        {130 , "minority" },
        {131 , "fiction" },
          {132 , "ignite" },
        {133 , "abolish" },
        {134 , "urban" },
        {135 , "population" },
        {136 , "frank" },
        {137 , "pollute" },
        {138 , "reveal" },
        {139 , "prohibit" },
        {140 , "urgent" },
        {141 , "adequate" },
        {142 , "decrease" },
        {143 , "audible" },
          {144 , "famine" },
        {145 , "editor" },
        {146 , "revive" },
        {147 , "journalist" },
        {148 , "commence" },
        {149 , "gleam" },
        {150 , "hazy" },
        {151 , "persist" },
        {152 , "vessel" },
        {153 , "observant" },
        {154 , "migrate" },
        {155 , "identify" },
          {156 , "bewildered" },
        {157 , "brawl" },
        {158 , "brutal" },
        {159 , "duplicate" },
        {160 , "opponent" },
        {161 , "rival" },
        {162 , "thrust" },
        {163 , "underdog" },
        {164 , "unruly" },
        {165 , "vicious" },
        {166 , "violent" },
        {167 , "whirling" },
          {168 , "alter" },
        {169 , "casual" },
        {170 , "expand" },
        {171 , "fortunate" },
        {172 , "innovative" },
        {173 , "mature" },
        {174 , "pioneer" },
        {175 , "pledge" },
        {176 , "pursue" },
        {177 , "revise" },
        {178 , "sacred" },
        {179 , "unanimous" },
          {180 , "slender" },
        {181 , "surpass" },
        {182 , "vast" },
        {183 , "doubt" },
        {184 , "capacity" },
        {185 , "penetrate" },
        {186 , "pierce" },
        {187 , "accurate" },
        {188 , "microscope" },
        {189 , "grateful" },
        {190 , "cautious" },
        {191 , "confident" },
          {192 , "appeal" },
        {193 , "addict" },
        {194 , "wary" },
        {195 , "aware" },
        {196 , "misfortune" },
        {197 , "avoid" },
        {198 , "wretched" },
        {199 , "keg" },
        {200 , "nourish" },
        {201 , "harsh" },
        {202 , "quantity" },
        {203 , "opt" },
          {204 , "tragedy" },
        {205 , "pedestrian" },
        {206 , "glance" },
        {207 , "budget" },
        {208 , "nimble" },
        {209 , "manipulate" },
        {210 , "reckless" },
        {211 , "horrid" },
        {212 , "rave" },
        {213 , "economical" },
        {214 , "lubricate" },
        {215 , "ingenious" },
          {216 , "harvest" },
        {217 , "abundant" },
        {218 , "uneasy" },
        {219 , "calculate" },
        {220 , "absorb" },
        {221 , "estimate" },
        {222 , "morsel" },
        {223 , "quota" },
        {224 , "threat" },
        {225 , "ban" },
        {226 , "panic" },
        {227 , "appropriate" },
          {228 , "emerge" },
        {229 , "jagged" },
        {230 , "linger" },
        {231 , "ambush" },
        {232 , "crafty" },
        {233 , "defiant" },
        {234 , "vigor" },
        {235 , "perish" },
        {236 , "fragile" },
        {237 , "captive" },
        {238 , "prosper" },
        {239 , "devour" },
          {240 , "plea" },
        {241 , "weary" },
        {242 , "collide" },
        {243 , "confirm" },
        {244 , "verify" },
        {245 , "anticipate" },
        {246 , "dilemma" },
        {247 , "detour" },
        {248 , "merit" },
        {249 , "transmit" },
        {250 , "relieve" },
        {251 , "baffle" },
          {252 , "warden" },
        {253 , "acknowledge" },
        {254 , "justice" },
        {255 , "delinquent" },
        {256 , "deprive" },
        {257 , "spouse" },
        {258 , "vocation" },
        {259 , "unstable" },
        {260 , "homicide" },
        {261 , "penalize" },
        {262 , "beneficiary" },
        {263 , "reject" },
          {264 , "reptile" },
        {265 , "rarely" },
        {266 , "exhibit" },
        {267 , "proceed" },
        {268 , "precaution" },
        {269 , "extract" },
        {270 , "prior" },
        {271 , "embrace" },
        {272 , "valiant" },
        {273 , "partial" },
        {274 , "forbid" },
        {275 , "logical" },
          {276 , "fierce" },
        {277 , "detest" },
        {278 , "sneer" },
        {279 , "scowl" },
        {280 , "encourage" },
        {281 , "consider" },
        {282 , "vermin" },
        {283 , "wail" },
        {284 , "symbol" },
        {285 , "authority" },
        {286 , "neutral" },
        {287 , "trifle" },
          {288 , "matrimony" },
        {289 , "baggage" },
        {290 , "squander" },
        {291 , "abroad" },
        {292 , "fugitive" },
        {293 , "calamity" },
        {294 , "pauper" },
        {295 , "envy" },
        {296 , "prosecute" },
        {297 , "bigamy" },
        {298 , "collapse" },
        {299 , "architect" },
          {300 , "possible" },
        {301 , "compel" },
        {302 , "awkward" },
        {303 , "venture" },
        {304 , "awesome" },
        {305 , "guide" },
        {306 , "quench" },
        {307 , "betray" },
        {308 , "utter" },
        {309 , "pacify" },
        {310 , "respond" },
        {311 , "beckon" },
          {312 , "despite" },
        {313 , "disrupt" },
        {314 , "rash" },
        {315 , "rapid" },
        {316 , "exhaust" },
        {317 , "severity" },
        {318 , "feeble" },
        {319 , "unite" },
        {320 , "cease" },
        {321 , "thrifty" },
        {322 , "miserly" },
        {323 , "monarch" },
          {324 , "outlaw" },
        {325 , "promote" },
        {326 , "undernourished" },
        {327 , "illustrate" },
        {328 , "disclose" },
        {329 , "excessive" },
        {330 , "disaster" },
        {331 , "censor" },
        {332 , "culprit" },
        {333 , "juvenile" },
        {334 , "bait" },
        {335 , "insist" },
          {336 , "toil" },
        {337 , "blunder" },
        {338 , "daze" },
        {339 , "mourn" },
        {340 , "subside" },
        {341 , "maim" },
        {342 , "comprehend" },
        {343 , "commend" },
        {344 , "final" },
        {345 , "exempt" },
        {346 , "vain" },
        {347 , "repetition" },
          {348 , "depict" },
        {349 , "mortal" },
        {350 , "novel" },
        {351 , "occupant" },
        {352 , "appoint" },
        {353 , "quarter" },
        {354 , "site" },
        {355 , "quote" },
        {356 , "verse" },
        {357 , "morality" },
        {358 , "roam" },
        {359 , "attract" },
          {360 , "commuter" },
        {361 , "confine" },
        {362 , "idle" },
        {363 , "idol" },
        {364 , "jest" },
        {365 , "patriotic" },
        {366 , "dispute" },
        {367 , "valor" },
        {368 , "lunatic" },
        {369 , "vein" },
        {370 , "uneventful" },
        {371 , "fertile" },
          {372 , "refer" },
        {373 , "distress" },
        {374 , "diminish" },
        {375 , "maximum" },
        {376 , "flee" },
        {377 , "vulnerable" },
        {378 , "signify" },
        {379 , "mythology" },
        {380 , "colleague" },
        {381 , "torment" },
        {382 , "provide" },
        {383 , "loyalty" },
          {384 , "volunteer" },
        {385 , "prejudice" },
        {386 , "shrill" },
        {387 , "jolly" },
        {388 , "witty" },
        {389 , "hinder" },
        {390 , "lecture" },
        {391 , "abuse" },
        {392 , "mumble" },
        {393 , "mute" },
        {394 , "wad" },
        {395 , "retain" },
          {396 , "candidate" },
        {397 , "precede" },
        {398 , "adolescent" },
        {399 , "coeducational" },
        {400 , "radical" },
        {401 , "spontaneous" },
        {402 , "skim" },
        {403 , "vaccinate" },
        {404 , "untidy" },
        {405 , "utensil" },
        {406 , "sensitive" },
        {407 , "temperate" },
          {408 , "vague" },
        {409 , "elevate" },
        {410 , "lottery" },
        {411 , "finance" },
        {412 , "obtain" },
        {413 , "cinema" },
        {414 , "event" },
        {415 , "discard" },
        {416 , "soar" },
        {417 , "subsequent" },
        {418 , "relate" },
        {419 , "stationary" },
          {420 , "prompt" },
        {421 , "hasty" },
        {422 , "scorch" },
        {423 , "tempest" },
        {424 , "soothe" },
        {425 , "sympathetic" },
        {426 , "redeem" },
        {427 , "resume" },
        {428 , "harmony" },
        {429 , "refrain" },
        {430 , "illegal" },
        {431 , "narcotic" },
          {432 , "heir" },
        {433 , "majestic" },
        {434 , "dwindle" },
        {435 , "surplus" },
        {436 , "traitor" },
        {437 , "deliberate" },
        {438 , "vandal" },
        {439 , "drought" },
        {440 , "abide" },
        {441 , "unify" },
        {442 , "summit" },
        {443 , "heed" },
          {444 , "biography" },
        {445 , "drench" },
        {446 , "swarm" },
        {447 , "wobble" },
        {448 , "tumult" },
        {449 , "kneel" },
        {450 , "dejected" },
        {451 , "obedient" },
        {452 , "recede" },
        {453 , "tyrant" },
        {454 , "charity" },
        {455 , "verdict" },
          {456 , "unearth" },
        {457 , "depart" },
        {458 , "coincide" },
        {459 , "cancel" },
        {460 , "debtor" },
        {461 , "legible" },
        {462 , "placard" },
        {463 , "contagious" },
        {464 , "clergy" },
        {465 , "customary" },
        {466 , "transparent" },
        {467 , "scald" },
          {468 , "epidemic" },
        {469 , "obesity" },
        {470 , "magnify" },
        {471 , "chiropractor" },
        {472 , "obstacle" },
        {473 , "ventilate" },
        {474 , "jeopardize" },
        {475 , "negative" },
        {476 , "pension" },
        {477 , "vital" },
        {478 , "municipal" },
        {479 , "oral" },
          {480 , "complacent" },
        {481 , "wasp" },
        {482 , "rehabilitate" },
        {483 , "parole" },
        {484 , "vertical" },
        {485 , "multitude" },
        {486 , "nominate" },
        {487 , "potential" },
        {488 , "morgue" },
        {489 , "preoccupied" },
        {490 , "upholstery" },
        {491 , "indifference" },
          {492 , "maintain" },
        {493 , "snub" },
        {494 , "endure" },
        {495 , "wrath" },
        {496 , "expose" },
        {497 , "legend" },
        {498 , "ponder" },
        {499 , "resign" },
        {500 , "drastic" },
        {501 , "wharf" },
        {502 , "amend" },
        {503 , "ballot" },
        };
    public Dictionary<int, string> VocabDic = new Dictionary<int, string>()
         {
        {0, "desert; leave without planning to come back; quit" },
        {1, "sharp; eager; intense; sensitive" },
        {2, "afraid that the one you love might prefer someone else" },
        {3, "ability to say the right thing" },
        {4, "a promise that something is true; a curse" },
        {5, "empty; not filled" },
        {6, "something that is hard to bear; difficulty" },
        {7, "brave; showing respect for women" },
        {8, "facts; information" },
        {9, "not used to something" },
        {10, "a man who has not married" },
        {11, "become fit; show that you are able" },
        {12 , "a dead body" },
        {13 , "hide" },
        {14 , "very bad or unpleasant and making you feel unhappy" },
        {15 , "extremely cold (of weather conditions or the conditions in a room)" },
        {16 , "Live in" },
        {17 , "without the power of feeling; deadened" },
        {18 , "great danger, or something that is very dangerous" },
        {19 , "lie down; stretch out; lean back" },
        {20 , "Scream" },
        {21 , "evil; wicked; dishonest; frightening" },
        {22 , "to make someone want to have or do something, especially something that is unnecessary or wrong" },
        {23 , "an amount of money that you risk in the hope of winning more, by trying to guess something uncertain, or the agreement that you make to take this risk; bet" },
          {24 , "usual; of a kind" },
        {25 , "the least possible amount; the lowest amount" },
        {26 , "not easy to find or get; rare" },
        {27 , "once a year; something that appears yearly or lasts for a year" },
        {28 , "win over to do or believe; make willing" },
        {29 , "necessary; very important" },
        {30 , "mix together thoroughly; a mixture" },
        {31 , "able to be seen" },
        {32 , "costly; high-priced" },
        {33 , "natural ability" },
        {34 , "think out; plan; invent" },
        {35 , "in large quantity; less than retail in price" },
          {36 , "moisture in the air that can be seen; fog; mist" },
        {37 , "get rid of; remove; omit" },
        {38 , "a very wicked person" },
        {39 , "closely packed together; thick" },
        {40 , "to use something in an effective way" },
        {41 , "moist; damp" },
        {42 , "explanation based on thought, observation, or reasoning" },
        {43 , "go or come down from a higher place to a lower level" },
        {44 , "go around; go from place to place or person to person" },
        {45 , "extremely large; huge" },
        {46 , "tell beforehand" },
        {47 , "to disappear or stop being present or existing, especially in a sudden, surprising way" },
          {48 , "beliefs, opinions, and customs handed down from one generation to another" },
        {49 , "in the country" },
        {50 , "what is carried; a load" },
        {51 , "grounds of a college, university, or school" },
        {52 , "the larger number; greater part; more than half" },
        {53 , "gather together" },
        {54 , "go over carefully; look into closely; examine" },
        {55 , "subject that people think, write, or talk about" },
        {56 , "a discussion in which reasons for and against something are brought out" },
        {57 , "get away from by trickery or cleverness" },
        {58 , "search into; examine thoroughly; investigate" },
        {59 , "make better" },
          {60 , "come near or nearer to" },
        {61 , "find out; discover" },
        {62 , "fault" },
        {63 , "a person who works for pay" },
        {64 , "give too little care or attention to" },
        {65 , "to persuade someone that something false is the truth, or to keep the truth hidden from someone for your own advantage" },
        {66 , "certainly; beyond doubt" },
        {67 , "liked by most people" },
        {68 , "being all that is needed; complete" },
        {69 , "person for whom a lawyer acts; customer" },
        {70 , "complete and including everything that is necessary" },
        {71 , "take money, rights, etc., away by cheating" },
          {72 , "put off to a later time; delay" },
        {73 , "agree; give permission or approval" },
        {74 , "big & heavy; bulky" },
        {75 , "a small case or covering" },
        {76 , "keep safe; protect" },
        {77 , "condemn in public; express strong disapproval of" },
        {78 , "having no like or equal" },
        {79 , "a sudden large or too large amount, especially one that seems to be uncontrolled" },
        {80 , "feel injured & angered at (sth. or someone)" },
        {81 , "interfere with & trouble; disturb" },
        {82 , "dark; dim; in low spirits" },
        {83 , "unexpected; unanticipated" },
          {84 , "make something greater than it is; overstate" },
        {85 , "a person who does something for pleasure, not for money or as a profession" },
        {86 , "neither good nor bad; average; ordinary" },
        {87 , "lack of sameness; a number of different things" },
        {88 , "supported by facts or authority; sound (adj.); true" },
        {89 , "live longer than; remain alive after" },
        {90 , "very strange and unusual, unexpected, or not natural" },
        {91 , "very well known and important" },
        {92 , "freedom from danger, care, or fear" },
        {93 , "taking up too much space; large" },
        {94 , "not willing to do something and therefore slow to do it" },
        {95 , "easily seen or understood; clear to the eye or mind; not doubted" },
          {96 , "region near a place; neighborhood" },
        {97 , "100 years" },
        {98 , "violent anger; something that arouses intense but brief enthusiasm" },
        {99 , "something handwritten or printed that gives information or proof of some fact" },
        {100 , "end; finish; decide" },
        {101 , "not to be denied; cannot be questioned" },
        {102 , "act against; strive against; oppose" },
        {103 , "be entirely without something; not have enough" },
        {104 , "pay no attention to; disregard" },
        {105 , "call to a fight" },
        {106 , "represented on a small scale" },
        {107 , "place from which something comes or is obtained" },
          {108 , "be better than; do better than" },
        {109 , "of women or girls" },
        {110 , "get up on" },
        {111 , "try hard to get something wanted by others; be a rival" },
        {112 , "to feel extremely worried or frightened about something that is going to happen or that might happen" },
        {113 , "of man; male" },
        {114 , "something that is likely to cause harm; threat" },
        {115 , "leaning; movement in a certain direction" },
        {116 , "set too low a value, amount, or rate" },
        {117 , "having won a victory; conquering" },
        {118 , "very many; several" },
        {119 , "easily bent; willing to yield" },
          {120 , "that which makes clear the truth or falsehood of something" },
        {121 , "alone; single; only" },
        {122 , "power of seeing; sense of sight" },
        {123 , "happening often; occuring repeatedly" },
        {124 , "a short" },
        {125 , "done, made, or occuring not long ago" },
        {126 , "10 years" },
        {127 , "fail to act quickly; be undecided" },
        {128 , "plainly not true or sensible; foolish" },
        {129 , "direct opposition; disagreement" },
        {130 , "smaller number or part; less than half" },
        {131 , "that which is imagined or made up" },
          {132 , "set on fire" },
        {133 , "do away with completely; put an end to" },
        {134 , "of or having to do with cities or towns" },
        {135 , "people of a city or country" },
        {136 , "honest, sincere, and telling the truth, even when this might be awkward or make other people uncomfortable" },
        {137 , "make dirty" },
        {138 , "to make known or show something that is surprising or that was previously secret" },
        {139 , "forbid by law or authority" },
        {140 , "demanding immediate action or attention; important" },
        {141 , "as much as is needed; fully sufficient" },
        {142 , "make or become less" },
        {143 , "able to be heard" },
          {144 , "a situation in which there is not enough food for a great number of people, causing illness and death, or a particular period when this happens; starvation; great shortage" },
        {145 , "a person who prepares a publication; one who corrects manuscript and helps to improve it" },
        {146 , "bring back or come back to life or consciousness" },
        {147 , "one who writes for, edits, manages, or produces a newspaper or magazine" },
        {148 , "begin; start" },
        {149 , "to produce or reflect a small, bright light; flash; sparkle; a beam of light" },
        {150 , "misty; smoky; unclear" },
        {151 , "continue firmly; refuse to stop or be changed" },
        {152 , "a ship; a hollow container; tube containing body fluid" },
        {153 , "watchful; quick to notice" },
        {154 , "move from one place to another place" },
        {155 , "recognize as being, or show to be, a certain person or thing; prove to be the same" },
          {156 , "confused completely; puzzled" },
        {157 , "a noisy quarrel or fight" },
        {158 , "coarse and savage; like a brute; cruel" },
        {159 , "an exact copy; make an exact copy of; repeat exactly" },
        {160 , "person who is on the other side of a fight, game, or discussion; person fighting, struggling or speaking against another" },
        {161 , "a person who wants and tries to get the same thing as another or one who tries to equal or do better than another; competitor" },
        {162 , "to push suddenly and strongly" },
        {163 , "person having the worst of any struggle; one who is expected to lose" },
        {164 , "hard to rule or control; lawless" },
        {165 , "describes people or actions that show an intention or wish to hurt someone or something very badly; evil; wicked; savage" },
        {166 , "acting or done with strong, rough force" },
        {167 , "turning or swinging round and round; spinning" },
          {168 , "make different; change; vary" },
        {169 , "happening by chance; not planned or expected; not calling attention to itself" },
        {170 , "increase in size; enlarge; swell" },
        {171 , "having good luck; lucky" },
        {172 , "fresh, clever, having new ideas" },
        {173 , "someone who is grown up and not like a child" },
        {174 , "one who goes first or prepares a way for others" },
        {175 , "a serious or formal promise, especially one to give money or to be a friend, or something that you give as a sign that you will keep a promise" },
        {176 , "to follow someone or something, usually to try to catch him, her, or it" },
        {177 , "to look at or consider again an idea, piece of writing, etc. in order to correct or improve it" },
        {178 , "considered to be holy and deserving respect, especially because of a connection with a god" },
        {179 , "in complete agreement" },
          {180 , "long and thin; limited; slight" },
        {181 , "do better than; be greater than; excel" },
        {182 , "very great; enormous" },
        {183 , "not believe; not be sure of; feel uncertain about; lack of certainty" },
        {184 , "amount of room or space inside; largest amount that can be held by a container" },
        {185 , "get into or through" },
        {186 , "go into; go through; penetrate" },
        {187 , "exactly right as the result of care or pains" },
        {188 , "instrument with a lens for making objects larger so that one can see things more clearly" },
        {189 , "feeling gratitude; thankful" },
        {190 , "very careful; never taking chances" },
        {191 , "firmly believing; certain; sure" },
          {192 , "attraction; interest; to urge" },
        {193 , "one who cannot break away from a habit or practice" },
        {194 , "not completely trusting or certain about something or someone; cautious" },
        {195 , "knowing; realizing" },
        {196 , "bad luck" },
        {197 , "keep away from; keep out of the way of" },
        {198 , "very unsatisfactory; miserable" },
        {199 , "small barrel, usually holding less than ten gallons" },
        {200 , "make or keep alive and well, with food; feed; develop an attitude" },
        {201 , "unpleasant, unkind, cruel, or more severe than is necessary" },
        {202 , "amount" },
        {203 , "choose or favor; select" },
          {204 , "a very sad or terrible happening; a sad play (drama)" },
        {205 , "a person who is walking, especially in an area where vehicles go" },
        {206 , "to look at quickly; a quick look" },
        {207 , "estimate of the amount of money that can be spent for different purposes in a given time" },
        {208 , "active and sure-footed; quick moving; light and quick" },
        {209 , "handle or treat skillfully" },
        {210 , "careless; heedless; wild" },
        {211 , "terrible; frightful" },
        {212 , "to speak in an uncontrolled way, usually because you are upset or angry, or because you are ill" },
        {213 , "not wasting money or time" },
        {214 , "make (machinery) smooth and easy to work by putting on oil, grease, or a similar substance" },
        {215 , "(of a person) very intelligent and skillful" },
          {216 , "gathering in of grain or other food crops" },
        {217 , "more than enough; very plentiful" },
        {218 , "restless; disturbed; anxious" },
        {219 , "find out by adding, subtracting, multiplying, or dividing; figure" },
        {220 , "take in or suck up (liquids); interest greatly" },
        {221 , "form a judgment or opinion about; guess" },
        {222 , "a small bite; mouthful; tiny amount" },
        {223 , "a fixed, limited amount or number that is officially allowed" },
        {224 , "a suggestion that something unpleasant or violent will happen, especially if a particular action or order is not followed" },
        {225 , "to forbid something, especially officially; prohibit" },
        {226 , "unreasoning fear; fear spreading through a group of people so that they lose control of themselves" },
        {227 , "suitable or right for a particular situation or occasion" },
          {228 , "to appear by coming out of something or out from behind something" },
        {229 , "with sharp points sticking out; unevenly cut or torn" },
        {230 , "to take a long time to leave or disappear" },
        {231 , "a trap in which soldiers or other enemies hide to make a surprise attack" },
        {232 , "skillful in deceiving others; sly; tricky" },
        {233 , "proudly refusing to obey authority" },
        {234 , "strength, energy, or enthusiasm" },
        {235 , "to die, especially in an accident or by being killed, or to be destroyed" },
        {236 , "easily broken, damaged, or destroyed; delicate" },
        {237 , "a person or animal whose ability to move or act freely is limited by being closed in a space; a prisoner, especially a person held by the enemy during a war" },
        {238 , "be successful; have good fortune" },
        {239 , "to eat something eagerly and in large amounts so that nothing is left" },
          {240 , "an urgent and emotional request" },
        {241 , "very tired, especially after working hard for a long time" },
        {242 , "(especially of moving objects) to hit something violently" },
        {243 , "to prove that a belief or an opinion that was previously not completely certain is true; make certain" },
        {244 , "to prove that something exists or is true, or to make certain that something is correct" },
        {245 , "to look forward or expect that something will happen" },
        {246 , "a situation in which a difficult choice has to be made between two different things you could do" },
        {247 , "a different or less direct route to a place that is used to avoid a problem or to visit somewhere or do something on the way" },
        {248 , "the quality of being good and deserving praise" },
        {249 , "to pass something from one person or place to another" },
        {250 , "to make an unpleasant feeling, such as pain or worry, less strong; make easier" },
        {251 , "to cause someone to be completely unable to understand or explain something" },
          {252 , "a person who is in charge of (the people in) a particular building" },
        {253 , "to accept, admit, or recognize something, or the truth or existence of something" },
        {254 , "fairness in the way people are dealt with" },
        {255 , "a young person who behaves badly, usually by committing crimes" },
        {256 , "to take something important or necessary away from someone or something" },
        {257 , "husband or wife" },
        {258 , "occupation; business; profession; trade" },
        {259 , "not firmly fixed; easily moved or overthrown" },
        {260 , "a killing of one human being by another; murder" },
        {261 , "declare punishable by law or rule" },
        {262 , "someone who receives money, help, etc from something or someone else" },
        {263 , "to refuse to accept or agree with something" },
          {264 , "an animal whose body is covered with scales (= pieces of hard skin), and whose blood changes temperature, for example a snake" },
        {265 , "seldom; not often" },
        {266 , "to show objects such as paintings to the public" },
        {267 , "to continue as planned; go on after having stopped; move forward" },
        {268 , "something that you do to prevent bad things happening in the future; measures taken beforehand; foresight" },
        {269 , "to take something out; pull out or draw out, usually with some effort" },
        {270 , "coming before; earlier" },
        {271 , "hug one another; a hug" },
        {272 , "brave; courageous" },
        {273 , "not complete; not total" },
        {274 , "order someone not to do something; make a rule against" },
        {275 , "reasonable; reasonably expected" },
          {276 , "savage; wild" },
        {277 , "dislike very much; hate" },
        {278 , "show scorn or contempt by looks or words; a scornful look or remark" },
        {279 , "look angry by lowering the eyebrows; frown" },
        {280 , "give courage to; increase the confidence of" },
        {281 , "think about in order to decide" },
        {282 , "small animals that are troublesome or destructive; such as fleas, bedbugs, lice, rats, and mice" },
        {283 , "cry loud and long because of grief or pain" },
        {284 , "something that stands for or represents something else" },
        {285 , "the right to command or enforce obedience; power delegated to another; an author or volume that may be appealed to in support of an action or belief" },
        {286 , "on neither side of a quarrel or war" },
        {287 , "a small amount; a little bit; something of little value" },
          {288 , "married life; ceremony of marriage" },
        {289 , "the trunks and suitcases a person takes when he or she travels; an army's equipment" },
        {290 , "spend foolishly; waste" },
        {291 , "outside one's country; going around; far and wide" },
        {292 , "a runaway" },
        {293 , "a great misfortune; serious trouble" },
        {294 , "a very poor person" },
        {295 , "jealousy; the object of jealousy; to feel jealous" },
        {296 , "bring before a court; follow up; carry on" },
        {297 , "having two wives or two husbands at the same time" },
        {298 , "a breakdown; to fall in; break down; fail suddenly; fold together" },
        {299 , "a person who makes plans for buildings and other structures; a maker; a creator" },
          {300 , "able to be, be done, happen; able to be true; able to be done or chosen properly" },
        {301 , "force; get by force" },
        {302 , "clumsy; not well-suited to use; not easily managed; embarrassing" },
        {303 , "a daring undertaking; an attempt to make money by taking business risks; to dare; to expose to risk" },
        {304 , "causing or showing great fear, wonder, or respect" },
        {305 , "a person who shows the way; to direct; to manage" },
        {306 , "put an end to; drown or put out" },
        {307 , "give away to the enemy; be unfaithful; mislead; show" },
        {308 , "speak; make known; express" },
        {309 , "make calm; quiet down; bring peace to" },
        {310 , "answer; react" },
        {311 , "signal by a motion of the hand or head; attract" },
          {312 , "regardless of" },
        {313 , "upset; cause to break down" },
        {314 , "a breaking out with many small red spots on the skin; outbreak of many instances within a short time; too hasty or careless" },
        {315 , "very quick; swift" },
        {316 , "empty completely; use up; tire out" },
        {317 , "strictness; harshness; plainness; violence" },
        {318 , "very weak" },
        {319 , "join together; become one" },
        {320 , "stop" },
        {321 , "saving; careful in spending; thriving" },
        {322 , "stingy; like one who is stingy" },
        {323 , "king or queen; ruler" },
          {324 , "an exile; an outcast; a criminal; to declare unlawful" },
        {325 , "raise in rank or importance; help to grow and develop; help to organize" },
        {326 , "not sufficiently fed" },
        {327 , "make clear or explain by stories, examples, comparisons, or other means; serve as an example" },
        {328 , "uncover; make known" },
        {329 , "too much; too great; extreme" },
        {330 , "an event that causes mush suffering or loss; a great misfortune" },
        {331 , "person who tells others how they ought to" },
        {332 , "offender; person guilty of a fault or crime" },
        {333 , "young; youthful; of or for boys and girls; a young person" },
        {334 , "anything, especially food, used to attract fish or other animals so that they may be caught" },
        {335 , "keep firmly to some demand, statement, or position" },
          {336 , "hard work; to work hard; move with difficulty" },
        {337 , "stupid mistake; to make a stupid mistake; stumble; say clumsily" },
        {338 , "confuse" },
        {339 , "grieve; feel or show sorrow for" },
        {340 , "sink to a lower level; grow less" },
        {341 , "cripple; disable; cause to lose an arm, leg, or other part of the body" },
        {342 , "understand" },
        {343 , "praise; hand over for safekeeping" },
        {344 , "coming last; deciding" },
        {345 , "make free from; freed from" },
        {346 , "having too much pride in one's ability, looks, etc.; of no use" },
        {347 , "act of doing or saying again" },
          {348 , "represent by drawing or painting; describe" },
        {349 , "sure to die sometime; pertaining to man; deadly; pertaining to causing death" },
        {350 , "new, strange; a long story with characters and plot" },
        {351 , "person in possession of a house, office, or position" },
        {352 , "decide on; set a time or place; choose for a position; equip or furnish" },
        {353 , "region; section; a place to live; to provide a place to live" },
        {354 , "position or place (of anything)" },
        {355 , "repeat exactly the words of another or a passage from a book; that is, something that is repeated exactly; give the price of" },
        {356 , "a short division of a chapter in the Bible; a single line or a group of lines of poetry" },
        {357 , "the right or wrong of an action; virtue; a set of rules or principles of conduct" },
        {358 , "wander; go about with no special plan or aim" },
        {359 , "draw to oneself; win the attention and liking of" },
          {360 , "one who travels regularly, especially over a considerable distance, between home and work" },
        {361 , "keep in, hold in" },
        {362 , "not doing anything; not busy; lazy; without any good reason or cause" },
        {363 , "a thing, usually an image, that is worshiped; a person or thing that is loved very much" },
        {364 , "joke; fun; mockery; thing to be laughed at; to joke; poke fun" },
        {365 , "loving one's country; showing love and loyal support for one's country" },
        {366 , "disagree; oppose; try to win; a debate or disagreement" },
        {367 , "bravery; courage" },
        {368 , "crazy person; insane; extremely foolish" },
        {369 , "mood; a blood vessel that carries blood to the heart; a crack or seam" },
        {370 , "without important or striking happenings" },
        {371 , "bearing seeds or fruit; producing much of anything" },
          {372 , "hand over; send, direct, or turn for information, help, or action; direct attention to or speak about; assign to or think of as caused by" },
        {373 , "great pain or sorrow; misfortune; dangerous or difficult situation; to cause pain or make unhappy" },
        {374 , "make or become smaller in size, amount or importance" },
        {375 , "greatest amount; greatest possible" },
        {376 , "run away; go quickly" },
        {377 , "capable of being injured; open to attack, sensitive to criticism, influences, etc." },
        {378 , "mean; be a sign of; make known by signs, words, or actions; have importance" },
        {379 , "legends or stories that usually attempt to explain something in nature" },
        {380 , "associate; fellow worker" },
        {381 , "cause very great pain to; worry or annoy very much; cause of very great pain; very great pain" },
        {382 , "to supply; to state as a condition; to prepare for or against some situation" },
        {383 , "faithfulness to a person, government, idea, custom, or the like" },
          {384 , "person who enters any service of his or her own free will; to offer one's services" },
        {385 , "an opinion formed without taking time and care to judge fairly; to harm or injure" },
        {386 , "having a high pitch; high and sharp in sound; piercing" },
        {387 , "merry; full of fun" },
        {388 , "cleverly amusing" },
        {389 , "hold back; make hard to do" },
        {390 , "speech or planned talk; a scolding; to scold" },
        {391 , "make bad use of; use wrongly; treat badly; scold very severely; bad or wrong use; bad treatment" },
        {392 , "speak indistinctly" },
        {393 , "silent; unable to speak" },
        {394 , "small; soft mass; to roll or crush into a small mass" },
        {395 , "keep; remember; employ by payment of a fee" },
          {396 , "person who is proposed for some office or honor" },
        {397 , "go before; come before; be higher in rank or importance" },
        {398 , "growing up to manhood or womanhood; youthful; a person from about 13 to 22 years of age" },
        {399 , "having to do with educating both sexes in the same school" },
        {400 , "going to the root; fundamental; extreme; person with extreme opinions" },
        {401 , "of one's own free will; natural; on the spur of the moment; without rehearsal" },
        {402 , "remove from the top; move lightly (over); glide along; read hastily or carelessly" },
        {403 , "inoculate with vaccine as a protection against smallpox and other diseases" },
        {404 , "not neat; not in order" },
        {405 , "container or tool used for practical purposes" },
        {406 , "receiving impressions readily; easily affected or influenced; easily hurt or offended" },
        {407 , "not very hot and not very cold; moderate" },
          {408 , "not definite; not clear; not distinct" },
        {409 , "raise; lift up" },
        {410 , "a scheme for distributing prizes by lot or chance" },
        {411 , "money matters; to provide money for" },
        {412 , "get; be in use" },
        {413 , "moving picture" },
        {414 , "happening; important happening; result or outcome; one item in a program of sports" },
        {415 , "throw aside" },
        {416 , "fly upward or at a great height; aspire" },
        {417 , "later; following; coming after" },
        {418 , "tell; given an account for; connect in thought or meaning" },
        {419 , "having a fixed station or place; standing still; not moving; not changing in size, number or activity" },
          {420 , "quick; on time; done at once; to cause (someone) to do something; remind (someone) of the words or actions needed" },
        {421 , "quick; hurried; not well thought out" },
        {422 , "burn slightly; dry up; criticize sharply" },
        {423 , "violent storm with much wind; a violent disturbance" },
        {424 , "quiet; calm; comfort" },
        {425 , "someone who has or shows kind feelings toward others" },
        {426 , "buy back; pay off; carry out; set free; make up for" },
        {427 , "begin again; go on; take again" },
        {428 , "situation of getting on well together or going well together; sweet or musical sound" },
        {429 , "hold back" },
        {430 , "not lawful; against the law" },
        {431 , "drug that produces drowsiness, sleep, dullness, or an insensible condition, and lessens pain by dulling the nerves" },
          {432 , "person who has a right to someone's property after that one dies; person who inherits anything" },
        {433 , "grand; noble; dignified; kingly" },
        {434 , "become smaller and smaller; shrink" },
        {435 , "amount over and above what is needed; excess, extra" },
        {436 , "person who betrays his or her country, a friend, duty, etc." },
        {437 , "to consider carefully; intended; done on purpose; slow and careful, as though allowing time to decide what to do" },
        {438 , "person who willfully or ignorantly destroys or damages beautiful things" },
        {439 , "long period of dry weather; lack of rain; lack of water; dryness" },
        {440 , "accept and follow out; remain faithful to; dwell; endure" },
        {441 , "unite; make or form into one" },
        {442 , "highest point; top" },
        {443 , "give careful attention to; take notice of; careful attention" },
          {444 , "the written story of a person's life" },
        {445 , "wet thoroughly; soak" },
        {446 , "group of insects flying or moving about together; crowd or great number ; to fly or move about in great numbers" },
        {447 , "move unsteadily from side to side" },
        {448 , "noise; uproar; violent* disturbance or disorder" },
        {449 , "go down on one's knees; remain on the knees" },
        {450 , "in low spirits; sad" },
        {451 , "doing what one is told; willing to obey" },
        {452 , "go back; move back; slope backward; withdraw" },
        {453 , "cruel or unjust ruler; cruel master; absolute ruler" },
        {454 , "generous giving to the poor; institutions for helping the sick; the poor; or the helpless; kindness in judging people's faults" },
        {455 , "decision of a jury; judgment" },
          {456 , "dig up; discover; find out" },
        {457 , "go away; leave; turn away (from); change; die" },
        {458 , "occupy the same place in space; occupy the same time; correspond exactly; agree" },
        {459 , "cross out; mark so that it cannot be used; wipe out; call off" },
        {460 , "person who owes something to another" },
        {461 , "able to be read; easy to read; plain and clear" },
        {462 , "a notice to be posted in a public place; poster" },
        {463 , "spreading by contact, easily spreading from one to another" },
        {464 , "persons prepared for religious work" },
        {465 , "usual" },
        {466 , "easily seen through; clear" },
        {467 , "pour boiling liquid over; burn with hot liquid or steam; heat almost to the boiling point" },
          {468 , "an outbreak of a disease that spreads rapidly,* so that many people have it at the same time; widespread" },
        {469 , "extreme fatness" },
        {470 , "cause to look larger than it really is; make too much of; go beyond the truth in telling" },
        {471 , "a person who treats ailments by massage and manipulation of the vertebrae and other forms of therapy on the theory* that disease results from interference with the normal functioning of the nervous system" },
        {472 , "anything that gets in the way or hinders; impediment; obstruction" },
        {473 , "change the air in; purify by fresh air; discuss openly" },
        {474 , "risk; endanger" },
        {475 , "saying no; minus; showing the lights and shadows reversed" },
        {476 , "regular payment that is not wages; to make such a payment" },
        {477 , "having to do with life; necessary to life; causing death, failure or ruin; lively" },
        {478 , "of a city or state; having something to do in the affairs of a city or town" },
        {479 , "spoken; using speech; of the mouth" },
          {480 , "pleased with oneself; self-satisfied" },
        {481 , "an insect with a slender* body and powerful sting" },
        {482 , "restore to good condition; make over in a new form; restore to former standing, rank, reputation, etc." },
        {483 , "word of honor; conditional freedom; to free (a prisoner) under certain conditions" },
        {484 , "straight up and down with reference to the horizon" },
        {485 , "a great number; a crowd" },
        {486 , "name as a candidate for office; appoint to an office" },
        {487 , "possibility as opposed to actuality; capability of coming into being or action; possible as opposed to actual; capable of coming into being or action" },
        {488 , "place where bodies of unknown persons found dead are kept" },
        {489 , "took up all the attention" },
        {490 , "coverings and cushions for furniture" },
        {491 , "lack of interest, care, or attention" },
          {492 , "keep; keep up; carry on; uphold; support; declare to be true" },
        {493 , "treat coldly, scornfully, or with contempt; cold treatment" },
        {494 , "last; keep on; undergo; bear; stand" },
        {495 , "very great anger; rage" },
        {496 , "lay open; uncover; leave unprotected; show openly" },
        {497 , "story coming from the past, which many people have believed" },
        {498 , "consider carefully" },
        {499 , "give up; yield; submit" },
        {500 , "acting with force or violence" },
        {501 , "platform built on the shore or out from the shore beside which ships can load or unload" },
        {502 , "change for the better; correct; change" },
        {503 , "piece of paper used in voting; the whole number of votes cast; the method of secret voting; to vote or decide by using ballots" },
        };

    #endregion

    #region private Variables

    private static int iLevelH;
    private float currCountdownValueH;
    private int iSetH;
    int[] ScoreH = new int[21];
    bool[] CheckSetTextH = new bool[21];
    bool[] CheckSetDictH = new bool[21];
    bool[] CheckFullDictRandomH = new bool[21];
    bool[] CheckFullCodeMeanH = new bool[21];
    bool[] CheckDictRandomIsOneH = new bool[21];

    private const int LockH = 19;
    private IEnumerator coH;

    private const String PpsTrueH0 = "PpsTrueH0"; private const String PpsTrueH1 = "PpsTrueH1"; private const String PpsTrueH2 = "PpsTrueH2"; private const String PpsTrueH3 = "PpsTrueH3"; private const String PpsTrueH4 = "PpsTrueH4"; private const String PpsTrueH5 = "PpsTrueH5"; private const String PpsTrueH6 = "PpsTrueH6"; private const String PpsTrueH7 = "PpsTrueH7"; private const String PpsTrueH8 = "PpsTrueH8"; private const String PpsTrueH9 = "PpsTrueH9"; private const String PpsTrueH10 = "PpsTrueH10"; private const String PpsTrueH11 = "PpsTrueH11"; private const String PpsTrueH12 = "PpsTrueH12"; private const String PpsTrueH13 = "PpsTrueH13"; private const String PpsTrueH14 = "PpsTrueH14"; private const String PpsTrueH15 = "PpsTrueH15"; private const String PpsTrueH16 = "PpsTrueH16"; private const String PpsTrueH17 = "PpsTrueH17"; private const String PpsTrueH18 = "PpsTrueH18"; private const String PpsTrueH19 = "PpsTrueH19"; private const String PpsTrueH20 = "PpsTrueH20";
    private const String PpsFalseH0 = "PpsFalseH0"; private const String PpsFalseH1 = "PpsFalseH1"; private const String PpsFalseH2 = "PpsFalseH2"; private const String PpsFalseH3 = "PpsFalseH3"; private const String PpsFalseH4 = "PpsFalseH4"; private const String PpsFalseH5 = "PpsFalseH5"; private const String PpsFalseH6 = "PpsFalseH6"; private const String PpsFalseH7 = "PpsFalseH7"; private const String PpsFalseH8 = "PpsFalseH8"; private const String PpsFalseH9 = "PpsFalseH9"; private const String PpsFalseH10 = "PpsFalseH10"; private const String PpsFalseH11 = "PpsFalseH11"; private const String PpsFalseH12 = "PpsFalseH12"; private const String PpsFalseH13 = "PpsFalseH13"; private const String PpsFalseH14 = "PpsFalseH14"; private const String PpsFalseH15 = "PpsFalseH15"; private const String PpsFalseH16 = "PpsFalseH16"; private const String PpsFalseH17 = "PpsFalseH17"; private const String PpsFalseH18 = "PpsFalseH18"; private const String PpsFalseH19 = "PpsFalseH19"; private const String PpsFalseH20 = "PpsFalseH20";
    private const String PpsScoresH0 = "PpsScoresH0"; private const String PpsScoresH1 = "PpsScoresH1"; private const String PpsScoresH2 = "PpsScoresH2"; private const String PpsScoresH3 = "PpsScoresH3"; private const String PpsScoresH4 = "PpsScoresH4"; private const String PpsScoresH5 = "PpsScoresH5"; private const String PpsScoresH6 = "PpsScoresH6"; private const String PpsScoresH7 = "PpsScoresH7"; private const String PpsScoresH8 = "PpsScoresH8"; private const String PpsScoresH9 = "PpsScoresH9"; private const String PpsScoresH10 = "PpsScoresH10"; private const String PpsScoresH11 = "PpsScoresH11"; private const String PpsScoresH12 = "PpsScoresH12"; private const String PpsScoresH13 = "PpsScoresH13"; private const String PpsScoresH14 = "PpsScoresH14"; private const String PpsScoresH15 = "PpsScoresH15"; private const String PpsScoresH16 = "PpsScoresH16"; private const String PpsScoresH17 = "PpsScoresH17"; private const String PpsScoresH18 = "PpsScoresH18"; private const String PpsScoresH19 = "PpsScoresH19"; private const String PpsScoresH20 = "PpsScoresH20";

    private string PpsTrueH, PpsFalseH,PpsScoresH, PpsLockH;

    private const String PpsLockH1 = "PpsLockH1"; private const String PpsLockH2 = "PpsLockH2"; private const String PpsLockH3 = "PpsLockH3"; private const String PpsLockH4 = "PpsLockH4"; private const String PpsLockH5 = "PpsLockH5"; private const String PpsLockH6 = "PpsLockH6"; private const String PpsLockH7 = "PpsLockH7"; private const String PpsLockH8 = "PpsLockH8"; private const String PpsLockH9 = "PpsLockH9"; private const String PpsLockH10 = "PpsLockH10"; private const String PpsLockH11 = "PpsLockH11"; private const String PpsLockH12 = "PpsLockH12"; private const String PpsLockH13 = "PpsLockH13"; private const String PpsLockH14 = "PpsLockH14"; private const String PpsLockH15 = "PpsLockH15"; private const String PpsLockH16 = "PpsLockH16"; private const String PpsLockH17 = "PpsLockH17"; private const String PpsLockH18 = "PpsLockH18"; private const String PpsLockH19 = "PpsLockH19"; private const String PpsLockH20 = "PpsLockH20";

    MainMenu menu;
    LinksVocabolary sounds;
    #endregion

    #region Awake
    private void Awake()
    {
        menu = gameObject.GetComponentInParent<MainMenu>();
        sounds = GameObject.Find("GameControlerHigh").gameObject.GetComponent<LinksVocabolary>();
    }
    #endregion

    #region Start
    void Start()
    {
        ManageBooleans();
        ManageLockLevels();
    }

    private void ManageLockLevels()
    {
        for (int i = 0; i < 20; i++)
        {
            ChangeObscuredPrefsKey(i+1);
            if (ObscuredPrefs.HasKey(PpsLockH))
            {
                if (ObscuredPrefs.GetInt(PpsLockH) == 1)
                {
                    ButtonsLevels[i + 1].interactable = true;
                    PanelLock[i].gameObject.SetActive(false);
                }
            }
        }
        iLevelH = 0;
    }

    private void ManageBooleans()
    {
        for (int i = 0; i < 21; i++)
        {
            CheckFullDictRandomH[i] = false;
            CheckSetTextH[i] = false;
            CheckSetDictH[i] = true;
            CheckDictRandomIsOneH[i] = true;
        }
    }
    #endregion

    #region Canvas Game

    #region Back to Main
    public void BackofMenuLevelsHightoSwitchMenu()
    {
        menu.PlayBack();
        menu.Faryar.gameObject.SetActive(true);
        menu.GameMenuLevelHolderHigh.gameObject.SetActive(false);
        menu.GameSwitchHolder.gameObject.SetActive(true);
    }
    #endregion

    #region Back to MenuLevels
    public void BackofGametoMenuLevels()
    {
            if (DictRandomH[iLevelH].Count > 0)
            {
                DictRandomH[iLevelH].Clear();
            }
            CheckSetDictH[iLevelH] = true;
            SetObscuredPrefs(iLevelH);
            StopAllCoroutines();
            menu.PlayBack();
            GamePlay.gameObject.SetActive(false);
            menu.GameMenuLevelHolderHigh.gameObject.SetActive(true);
            Table.gameObject.SetActive(false);
            menu.Background.gameObject.SetActive(true);
            TextVocab.gameObject.SetActive(false);
            TextWord.gameObject.SetActive(false);
    }

    public void FalseActiveGameObjects()
    {
        for (int i = 0; i < 21; i++)
        {
            Text_ScoreH[i].gameObject.SetActive(false);
            Text_ScoresH[i].gameObject.SetActive(false);
            Text_DictRandomCountH[i].gameObject.SetActive(false);
            Text_DictFalseH[i].gameObject.SetActive(false);
            Text_DictTrueH[i].gameObject.SetActive(false);
            TextMassageFalseH[i].gameObject.SetActive(false);
            TextMassageTrueH[i].gameObject.SetActive(false);
            PanelOpenLevel[i].gameObject.SetActive(false);
        }
    }
    public void TrueActiveGaObsiLevel()
    {
        Text_ScoreH[iLevelH].gameObject.SetActive(true);
        Text_ScoresH[iLevelH].gameObject.SetActive(true);
        Text_DictRandomCountH[iLevelH].gameObject.SetActive(true);
        Text_DictFalseH[iLevelH].gameObject.SetActive(true);
        Text_DictTrueH[iLevelH].gameObject.SetActive(true);
        PanelOpenLevel[iLevelH].gameObject.SetActive(true);
    }

    #endregion

    #region Play Sound
    public void PlayStartSet()
    {
        if (StartSet != null && audioSource != null)
        {
            audioSource.PlayOneShot(StartSet);
        }
    }
    public void PlayTimeOut()
    {
        if (TimeOut != null && audioSource != null)
        {
            audioSource.PlayOneShot(TimeOut);
        }
    }
    #endregion

    #endregion

    #region Click Button Levels


    #region Levels Buttons
    public void Level_1_Button()
    {
        iLevelH = 0;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(0, 24);
        SetActiveFunction();
    }
    public void Level_2_Button()
    {
        iLevelH = 1;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(24, 48);
        SetActiveFunction();
    }
    public void Level_3_Button()
    {
        iLevelH = 2;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(48, 72);
        SetActiveFunction();
    }
    public void Level_4_Button()
    {
        iLevelH = 3;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(72, 96);
        SetActiveFunction();
    }
    public void Level_5_Button()
    {
        iLevelH = 4;
        CheckCreateDicts();
        SetActiveFunction();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(96, 120);
    }
    public void Level_6_Button()
    {
        iLevelH = 5;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(120, 144);
        SetActiveFunction();
    }
    public void Level_7_Button()
    {
        iLevelH = 6;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(144, 168);
        SetActiveFunction();
    }
    public void Level_8_Button()
    {
        iLevelH = 7;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(168, 192);
        SetActiveFunction();
    }
    public void Level_9_Button()
    {
        iLevelH = 8;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(192, 216);
        SetActiveFunction();
    }
    public void Level_10_Button()
    {
        iLevelH = 9;
        CheckCreateDicts();
        SetActiveFunction();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(216, 240);
    }
    public void Level_11_Button()
    {
        iLevelH = 10;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(240, 264);
        SetActiveFunction();
    }
    public void Level_12_Button()
    {
        iLevelH = 11;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(264, 288);
        SetActiveFunction();
    }
    public void Level_13_Button()
    {
        iLevelH = 12;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(288, 312);
        SetActiveFunction();
    }
    public void Level_14_Button()
    {
        iLevelH = 13;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(312, 336);
        SetActiveFunction();
    }
    public void Level_15_Button()
    {
        iLevelH = 14;
        CheckCreateDicts();

        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(336, 360);
        SetActiveFunction();
    }
    public void Level_16_Button()
    {
        iLevelH = 15;
        CheckCreateDicts();
        SetActiveFunction();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(360, 384);
    }
    public void Level_17_Button()
    {
        iLevelH = 16;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(384, 408);
        SetActiveFunction();
    }
    public void Level_18_Button()
    {
        iLevelH = 17;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(408, 432);
        SetActiveFunction();
    }
    public void Level_19_Button()
    {
        iLevelH = 18;
        CheckCreateDicts();
        SetActiveFunction();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(432, 456);
    }
    public void Level_20_Button()
    {
        iLevelH = 19;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(456, 480);
        SetActiveFunction();
    }
    public void Level_21_Button()
    {
        iLevelH = 20;
        CheckCreateDicts();
        if (DictRandomH[iLevelH].Count == 0)
            CreateRandomDic(480, 504);
        SetActiveFunction();
    }
    #endregion

    #region UnLockPanels And Active Buttons 
    public void UnLockNextLevelHigh()
    {
        RepeatPanel.gameObject.SetActive(false);
        BackofGametoMenuLevels();
        if (iLevelH < 20)
        {
            ChangeObscuredPrefsKey(iLevelH+1);
            ObscuredPrefs.SetInt(PpsLockH, 1);
            ObscuredPrefs.Save();
            ButtonsLevels[iLevelH + 1].interactable = true;
            PanelLock[iLevelH].gameObject.SetActive(false);
            ButtonsLevels[iLevelH + 1].onClick.Invoke();
        }
        menu.PlayClick();
    }
    #endregion

    private void SetActiveFunction()
    {
        FalseActiveGameObjects();
        TrueActiveGaObsiLevel();
        menu.PlayClick();

        Text_Timer.text = "20";
        Text_Levels1.text = (iLevelH + 1).ToString();
        Text_Levels2.text = (iLevelH + 1).ToString();

        RepeatPanel.gameObject.SetActive(false);
        GamePlay.gameObject.SetActive(true);
        menu.GameMenuLevelHolderHigh.gameObject.SetActive(false);
        Table.gameObject.SetActive(true);
        menu.Background.gameObject.SetActive(false);
        TextWord.gameObject.SetActive(false);

        if (DictRandomH[iLevelH].Count > 0)
        {
            Text_ScoreH[iLevelH].text = ScoreH[iLevelH].ToString();
        }
        else if (DictRandomH[iLevelH].Count == 0)
        {
            Text_ScoreH[iLevelH].text = "";
            Text_DictRandomCountH[iLevelH].text = "";
        }

        if (DictRandomH[iLevelH].Count == 24)
        {
            StartGameButton.gameObject.SetActive(true);
            SetTextButton.gameObject.SetActive(false);
        }
        else
        {
            StartGameButton.gameObject.SetActive(false);
            SetTextButton.gameObject.SetActive(true);
        }
        GetObscuredPrefsResult(iLevelH);
    }

    private void CheckCreateDicts()
    {
        if (DictRandomH[iLevelH] == null)
        {
            DictRandomH[iLevelH] = new Dictionary<int, string>();
        }
        if (DictTrueH[iLevelH] == null)
        {
            DictTrueH[iLevelH] = new Dictionary<int, string>();
        }
        if (DictFalseH[iLevelH] == null)
        {
            DictFalseH[iLevelH] = new Dictionary<int, string>();
        }
    }

    private void CreateRandomDic(int min, int max)
    {

        System.Random r = new System.Random();

        for (int i = 0; i < 200; i++)
        {
            int randNum = r.Next(min, max);
            if (!DictRandomH[iLevelH].Keys.Contains(WordDicH.ElementAt(randNum).Key))
                DictRandomH[iLevelH].Add(WordDicH.ElementAt(randNum).Key, WordDicH.ElementAt(randNum).Value);
        }
        CheckFullDictRandomH[iLevelH] = true;
    }
    #endregion

    #region Set Random Text to Jorchin

    public void StartGame()
    {
        ChangeObscuredPrefsKey(iLevelH);
        if (IntParseFast(ObscuredPrefs.GetString(PpsScoresH)) > LockH)
        {
            OpenPanelRepeat();
        }
        else
        {
            RepeatLevelButton();
            StartGameButton.gameObject.SetActive(false);
            SetTextButton.gameObject.SetActive(true);
            Text_ScoreH[iLevelH].text = "0";
        }
    }

    private void SetTextFunction()
    {
        if (CheckDictRandomIsOneH[iLevelH] == true)
        {
            if (CheckFullDictRandomH[iLevelH] == true)
            {
                Text_DictRandomCountH[iLevelH].text = DictRandomH[iLevelH].Count.ToString();
                TextVocab.gameObject.SetActive(true);
                TextWord.gameObject.SetActive(true);

                if (DictRandomH[iLevelH].Count > 0)
                {
                    if (CheckSetDictH[iLevelH] == true)
                    {                    
                        VocabJorchin.GetComponent<Animator>().enabled = true;
                        VocabJorchin.GetComponent<Animator>().Play("Vocab_Jorchin");
                        WordJorchin.GetComponent<Animator>().enabled = true;
                        WordJorchin.GetComponent<Animator>().Play("Word_Jorchin");


                        PlayStartSet();
                        CheckSetTextH[iLevelH] = true;
                        coH = Countdown();
                        StopAllCoroutines();
                        StartCoroutine(coH);
                        System.Random r = new System.Random();
                        int random = r.Next(0, DictRandomH[iLevelH].Count);
                        int i = DictRandomH[iLevelH].Keys.ElementAt(random);
                        iSetH = i;
                        TextVocab.text = VocabDic.ElementAt(i).Value;
                        CheckFullCodeMeanH[iLevelH] = true;
                        TextWord.text = "";
                        if (DictRandomH[iLevelH].Count == 1)
                        {
                            CheckDictRandomIsOneH[iLevelH] = false;
                        }
                        DictRandomH[iLevelH].Remove(i);
                        CheckSetDictH[iLevelH] = false;
                        if (DictRandomH[iLevelH].Count == 0 && currCountdownValueH > 0)
                        {
                            BackButton.interactable = false;
                        }
                        else
                        {
                            BackButton.interactable = true;
                        }
                    }
                    else if (CheckSetDictH[iLevelH] == false)
                    {
                        if (CheckFullCodeMeanH[iLevelH] == true)
                        {
                            SetDictFalse();
                            CheckSetDictH[iLevelH] = true;
                            SetTextFunction();
                        }
                    }
                }

                else if (DictRandomH[iLevelH].Count == 0)
                {
                    StopCoroutine(coH);
                    Text_Timer.text = "0";
                    CheckFullDictRandomH[iLevelH] = false;
                    SetObscuredPrefs(iLevelH);
                    TextWord.gameObject.SetActive(false);
                    TextWord.text = "";
                    TextVocab.text = "";
                    CheckFullCodeMeanH[iLevelH] = false;
                    SetTextFunction();
                }
            }
            else if (CheckFullDictRandomH[iLevelH] == false)
            {
                OpenPanelRepeat();
            }
        }
    }

    private void OpenPanelRepeat()
    {
        RepeatPanel.gameObject.SetActive(true);
        ChangeObscuredPrefsKey(iLevelH);
        if (IntParseFast(ObscuredPrefs.GetString(PpsScoresH)) > LockH)
        {
            PanelOpenLevel[iLevelH].gameObject.SetActive(false);
        }
        if (iLevelH == 20)
        {
            ButtonNextLevel.gameObject.SetActive(false);
            for (int i = 0; i < 21; i++)
            {
                PanelOpenLevel[i].gameObject.SetActive(false);
            }
        }
    }

    public static int IntParseFast(string value)
    {
        int result = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char letter = value[i];
            result = 10 * result + (letter - 48);
        }
        return result;
    }

    public void RepeatLevelButton()
    {
        if (ObscuredPrefs.HasKey(PpsScoresH))
        {
            ChangeObscuredPrefsKey(iLevelH);
            ObscuredPrefs.DeleteKey(PpsTrueH);
            ObscuredPrefs.DeleteKey(PpsFalseH);
            ObscuredPrefs.DeleteKey(PpsScoresH);
            DictFalseH[iLevelH].Clear();
            DictTrueH[iLevelH].Clear();
        }
        Text_DictRandomCountH[iLevelH].text = null;
        Text_ScoresH[iLevelH].text = null;
        Text_DictFalseH[iLevelH].text = null;
        Text_DictTrueH[iLevelH].text = null;
        TextMassageFalseH[iLevelH].text = null;
        TextMassageTrueH[iLevelH].text = null;
        BackofGametoMenuLevels();
        ButtonsLevels[iLevelH].onClick.Invoke();
        ScoreH[iLevelH] = 0;
        CheckFullDictRandomH[iLevelH] = true;
    }

    public IEnumerator Countdown(float countdownValue = 20)
    {

        currCountdownValueH = countdownValue;
        while (currCountdownValueH >= 0)
        {
            Text_Timer.text = currCountdownValueH.ToString();
            yield return new WaitForSeconds(1.0f);
            currCountdownValueH--;
        }
        if (currCountdownValueH < 0)
        {
            VocabJorchin.GetComponent<Animator>().enabled = false;        
            WordJorchin.GetComponent<Animator>().enabled = false;
            PlayTimeOut();
            StopCoroutine(coH);
            CheckSetTextH[iLevelH] = false;
            SetDictFalse();
            SetObscuredPrefs(iLevelH);
            TextVocab.gameObject.SetActive(false);
            TextWord.gameObject.SetActive(false);
            BackButton.interactable = true;
        }

    }

    public void SetText()
    {
        SetTextFunction();
    }
    #endregion

    #region Check Jorchin Button

    public void CheckButton()
    {
        if (CheckSetTextH[iLevelH] == true)
        {
            if (TextWord.text.ToLower() == WordDicH.ElementAt(iSetH).Value.ToLower())
            {
                VocabJorchin.GetComponent<Animator>().Play("OkVocab_Jorchin");
                WordJorchin.GetComponent<Animator>().Play("OkWord_Jorchin");

                sounds.PlaySounds(sounds.WordsClip[iSetH]);
                StopCoroutine(coH);
                SetDictTrue();

                ScoreH[iLevelH] += 1;
                Text_ScoreH[iLevelH].text = ScoreH[iLevelH].ToString();
                if (ScoreH[iLevelH] != 0)
                {
                    Text_ScoresH[iLevelH].text = Text_ScoreH[iLevelH].text.ToString();
                }
                CheckSetTextH[iLevelH] = false;
                SetObscuredPrefs(iLevelH);
                BackButton.interactable = true;
            }
            else
            {
                if (currCountdownValueH > 0)
                {
                    VocabJorchin.GetComponent<Animator>().Play("Vocab_Jorchin");
                    WordJorchin.GetComponent<Animator>().Play("Word_Jorchin");

                    PlayStartSet();
                    TextWord.text = "";
                    CheckSetTextH[iLevelH] = true;
                }
            }
        }
    }

    #region Set Data

    public void SetDictTrue()
    {
        if (DictRandomH[iLevelH].Count >= 0)
        {
            if (!DictTrueH[iLevelH].Keys.Contains(WordDicH.ElementAt(iSetH).Key))
            {
                DictTrueH[iLevelH].Add(WordDicH.ElementAt(iSetH).Key, WordDicH.ElementAt(iSetH).Value);
            }
            CheckSetDictH[iLevelH] = true;
            CheckDictRandomIsOneH[iLevelH] = true;
        }
    }

    public void SetDictFalse()
    {
        if (DictRandomH[iLevelH].Count >= 0)
        {
            if (!DictFalseH[iLevelH].Keys.Contains(WordDicH.ElementAt(iSetH).Key))
            {
                DictFalseH[iLevelH].Add(WordDicH.ElementAt(iSetH).Key, WordDicH.ElementAt(iSetH).Value);
            }
            CheckSetDictH[iLevelH] = true;
            CheckDictRandomIsOneH[iLevelH] = true;
        }
    }

    #endregion

    #endregion

    #region Panel Result Levels 

    public void PrintResult()
    {
        ResultPanel.gameObject.SetActive(true);
        SetTextPrint();
    }

    private void SetTextPrint()
    {
        ChangeObscuredPrefsKey(iLevelH);
        Text_Levels1.text = (iLevelH + 1).ToString();
        Text_ScoresH[iLevelH].text = ObscuredPrefs.GetString(PpsScoresH).ToString();
        if (DictRandomH[iLevelH].Count >= 0)
        {
            if (DictTrueH[iLevelH].Count != 0 && ObscuredPrefs.HasKey(PpsScoresH))
            {
                foreach (KeyValuePair<int, string> pair in DictTrueH[iLevelH])
                {
                    if (!Text_DictTrueH[iLevelH].text.Contains(pair.Value.ToLower()))
                    {
                        Text_DictTrueH[iLevelH].text += string.Format("{0}\n", pair.Value.ToLower());
                    }
                }
            }
            else if (ObscuredPrefs.HasKey(PpsFalseH) && DictTrueH[iLevelH].Count == 0 && DictFalseH[iLevelH].Count == 24)
            {
                TextMassageTrueH[iLevelH].gameObject.SetActive(true);
                TextMassageTrueH[iLevelH].text = "Don't Play\nWithout Reading";
            }

            if (DictFalseH[iLevelH].Count != 0 && ObscuredPrefs.HasKey(PpsScoresH))
            {
                foreach (KeyValuePair<int, string> pair in DictFalseH[iLevelH])
                {
                    if (!Text_DictFalseH[iLevelH].text.Contains(pair.Value.ToLower()))
                    {
                        Text_DictFalseH[iLevelH].text += string.Format("{0}\n", pair.Value.ToLower());
                    }
                }
            }
            else if (ObscuredPrefs.HasKey(PpsTrueH) && DictFalseH[iLevelH].Count == 0 && DictTrueH[iLevelH].Count == 24)
            {
                TextMassageFalseH[iLevelH].gameObject.SetActive(true);
                TextMassageFalseH[iLevelH].text = "Very Well\nWas Wonderful";
            }

            SetObscuredPrefs(iLevelH);

            GetObscuredPrefsResult(iLevelH);
        }
    }

    #endregion

    #region Sava Data

    private void ChangeObscuredPrefsKey(int i)
    {
        switch (i)
        {
            case 0:
                PpsTrueH = PpsTrueH0;
                PpsFalseH = PpsFalseH0;
                PpsScoresH = PpsScoresH0;
                break;
            case 1:
                PpsTrueH = PpsTrueH1;
                PpsFalseH = PpsFalseH1;
                PpsScoresH = PpsScoresH1;
                PpsLockH = PpsLockH1;
                break;
            case 2:
                PpsTrueH = PpsTrueH2;
                PpsFalseH = PpsFalseH2;
                PpsScoresH = PpsScoresH2;
                PpsLockH = PpsLockH2;
                break;
            case 3:
                PpsTrueH = PpsTrueH3;
                PpsFalseH = PpsFalseH3;
                PpsScoresH = PpsScoresH3;
                PpsLockH = PpsLockH3;
                break;
            case 4:
                PpsTrueH = PpsTrueH4;
                PpsFalseH = PpsFalseH4;
                PpsScoresH = PpsScoresH4;
                PpsLockH = PpsLockH4;
                break;
            case 5:
                PpsTrueH = PpsTrueH5;
                PpsFalseH = PpsFalseH5;
                PpsScoresH = PpsScoresH5;
                PpsLockH = PpsLockH5;
                break;
            case 6:
                PpsTrueH = PpsTrueH6;
                PpsFalseH = PpsFalseH6;
                PpsScoresH = PpsScoresH6;
                PpsLockH = PpsLockH6;
                break;
            case 7:
                PpsTrueH = PpsTrueH7;
                PpsFalseH = PpsFalseH7;
                PpsScoresH = PpsScoresH7;
                PpsLockH = PpsLockH7;
                break;
            case 8:
                PpsTrueH = PpsTrueH8;
                PpsFalseH = PpsFalseH8;
                PpsScoresH = PpsScoresH8;
                PpsLockH = PpsLockH8;
                break;
            case 9:
                PpsTrueH = PpsTrueH9;
                PpsFalseH = PpsFalseH9;
                PpsScoresH = PpsScoresH9;
                PpsLockH = PpsLockH9;
                break;
            case 10:
                PpsTrueH = PpsTrueH10;
                PpsFalseH = PpsFalseH10;
                PpsScoresH = PpsScoresH10;
                PpsLockH = PpsLockH10;
                break;
            case 11:
                PpsTrueH = PpsTrueH11;
                PpsFalseH = PpsFalseH11;
                PpsScoresH = PpsScoresH11;
                PpsLockH = PpsLockH11;
                break;
            case 12:
                PpsTrueH = PpsTrueH12;
                PpsFalseH = PpsFalseH12;
                PpsScoresH = PpsScoresH12;
                PpsLockH = PpsLockH12;
                break;
            case 13:
                PpsTrueH = PpsTrueH13;
                PpsFalseH = PpsFalseH13;
                PpsScoresH = PpsScoresH13;
                PpsLockH = PpsLockH13;
                break;
            case 14:
                PpsTrueH = PpsTrueH14;
                PpsFalseH = PpsFalseH14;
                PpsScoresH = PpsScoresH14;
                PpsLockH = PpsLockH14;
                break;
            case 15:
                PpsTrueH = PpsTrueH15;
                PpsFalseH = PpsFalseH15;
                PpsScoresH = PpsScoresH15;
                PpsLockH = PpsLockH15;
                break;
            case 16:
                PpsTrueH = PpsTrueH16;
                PpsFalseH = PpsFalseH16;
                PpsScoresH = PpsScoresH16;
                PpsLockH = PpsLockH16;
                break;
            case 17:
                PpsTrueH = PpsTrueH17;
                PpsFalseH = PpsFalseH17;
                PpsScoresH = PpsScoresH17;
                PpsLockH = PpsLockH17;
                break;
            case 18:
                PpsTrueH = PpsTrueH18;
                PpsFalseH = PpsFalseH18;
                PpsScoresH = PpsScoresH18;
                PpsLockH = PpsLockH18;
                break;
            case 19:
                PpsTrueH = PpsTrueH19;
                PpsFalseH = PpsFalseH19;
                PpsScoresH = PpsScoresH19;
                PpsLockH = PpsLockH19;
                break;
            case 20:
                PpsTrueH = PpsTrueH20;
                PpsFalseH = PpsFalseH20;
                PpsScoresH = PpsScoresH20;
                PpsLockH = PpsLockH20;
                break;
        }
    }


    public void GetObscuredPrefsResult(int i)
    {
        for (i = 0; i < 21; i++)
        {
            ChangeObscuredPrefsKey(i);
            Text_DictTrueH[i].text = ObscuredPrefs.GetString(PpsTrueH).ToString();
            Text_DictFalseH[i].text = ObscuredPrefs.GetString(PpsFalseH).ToString();
            Text_ScoresH[i].text = ObscuredPrefs.GetString(PpsScoresH).ToString();
        }
    }



    public void SetObscuredPrefs(int i)
    {
        for (i = 0; i < 21; i++)
        {
            ChangeObscuredPrefsKey(i);
            ObscuredPrefs.SetString(PpsScoresH, Text_ScoresH[i].text);
            ObscuredPrefs.SetString(PpsTrueH, Text_DictTrueH[i].text);
            ObscuredPrefs.SetString(PpsFalseH, Text_DictFalseH[i].text);
        }
        ObscuredPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SetObscuredPrefs(iLevelH);
    }

    public void ResetObscuredPrefsofGameH()
    {
        for (int i = 0; i < 21; i++)
        {
            ChangeObscuredPrefsKey(i);
            ObscuredPrefs.DeleteKey(PpsTrueH);
            ObscuredPrefs.DeleteKey(PpsFalseH);
            ObscuredPrefs.DeleteKey(PpsScoresH);
            ObscuredPrefs.DeleteKey(PpsLockH);
        }
    }
    public void ResetGameHigh()
    {
        menu.PlayClick();
        ResetObscuredPrefsofGameH();
        for (int i = 0; i < 20; i++)
        {
            PanelLock[i].gameObject.SetActive(true);
            ButtonsLevels[i + 1].interactable = false;
        }
        for (int i = 0; i < 21; i++)
        {
            Text_DictRandomCountH[i].text = "";
            Text_ScoreH[i].text = "";
        }
    }

    #endregion
}
