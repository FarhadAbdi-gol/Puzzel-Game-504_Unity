
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class LinksVocabolary : MonoBehaviour, IPointerClickHandler
{

    TextMeshProUGUI textMeshPro504;
    Canvas canvas;
    Camera _camera;
    public AudioSource audiosource;
    public AudioClip[] WordsClip;

    void Awake()
    {
      
        textMeshPro504 = gameObject.GetComponent<TextMeshProUGUI>();
        canvas = gameObject.GetComponentInParent<Canvas>();
        _camera = gameObject.GetComponentInParent<Camera>();

        if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
        {
            _camera = null;
        }
        else
        {
            _camera = canvas.worldCamera;
        }
    }

    public void PlaySounds(AudioClip sound)
    {
        if(audiosource!=null)
        audiosource.PlayOneShot(sound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex504 = TMP_TextUtilities.FindIntersectingLink(textMeshPro504, Input.mousePosition, _camera);
        if (linkIndex504 != -1)
        {
            TMP_LinkInfo linkInfo504 = textMeshPro504.textInfo.linkInfo[linkIndex504];
            switch (linkInfo504.GetLinkID())
            {
                //Story 1
                case "Aa":
                    {
                        PlaySounds(WordsClip[0]);
                    }
                    break;
                case "Ab":
                    {
                        PlaySounds(WordsClip[1]);
                    }
                    break;
                case "Ac":
                    {
                        PlaySounds(WordsClip[2]);
                    }
                    break;
                case "Ad":
                    {
                        PlaySounds(WordsClip[3]);
                    }
                    break;
                case "Ae":
                    {
                        PlaySounds(WordsClip[4]);
                    }
                    break;
                case "Af":
                    {
                        PlaySounds(WordsClip[5]);
                    }
                    break;
                case "Ag":
                    {
                        PlaySounds(WordsClip[6]);
                    }
                    break;
                case "Ah":
                    {
                        PlaySounds(WordsClip[7]);
                    }
                    break;
                case "Ai":
                    {
                        PlaySounds(WordsClip[8]);
                    }
                    break;
                case "Aj":
                    {
                        PlaySounds(WordsClip[9]);
                    }
                    break;
                case "Ak":
                    {
                        PlaySounds(WordsClip[10]);
                    }
                    break;
                case "Al":
                    {
                        PlaySounds(WordsClip[11]);
                    }
                    break;
                //Story 2
                case "Ba":
                    {
                        PlaySounds(WordsClip[12]);
                    }
                    break;
                case "Bb":
                    {
                        PlaySounds(WordsClip[13]);
                    }
                    break;
                case "Bc":
                    {
                        PlaySounds(WordsClip[14]);
                    }
                    break;
                case "Bd":
                    {
                        PlaySounds(WordsClip[15]);
                    }
                    break;
                case "Be":
                    {
                        PlaySounds(WordsClip[16]);
                    }
                    break;
                case "Bf":
                    {
                        PlaySounds(WordsClip[17]);
                    }
                    break;
                case "Bg":
                    {
                        PlaySounds(WordsClip[18]);
                    }
                    break;
                case "Bh":
                    {
                        PlaySounds(WordsClip[19]);
                    }
                    break;
                case "Bi":
                    {
                        PlaySounds(WordsClip[20]);
                    }
                    break;
                case "Bj":
                    {
                        PlaySounds(WordsClip[21]);
                    }
                    break;
                case "Bk":
                    {
                        PlaySounds(WordsClip[22]);
                    }
                    break;
                case "Bl":
                    {
                        PlaySounds(WordsClip[23]);
                    }
                    break;
                //Story 3
                case "Ca":
                    {
                        PlaySounds(WordsClip[24]);
                    }
                    break;
                case "Cb":
                    {
                        PlaySounds(WordsClip[25]);
                    }
                    break;
                case "Cc":
                    {
                        PlaySounds(WordsClip[26]);
                    }
                    break;
                case "Cd":
                    {
                        PlaySounds(WordsClip[27]);
                    }
                    break;
                case "Ce":
                    {
                        PlaySounds(WordsClip[28]);
                    }
                    break;
                case "Cf":
                    {
                        PlaySounds(WordsClip[29]);
                    }
                    break;
                case "Cg":
                    {
                        PlaySounds(WordsClip[30]);
                    }
                    break;
                case "Ch":
                    {
                        PlaySounds(WordsClip[31]);
                    }
                    break;
                case "Ci":
                    {
                        PlaySounds(WordsClip[32]);
                    }
                    break;
                case "Cj":
                    {
                        PlaySounds(WordsClip[33]);
                    }
                    break;
                case "Ck":
                    {
                        PlaySounds(WordsClip[34]);
                    }
                    break;
                case "Cl":
                    {
                        PlaySounds(WordsClip[35]);
                    }
                    break;
                //Story 4
                case "Da":
                    {
                        PlaySounds(WordsClip[36]);
                    }
                    break;
                case "Db":
                    {
                        PlaySounds(WordsClip[37]);
                    }
                    break;
                case "Dc":
                    {
                        PlaySounds(WordsClip[38]);
                    }
                    break;
                case "Dd":
                    {
                        PlaySounds(WordsClip[39]);
                    }
                    break;
                case "De":
                    {
                        PlaySounds(WordsClip[40]);
                    }
                    break;
                case "Df":
                    {
                        PlaySounds(WordsClip[41]);
                    }
                    break;
                case "Dg":
                    {
                        PlaySounds(WordsClip[42]);
                    }
                    break;
                case "Dh":
                    {
                        PlaySounds(WordsClip[43]);
                    }
                    break;
                case "Di":
                    {
                        PlaySounds(WordsClip[44]);
                    }
                    break;
                case "Dj":
                    {
                        PlaySounds(WordsClip[45]);
                    }
                    break;
                case "Dk":
                    {
                        PlaySounds(WordsClip[46]);
                    }
                    break;
                case "Dl":
                    {
                        PlaySounds(WordsClip[47]);
                    }
                    break;
                //Story 5
                case "Ea":
                    {
                        PlaySounds(WordsClip[48]);
                    }
                    break;
                case "Eb":
                    {
                        PlaySounds(WordsClip[49]);
                    }
                    break;
                case "Ec":
                    {
                        PlaySounds(WordsClip[50]);
                    }
                    break;
                case "Ed":
                    {
                        PlaySounds(WordsClip[51]);
                    }
                    break;
                case "Ee":
                    {
                        PlaySounds(WordsClip[52]);
                    }
                    break;
                case "Ef":
                    {
                        PlaySounds(WordsClip[53]);
                    }
                    break;
                case "Eg":
                    {
                        PlaySounds(WordsClip[54]);
                    }
                    break;
                case "Eh":
                    {
                        PlaySounds(WordsClip[55]);
                    }
                    break;
                case "Ei":
                    {
                        PlaySounds(WordsClip[56]);
                    }
                    break;
                case "Ej":
                    {
                        PlaySounds(WordsClip[57]);
                    }
                    break;
                case "Ek":
                    {
                        PlaySounds(WordsClip[58]);
                    }
                    break;
                case "El":
                    {
                        PlaySounds(WordsClip[59]);
                    }
                    break;
                //Story 6
                case "Fa":
                    {
                        PlaySounds(WordsClip[60]);
                    }
                    break;
                case "Fb":
                    {
                        PlaySounds(WordsClip[61]);
                    }
                    break;
                case "Fc":
                    {
                        PlaySounds(WordsClip[62]);
                    }
                    break;
                case "Fd":
                    {
                        PlaySounds(WordsClip[63]);
                    }
                    break;
                case "Fe":
                    {
                        PlaySounds(WordsClip[64]);
                    }
                    break;
                case "Ff":
                    {
                        PlaySounds(WordsClip[65]);
                    }
                    break;
                case "Fg":
                    {
                        PlaySounds(WordsClip[66]);
                    }
                    break;
                case "Fh":
                    {
                        PlaySounds(WordsClip[67]);
                    }
                    break;
                case "Fi":
                    {
                        PlaySounds(WordsClip[68]);
                    }
                    break;
                case "Fj":
                    {
                        PlaySounds(WordsClip[69]);
                    }
                    break;
                case "Fk":
                    {
                        PlaySounds(WordsClip[70]);
                    }
                    break;
                case "Fl":
                    {
                        PlaySounds(WordsClip[71]);
                    }
                    break;
                //Story 7
                case "Ga":
                    {
                        PlaySounds(WordsClip[72]);
                    }
                    break;
                case "Gb":
                    {
                        PlaySounds(WordsClip[73]);
                    }
                    break;
                case "Gc":
                    {
                        PlaySounds(WordsClip[74]);
                    }
                    break;
                case "Gd":
                    {
                        PlaySounds(WordsClip[75]);
                    }
                    break;
                case "Ge":
                    {
                        PlaySounds(WordsClip[76]);
                    }
                    break;
                case "Gf":
                    {
                        PlaySounds(WordsClip[77]);
                    }
                    break;
                case "Gg":
                    {
                        PlaySounds(WordsClip[78]);
                    }
                    break;
                case "Gh":
                    {
                        PlaySounds(WordsClip[79]);
                    }
                    break;
                case "Gi":
                    {
                        PlaySounds(WordsClip[80]);
                    }
                    break;
                case "Gj":
                    {
                        PlaySounds(WordsClip[81]);
                    }
                    break;
                case "Gk":
                    {
                        PlaySounds(WordsClip[82]);
                    }
                    break;
                case "Gl":
                    {
                        PlaySounds(WordsClip[83]);
                    }
                    break;
                //Story 8
                case "Ha":
                    {
                        PlaySounds(WordsClip[84]);
                    }
                    break;
                case "Hb":
                    {
                        PlaySounds(WordsClip[85]);
                    }
                    break;
                case "Hc":
                    {
                        PlaySounds(WordsClip[86]);
                    }
                    break;
                case "Hd":
                    {
                        PlaySounds(WordsClip[87]);
                    }
                    break;
                case "He":
                    {
                        PlaySounds(WordsClip[88]);
                    }
                    break;
                case "Hf":
                    {
                        PlaySounds(WordsClip[89]);
                    }
                    break;
                case "Hg":
                    {
                        PlaySounds(WordsClip[90]);
                    }
                    break;
                case "Hh":
                    {
                        PlaySounds(WordsClip[91]);
                    }
                    break;
                case "Hi":
                    {
                        PlaySounds(WordsClip[92]);
                    }
                    break;
                case "Hj":
                    {
                        PlaySounds(WordsClip[93]);
                    }
                    break;
                case "Hk":
                    {
                        PlaySounds(WordsClip[94]);
                    }
                    break;
                case "Hl":
                    {
                        PlaySounds(WordsClip[95]);
                    }
                    break;
                //Story 9
                case "Ia":
                    {
                        PlaySounds(WordsClip[96]);
                    }
                    break;
                case "Ib":
                    {
                        PlaySounds(WordsClip[97]);
                    }
                    break;
                case "Ic":
                    {
                        PlaySounds(WordsClip[98]);
                    }
                    break;
                case "Id":
                    {
                        PlaySounds(WordsClip[99]);
                    }
                    break;
                case "Ie":
                    {
                        PlaySounds(WordsClip[100]);
                    }
                    break;
                case "If":
                    {
                        PlaySounds(WordsClip[101]);
                    }
                    break;
                case "Ig":
                    {
                        PlaySounds(WordsClip[102]);
                    }
                    break;
                case "Ih":
                    {
                        PlaySounds(WordsClip[103]);
                    }
                    break;
                case "Ii":
                    {
                        PlaySounds(WordsClip[104]);
                    }
                    break;
                case "Ij":
                    {
                        PlaySounds(WordsClip[105]);
                    }
                    break;
                case "Ik":
                    {
                        PlaySounds(WordsClip[106]);
                    }
                    break;
                case "Il":
                    {
                        PlaySounds(WordsClip[107]);
                    }
                    break;
                //Story 10
                case "Ja":
                    {
                        PlaySounds(WordsClip[108]);
                    }
                    break;
                case "Jb":
                    {
                        PlaySounds(WordsClip[109]);
                    }
                    break;
                case "Jc":
                    {
                        PlaySounds(WordsClip[110]);
                    }
                    break;
                case "Jd":
                    {
                        PlaySounds(WordsClip[111]);
                    }
                    break;
                case "Je":
                    {
                        PlaySounds(WordsClip[112]);
                    }
                    break;
                case "Jf":
                    {
                        PlaySounds(WordsClip[113]);
                    }
                    break;
                case "Jg":
                    {
                        PlaySounds(WordsClip[114]);
                    }
                    break;
                case "Jh":
                    {
                        PlaySounds(WordsClip[115]);
                    }
                    break;
                case "Ji":
                    {
                        PlaySounds(WordsClip[116]);
                    }
                    break;
                case "Jj":
                    {
                        PlaySounds(WordsClip[117]);
                    }
                    break;
                case "Jk":
                    {
                        PlaySounds(WordsClip[118]);
                    }
                    break;
                case "Jl":
                    {
                        PlaySounds(WordsClip[119]);
                    }
                    break;
                //Story 11
                case "Ka":
                    {
                        PlaySounds(WordsClip[120]);
                    }
                    break;
                case "Kb":
                    {
                        PlaySounds(WordsClip[121]);
                    }
                    break;
                case "Kc":
                    {
                        PlaySounds(WordsClip[122]);
                    }
                    break;
                case "Kd":
                    {
                        PlaySounds(WordsClip[123]);
                    }
                    break;
                case "Ke":
                    {
                        PlaySounds(WordsClip[124]);
                    }
                    break;
                case "Kf":
                    {
                        PlaySounds(WordsClip[125]);
                    }
                    break;
                case "Kg":
                    {
                        PlaySounds(WordsClip[126]);
                    }
                    break;
                case "Kh":
                    {
                        PlaySounds(WordsClip[127]);
                    }
                    break;
                case "Ki":
                    {
                        PlaySounds(WordsClip[128]);
                    }
                    break;
                case "Kj":
                    {
                        PlaySounds(WordsClip[129]);
                    }
                    break;
                case "Kk":
                    {
                        PlaySounds(WordsClip[130]);
                    }
                    break;
                case "Kl":
                    {
                        PlaySounds(WordsClip[131]);
                    }
                    break;
                //Story 12
                case "La":
                    {
                        PlaySounds(WordsClip[132]);
                    }
                    break;
                case "Lb":
                    {
                        PlaySounds(WordsClip[133]);
                    }
                    break;
                case "Lc":
                    {
                        PlaySounds(WordsClip[134]);
                    }
                    break;
                case "Ld":
                    {
                        PlaySounds(WordsClip[135]);
                    }
                    break;
                case "Le":
                    {
                        PlaySounds(WordsClip[136]);
                    }
                    break;
                case "Lf":
                    {
                        PlaySounds(WordsClip[137]);
                    }
                    break;
                case "Lg":
                    {
                        PlaySounds(WordsClip[138]);
                    }
                    break;
                case "Lh":
                    {
                        PlaySounds(WordsClip[139]);
                    }
                    break;
                case "Li":
                    {
                        PlaySounds(WordsClip[140]);
                    }
                    break;
                case "Lj":
                    {
                        PlaySounds(WordsClip[141]);
                    }
                    break;
                case "Lk":
                    {
                        PlaySounds(WordsClip[142]);
                    }
                    break;
                case "Ll":
                    {
                        PlaySounds(WordsClip[143]);
                    }
                    break;
                //Story 13
                case "Ma":
                    {
                        PlaySounds(WordsClip[144]);
                    }
                    break;
                case "Mb":
                    {
                        PlaySounds(WordsClip[145]);
                    }
                    break;
                case "Mc":
                    {
                        PlaySounds(WordsClip[146]);
                    }
                    break;
                case "Md":
                    {
                        PlaySounds(WordsClip[147]);
                    }
                    break;
                case "Me":
                    {
                        PlaySounds(WordsClip[148]);
                    }
                    break;
                case "Mf":
                    {
                        PlaySounds(WordsClip[149]);
                    }
                    break;
                case "Mg":
                    {
                        PlaySounds(WordsClip[150]);
                    }
                    break;
                case "Mh":
                    {
                        PlaySounds(WordsClip[151]);
                    }
                    break;
                case "Mi":
                    {
                        PlaySounds(WordsClip[152]);
                    }
                    break;
                case "Mj":
                    {
                        PlaySounds(WordsClip[153]);
                    }
                    break;
                case "Mk":
                    {
                        PlaySounds(WordsClip[154]);
                    }
                    break;
                case "Ml":
                    {
                        PlaySounds(WordsClip[155]);
                    }
                    break;
                //Story 14
                case "Na":
                    {
                        PlaySounds(WordsClip[156]);
                    }
                    break;
                case "Nb":
                    {
                        PlaySounds(WordsClip[157]);
                    }
                    break;
                case "Nc":
                    {
                        PlaySounds(WordsClip[158]);
                    }
                    break;
                case "Nd":
                    {
                        PlaySounds(WordsClip[159]);
                    }
                    break;
                case "Ne":
                    {
                        PlaySounds(WordsClip[160]);
                    }
                    break;
                case "Nf":
                    {
                        PlaySounds(WordsClip[161]);
                    }
                    break;
                case "Ng":
                    {
                        PlaySounds(WordsClip[162]);
                    }
                    break;
                case "Nh":
                    {
                        PlaySounds(WordsClip[163]);
                    }
                    break;
                case "Ni":
                    {
                        PlaySounds(WordsClip[164]);
                    }
                    break;
                case "Nj":
                    {
                        PlaySounds(WordsClip[165]);
                    }
                    break;
                case "Nk":
                    {
                        PlaySounds(WordsClip[166]);
                    }
                    break;
                case "Nl":
                    {
                        PlaySounds(WordsClip[167]);
                    }
                    break;
                //Story 15
                case "Oa":
                    {
                        PlaySounds(WordsClip[168]);
                    }
                    break;
                case "Ob":
                    {
                        PlaySounds(WordsClip[169]);
                    }
                    break;
                case "Oc":
                    {
                        PlaySounds(WordsClip[170]);
                    }
                    break;
                case "Od":
                    {
                        PlaySounds(WordsClip[171]);
                    }
                    break;
                case "Oe":
                    {
                        PlaySounds(WordsClip[172]);
                    }
                    break;
                case "Of":
                    {
                        PlaySounds(WordsClip[173]);
                    }
                    break;
                case "Og":
                    {
                        PlaySounds(WordsClip[174]);
                    }
                    break;
                case "Oh":
                    {
                        PlaySounds(WordsClip[175]);
                    }
                    break;
                case "Oi":
                    {
                        PlaySounds(WordsClip[176]);
                    }
                    break;
                case "Oj":
                    {
                        PlaySounds(WordsClip[177]);
                    }
                    break;
                case "Ok":
                    {
                        PlaySounds(WordsClip[178]);
                    }
                    break;
                case "Ol":
                    {
                        PlaySounds(WordsClip[179]);
                    }
                    break;
                //Story 16
                case "Pa":
                    {
                        PlaySounds(WordsClip[180]);
                    }
                    break;
                case "Pb":
                    {
                        PlaySounds(WordsClip[181]);
                    }
                    break;
                case "Pc":
                    {
                        PlaySounds(WordsClip[182]);
                    }
                    break;
                case "Pd":
                    {
                        PlaySounds(WordsClip[183]);
                    }
                    break;
                case "Pe":
                    {
                        PlaySounds(WordsClip[184]);
                    }
                    break;
                case "Pf":
                    {
                        PlaySounds(WordsClip[185]);
                    }
                    break;
                case "Pg":
                    {
                        PlaySounds(WordsClip[186]);
                    }
                    break;
                case "Ph":
                    {
                        PlaySounds(WordsClip[187]);
                    }
                    break;
                case "Pi":
                    {
                        PlaySounds(WordsClip[188]);
                    }
                    break;
                case "Pj":
                    {
                        PlaySounds(WordsClip[189]);
                    }
                    break;
                case "Pk":
                    {
                        PlaySounds(WordsClip[190]);
                    }
                    break;
                case "Pl":
                    {
                        PlaySounds(WordsClip[191]);
                    }
                    break;
                //Story 17
                case "Qa":
                    {
                        PlaySounds(WordsClip[192]);
                    }
                    break;
                case "Qb":
                    {
                        PlaySounds(WordsClip[193]);
                    }
                    break;
                case "Qc":
                    {
                        PlaySounds(WordsClip[194]);
                    }
                    break;
                case "Qd":
                    {
                        PlaySounds(WordsClip[195]);
                    }
                    break;
                case "Qe":
                    {
                        PlaySounds(WordsClip[196]);
                    }
                    break;
                case "Qf":
                    {
                        PlaySounds(WordsClip[197]);
                    }
                    break;
                case "Qg":
                    {
                        PlaySounds(WordsClip[198]);
                    }
                    break;
                case "Qh":
                    {
                        PlaySounds(WordsClip[199]);
                    }
                    break;
                case "Qi":
                    {
                        PlaySounds(WordsClip[200]);
                    }
                    break;
                case "Qj":
                    {
                        PlaySounds(WordsClip[201]);
                    }
                    break;
                case "Qk":
                    {
                        PlaySounds(WordsClip[202]);
                    }
                    break;
                case "Ql":
                    {
                        PlaySounds(WordsClip[203]);
                    }
                    break;
                //Story 18
                case "Ra":
                    {
                        PlaySounds(WordsClip[204]);
                    }
                    break;
                case "Rb":
                    {
                        PlaySounds(WordsClip[205]);
                    }
                    break;
                case "Rc":
                    {
                        PlaySounds(WordsClip[206]);
                    }
                    break;
                case "Rd":
                    {
                        PlaySounds(WordsClip[207]);
                    }
                    break;
                case "Re":
                    {
                        PlaySounds(WordsClip[208]);
                    }
                    break;
                case "Rf":
                    {
                        PlaySounds(WordsClip[209]);
                    }
                    break;
                case "Rg":
                    {
                        PlaySounds(WordsClip[210]);
                    }
                    break;
                case "Rh":
                    {
                        PlaySounds(WordsClip[211]);
                    }
                    break;
                case "Ri":
                    {
                        PlaySounds(WordsClip[212]);
                    }
                    break;
                case "Rj":
                    {
                        PlaySounds(WordsClip[213]);
                    }
                    break;
                case "Rk":
                    {
                        PlaySounds(WordsClip[214]);
                    }
                    break;
                case "Rl":
                    {
                        PlaySounds(WordsClip[215]);
                    }
                    break;
                //Story 19
                case "Sa":
                    {
                        PlaySounds(WordsClip[216]);
                    }
                    break;
                case "Sb":
                    {
                        PlaySounds(WordsClip[217]);
                    }
                    break;
                case "Sc":
                    {
                        PlaySounds(WordsClip[218]);
                    }
                    break;
                case "Sd":
                    {
                        PlaySounds(WordsClip[219]);
                    }
                    break;
                case "Se":
                    {
                        PlaySounds(WordsClip[220]);
                    }
                    break;
                case "Sf":
                    {
                        PlaySounds(WordsClip[221]);
                    }
                    break;
                case "Sg":
                    {
                        PlaySounds(WordsClip[222]);
                    }
                    break;
                case "Sh":
                    {
                        PlaySounds(WordsClip[223]);
                    }
                    break;
                case "Si":
                    {
                        PlaySounds(WordsClip[224]);
                    }
                    break;
                case "Sj":
                    {
                        PlaySounds(WordsClip[225]);
                    }
                    break;
                case "Sk":
                    {
                        PlaySounds(WordsClip[226]);
                    }
                    break;
                case "Sl":
                    {
                        PlaySounds(WordsClip[227]);
                    }
                    break;
                //Story 20
                case "Ta":
                    {
                        PlaySounds(WordsClip[228]);
                    }
                    break;
                case "Tb":
                    {
                        PlaySounds(WordsClip[229]);
                    }
                    break;
                case "Tc":
                    {
                        PlaySounds(WordsClip[230]);
                    }
                    break;
                case "Td":
                    {
                        PlaySounds(WordsClip[231]);
                    }
                    break;
                case "Te":
                    {
                        PlaySounds(WordsClip[232]);
                    }
                    break;
                case "Tf":
                    {
                        PlaySounds(WordsClip[233]);
                    }
                    break;
                case "Tg":
                    {
                        PlaySounds(WordsClip[234]);
                    }
                    break;
                case "Th":
                    {
                        PlaySounds(WordsClip[235]);
                    }
                    break;
                case "Ti":
                    {
                        PlaySounds(WordsClip[236]);
                    }
                    break;
                case "Tj":
                    {
                        PlaySounds(WordsClip[237]);
                    }
                    break;
                case "Tk":
                    {
                        PlaySounds(WordsClip[238]);
                    }
                    break;
                case "Tl":
                    {
                        PlaySounds(WordsClip[239]);
                    }
                    break;
                //Story 21
                case "Ua":
                    {
                        PlaySounds(WordsClip[240]);
                    }
                    break;
                case "Ub":
                    {
                        PlaySounds(WordsClip[241]);
                    }
                    break;
                case "Uc":
                    {
                        PlaySounds(WordsClip[242]);
                    }
                    break;
                case "Ud":
                    {
                        PlaySounds(WordsClip[243]);
                    }
                    break;
                case "Ue":
                    {
                        PlaySounds(WordsClip[244]);
                    }
                    break;
                case "Uf":
                    {
                        PlaySounds(WordsClip[245]);
                    }
                    break;
                case "Ug":
                    {
                        PlaySounds(WordsClip[246]);
                    }
                    break;
                case "Uh":
                    {
                        PlaySounds(WordsClip[247]);
                    }
                    break;
                case "Ui":
                    {
                        PlaySounds(WordsClip[248]);
                    }
                    break;
                case "Uj":
                    {
                        PlaySounds(WordsClip[249]);
                    }
                    break;
                case "Uk":
                    {
                        PlaySounds(WordsClip[250]);
                    }
                    break;
                case "Ul":
                    {
                        PlaySounds(WordsClip[251]);
                    }
                    break;
                //Story 22
                case "Va":
                    {
                        PlaySounds(WordsClip[252]);
                    }
                    break;
                case "Vb":
                    {
                        PlaySounds(WordsClip[253]);
                    }
                    break;
                case "Vc":
                    {
                        PlaySounds(WordsClip[254]);
                    }
                    break;
                case "Vd":
                    {
                        PlaySounds(WordsClip[255]);
                    }
                    break;
                case "Ve":
                    {
                        PlaySounds(WordsClip[256]);
                    }
                    break;
                case "Vf":
                    {
                        PlaySounds(WordsClip[257]);
                    }
                    break;
                case "Vg":
                    {
                        PlaySounds(WordsClip[258]);
                    }
                    break;
                case "Vh":
                    {
                        PlaySounds(WordsClip[259]);
                    }
                    break;
                case "Vi":
                    {
                        PlaySounds(WordsClip[260]);
                    }
                    break;
                case "Vj":
                    {
                        PlaySounds(WordsClip[261]);
                    }
                    break;
                case "Vk":
                    {
                        PlaySounds(WordsClip[262]);
                    }
                    break;
                case "Vl":
                    {
                        PlaySounds(WordsClip[263]);
                    }
                    break;
                //Story 23
                case "Wa":
                    {
                        PlaySounds(WordsClip[264]);
                    }
                    break;
                case "Wb":
                    {
                        PlaySounds(WordsClip[265]);
                    }
                    break;
                case "Wc":
                    {
                        PlaySounds(WordsClip[266]);
                    }
                    break;
                case "Wd":
                    {
                        PlaySounds(WordsClip[267]);
                    }
                    break;
                case "We":
                    {
                        PlaySounds(WordsClip[268]);
                    }
                    break;
                case "Wf":
                    {
                        PlaySounds(WordsClip[269]);
                    }
                    break;
                case "Wg":
                    {
                        PlaySounds(WordsClip[270]);
                    }
                    break;
                case "Wh":
                    {
                        PlaySounds(WordsClip[271]);
                    }
                    break;
                case "Wi":
                    {
                        PlaySounds(WordsClip[272]);
                    }
                    break;
                case "Wj":
                    {
                        PlaySounds(WordsClip[273]);
                    }
                    break;
                case "Wk":
                    {
                        PlaySounds(WordsClip[274]);
                    }
                    break;
                case "Wl":
                    {
                        PlaySounds(WordsClip[275]);
                    }
                    break;
                //Story 24
                case "Xa":
                    {
                        PlaySounds(WordsClip[276]);
                    }
                    break;
                case "Xb":
                    {
                        PlaySounds(WordsClip[277]);
                    }
                    break;
                case "Xc":
                    {
                        PlaySounds(WordsClip[278]);
                    }
                    break;
                case "Xd":
                    {
                        PlaySounds(WordsClip[279]);
                    }
                    break;
                case "Xe":
                    {
                        PlaySounds(WordsClip[280]);
                    }
                    break;
                case "Xf":
                    {
                        PlaySounds(WordsClip[281]);
                    }
                    break;
                case "Xg":
                    {
                        PlaySounds(WordsClip[282]);
                    }
                    break;
                case "Xh":
                    {
                        PlaySounds(WordsClip[283]);
                    }
                    break;
                case "Xi":
                    {
                        PlaySounds(WordsClip[284]);
                    }
                    break;
                case "Xj":
                    {
                        PlaySounds(WordsClip[285]);
                    }
                    break;
                case "Xk":
                    {
                        PlaySounds(WordsClip[286]);
                    }
                    break;
                case "Xl":
                    {
                        PlaySounds(WordsClip[287]);
                    }
                    break;
                //Story 25
                case "Ya":
                    {
                        PlaySounds(WordsClip[288]);
                    }
                    break;
                case "Yb":
                    {
                        PlaySounds(WordsClip[289]);
                    }
                    break;
                case "Yc":
                    {
                        PlaySounds(WordsClip[290]);
                    }
                    break;
                case "Yd":
                    {
                        PlaySounds(WordsClip[291]);
                    }
                    break;
                case "Ye":
                    {
                        PlaySounds(WordsClip[292]);
                    }
                    break;
                case "Yf":
                    {
                        PlaySounds(WordsClip[293]);
                    }
                    break;
                case "Yg":
                    {
                        PlaySounds(WordsClip[294]);
                    }
                    break;
                case "Yh":
                    {
                        PlaySounds(WordsClip[295]);
                    }
                    break;
                case "Yi":
                    {
                        PlaySounds(WordsClip[296]);
                    }
                    break;
                case "Yj":
                    {
                        PlaySounds(WordsClip[297]);
                    }
                    break;
                case "Yk":
                    {
                        PlaySounds(WordsClip[298]);
                    }
                    break;
                case "Yl":
                    {
                        PlaySounds(WordsClip[299]);
                    }
                    break;
                //Story 26
                case "Za":
                    {
                        PlaySounds(WordsClip[300]);
                    }
                    break;
                case "Zb":
                    {
                        PlaySounds(WordsClip[301]);
                    }
                    break;
                case "Zc":
                    {
                        PlaySounds(WordsClip[302]);
                    }
                    break;
                case "Zd":
                    {
                        PlaySounds(WordsClip[303]);
                    }
                    break;
                case "Ze":
                    {
                        PlaySounds(WordsClip[304]);
                    }
                    break;
                case "Zf":
                    {
                        PlaySounds(WordsClip[305]);
                    }
                    break;
                case "Zg":
                    {
                        PlaySounds(WordsClip[306]);
                    }
                    break;
                case "Zh":
                    {
                        PlaySounds(WordsClip[307]);
                    }
                    break;
                case "Zi":
                    {
                        PlaySounds(WordsClip[308]);
                    }
                    break;
                case "Zj":
                    {
                        PlaySounds(WordsClip[309]);
                    }
                    break;
                case "Zk":
                    {
                        PlaySounds(WordsClip[310]);
                    }
                    break;
                case "Zl":
                    {
                        PlaySounds(WordsClip[311]);
                    }
                    break;
                //Story 27
                case "AAa":
                    {
                        PlaySounds(WordsClip[312]);
                    }
                    break;
                case "AAb":
                    {
                        PlaySounds(WordsClip[313]);
                    }
                    break;
                case "AAc":
                    {
                        PlaySounds(WordsClip[314]);
                    }
                    break;
                case "AAd":
                    {
                        PlaySounds(WordsClip[315]);
                    }
                    break;
                case "AAe":
                    {
                        PlaySounds(WordsClip[316]);
                    }
                    break;
                case "AAf":
                    {
                        PlaySounds(WordsClip[317]);
                    }
                    break;
                case "AAg":
                    {
                        PlaySounds(WordsClip[318]);
                    }
                    break;
                case "AAh":
                    {
                        PlaySounds(WordsClip[319]);
                    }
                    break;
                case "AAi":
                    {
                        PlaySounds(WordsClip[320]);
                    }
                    break;
                case "AAj":
                    {
                        PlaySounds(WordsClip[321]);
                    }
                    break;
                case "AAk":
                    {
                        PlaySounds(WordsClip[322]);
                    }
                    break;
                case "AAl":
                    {
                        PlaySounds(WordsClip[323]);
                    }
                    break;
                //Story 28
                case "BBa":
                    {
                        PlaySounds(WordsClip[324]);
                    }
                    break;
                case "BBb":
                    {
                        PlaySounds(WordsClip[325]);
                    }
                    break;
                case "BBc":
                    {
                        PlaySounds(WordsClip[326]);
                    }
                    break;
                case "BBd":
                    {
                        PlaySounds(WordsClip[327]);
                    }
                    break;
                case "BBe":
                    {
                        PlaySounds(WordsClip[328]);
                    }
                    break;
                case "BBf":
                    {
                        PlaySounds(WordsClip[329]);
                    }
                    break;
                case "BBg":
                    {
                        PlaySounds(WordsClip[330]);
                    }
                    break;
                case "BBh":
                    {
                        PlaySounds(WordsClip[331]);
                    }
                    break;
                case "BBi":
                    {
                        PlaySounds(WordsClip[332]);
                    }
                    break;
                case "BBj":
                    {
                        PlaySounds(WordsClip[333]);
                    }
                    break;
                case "BBk":
                    {
                        PlaySounds(WordsClip[334]);
                    }
                    break;
                case "BBl":
                    {
                        PlaySounds(WordsClip[335]);
                    }
                    break;
                //Story 29
                case "CCa":
                    {
                        PlaySounds(WordsClip[336]);
                    }
                    break;
                case "CCb":
                    {
                        PlaySounds(WordsClip[337]);
                    }
                    break;
                case "CCc":
                    {
                        PlaySounds(WordsClip[338]);
                    }
                    break;
                case "CCd":
                    {
                        PlaySounds(WordsClip[339]);
                    }
                    break;
                case "CCe":
                    {
                        PlaySounds(WordsClip[340]);
                    }
                    break;
                case "CCf":
                    {
                        PlaySounds(WordsClip[341]);
                    }
                    break;
                case "CCg":
                    {
                        PlaySounds(WordsClip[342]);
                    }
                    break;
                case "CCh":
                    {
                        PlaySounds(WordsClip[343]);
                    }
                    break;
                case "CCi":
                    {
                        PlaySounds(WordsClip[344]);
                    }
                    break;
                case "CCj":
                    {
                        PlaySounds(WordsClip[345]);
                    }
                    break;
                case "CCk":
                    {
                        PlaySounds(WordsClip[346]);
                    }
                    break;
                case "CCl":
                    {
                        PlaySounds(WordsClip[347]);
                    }
                    break;
                //Story 30
                case "DDa":
                    {
                        PlaySounds(WordsClip[348]);
                    }
                    break;
                case "DDb":
                    {
                        PlaySounds(WordsClip[349]);
                    }
                    break;
                case "DDc":
                    {
                        PlaySounds(WordsClip[350]);
                    }
                    break;
                case "DDd":
                    {
                        PlaySounds(WordsClip[351]);
                    }
                    break;
                case "DDe":
                    {
                        PlaySounds(WordsClip[352]);
                    }
                    break;
                case "DDf":
                    {
                        PlaySounds(WordsClip[353]);
                    }
                    break;
                case "DDg":
                    {
                        PlaySounds(WordsClip[354]);
                    }
                    break;
                case "DDh":
                    {
                        PlaySounds(WordsClip[355]);
                    }
                    break;
                case "DDi":
                    {
                        PlaySounds(WordsClip[356]);
                    }
                    break;
                case "DDj":
                    {
                        PlaySounds(WordsClip[357]);
                    }
                    break;
                case "DDk":
                    {
                        PlaySounds(WordsClip[358]);
                    }
                    break;
                case "DDl":
                    {
                        PlaySounds(WordsClip[359]);
                    }
                    break;
                //Story 31
                case "EEa":
                    {
                        PlaySounds(WordsClip[360]);
                    }
                    break;
                case "EEb":
                    {
                        PlaySounds(WordsClip[361]);
                    }
                    break;
                case "EEc":
                    {
                        PlaySounds(WordsClip[362]);
                    }
                    break;
                case "EEd":
                    {
                        PlaySounds(WordsClip[363]);
                    }
                    break;
                case "EEe":
                    {
                        PlaySounds(WordsClip[364]);
                    }
                    break;
                case "EEf":
                    {
                        PlaySounds(WordsClip[365]);
                    }
                    break;
                case "EEg":
                    {
                        PlaySounds(WordsClip[366]);
                    }
                    break;
                case "EEh":
                    {
                        PlaySounds(WordsClip[367]);
                    }
                    break;
                case "EEi":
                    {
                        PlaySounds(WordsClip[368]);
                    }
                    break;
                case "EEj":
                    {
                        PlaySounds(WordsClip[369]);
                    }
                    break;
                case "EEk":
                    {
                        PlaySounds(WordsClip[370]);
                    }
                    break;
                case "EEl":
                    {
                        PlaySounds(WordsClip[371]);
                    }
                    break;
                //Story 32
                case "FFa":
                    {
                        PlaySounds(WordsClip[372]);
                    }
                    break;
                case "FFb":
                    {
                        PlaySounds(WordsClip[373]);
                    }
                    break;
                case "FFc":
                    {
                        PlaySounds(WordsClip[374]);
                    }
                    break;
                case "FFd":
                    {
                        PlaySounds(WordsClip[375]);
                    }
                    break;
                case "FFe":
                    {
                        PlaySounds(WordsClip[376]);
                    }
                    break;
                case "FFf":
                    {
                        PlaySounds(WordsClip[377]);
                    }
                    break;
                case "FFg":
                    {
                        PlaySounds(WordsClip[378]);
                    }
                    break;
                case "FFh":
                    {
                        PlaySounds(WordsClip[379]);
                    }
                    break;
                case "FFi":
                    {
                        PlaySounds(WordsClip[380]);
                    }
                    break;
                case "FFj":
                    {
                        PlaySounds(WordsClip[381]);
                    }
                    break;
                case "FFk":
                    {
                        PlaySounds(WordsClip[382]);
                    }
                    break;
                case "FFl":
                    {
                        PlaySounds(WordsClip[383]);
                    }
                    break;
                //Story 33
                case "GGa":
                    {
                        PlaySounds(WordsClip[384]);
                    }
                    break;
                case "GGb":
                    {
                        PlaySounds(WordsClip[385]);
                    }
                    break;
                case "GGc":
                    {
                        PlaySounds(WordsClip[386]);
                    }
                    break;
                case "GGd":
                    {
                        PlaySounds(WordsClip[387]);
                    }
                    break;
                case "GGe":
                    {
                        PlaySounds(WordsClip[388]);
                    }
                    break;
                case "GGf":
                    {
                        PlaySounds(WordsClip[389]);
                    }
                    break;
                case "GGg":
                    {
                        PlaySounds(WordsClip[390]);
                    }
                    break;
                case "GGh":
                    {
                        PlaySounds(WordsClip[391]);
                    }
                    break;
                case "GGi":
                    {
                        PlaySounds(WordsClip[392]);
                    }
                    break;
                case "GGj":
                    {
                        PlaySounds(WordsClip[393]);
                    }
                    break;
                case "GGk":
                    {
                        PlaySounds(WordsClip[394]);
                    }
                    break;
                case "GGl":
                    {
                        PlaySounds(WordsClip[395]);
                    }
                    break;
                //Story 34
                case "HHa":
                    {
                        PlaySounds(WordsClip[396]);
                    }
                    break;
                case "HHb":
                    {
                        PlaySounds(WordsClip[397]);
                    }
                    break;
                case "HHc":
                    {
                        PlaySounds(WordsClip[398]);
                    }
                    break;
                case "HHd":
                    {
                        PlaySounds(WordsClip[399]);
                    }
                    break;
                case "HHe":
                    {
                        PlaySounds(WordsClip[400]);
                    }
                    break;
                case "HHf":
                    {
                        PlaySounds(WordsClip[401]);
                    }
                    break;
                case "HHg":
                    {
                        PlaySounds(WordsClip[402]);
                    }
                    break;
                case "HHh":
                    {
                        PlaySounds(WordsClip[403]);
                    }
                    break;
                case "HHi":
                    {
                        PlaySounds(WordsClip[404]);
                    }
                    break;
                case "HHj":
                    {
                        PlaySounds(WordsClip[405]);
                    }
                    break;
                case "HHk":
                    {
                        PlaySounds(WordsClip[406]);
                    }
                    break;
                case "HHl":
                    {
                        PlaySounds(WordsClip[407]);
                    }
                    break;
                //Story 35
                case "IIa":
                    {
                        PlaySounds(WordsClip[408]);
                    }
                    break;
                case "IIb":
                    {
                        PlaySounds(WordsClip[409]);
                    }
                    break;
                case "IIc":
                    {
                        PlaySounds(WordsClip[410]);
                    }
                    break;
                case "IId":
                    {
                        PlaySounds(WordsClip[411]);
                    }
                    break;
                case "IIe":
                    {
                        PlaySounds(WordsClip[412]);
                    }
                    break;
                case "IIf":
                    {
                        PlaySounds(WordsClip[413]);
                    }
                    break;
                case "IIg":
                    {
                        PlaySounds(WordsClip[414]);
                    }
                    break;
                case "IIh":
                    {
                        PlaySounds(WordsClip[415]);
                    }
                    break;
                case "IIi":
                    {
                        PlaySounds(WordsClip[416]);
                    }
                    break;
                case "IIj":
                    {
                        PlaySounds(WordsClip[417]);
                    }
                    break;
                case "IIk":
                    {
                        PlaySounds(WordsClip[418]);
                    }
                    break;
                case "IIl":
                    {
                        PlaySounds(WordsClip[419]);
                    }
                    break;
                //Story 36
                case "JJa":
                    {
                        PlaySounds(WordsClip[420]);
                    }
                    break;
                case "JJb":
                    {
                        PlaySounds(WordsClip[421]);
                    }
                    break;
                case "JJc":
                    {
                        PlaySounds(WordsClip[422]);
                    }
                    break;
                case "JJd":
                    {
                        PlaySounds(WordsClip[423]);
                    }
                    break;
                case "JJe":
                    {
                        PlaySounds(WordsClip[424]);
                    }
                    break;
                case "JJf":
                    {
                        PlaySounds(WordsClip[425]);
                    }
                    break;
                case "JJg":
                    {
                        PlaySounds(WordsClip[426]);
                    }
                    break;
                case "JJh":
                    {
                        PlaySounds(WordsClip[427]);
                    }
                    break;
                case "JJi":
                    {
                        PlaySounds(WordsClip[428]);
                    }
                    break;
                case "JJj":
                    {
                        PlaySounds(WordsClip[429]);
                    }
                    break;
                case "JJk":
                    {
                        PlaySounds(WordsClip[430]);
                    }
                    break;
                case "JJl":
                    {
                        PlaySounds(WordsClip[431]);
                    }
                    break;
                //Story 37
                case "KKa":
                    {
                        PlaySounds(WordsClip[432]);
                    }
                    break;
                case "KKb":
                    {
                        PlaySounds(WordsClip[433]);
                    }
                    break;
                case "KKc":
                    {
                        PlaySounds(WordsClip[434]);
                    }
                    break;
                case "KKd":
                    {
                        PlaySounds(WordsClip[435]);
                    }
                    break;
                case "KKe":
                    {
                        PlaySounds(WordsClip[436]);
                    }
                    break;
                case "KKf":
                    {
                        PlaySounds(WordsClip[437]);
                    }
                    break;
                case "KKg":
                    {
                        PlaySounds(WordsClip[438]);
                    }
                    break;
                case "KKh":
                    {
                        PlaySounds(WordsClip[439]);
                    }
                    break;
                case "KKi":
                    {
                        PlaySounds(WordsClip[440]);
                    }
                    break;
                case "KKj":
                    {
                        PlaySounds(WordsClip[441]);
                    }
                    break;
                case "KKk":
                    {
                        PlaySounds(WordsClip[442]);
                    }
                    break;
                case "KKl":
                    {
                        PlaySounds(WordsClip[443]);
                    }
                    break;
                //Story 38
                case "LLa":
                    {
                        PlaySounds(WordsClip[444]);
                    }
                    break;
                case "LLb":
                    {
                        PlaySounds(WordsClip[445]);
                    }
                    break;
                case "LLc":
                    {
                        PlaySounds(WordsClip[446]);
                    }
                    break;
                case "LLd":
                    {
                        PlaySounds(WordsClip[447]);
                    }
                    break;
                case "LLe":
                    {
                        PlaySounds(WordsClip[448]);
                    }
                    break;
                case "LLf":
                    {
                        PlaySounds(WordsClip[449]);
                    }
                    break;
                case "LLg":
                    {
                        PlaySounds(WordsClip[450]);
                    }
                    break;
                case "LLh":
                    {
                        PlaySounds(WordsClip[451]);
                    }
                    break;
                case "LLi":
                    {
                        PlaySounds(WordsClip[452]);
                    }
                    break;
                case "LLj":
                    {
                        PlaySounds(WordsClip[453]);
                    }
                    break;
                case "LLk":
                    {
                        PlaySounds(WordsClip[454]);
                    }
                    break;
                case "LLl":
                    {
                        PlaySounds(WordsClip[455]);
                    }
                    break;
                //Story 39
                case "MMa":
                    {
                        PlaySounds(WordsClip[456]);
                    }
                    break;
                case "MMb":
                    {
                        PlaySounds(WordsClip[457]);
                    }
                    break;
                case "MMc":
                    {
                        PlaySounds(WordsClip[458]);
                    }
                    break;
                case "MMd":
                    {
                        PlaySounds(WordsClip[459]);
                    }
                    break;
                case "MMe":
                    {
                        PlaySounds(WordsClip[460]);
                    }
                    break;
                case "MMf":
                    {
                        PlaySounds(WordsClip[461]);
                    }
                    break;
                case "MMg":
                    {
                        PlaySounds(WordsClip[462]);
                    }
                    break;
                case "MMh":
                    {
                        PlaySounds(WordsClip[463]);
                    }
                    break;
                case "MMi":
                    {
                        PlaySounds(WordsClip[464]);
                    }
                    break;
                case "MMj":
                    {
                        PlaySounds(WordsClip[465]);
                    }
                    break;
                case "MMk":
                    {
                        PlaySounds(WordsClip[466]);
                    }
                    break;
                case "MMl":
                    {
                        PlaySounds(WordsClip[467]);
                    }
                    break;
                //Story 40
                case "NNa":
                    {
                        PlaySounds(WordsClip[468]);
                    }
                    break;
                case "NNb":
                    {
                        PlaySounds(WordsClip[469]);
                    }
                    break;
                case "NNc":
                    {
                        PlaySounds(WordsClip[470]);
                    }
                    break;
                case "NNd":
                    {
                        PlaySounds(WordsClip[471]);
                    }
                    break;
                case "NNe":
                    {
                        PlaySounds(WordsClip[472]);
                    }
                    break;
                case "NNf":
                    {
                        PlaySounds(WordsClip[473]);
                    }
                    break;
                case "NNg":
                    {
                        PlaySounds(WordsClip[474]);
                    }
                    break;
                case "NNh":
                    {
                        PlaySounds(WordsClip[475]);
                    }
                    break;
                case "NNi":
                    {
                        PlaySounds(WordsClip[476]);
                    }
                    break;
                case "NNj":
                    {
                        PlaySounds(WordsClip[477]);
                    }
                    break;
                case "NNk":
                    {
                        PlaySounds(WordsClip[478]);
                    }
                    break;
                case "NNl":
                    {
                        PlaySounds(WordsClip[479]);
                    }
                    break;
                //Story 41
                case "OOa":
                    {
                        PlaySounds(WordsClip[480]);
                    }
                    break;
                case "OOb":
                    {
                        PlaySounds(WordsClip[481]);
                    }
                    break;
                case "OOc":
                    {
                        PlaySounds(WordsClip[482]);
                    }
                    break;
                case "OOd":
                    {
                        PlaySounds(WordsClip[483]);
                    }
                    break;
                case "OOe":
                    {
                        PlaySounds(WordsClip[484]);
                    }
                    break;
                case "OOf":
                    {
                        PlaySounds(WordsClip[485]);
                    }
                    break;
                case "OOg":
                    {
                        PlaySounds(WordsClip[486]);
                    }
                    break;
                case "OOh":
                    {
                        PlaySounds(WordsClip[487]);
                    }
                    break;
                case "OOi":
                    {
                        PlaySounds(WordsClip[488]);
                    }
                    break;
                case "OOj":
                    {
                        PlaySounds(WordsClip[489]);
                    }
                    break;
                case "OOk":
                    {
                        PlaySounds(WordsClip[490]);
                    }
                    break;
                case "OOl":
                    {
                        PlaySounds(WordsClip[491]);
                    }
                    break;
                //Story 42
                case "PPa":
                    {
                        PlaySounds(WordsClip[492]);
                    }
                    break;
                case "PPb":
                    {
                        PlaySounds(WordsClip[493]);
                    }
                    break;
                case "PPc":
                    {
                        PlaySounds(WordsClip[494]);
                    }
                    break;
                case "PPd":
                    {
                        PlaySounds(WordsClip[495]);
                    }
                    break;
                case "PPe":
                    {
                        PlaySounds(WordsClip[496]);
                    }
                    break;
                case "PPf":
                    {
                        PlaySounds(WordsClip[497]);
                    }
                    break;
                case "PPg":
                    {
                        PlaySounds(WordsClip[498]);
                    }
                    break;
                case "PPh":
                    {
                        PlaySounds(WordsClip[499]);
                    }
                    break;
                case "PPi":
                    {
                        PlaySounds(WordsClip[500]);
                    }
                    break;
                case "PPj":
                    {
                        PlaySounds(WordsClip[501]);
                    }
                    break;
                case "PPk":
                    {
                        PlaySounds(WordsClip[502]);
                    }
                    break;
                case "PPl":
                    {
                        PlaySounds(WordsClip[503]);
                    }
                    break;
            }
        }
    }
}
