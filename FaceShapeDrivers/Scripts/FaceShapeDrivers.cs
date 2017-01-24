using System;
using UnityEngine;

[ExecuteInEditMode()]
public class FaceShapeDrivers : MonoBehaviour {
    public GameObject[] target;
    public GameObject[] eyes;
    SkinnedMeshRenderer skinnedMeshRenderer;

    float fScale, gScale, frScale, exScale, drScale, dsg02Scale, dsgScale, cScale, cr02Scale, crScale, brdScale,
        atScale, arScale, axScale, amScale, scScale, s02Scale, sScale, suScale, blScale;
    [Range(0f, 100f)]
    public float blinkExpression;
    [Range(0f, 100f)]
    public float furyExpression;
    [Range(0f, 100f)]
    public float glareExpression;
    [Range(0f, 100f)]
    public float frownExpression;
    [Range(0f, 100f)]
    public float excitedExpression;
    [Range(0f, 100f)]
    public float drainedExpression;
    [Range(0f, 100f)]
    public float disgusted02Expression;
    [Range(0f, 100f)]
    public float disgustedExpression;
    [Range(0f, 100f)]
    public float curiousExpression;
    [Range(0f, 100f)]
    public float crying02Expression;
    [Range(0f, 100f)]
    public float cryingExpression;
    [Range(0f, 100f)]
    public float boredExpression;
    [Range(0f, 100f)]
    public float attentiveExpression;
    [Range(0f, 100f)]
    public float arrogantExpression;
    [Range(0f, 100f)]
    public float anxiousExpression;
    [Range(0f, 100f)]
    public float amusedExpression;
    [Range(0f, 100f)]
    public float scaredExpression;
    [Range(0f, 100f)]
    public float sad02Expression;
    [Range(0f, 100f)]
    public float sadExpression;
    [Range(0f, 100f)]
    public float surpriseExpression;    

    float vRest, vAE_AX_AH, vAA, vAO, vEY_EH_UH, vER, vY_IY_IH_IX, vW_UW, vOW, vAW, vOY, vAY, vH, vR, vL, vS_Z,
        vSH_CH_JH, vTH_DH, vF_V, vD_T_N, vK_G_NG, vP_B_M, vOff;

    [Range(0f, 100f)]
    public float AE_AX_AHViseme, AAViseme, AOViseme, EY_EH_UHViseme, ERViseme, Y_IY_IH_IXViseme,
        W_UWViseme, OWViseme, AWViseme, OYViseme, AYViseme, HViseme, RViseme, LViseme, S_ZViseme,
        SH_CH_JH_ZHViseme, TH_DHViseme, F_VViseme, D_T_NViseme, K_G_NGViseme, P_B_MViseme;
    



    void OnEnable()
    {
        for (int ix = 0; ix < target.Length; ix++)
        if (target[ix] != gameObject)
        {
            var proxy = target[ix].GetComponent<FaceShapeTargetProxy>() ?? target[ix].AddComponent<FaceShapeTargetProxy>();
            if (proxy.owner != this)
                proxy.owner = this;            
        }
    }

    void Update()
    {
        for (int ix = 0; ix < target.Length; ix++)
        {
            skinnedMeshRenderer = ((target[ix] ?? gameObject).GetComponent<SkinnedMeshRenderer>());
            if (skinnedMeshRenderer == null)
                return;

            if (fScale != furyExpression)
            {
                SetFuryExpression();
                if (ix == target.Length - 1)
                    fScale = furyExpression;
            }
            else if (gScale != glareExpression)
            {
                SetGlareExpression();
                if (ix == target.Length - 1)
                    gScale = glareExpression;
            }
            else if (frScale != frownExpression)
            {
                SetFrownExpression();
                if (ix == target.Length - 1)
                    frScale = frownExpression;
            }
            else if (exScale != excitedExpression)
            {
                SetExcitedExpression();
                if (ix == target.Length - 1)
                    exScale = excitedExpression;
            }
            else if (drScale != drainedExpression)
            {
                SetDrainedExpression();
                if (ix == target.Length - 1)
                    drScale = drainedExpression;
            }
            else if (dsg02Scale != disgusted02Expression)
            {
                SetDisgusted02Express();
                if (ix == target.Length - 1)
                    dsg02Scale = disgusted02Expression;
            }
            else if (dsgScale != disgustedExpression)
            {
                SetDisgustedExpress();
                if (ix == target.Length - 1)
                    dsgScale = disgustedExpression;
            }
            else if (cScale != curiousExpression)
            {
                SetCuriousExpression();
                if (ix == target.Length - 1)
                    cScale = curiousExpression;
            }
            else if (cr02Scale != crying02Expression)
            {
                SetCrying02Expression();
                if (ix == target.Length - 1)
                    cr02Scale = crying02Expression;
            }
            else if (crScale != cryingExpression)
            {
                SetCryingExpression();
                if (ix == target.Length - 1)
                    crScale = cryingExpression;
            }
            else if (brdScale != boredExpression)
            {
                SetBoredExpression();
                if (ix == target.Length - 1)
                    brdScale = boredExpression;
            }
            else if (atScale != attentiveExpression)
            {
                SetAttentiveExpression();
                if (ix == target.Length - 1)
                    atScale = attentiveExpression;
            }
            else if (arScale != arrogantExpression)
            {
                SetArrogantExpression();
                if (ix == target.Length - 1)
                    arScale = arrogantExpression;
            }
            else if (axScale != anxiousExpression)
            {
                SetAnxiousExpression();
                if (ix == target.Length - 1)
                    axScale = anxiousExpression;
            }
            else if (amScale != amusedExpression)
            {
                SetAmusedExpression();
                if (ix == target.Length - 1)
                    amScale = amusedExpression;
            }
            else if (scScale != scaredExpression)
            {
                SetScaredExpression();
                if (ix == target.Length - 1)
                    scScale = scaredExpression;
            }
            else if (s02Scale != sad02Expression)
            {
                SetSad02Expression();
                if (ix == target.Length - 1)
                    s02Scale = sad02Expression;
            }
            else if (sScale != sadExpression)
            {
                SetSadExpression();
                if (ix == target.Length - 1)
                    sScale = sadExpression;
            }
            else if (suScale != surpriseExpression)
            {
                SetSurpriseExpression();
                if (ix == target.Length - 1)
                    suScale = surpriseExpression;
            }

            else if (blScale != blinkExpression)
            {
                SetBlink();
                if (ix == target.Length - 1)
                    blScale = blinkExpression;
            }

            //Visemes
            if (vAE_AX_AH != AE_AX_AHViseme)
            {
                SetAE_AX_AHViseme();
                if (ix == target.Length - 1)
                    vAE_AX_AH = AE_AX_AHViseme;
            }
            else if (vAA != AAViseme)
            {
                SetAAViseme();
                if (ix == target.Length - 1)
                    vAA = AAViseme;
            }
            else if (vAO != AOViseme)
            {
                SetAOViseme();
                if (ix == target.Length - 1)
                    vAO = AOViseme;
            }
            else if (vEY_EH_UH != EY_EH_UHViseme)
            {
                SetEy_Eh_UhViseme();
                if (ix == target.Length - 1)
                    vEY_EH_UH = EY_EH_UHViseme;
            }
            else if (vER != ERViseme)
            {
                SetErViseme();
                if (ix == target.Length - 1)
                    vER = ERViseme;
            }
            else if (vY_IY_IH_IX != Y_IY_IH_IXViseme)
            {
                SetY_Iy_Ih_IxViseme();
                if (ix == target.Length - 1)
                    vY_IY_IH_IX = Y_IY_IH_IXViseme;
            }
            else if (vW_UW != W_UWViseme)
            {
                SetW_UwViseme();
                if (ix == target.Length - 1)
                    vW_UW = W_UWViseme;
            }
            else if (vOW != OWViseme)
            {
                SetOwViseme();
                if (ix == target.Length - 1)
                    vOW = OWViseme;
            }
            else if (vAW != AWViseme)
            {
                SetAwViseme();
                if (ix == target.Length - 1)
                    vAW = AWViseme;
            }
            else if (vOY != OYViseme)
            {
                SetOyViseme();
                if (ix == target.Length - 1)
                    vOY = OYViseme;
            }
            else if (vAY != AYViseme)
            {
                SetAyViseme();
                if (ix == target.Length - 1)
                    vAY = AYViseme;
            }
            else if (vH != HViseme)
            {
                SetHViseme();
                if (ix == target.Length - 1)
                    vH = HViseme;
            }
            else if (vR != RViseme)
            {
                SetRViseme();
                if (ix == target.Length - 1)
                    vR = RViseme;
            }
            else if (vL != LViseme)
            {
                SetLViseme();
                if (ix == target.Length - 1)
                    vL = LViseme;
            }
            else if (vS_Z != S_ZViseme)
            {
                SetS_ZViseme();
                if (ix == target.Length - 1)
                    vS_Z = S_ZViseme;
            }
            else if (vSH_CH_JH != SH_CH_JH_ZHViseme)
            {
                SetSh_Ch_Jh_ZhViseme();
                if (ix == target.Length - 1)
                    vSH_CH_JH = SH_CH_JH_ZHViseme;
            }
            else if (vTH_DH != TH_DHViseme)
            {
                SetTh_DhViseme();
                if (ix == target.Length - 1)
                    vTH_DH = TH_DHViseme;
            }
            else if (vF_V != F_VViseme)
            {
                SetF_VViseme();
                if (ix == target.Length - 1)
                    vF_V = F_VViseme;
            }
            else if (vD_T_N != D_T_NViseme)
            {
                SetD_T_NViseme();
                if (ix == target.Length - 1)
                    vD_T_N = D_T_NViseme;
            }
            else if (vK_G_NG != K_G_NGViseme)
            {
                SetK_G_NGViseme();
                if (ix == target.Length - 1)
                    vK_G_NG = K_G_NGViseme;
            }
            else if (vP_B_M != P_B_MViseme)
            {
                SetP_B_MViseme();
                if (ix == target.Length - 1)
                    vP_B_M = P_B_MViseme;
            }
            
        }
    }

    

    

    private void SetP_B_MViseme()
    {
        ModifyExpressionValues("Facial_Blends.JawForeward", 29, P_B_MViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 38, P_B_MViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipIn", 100, P_B_MViseme);
    }

    private void SetK_G_NGViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 9, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 40, K_G_NGViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 40, K_G_NGViseme);
    }

    private void SetD_T_NViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 9, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, D_T_NViseme);
        ModifyExpressionValues("Facial_Blends.TongueUp", 60, D_T_NViseme);
    }

    private void SetF_VViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, F_VViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, F_VViseme);
        ModifyExpressionValues("Facial_Blends.JawBackward", 75, F_VViseme);
        ModifyExpressionValues("Facial_Blends.Jaw_Up", 58, F_VViseme);

        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, F_VViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, F_VViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 5, F_VViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, F_VViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, F_VViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 11, F_VViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 11, F_VViseme);
    }

    private void SetTh_DhViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 5, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.TongueUp", 40, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, TH_DHViseme);
        ModifyExpressionValues("Facial_Blends.Jaw_Down", 11, TH_DHViseme);

    }

    private void SetSh_Ch_Jh_ZhViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 52, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 52, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 20, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 100, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 50, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 50, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 8, SH_CH_JH_ZHViseme);
        //ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Left", 32);
        //ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Right", 32);
        ModifyExpressionValues("Facial_Blends.TongueUp", 28, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipIn", 100, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipOut", 25, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 12, SH_CH_JH_ZHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 12, SH_CH_JH_ZHViseme);
    }

    private void SetS_ZViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 5, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, S_ZViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, S_ZViseme);
    }

    private void SetLViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, LViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, LViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, LViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, LViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 18, LViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, LViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, LViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, LViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, LViseme);
        ModifyExpressionValues("Facial_Blends.TongueUp", 50, LViseme);
    }

    private void SetRViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 59, RViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 29, RViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 50, RViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 50, RViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 18, RViseme);
        ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Left", 32, RViseme);
        ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Right", 32, RViseme);
        ModifyExpressionValues("Facial_Blends.TongueUp", 100, RViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipOut", 84, RViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 12, RViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 15, RViseme);
    }

    private void SetHViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 10, HViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 10, HViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 8, HViseme);
    }

    private void SetAyViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 34, AYViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 71, AYViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 20, AYViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 20, AYViseme);
    }

    private void SetOyViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 34, OYViseme);
        ModifyExpressionValues("Facial_Blends.Midmouth_Left", 18, OYViseme);
        ModifyExpressionValues("Facial_Blends.Midmouth_Right", 18, OYViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 41, OYViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 41, OYViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 71, OYViseme);
    }

    private void SetAwViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 34, AWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 26, AWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 26, AWViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 71, AWViseme);
    }

    private void SetOwViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 28, OWViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 28, OWViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 71, OWViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 100, OWViseme);
        ModifyExpressionValues("Facial_Blends.MidMouth_Left", 16, OWViseme);
        ModifyExpressionValues("Facial_Blends.MidMouth_Right", 16, OWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 100, OWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 100, OWViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 33, OWViseme);
        ModifyExpressionValues("Facial_Blends.MouthUp", 42, OWViseme);
    }

    private void SetW_UwViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 100, W_UWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 100, W_UWViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 100, W_UWViseme);

    }

    private void SetY_Iy_Ih_IxViseme()
    {
        ModifyExpressionValues("Facial_Blends.Frown_Left", 54, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 54, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 22, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 30, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 18, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 10, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 10, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 56, Y_IY_IH_IXViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 56, Y_IY_IH_IXViseme);

    }

    void SetErViseme()
    {
        ModifyExpressionValues("Facial_Blends.JawBackward", 84, ERViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 59, ERViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 100, ERViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 50, ERViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 50, ERViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 20, ERViseme);
        ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Left", 32, ERViseme);
        ModifyExpressionValues("Facial_Blends.MouthWhistle_NarrowAdjust_Right", 32, ERViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipIn", 100, ERViseme);
        ModifyExpressionValues("Facial_Blends.TongueUp", 100, ERViseme);
    }

    private void SetEy_Eh_UhViseme()
    {
        ModifyExpressionValues("Facial_Blends.Jaw_Down", 71, EY_EH_UHViseme);
        ModifyExpressionValues("Facial_Blends.Jaw_Up", 39, EY_EH_UHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 26, EY_EH_UHViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 26, EY_EH_UHViseme);

    }

    private void SetAOViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 10, AOViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 10, AOViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 13, AOViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 13, AOViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 40, AOViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Left", 70, AOViseme);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 70, AOViseme);

    }

    private void SetAAViseme()
    {
        ModifyExpressionValues("Facial_Blends.Jaw_Up", 64, AAViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 20, AAViseme);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 96, AAViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Left", 25, AAViseme);
        ModifyExpressionValues("Facial_Blends.MouthNarrow_Right", 25, AAViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 60, AAViseme);
        ModifyExpressionValues("Facial_Blends.MouthUp", 15, AAViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 29, AAViseme);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 29, AAViseme);
    }

    private void SetAE_AX_AHViseme()
    {
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 20, AE_AX_AHViseme);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 29, AE_AX_AHViseme);
    }

    /****************EXPRESSIONS*****************/

    void SetSurpriseExpression()
    {
        ModifyExpressionValues("Facial_Blends.BrowsDown_Left", 61, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Right", 61, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Left", 77, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Right", 77, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.BrowsUp_Left", 77, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.BrowsUp_Right", 77, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 74, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.Midmouth_Left", 18, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.Midmouth_Right", 18, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.MouthDown", 21, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 45, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.MouthUp", 40, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipOut", 50, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 15, surpriseExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 15, surpriseExpression);

    }

    private void SetSadExpression()
    {
        ModifyExpressionValues("Facial_Blends.BrowsDown_Left", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Right", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Left", 73, sadExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Right", 73, sadExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Left", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Right", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Left", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.Jaw_Up", 86, sadExpression);
        ModifyExpressionValues("Facial_Blends.LowerLipOut", 100, sadExpression);
        ModifyExpressionValues("Facial_Blends.MouthDown", 26, sadExpression);

    }

    private void SetSad02Expression()
    {
        ModifyExpressionValues("Facial_Blends.Blink_Left", 100, sad02Expression);
        ModifyExpressionValues("Facial_Blends.Blink_Right", 100, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Left", 80, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Right", 80, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Left", 85, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Right", 85, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Left", 100, sad02Expression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Right", 100, sad02Expression);
        ModifyExpressionValues("Facial_Blends.Frown_Left", 40, sad02Expression);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 40, sad02Expression);
    }

    private void SetScaredExpression()
    {
        ModifyExpressionValues("Facial_Blends.EyesWide_Left", 100, scaredExpression);
        ModifyExpressionValues("Facial_Blends.EyesWide_Right", 100, scaredExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Left", 46, scaredExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 46, scaredExpression);
        ModifyExpressionValues("Facial_Blends.Jaw_Down", 51, scaredExpression);
    }

    private void SetAmusedExpression()
    {
        ModifyExpressionValues("Facial_Blends.Blink_Left", 100, amusedExpression);
        ModifyExpressionValues("Facial_Blends.Blink_Right", 100, amusedExpression);
        ModifyExpressionValues("Facial_Blends.BrowsUp_Left", 46, amusedExpression);
        ModifyExpressionValues("Facial_Blends.BrowsUp_Right", 46, amusedExpression);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 16, amusedExpression);
        ModifyExpressionValues("Facial_Blends.MouthUp", 26, amusedExpression);
        ModifyExpressionValues("Facial_Blends.Smile_Left", 18, amusedExpression);
        ModifyExpressionValues("Facial_Blends.Smile_Right", 20, amusedExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Left", 23, amusedExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipUp_Right", 23, amusedExpression);
    }

    private void SetAnxiousExpression()
    {
        ModifyExpressionValues("Facial_Blends.Blink_Left", 10, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.Blink_Right", 10, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Left", 82, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Right", 82, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Left", 100, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Right", 100, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Left", 48, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Right", 48, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Left", 73, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.Frown_Right", 73, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.Jaw_Up", 33, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.MouthOpen", 13, anxiousExpression);
        ModifyExpressionValues("Facial_Blends.MouthUp", 3, anxiousExpression);
        for (int ix = 0; ix < eyes.Length; ix++)
        {
            eyes[ix].transform.localEulerAngles = new Vector3(anxiousExpression * .07f, anxiousExpression * .17f, 0f);
            //eyeRot.x = ;
            //eyeRot.y = ;
            //.Rotate(new Vector3(anxiousExpression / .07f, anxiousExpression / .17f));
        }




    }

    private void SetArrogantExpression()
    {
        ModifyArrogantValues("Facial_Blends.BrowsDown_Left", 72);
        ModifyArrogantValues("Facial_Blends.BrowsDown_Right", 100);
        ModifyArrogantValues("Facial_Blends.BrowsIn_Left", 92);
        ModifyArrogantValues("Facial_Blends.BrowsUp_Right", 100);
        ModifyArrogantValues("Facial_Blends.MouthUp", 12);
        ModifyArrogantValues("Facial_Blends.NoseScrunch_Left", 34);
        ModifyArrogantValues("Facial_Blends.Smile_Left", 100);
        ModifyArrogantValues("Facial_Blends.Smile_Right", 67);
        ModifyArrogantValues("Facial_Blends.Squint_Left", 26);
        ModifyArrogantValues("Facial_Blends.Squint_Right", 9);
    }

    private void SetAttentiveExpression()
    {
        ModifyAttentiveValues("Facial_Blends.BrowsDown_Left", 41);
        ModifyAttentiveValues("Facial_Blends.BrowsDown_Right", 41);
        ModifyAttentiveValues("Facial_Blends.BrowsIn_Left", 100);
        ModifyAttentiveValues("Facial_Blends.BrowsIn_Right", 100);
        ModifyAttentiveValues("Facial_Blends.BrowsUp_Left", 23);
        ModifyAttentiveValues("Facial_Blends.BrowsUp_Right", 23);
        ModifyAttentiveValues("Facial_Blends.MouthDown", 33);
    }

    private void SetBoredExpression()
    {
        ModifyBoredValues("Facial_Blends.CheekPuff_Left", 35);
        ModifyBoredValues("Facial_Blends.CheekPuff_Right", 27);
        ModifyBoredValues("Facial_Blends.Jaw_Forward", 17);
        ModifyBoredValues("Facial_Blends.Jaw_Up", 92);
        ModifyBoredValues("Facial_Blends.LowerLipOut", 100);
        ModifyBoredValues("Facial_Blends.MouthNarrow_Left", 59);
        ModifyBoredValues("Facial_Blends.MouthNarrow_Right", 59);
        ModifyBoredValues("Facial_Blends.UpperLipIn", 70);
    }

    private void SetCryingExpression()
    {
        ModifyExpressionValues("Facial_Blends.Blink_Left", 18, cryingExpression);
        ModifyExpressionValues("Facial_Blends.Blink_Right", 18, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Left", 96, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsDown_Right", 96, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Left", 100, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsIn_Right", 100, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Left", 100, cryingExpression);
        ModifyExpressionValues("Facial_Blends.BrowsOuterLower_Right", 100, cryingExpression);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Left", 14, cryingExpression);
        ModifyExpressionValues("Facial_Blends.LowerLipDown_Right", 12, cryingExpression);
        ModifyExpressionValues("Facial_Blends.LowerLipIn", 100, cryingExpression);
        ModifyExpressionValues("Facial_Blends.UpperLipIn", 100, cryingExpression);
    }

    private void SetCrying02Expression()
    {
        ModifyCrying02Values("Facial_Blends.Blink_Left", 95);
        ModifyCrying02Values("Facial_Blends.Blink_Right", 90);
        ModifyCrying02Values("Facial_Blends.BrowsDown_Left", 100);
        ModifyCrying02Values("Facial_Blends.BrowsDown_Right", 100);
        ModifyCrying02Values("Facial_Blends.BrowsIn_Left", 86);
        ModifyCrying02Values("Facial_Blends.BrowsIn_Right", 100);
        ModifyCrying02Values("Facial_Blends.BrowsOuterLower_Left", 73);
        ModifyCrying02Values("Facial_Blends.BrowsOuterLower_Right", 60);
        ModifyCrying02Values("Facial_Blends.Jaw_Up", 53);
        ModifyCrying02Values("Facial_Blends.LowerLipDown_Left", 75);
        ModifyCrying02Values("Facial_Blends.LowerLipDown_Right", 75);
        ModifyCrying02Values("Facial_Blends.LowerLipIn", 100);
        ModifyCrying02Values("Facial_Blends.NoseScrunch_Left", 86);
        ModifyCrying02Values("Facial_Blends.NoseScrunch_Right", 86);
        ModifyCrying02Values("Facial_Blends.UpperLipUp_Left", 46);
        ModifyCrying02Values("Facial_Blends.UpperLipUp_Right", 40);
    }

    private void SetCuriousExpression()
    {
        ModifyCuriousValues("Facial_Blends.BrowsOuterLower_Left", 27);
        ModifyCuriousValues("Facial_Blends.BrowsOuterLower_Right", 27);
        ModifyCuriousValues("Facial_Blends.BrowsUp_Left", 35);
        ModifyCuriousValues("Facial_Blends.BrowsUp_Right", 35);
        ModifyCuriousValues("Facial_Blends.EyesWide_Left", 69);
        ModifyCuriousValues("Facial_Blends.EyesWide_Right", 69);
        ModifyCuriousValues("Facial_Blends.Jaw_Down", 17);
    }

    private void SetDisgustedExpress()
    {
        ModifyDisgustedValues("Facial_Blends.BrowsDown_Left", 71);
        ModifyDisgustedValues("Facial_Blends.BrowsDown_Right", 82);
        ModifyDisgustedValues("Facial_Blends.BrowsIn_Left", 58);
        ModifyDisgustedValues("Facial_Blends.BrowsIn_Right", 58);
        ModifyDisgustedValues("Facial_Blends.Frown_Left", 91);
        ModifyDisgustedValues("Facial_Blends.Frown_Right", 91);
        ModifyDisgustedValues("Facial_Blends.JawRotateZ_Left", 33);
        ModifyDisgustedValues("Facial_Blends.NoseScrunch_Left", 36);
        ModifyDisgustedValues("Facial_Blends.NoseScrunch_Right", 28);
    }

    private void SetDisgusted02Express()
    {
        ModifyDisgusted02Values("Facial_Blends.BrowsDown_Left", 89);
        ModifyDisgusted02Values("Facial_Blends.BrowsDown_Right", 37);
        ModifyDisgusted02Values("Facial_Blends.BrowsIn_Left", 95);
        ModifyDisgusted02Values("Facial_Blends.BrowsIn_Right", 80);
        ModifyDisgusted02Values("Facial_Blends.BrowsOuterLower_Left", 26);
        ModifyDisgusted02Values("Facial_Blends.Frown_Left", 30);
        ModifyDisgusted02Values("Facial_Blends.JawRotateZ_Left", 33);
        ModifyDisgusted02Values("Facial_Blends.Jaw_Down", 4);
        ModifyDisgusted02Values("Facial_Blends.NoseScrunch_Left", 94);
        ModifyDisgusted02Values("Facial_Blends.NoseScrunch_Right", 4);
        ModifyDisgusted02Values("Facial_Blends.Squint_Left", 44);
        ModifyDisgusted02Values("Facial_Blends.Squint_Right", 52);
        ModifyDisgusted02Values("Facial_Blends.UpperLipUp_Left", 66);
        ModifyDisgusted02Values("Facial_Blends.UpperLipUp_Right", 26);
    }

    private void SetDrainedExpression()
    {
        ModifyDrainedValues("Facial_Blends.Blink_Left", 75);
        ModifyDrainedValues("Facial_Blends.Blink_Right", 75);
        ModifyDrainedValues("Facial_Blends.BrowsDown_Left", 28);
        ModifyDrainedValues("Facial_Blends.BrowsDown_Right", 28);
        ModifyDrainedValues("Facial_Blends.BrowsIn_Left", 92);
        ModifyDrainedValues("Facial_Blends.BrowsIn_Right", 92);
        ModifyDrainedValues("Facial_Blends.BrowsOuterLower_Left", 84);
        ModifyDrainedValues("Facial_Blends.BrowsOuterLower_Right", 84);
        ModifyDrainedValues("Facial_Blends.LowerLipDown_Left", 26);
        ModifyDrainedValues("Facial_Blends.LowerLipDown_Right", 37);
        ModifyDrainedValues("Facial_Blends.MouthDown", 25);
        ModifyDrainedValues("Facial_Blends.MouthOpen", 18);
    }

    private void SetFrownExpression()
    {
        ModifyFrownValues("Facial_Blends.BrowsIn_Left", 92);
        ModifyFrownValues("Facial_Blends.BrowsIn_Right", 95);
        ModifyFrownValues("Facial_Blends.LowerLipOut", 44);
        ModifyFrownValues("Facial_Blends.Frown_Left", 50);
        ModifyFrownValues("Facial_Blends.Frown_Right", 50);
    }



    private void SetGlareExpression()
    {
        ModifyGlareValues("Facial_Blends.BrowsDown_Left", 98);
        ModifyGlareValues("Facial_Blends.BrowsDown_Right", 83);
        ModifyGlareValues("Facial_Blends.BrowsIn_Left", 98);
        ModifyGlareValues("Facial_Blends.BrowsIn_Right", 83);
        ModifyGlareValues("Facial_Blends.NoseScrunch_Left", 39);
        ModifyGlareValues("Facial_Blends.NoseScrunch_Right", 47);
        ModifyGlareValues("Facial_Blends.Squint_Right", 72);
        ModifyGlareValues("Facial_Blends.Squint_Left", 65);
    }

    private void SetFuryExpression()
    {
        ModifyFuryValues("Facial_Blends.BrowsDown_Left", 98);
        ModifyFuryValues("Facial_Blends.BrowsDown_Right", 83);
        ModifyFuryValues("Facial_Blends.BrowsIn_Left", 98);
        ModifyFuryValues("Facial_Blends.BrowsIn_Right", 83);
        ModifyFuryValues("Facial_Blends.LowerLipOut", 89);
        ModifyFuryValues("Facial_Blends.MouthOpen", 100);
        ModifyFuryValues("Facial_Blends.MouthUp", 30);
        ModifyFuryValues("Facial_Blends.Smile_Left", 35);
        ModifyFuryValues("Facial_Blends.NoseScrunch_Left", 39);
        ModifyFuryValues("Facial_Blends.NoseScrunch_Right", 47);
        ModifyFuryValues("Facial_Blends.Squint_Right", 72);
        ModifyFuryValues("Facial_Blends.Squint_Left", 65);
    }

    private void SetExcitedExpression()
    {
        ModifyExcitedValues("Facial_Blends.BrowsOuterLower_Left", 77);
        ModifyExcitedValues("Facial_Blends.BrowsUp_Left", 80);
        ModifyExcitedValues("Facial_Blends.BrowsUp_Right", 80);
        ModifyExcitedValues("Facial_Blends.LowerLipDown_Left", 62);
        ModifyExcitedValues("Facial_Blends.LowerLipDown_Right", 62);
        ModifyExcitedValues("Facial_Blends.MouthNarrow_Left", 40);
        ModifyExcitedValues("Facial_Blends.MouthNarrow_Right", 40);
        ModifyExcitedValues("Facial_Blends.Smile_Left", 50);
        ModifyExcitedValues("Facial_Blends.Smile_Right", 50);
        ModifyExcitedValues("Facial_Blends.UpperLipUp_Left", 50);
        ModifyExcitedValues("Facial_Blends.UpperLipUp_Right", 50);
    }

    private void SetBlink()
    {
        ModifyExpressionValues("Facial_Blends.Blink_Left", 100, blinkExpression);
        ModifyExpressionValues("Facial_Blends.Blink_Right", 100, blinkExpression);
    }

    private void ModifyExpressionValues(string blendShapeName, float blendShapeMaxValue, float expressionValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, expressionValue * (blendShapeMaxValue / 100));
    }

    private void ModifyCrying02Values(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, crying02Expression * (blendShapeMaxValue / 100));
    }

    private void ModifyExcitedValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, excitedExpression * (blendShapeMaxValue / 100));
    }

    void ModifyFuryValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, furyExpression * (blendShapeMaxValue / 100));
    }
    void ModifyGlareValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, glareExpression * (blendShapeMaxValue / 100));
    }

    private void ModifyFrownValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, frownExpression * (blendShapeMaxValue / 100));
    }

    private void ModifyDrainedValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, drainedExpression * (blendShapeMaxValue / 100));
    }

    private void ModifyDisgusted02Values(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, disgusted02Expression * (blendShapeMaxValue / 100));
    }

    private void ModifyDisgustedValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, disgustedExpression * (blendShapeMaxValue / 100));
    }
    private void ModifyCuriousValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, curiousExpression * (blendShapeMaxValue / 100));
    }
    private void ModifyBoredValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, boredExpression * (blendShapeMaxValue / 100));
    }
    private void ModifyAttentiveValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, attentiveExpression * (blendShapeMaxValue / 100));
    }
    private void ModifyArrogantValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, arrogantExpression * (blendShapeMaxValue / 100));
    }
    private void ModifyVisemeValues(string blendShapeName, float blendShapeMaxValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, blendShapeMaxValue / 100);
    }

    private void ModifyVisemeValues(string blendShapeName, float blendShapeMaxValue, float expressionValue)
    {
        int index = skinnedMeshRenderer.sharedMesh.GetBlendShapeIndex(blendShapeName);
        if (index != -1)
            skinnedMeshRenderer.SetBlendShapeWeight(index, blendShapeMaxValue / 100);
    }
}
