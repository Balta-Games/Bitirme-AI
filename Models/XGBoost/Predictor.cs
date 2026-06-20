using static System.Math;
namespace ML {
    public static class Model {
        public static double[] Score(double[] input) {
            double var0;
            if (input[2] < 0.83) {
                if (input[1] < 3.0) {
                    if (input[13] < 405.0) {
                        var0 = -0.06609589;
                    } else {
                        var0 = -0.003709303;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var0 = -0.03477411;
                    } else {
                        var0 = 0.115242265;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[0] < 10.0) {
                        var0 = -0.058087446;
                    } else {
                        var0 = 0.108702436;
                    }
                } else {
                    if (input[2] < 1.33) {
                        var0 = 0.11424782;
                    } else {
                        var0 = 0.17623721;
                    }
                }
            }
            double var1;
            if (input[2] < 0.77) {
                if (input[10] < 12.0) {
                    if (input[11] < 5.0) {
                        var1 = -0.07462346;
                    } else {
                        var1 = -0.009031749;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var1 = 0.10948815;
                    } else {
                        var1 = -0.0009956914;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[5] < 0.78) {
                        var1 = -0.04650287;
                    } else {
                        var1 = 0.04494567;
                    }
                } else {
                    if (input[2] < 0.82) {
                        var1 = -0.051876742;
                    } else {
                        var1 = -0.07953209;
                    }
                }
            }
            double var2;
            if (input[0] < 4.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.98) {
                        var2 = -0.05586359;
                    } else {
                        var2 = 0.09672758;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var2 = 0.22113124;
                    } else {
                        var2 = -0.03316423;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[1] < 2.0) {
                        var2 = 0.06413241;
                    } else {
                        var2 = 0.2547885;
                    }
                } else {
                    if (input[5] < 0.28) {
                        var2 = 0.0708026;
                    } else {
                        var2 = -0.037280563;
                    }
                }
            }
            double var3;
            if (input[10] < 12.0) {
                if (input[2] < 0.74) {
                    if (input[11] < 5.0) {
                        var3 = 0.23100153;
                    } else {
                        var3 = 0.13373022;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var3 = 0.11970611;
                    } else {
                        var3 = -0.037371475;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[5] < 0.24) {
                        var3 = 0.06299458;
                    } else {
                        var3 = -0.03930173;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var3 = -0.022434276;
                    } else {
                        var3 = -0.060958564;
                    }
                }
            }
            double var4;
            if (input[2] < 0.83) {
                if (input[1] < 3.0) {
                    if (input[13] < 405.0) {
                        var4 = -0.06423213;
                    } else {
                        var4 = -0.002017459;
                    }
                } else {
                    if (input[10] < 19.0) {
                        var4 = -0.05056258;
                    } else {
                        var4 = 0.073035054;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[0] < 10.0) {
                        var4 = -0.05660605;
                    } else {
                        var4 = 0.099257514;
                    }
                } else {
                    if (input[2] < 1.33) {
                        var4 = 0.0984449;
                    } else {
                        var4 = 0.14890493;
                    }
                }
            }
            double var5;
            if (input[2] < 0.77) {
                if (input[10] < 12.0) {
                    if (input[11] < 5.0) {
                        var5 = -0.07076136;
                    } else {
                        var5 = -0.0081921;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var5 = 0.09805237;
                    } else {
                        var5 = -0.00086793967;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[5] < 0.78) {
                        var5 = -0.043805607;
                    } else {
                        var5 = 0.042579852;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var5 = -0.059707414;
                    } else {
                        var5 = -0.07684495;
                    }
                }
            }
            double var6;
            if (input[0] < 4.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.98) {
                        var6 = -0.055199485;
                    } else {
                        var6 = 0.08562842;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var6 = 0.18401651;
                    } else {
                        var6 = -0.032424286;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[3] < 4.0) {
                        var6 = 0.20474195;
                    } else {
                        var6 = 0.07651841;
                    }
                } else {
                    if (input[5] < 0.29) {
                        var6 = 0.06313893;
                    } else {
                        var6 = -0.036699057;
                    }
                }
            }
            double var7;
            if (input[10] < 13.0) {
                if (input[2] < 0.74) {
                    if (input[12] < 1.77) {
                        var7 = 0.18339106;
                    } else {
                        var7 = 0.09859262;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var7 = 0.08792093;
                    } else {
                        var7 = -0.038032375;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[2] < 0.37) {
                        var7 = 0.021609547;
                    } else {
                        var7 = -0.058453824;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var7 = -0.020862876;
                    } else {
                        var7 = -0.059878614;
                    }
                }
            }
            double var8;
            if (input[2] < 0.83) {
                if (input[2] < 0.57) {
                    if (input[13] < 501.0) {
                        var8 = -0.06375038;
                    } else {
                        var8 = 0.00033339259;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var8 = -0.045346726;
                    } else {
                        var8 = 0.0743809;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[0] < 10.0) {
                        var8 = -0.055170145;
                    } else {
                        var8 = 0.090520196;
                    }
                } else {
                    if (input[2] < 1.33) {
                        var8 = 0.08629111;
                    } else {
                        var8 = 0.12975655;
                    }
                }
            }
            double var9;
            if (input[2] < 0.77) {
                if (input[10] < 12.0) {
                    if (input[12] < 1.77) {
                        var9 = -0.06679229;
                    } else {
                        var9 = -0.004174353;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var9 = 0.089039855;
                    } else {
                        var9 = -0.0005915645;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[3] < 4.0) {
                        var9 = -0.041820075;
                    } else {
                        var9 = 0.03913611;
                    }
                } else {
                    if (input[5] < 3.34) {
                        var9 = -0.071470596;
                    } else {
                        var9 = 0.024606777;
                    }
                }
            }
            double var10;
            if (input[0] < 4.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.98) {
                        var10 = -0.054549355;
                    } else {
                        var10 = 0.076691695;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var10 = 0.13771549;
                    } else {
                        var10 = -0.052390285;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[2] < 0.84) {
                        var10 = 0.05555251;
                    } else {
                        var10 = 0.16344841;
                    }
                } else {
                    if (input[5] < 0.33) {
                        var10 = 0.055684377;
                    } else {
                        var10 = -0.03682111;
                    }
                }
            }
            double var11;
            if (input[10] < 13.0) {
                if (input[2] < 0.93) {
                    if (input[1] < 3.0) {
                        var11 = 0.1387171;
                    } else {
                        var11 = 0.009547396;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var11 = 0.033584725;
                    } else {
                        var11 = -0.053275105;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[2] < 0.37) {
                        var11 = 0.021903334;
                    } else {
                        var11 = -0.057451036;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var11 = -0.058627672;
                    } else {
                        var11 = -0.0034965375;
                    }
                }
            }
            double var12;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var12 = -0.06302052;
                    } else {
                        var12 = -0.026607532;
                    }
                } else {
                    if (input[2] < 0.43) {
                        var12 = -0.05471384;
                    } else {
                        var12 = 0.044848587;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var12 = -0.06438457;
                    } else {
                        var12 = 0.056339372;
                    }
                } else {
                    if (input[2] < 1.17) {
                        var12 = 0.05017358;
                    } else {
                        var12 = 0.109176755;
                    }
                }
            }
            double var13;
            if (input[2] < 0.77) {
                if (input[10] < 12.0) {
                    if (input[11] < 5.0) {
                        var13 = -0.06506768;
                    } else {
                        var13 = -0.0041875457;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var13 = 0.08172602;
                    } else {
                        var13 = -0.0012867685;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[5] < 0.78) {
                        var13 = -0.038064774;
                    } else {
                        var13 = 0.039595354;
                    }
                } else {
                    if (input[5] < 3.34) {
                        var13 = -0.0687362;
                    } else {
                        var13 = 0.025578503;
                    }
                }
            }
            double var14;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var14 = -0.05619622;
                } else {
                    var14 = 0.01831584;
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[2] < 0.84) {
                        var14 = 0.02233247;
                    } else {
                        var14 = 0.13631932;
                    }
                } else {
                    if (input[5] < 0.26) {
                        var14 = 0.058493715;
                    } else {
                        var14 = -0.035087466;
                    }
                }
            }
            double var15;
            if (input[10] < 13.0) {
                if (input[2] < 0.93) {
                    if (input[11] < 5.0) {
                        var15 = 0.13143972;
                    } else {
                        var15 = 0.060581334;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var15 = 0.03206366;
                    } else {
                        var15 = -0.052286237;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[3] < 2.0) {
                        var15 = 0.038865484;
                    } else {
                        var15 = -0.04571439;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var15 = -0.016623745;
                    } else {
                        var15 = -0.057924725;
                    }
                }
            }
            double var16;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var16 = -0.061683226;
                    } else {
                        var16 = -0.025662592;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var16 = -0.054932315;
                    } else {
                        var16 = 0.040592566;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var16 = -0.063129164;
                    } else {
                        var16 = 0.053382464;
                    }
                } else {
                    if (input[2] < 1.2) {
                        var16 = 0.046892963;
                    } else {
                        var16 = 0.10004213;
                    }
                }
            }
            double var17;
            if (input[2] < 0.77) {
                if (input[12] < 2.0) {
                    if (input[11] < 6.0) {
                        var17 = -0.061671507;
                    } else {
                        var17 = -0.0063265464;
                    }
                } else {
                    if (input[5] < 0.28) {
                        var17 = 0.03611607;
                    } else {
                        var17 = 0.081038915;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[3] < 4.0) {
                        var17 = -0.036512084;
                    } else {
                        var17 = 0.037370753;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var17 = -0.051056534;
                    } else {
                        var17 = -0.06868725;
                    }
                }
            }
            double var18;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var18 = -0.0557176;
                } else {
                    var18 = 0.018075129;
                }
            } else {
                if (input[12] < 3.59) {
                    if (input[3] < 4.0) {
                        var18 = 0.10347121;
                    } else {
                        var18 = 0.008358787;
                    }
                } else {
                    if (input[5] < 0.44) {
                        var18 = 0.020043809;
                    } else {
                        var18 = -0.051068008;
                    }
                }
            }
            double var19;
            if (input[10] < 13.0) {
                if (input[1] < 3.0) {
                    if (input[12] < 1.63) {
                        var19 = 0.11850404;
                    } else {
                        var19 = 0.059820306;
                    }
                } else {
                    if (input[2] < 0.89) {
                        var19 = 0.0060343775;
                    } else {
                        var19 = -0.056341555;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[2] < 0.37) {
                        var19 = 0.025156816;
                    } else {
                        var19 = -0.0558342;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var19 = -0.015038705;
                    } else {
                        var19 = -0.057035077;
                    }
                }
            }
            double var20;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var20 = -0.060486235;
                    } else {
                        var20 = -0.023754653;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var20 = -0.053393435;
                    } else {
                        var20 = 0.040010106;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[2] < 1.96) {
                        var20 = -0.051529266;
                    } else {
                        var20 = 0.075934984;
                    }
                } else {
                    if (input[2] < 1.33) {
                        var20 = 0.05626976;
                    } else {
                        var20 = 0.09699514;
                    }
                }
            }
            double var21;
            if (input[2] < 0.77) {
                if (input[12] < 2.06) {
                    if (input[11] < 5.0) {
                        var21 = -0.06127295;
                    } else {
                        var21 = -0.014769847;
                    }
                } else {
                    if (input[5] < 0.27) {
                        var21 = 0.033165965;
                    } else {
                        var21 = 0.07599557;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[2] < 1.06) {
                        var21 = 0.018868653;
                    } else {
                        var21 = -0.053263523;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var21 = -0.04865031;
                    } else {
                        var21 = -0.06670395;
                    }
                }
            }
            double var22;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var22 = -0.055277374;
                } else {
                    var22 = 0.017426314;
                }
            } else {
                if (input[12] < 3.59) {
                    if (input[3] < 4.0) {
                        var22 = 0.09172351;
                    } else {
                        var22 = 0.007843086;
                    }
                } else {
                    if (input[5] < 0.44) {
                        var22 = 0.01940271;
                    } else {
                        var22 = -0.050347693;
                    }
                }
            }
            double var23;
            if (input[10] < 13.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 1.06) {
                        var23 = 0.09552356;
                    } else {
                        var23 = -0.02830796;
                    }
                } else {
                    if (input[2] < 0.89) {
                        var23 = 0.005235233;
                    } else {
                        var23 = -0.055689424;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[3] < 2.0) {
                        var23 = 0.04074152;
                    } else {
                        var23 = -0.04327651;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var23 = -0.05593114;
                    } else {
                        var23 = 0.0045513134;
                    }
                }
            }
            double var24;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var24 = -0.05940042;
                    } else {
                        var24 = -0.02189972;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var24 = -0.05193266;
                    } else {
                        var24 = 0.039499536;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var24 = -0.061309572;
                    } else {
                        var24 = 0.045645077;
                    }
                } else {
                    if (input[2] < 1.43) {
                        var24 = 0.046388295;
                    } else {
                        var24 = 0.092985995;
                    }
                }
            }
            double var25;
            if (input[2] < 0.67) {
                if (input[10] < 12.0) {
                    if (input[12] < 1.77) {
                        var25 = -0.057749595;
                    } else {
                        var25 = -0.0025698568;
                    }
                } else {
                    if (input[14] < 111.0) {
                        var25 = 0.073066205;
                    } else {
                        var25 = 0.027628014;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[4] < 1.0) {
                        var25 = -0.04612038;
                    } else {
                        var25 = 0.026460493;
                    }
                } else {
                    if (input[2] < 0.81) {
                        var25 = -0.03148552;
                    } else {
                        var25 = -0.06350278;
                    }
                }
            }
            double var26;
            if (input[2] < 0.59) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.54) {
                        var26 = -0.054624554;
                    } else {
                        var26 = -0.026442269;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var26 = 0.088609725;
                    } else {
                        var26 = -0.038695954;
                    }
                }
            } else {
                if (input[12] < 2.98) {
                    if (input[1] < 2.0) {
                        var26 = -0.0021209295;
                    } else {
                        var26 = 0.09806415;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var26 = 0.032178883;
                    } else {
                        var26 = -0.039979454;
                    }
                }
            }
            double var27;
            if (input[10] < 13.0) {
                if (input[1] < 3.0) {
                    if (input[11] < 5.0) {
                        var27 = 0.09682682;
                    } else {
                        var27 = 0.044916406;
                    }
                } else {
                    if (input[2] < 0.89) {
                        var27 = 0.004673477;
                    } else {
                        var27 = -0.054983247;
                    }
                }
            } else {
                if (input[14] < 144.0) {
                    if (input[10] < 17.0) {
                        var27 = -0.040205784;
                    } else {
                        var27 = -0.057251748;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var27 = 0.04648342;
                    } else {
                        var27 = -0.05643035;
                    }
                }
            }
            double var28;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var28 = -0.0584023;
                    } else {
                        var28 = -0.020113556;
                    }
                } else {
                    if (input[2] < 0.43) {
                        var28 = -0.048304807;
                    } else {
                        var28 = 0.04196787;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var28 = -0.060264897;
                    } else {
                        var28 = 0.04384614;
                    }
                } else {
                    if (input[2] < 1.14) {
                        var28 = 0.030876169;
                    } else {
                        var28 = 0.07801256;
                    }
                }
            }
            double var29;
            if (input[2] < 0.77) {
                if (input[12] < 2.0) {
                    if (input[5] < 0.74) {
                        var29 = -0.05676967;
                    } else {
                        var29 = -0.004459664;
                    }
                } else {
                    if (input[5] < 0.28) {
                        var29 = 0.025951786;
                    } else {
                        var29 = 0.0675937;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var29 = -0.047896724;
                    } else {
                        var29 = 0.068105124;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var29 = -0.037238255;
                    } else {
                        var29 = -0.06340445;
                    }
                }
            }
            double var30;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var30 = -0.054474443;
                } else {
                    var30 = 0.016717937;
                }
            } else {
                if (input[12] < 3.59) {
                    if (input[0] < 10.0) {
                        var30 = 0.07012892;
                    } else {
                        var30 = -0.024914617;
                    }
                } else {
                    if (input[5] < 0.44) {
                        var30 = 0.01791979;
                    } else {
                        var30 = -0.04909971;
                    }
                }
            }
            double var31;
            if (input[10] < 13.0) {
                if (input[2] < 0.93) {
                    if (input[11] < 4.0) {
                        var31 = 0.09362556;
                    } else {
                        var31 = 0.04750867;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var31 = 0.018570838;
                    } else {
                        var31 = -0.04993346;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[2] < 0.37) {
                        var31 = 0.02887418;
                    } else {
                        var31 = -0.053788096;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var31 = -0.008504166;
                    } else {
                        var31 = -0.05469295;
                    }
                }
            }
            double var32;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var32 = -0.05750507;
                    } else {
                        var32 = -0.01798451;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var32 = -0.05763474;
                    } else {
                        var32 = 0.030316884;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var32 = -0.059406616;
                    } else {
                        var32 = 0.039214622;
                    }
                } else {
                    if (input[2] < 1.43) {
                        var32 = 0.03814095;
                    } else {
                        var32 = 0.082252614;
                    }
                }
            }
            double var33;
            if (input[2] < 0.84) {
                if (input[12] < 2.11) {
                    if (input[11] < 5.0) {
                        var33 = -0.056413796;
                    } else {
                        var33 = -0.00800993;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var33 = 0.057222486;
                    } else {
                        var33 = -0.024960201;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var33 = -0.050938357;
                    } else {
                        var33 = 0.06104792;
                    }
                } else {
                    if (input[5] < 3.34) {
                        var33 = -0.05956769;
                    } else {
                        var33 = 0.039985843;
                    }
                }
            }
            double var34;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var34 = -0.05411873;
                } else {
                    var34 = 0.015874574;
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[5] < 0.72) {
                        var34 = 0.06936261;
                    } else {
                        var34 = -0.0065570953;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var34 = 0.0196725;
                    } else {
                        var34 = -0.044441994;
                    }
                }
            }
            double var35;
            if (input[10] < 13.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 1.21) {
                        var35 = 0.073866725;
                    } else {
                        var35 = -0.05234496;
                    }
                } else {
                    if (input[2] < 0.89) {
                        var35 = 0.0009788466;
                    } else {
                        var35 = -0.05367859;
                    }
                }
            } else {
                if (input[14] < 144.0) {
                    if (input[10] < 17.0) {
                        var35 = -0.03741948;
                    } else {
                        var35 = -0.05602723;
                    }
                } else {
                    if (input[5] < 0.27) {
                        var35 = 0.059218287;
                    } else {
                        var35 = -0.043996863;
                    }
                }
            }
            double var36;
            if (input[2] < 0.71) {
                if (input[11] < 14.0) {
                    if (input[1] < 3.0) {
                        var36 = -0.05658601;
                    } else {
                        var36 = -0.020770753;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var36 = -0.056773633;
                    } else {
                        var36 = 0.054885097;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[2] < 1.96) {
                        var36 = -0.04855629;
                    } else {
                        var36 = 0.061122824;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var36 = 0.03356398;
                    } else {
                        var36 = 0.072895356;
                    }
                }
            }
            double var37;
            if (input[2] < 0.84) {
                if (input[12] < 2.11) {
                    if (input[11] < 5.0) {
                        var37 = -0.05475947;
                    } else {
                        var37 = -0.0065389737;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var37 = 0.054059662;
                    } else {
                        var37 = -0.02390459;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var37 = -0.049128726;
                    } else {
                        var37 = 0.05870658;
                    }
                } else {
                    if (input[5] < 3.34) {
                        var37 = -0.05815172;
                    } else {
                        var37 = 0.039618228;
                    }
                }
            }
            double var38;
            if (input[2] < 0.55) {
                if (input[0] < 4.0) {
                    if (input[2] < 0.54) {
                        var38 = -0.053582728;
                    } else {
                        var38 = -0.012669313;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var38 = 0.1038376;
                    } else {
                        var38 = -0.042483814;
                    }
                }
            } else {
                if (input[12] < 3.65) {
                    if (input[0] < 9.0) {
                        var38 = 0.064471446;
                    } else {
                        var38 = -0.014041399;
                    }
                } else {
                    if (input[3] < 2.0) {
                        var38 = 0.023276456;
                    } else {
                        var38 = -0.043338906;
                    }
                }
            }
            double var39;
            if (input[10] < 13.0) {
                if (input[2] < 0.93) {
                    if (input[11] < 5.0) {
                        var39 = 0.078545645;
                    } else {
                        var39 = 0.031869415;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var39 = 0.01606136;
                    } else {
                        var39 = -0.048594248;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[2] < 0.37) {
                        var39 = 0.031260215;
                    } else {
                        var39 = -0.05233231;
                    }
                } else {
                    if (input[14] < 153.0) {
                        var39 = -0.053911865;
                    } else {
                        var39 = -0.019450067;
                    }
                }
            }
            double var40;
            if (input[2] < 0.71) {
                if (input[11] < 14.0) {
                    if (input[1] < 3.0) {
                        var40 = -0.05578236;
                    } else {
                        var40 = -0.020112209;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var40 = -0.05595056;
                    } else {
                        var40 = 0.052677985;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[1] < 8.0) {
                        var40 = -0.05461464;
                    } else {
                        var40 = 0.07741652;
                    }
                } else {
                    if (input[11] < 11.0) {
                        var40 = 0.029647052;
                    } else {
                        var40 = 0.07266192;
                    }
                }
            }
            double var41;
            if (input[2] < 0.84) {
                if (input[12] < 2.11) {
                    if (input[11] < 4.0) {
                        var41 = -0.05675754;
                    } else {
                        var41 = -0.0129438955;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var41 = 0.05110663;
                    } else {
                        var41 = -0.022567037;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var41 = -0.047607016;
                    } else {
                        var41 = 0.05617355;
                    }
                } else {
                    if (input[5] < 3.34) {
                        var41 = -0.05683288;
                    } else {
                        var41 = 0.039059293;
                    }
                }
            }
            double var42;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var42 = -0.05346377;
                } else {
                    var42 = 0.014646212;
                }
            } else {
                if (input[3] < 3.0) {
                    if (input[0] < 9.0) {
                        var42 = 0.064177394;
                    } else {
                        var42 = -0.028559882;
                    }
                } else {
                    if (input[13] < 139.0) {
                        var42 = 0.030370802;
                    } else {
                        var42 = -0.040662248;
                    }
                }
            }
            double var43;
            if (input[10] < 13.0) {
                if (input[0] < 3.0) {
                    if (input[5] < 1.04) {
                        var43 = 0.07871389;
                    } else {
                        var43 = -0.0021214911;
                    }
                } else {
                    if (input[10] < 5.0) {
                        var43 = 0.04099397;
                    } else {
                        var43 = -0.032453354;
                    }
                }
            } else {
                if (input[14] < 144.0) {
                    if (input[10] < 17.0) {
                        var43 = -0.034693915;
                    } else {
                        var43 = -0.054973405;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var43 = 0.049086902;
                    } else {
                        var43 = -0.054320622;
                    }
                }
            }
            double var44;
            if (input[2] < 0.71) {
                if (input[13] < 343.0) {
                    if (input[1] < 3.0) {
                        var44 = -0.05517603;
                    } else {
                        var44 = -0.017038425;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var44 = -0.05502611;
                    } else {
                        var44 = 0.03258035;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[0] < 11.0) {
                        var44 = -0.057437558;
                    } else {
                        var44 = 0.032166384;
                    }
                } else {
                    if (input[2] < 1.43) {
                        var44 = 0.028504496;
                    } else {
                        var44 = 0.07239833;
                    }
                }
            }
            double var45;
            if (input[2] < 0.84) {
                if (input[10] < 12.0) {
                    if (input[5] < 0.44) {
                        var45 = -0.053754594;
                    } else {
                        var45 = 0.00053817354;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var45 = 0.050552674;
                    } else {
                        var45 = -0.020896293;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var45 = -0.045813296;
                    } else {
                        var45 = 0.053798504;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var45 = -0.04087631;
                    } else {
                        var45 = -0.059208628;
                    }
                }
            }
            double var46;
            if (input[2] < 0.59) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.54) {
                        var46 = -0.05286918;
                    } else {
                        var46 = -0.026100406;
                    }
                } else {
                    if (input[8] < 4.0) {
                        var46 = -0.05300771;
                    } else {
                        var46 = 0.056201722;
                    }
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[5] < 0.69) {
                        var46 = 0.061216515;
                    } else {
                        var46 = -0.004490282;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var46 = 0.016529394;
                    } else {
                        var46 = -0.04299091;
                    }
                }
            }
            double var47;
            if (input[10] < 13.0) {
                if (input[1] < 3.0) {
                    if (input[5] < 0.74) {
                        var47 = 0.06793941;
                    } else {
                        var47 = 0.018320428;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var47 = -0.005356171;
                    } else {
                        var47 = -0.0579694;
                    }
                }
            } else {
                if (input[10] < 15.0) {
                    if (input[3] < 2.0) {
                        var47 = 0.048810538;
                    } else {
                        var47 = -0.037463125;
                    }
                } else {
                    if (input[12] < 2.43) {
                        var47 = -0.0005680944;
                    } else {
                        var47 = -0.05210715;
                    }
                }
            }
            double var48;
            if (input[2] < 0.71) {
                if (input[11] < 14.0) {
                    if (input[1] < 3.0) {
                        var48 = -0.054371472;
                    } else {
                        var48 = -0.019733166;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var48 = -0.054474514;
                    } else {
                        var48 = 0.05245154;
                    }
                }
            } else {
                if (input[10] < 16.0) {
                    if (input[2] < 1.96) {
                        var48 = -0.046502646;
                    } else {
                        var48 = 0.053429622;
                    }
                } else {
                    if (input[2] < 1.33) {
                        var48 = 0.029635146;
                    } else {
                        var48 = 0.06745416;
                    }
                }
            }
            double var49;
            if (input[2] < 0.84) {
                if (input[12] < 1.77) {
                    if (input[4] < 6.0) {
                        var49 = -0.0486115;
                    } else {
                        var49 = 0.090000175;
                    }
                } else {
                    if (input[5] < 0.28) {
                        var49 = 0.0043692547;
                    } else {
                        var49 = 0.05185905;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var49 = -0.044117995;
                    } else {
                        var49 = 0.05200375;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var49 = -0.039149772;
                    } else {
                        var49 = -0.058315188;
                    }
                }
            }
            double var50;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var50 = -0.05289167;
                } else {
                    var50 = 0.014144567;
                }
            } else {
                if (input[3] < 4.0) {
                    if (input[0] < 9.0) {
                        var50 = 0.051421758;
                    } else {
                        var50 = -0.026163815;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var50 = 0.03750054;
                    } else {
                        var50 = -0.03775477;
                    }
                }
            }
            double var51;
            if (input[10] < 15.0) {
                if (input[2] < 0.93) {
                    if (input[13] < 107.0) {
                        var51 = 0.06661645;
                    } else {
                        var51 = 0.0106664635;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var51 = 0.0071110316;
                    } else {
                        var51 = -0.048972376;
                    }
                }
            } else {
                if (input[14] < 153.0) {
                    if (input[12] < 3.3) {
                        var51 = -0.041856445;
                    } else {
                        var51 = -0.054662574;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var51 = 0.06668236;
                    } else {
                        var51 = -0.05208714;
                    }
                }
            }
            double var52;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var52 = -0.054265626;
                    } else {
                        var52 = 0.030562451;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var52 = -0.052039005;
                    } else {
                        var52 = 0.061739124;
                    }
                }
            } else {
                if (input[10] < 17.0) {
                    if (input[0] < 9.0) {
                        var52 = -0.04534855;
                    } else {
                        var52 = 0.048410393;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var52 = 0.025056316;
                    } else {
                        var52 = 0.06312873;
                    }
                }
            }
            double var53;
            if (input[2] < 0.84) {
                if (input[11] < 5.0) {
                    if (input[5] < 1.03) {
                        var53 = -0.050315082;
                    } else {
                        var53 = 0.03625732;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var53 = 0.009216833;
                    } else {
                        var53 = 0.053347506;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var53 = -0.042705145;
                    } else {
                        var53 = 0.049821645;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var53 = -0.03760769;
                    } else {
                        var53 = -0.05750389;
                    }
                }
            }
            double var54;
            if (input[0] < 4.0) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.98) {
                        var54 = -0.049661193;
                    } else {
                        var54 = 0.045517053;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var54 = 0.07087191;
                    } else {
                        var54 = -0.052809633;
                    }
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[0] < 9.0) {
                        var54 = 0.05870694;
                    } else {
                        var54 = -0.019089503;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var54 = 0.01047681;
                    } else {
                        var54 = -0.042842157;
                    }
                }
            }
            double var55;
            if (input[10] < 15.0) {
                if (input[0] < 3.0) {
                    if (input[5] < 0.6) {
                        var55 = 0.07387861;
                    } else {
                        var55 = 0.01763802;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var55 = 0.033094015;
                    } else {
                        var55 = -0.040405598;
                    }
                }
            } else {
                if (input[14] < 153.0) {
                    if (input[0] < 1.0) {
                        var55 = -0.04126197;
                    } else {
                        var55 = -0.054411925;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var55 = 0.061609358;
                    } else {
                        var55 = -0.05148932;
                    }
                }
            }
            double var56;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var56 = -0.053681094;
                    } else {
                        var56 = 0.030588374;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var56 = -0.051214643;
                    } else {
                        var56 = 0.058970075;
                    }
                }
            } else {
                if (input[10] < 17.0) {
                    if (input[0] < 9.0) {
                        var56 = -0.04400776;
                    } else {
                        var56 = 0.044670895;
                    }
                } else {
                    if (input[11] < 11.0) {
                        var56 = 0.023594795;
                    } else {
                        var56 = 0.06139156;
                    }
                }
            }
            double var57;
            if (input[0] < 5.0) {
                if (input[10] < 11.0) {
                    if (input[3] < 4.0) {
                        var57 = -0.04804532;
                    } else {
                        var57 = 0.012723791;
                    }
                } else {
                    if (input[5] < 0.21) {
                        var57 = 0.0019841357;
                    } else {
                        var57 = 0.04639008;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var57 = -0.0377542;
                    } else {
                        var57 = 0.045528572;
                    }
                } else {
                    if (input[3] < 7.0) {
                        var57 = -0.05674829;
                    } else {
                        var57 = -0.033829127;
                    }
                }
            }
            double var58;
            if (input[0] < 3.0) {
                if (input[2] < 0.96) {
                    var58 = -0.052428525;
                } else {
                    var58 = 0.012357682;
                }
            } else {
                if (input[3] < 3.0) {
                    if (input[0] < 9.0) {
                        var58 = 0.050989397;
                    } else {
                        var58 = -0.02573136;
                    }
                } else {
                    if (input[13] < 139.0) {
                        var58 = 0.02364881;
                    } else {
                        var58 = -0.03863444;
                    }
                }
            }
            double var59;
            if (input[10] < 15.0) {
                if (input[1] < 2.0) {
                    if (input[5] < 0.6) {
                        var59 = 0.06781716;
                    } else {
                        var59 = 0.014601397;
                    }
                } else {
                    if (input[12] < 1.19) {
                        var59 = 0.019639572;
                    } else {
                        var59 = -0.047150742;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[14] < 124.0) {
                        var59 = -0.044303425;
                    } else {
                        var59 = 0.052616786;
                    }
                } else {
                    var59 = -0.054047924;
                }
            }
            double var60;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var60 = -0.053144395;
                    } else {
                        var60 = 0.030527664;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var60 = -0.05041879;
                    } else {
                        var60 = 0.056322575;
                    }
                }
            } else {
                if (input[11] < 9.0) {
                    if (input[0] < 8.0) {
                        var60 = -0.038235616;
                    } else {
                        var60 = 0.042218726;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var60 = 0.032488037;
                    } else {
                        var60 = 0.07120062;
                    }
                }
            }
            double var61;
            if (input[0] < 5.0) {
                if (input[11] < 5.0) {
                    if (input[5] < 1.03) {
                        var61 = -0.048715886;
                    } else {
                        var61 = 0.031250328;
                    }
                } else {
                    if (input[3] < 3.0) {
                        var61 = 0.010401308;
                    } else {
                        var61 = 0.049451824;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[10] < 9.0) {
                        var61 = -0.033760175;
                    } else {
                        var61 = 0.0463251;
                    }
                } else {
                    if (input[3] < 7.0) {
                        var61 = -0.055911954;
                    } else {
                        var61 = -0.032373685;
                    }
                }
            }
            double var62;
            if (input[2] < 0.59) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.54) {
                        var62 = -0.051855046;
                    } else {
                        var62 = -0.02396823;
                    }
                } else {
                    if (input[8] < 4.0) {
                        var62 = -0.05415395;
                    } else {
                        var62 = 0.046300363;
                    }
                }
            } else {
                if (input[5] < 0.69) {
                    if (input[10] < 22.0) {
                        var62 = 0.048654985;
                    } else {
                        var62 = -0.024002934;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var62 = 0.0379979;
                    } else {
                        var62 = -0.03773948;
                    }
                }
            }
            double var63;
            if (input[10] < 15.0) {
                if (input[2] < 0.99) {
                    if (input[13] < 154.0) {
                        var63 = 0.05315445;
                    } else {
                        var63 = -0.012302048;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var63 = 0.0016706983;
                    } else {
                        var63 = -0.052905317;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[14] < 124.0) {
                        var63 = -0.043627944;
                    } else {
                        var63 = 0.048836168;
                    }
                } else {
                    var63 = -0.053713452;
                }
            }
            double var64;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var64 = -0.052641224;
                    } else {
                        var64 = 0.030493373;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var64 = -0.04966208;
                    } else {
                        var64 = 0.053907253;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[1] < 8.0) {
                        var64 = -0.052786063;
                    } else {
                        var64 = 0.0618773;
                    }
                } else {
                    if (input[2] < 1.43) {
                        var64 = 0.01819811;
                    } else {
                        var64 = 0.06258291;
                    }
                }
            }
            double var65;
            if (input[2] < 0.84) {
                if (input[12] < 1.72) {
                    if (input[4] < 6.0) {
                        var65 = -0.044718992;
                    } else {
                        var65 = 0.083505645;
                    }
                } else {
                    if (input[5] < 0.28) {
                        var65 = 0.0010801041;
                    } else {
                        var65 = 0.0440989;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var65 = -0.039477196;
                    } else {
                        var65 = 0.04601225;
                    }
                } else {
                    if (input[1] < 3.0) {
                        var65 = -0.033483274;
                    } else {
                        var65 = -0.055541106;
                    }
                }
            }
            double var66;
            if (input[2] < 0.5) {
                var66 = -0.05153457;
            } else {
                if (input[5] < 0.69) {
                    if (input[0] < 9.0) {
                        var66 = 0.04221048;
                    } else {
                        var66 = -0.022431014;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var66 = 0.0329772;
                    } else {
                        var66 = -0.037512194;
                    }
                }
            }
            double var67;
            if (input[10] < 15.0) {
                if (input[1] < 3.0) {
                    if (input[11] < 6.0) {
                        var67 = 0.055941414;
                    } else {
                        var67 = 0.004711865;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var67 = -0.00804717;
                    } else {
                        var67 = -0.05675586;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[10] < 18.0) {
                        var67 = 0.020029351;
                    } else {
                        var67 = -0.05126843;
                    }
                } else {
                    var67 = -0.053423494;
                }
            }
            double var68;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var68 = -0.052153092;
                    } else {
                        var68 = 0.03023018;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var68 = -0.04894034;
                    } else {
                        var68 = 0.051947217;
                    }
                }
            } else {
                if (input[11] < 9.0) {
                    if (input[1] < 6.0) {
                        var68 = -0.03428909;
                    } else {
                        var68 = 0.04736381;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var68 = 0.029085426;
                    } else {
                        var68 = 0.06778767;
                    }
                }
            }
            double var69;
            if (input[1] < 3.0) {
                if (input[14] < 101.0) {
                    if (input[2] < 0.9) {
                        var69 = 0.046883326;
                    } else {
                        var69 = -0.013320866;
                    }
                } else {
                    if (input[13] < 129.0) {
                        var69 = -0.04297568;
                    } else {
                        var69 = 0.014934688;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[5] < 0.4) {
                        var69 = -0.04622723;
                    } else {
                        var69 = 0.04284447;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var69 = -0.05675723;
                    } else {
                        var69 = -0.031185055;
                    }
                }
            }
            double var70;
            if (input[0] < 4.0) {
                if (input[1] < 2.0) {
                    if (input[2] < 0.98) {
                        var70 = -0.052188892;
                    } else {
                        var70 = 0.023416935;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var70 = 0.041696507;
                    } else {
                        var70 = -0.041806873;
                    }
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[4] < 3.0) {
                        var70 = 0.049001932;
                    } else {
                        var70 = -0.015257602;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var70 = 0.010683283;
                    } else {
                        var70 = -0.040743213;
                    }
                }
            }
            double var71;
            if (input[10] < 15.0) {
                if (input[2] < 0.99) {
                    if (input[13] < 107.0) {
                        var71 = 0.054234724;
                    } else {
                        var71 = 0.004715141;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var71 = 0.00045680194;
                    } else {
                        var71 = -0.051992804;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[12] < 3.34) {
                        var71 = 0.019387865;
                    } else {
                        var71 = -0.05099184;
                    }
                } else {
                    var71 = -0.053147085;
                }
            }
            double var72;
            if (input[1] < 2.0) {
                if (input[13] < 343.0) {
                    if (input[2] < 1.1) {
                        var72 = -0.051927995;
                    } else {
                        var72 = 0.0105061205;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var72 = -0.046826303;
                    } else {
                        var72 = 0.046475764;
                    }
                }
            } else {
                if (input[10] < 13.0) {
                    if (input[1] < 8.0) {
                        var72 = -0.05177142;
                    } else {
                        var72 = 0.05673769;
                    }
                } else {
                    if (input[2] < 1.43) {
                        var72 = 0.018908849;
                    } else {
                        var72 = 0.06049446;
                    }
                }
            }
            double var73;
            if (input[1] < 3.0) {
                if (input[14] < 101.0) {
                    if (input[12] < 1.39) {
                        var73 = -0.05267611;
                    } else {
                        var73 = 0.042857636;
                    }
                } else {
                    if (input[13] < 154.0) {
                        var73 = -0.036480185;
                    } else {
                        var73 = 0.021017052;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[3] < 4.0) {
                        var73 = -0.02767221;
                    } else {
                        var73 = 0.05799825;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var73 = -0.056032818;
                    } else {
                        var73 = -0.030043377;
                    }
                }
            }
            double var74;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var74 = -0.051686276;
                } else {
                    var74 = 0.016628377;
                }
            } else {
                if (input[14] < 90.0) {
                    if (input[5] < 0.33) {
                        var74 = 0.013859602;
                    } else {
                        var74 = -0.039197743;
                    }
                } else {
                    if (input[0] < 10.0) {
                        var74 = 0.040318158;
                    } else {
                        var74 = -0.024212064;
                    }
                }
            }
            double var75;
            if (input[10] < 15.0) {
                if (input[1] < 2.0) {
                    if (input[5] < 0.6) {
                        var75 = 0.05967715;
                    } else {
                        var75 = 0.007376262;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var75 = 0.022221541;
                    } else {
                        var75 = -0.044673074;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[10] < 18.0) {
                        var75 = 0.020030526;
                    } else {
                        var75 = -0.050510705;
                    }
                } else {
                    var75 = -0.052898735;
                }
            }
            double var76;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var76 = -0.05127377;
                    } else {
                        var76 = 0.033244193;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var76 = -0.047885697;
                    } else {
                        var76 = 0.05324276;
                    }
                }
            } else {
                if (input[10] < 18.0) {
                    if (input[0] < 9.0) {
                        var76 = -0.03805574;
                    } else {
                        var76 = 0.041833207;
                    }
                } else {
                    if (input[11] < 12.0) {
                        var76 = 0.023067718;
                    } else {
                        var76 = 0.05783227;
                    }
                }
            }
            double var77;
            if (input[0] < 5.0) {
                if (input[14] < 103.0) {
                    if (input[1] < 2.0) {
                        var77 = 0.04636767;
                    } else {
                        var77 = 0.0007626931;
                    }
                } else {
                    if (input[5] < 0.27) {
                        var77 = -0.048054807;
                    } else {
                        var77 = 0.0076793693;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var77 = -0.03242552;
                    } else {
                        var77 = 0.0430366;
                    }
                } else {
                    if (input[3] < 7.0) {
                        var77 = -0.053492773;
                    } else {
                        var77 = -0.026463494;
                    }
                }
            }
            double var78;
            if (input[2] < 0.5) {
                var78 = -0.050893094;
            } else {
                if (input[5] < 0.97) {
                    if (input[10] < 23.0) {
                        var78 = 0.032343533;
                    } else {
                        var78 = -0.034484755;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var78 = 0.037461992;
                    } else {
                        var78 = -0.051027514;
                    }
                }
            }
            double var79;
            if (input[11] < 6.0) {
                if (input[2] < 1.1) {
                    if (input[1] < 4.0) {
                        var79 = 0.05053695;
                    } else {
                        var79 = -0.057144016;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var79 = -0.0040557114;
                    } else {
                        var79 = -0.054480474;
                    }
                }
            } else {
                if (input[14] < 135.0) {
                    if (input[5] < 0.24) {
                        var79 = -0.027084205;
                    } else {
                        var79 = -0.052616853;
                    }
                } else {
                    if (input[2] < 0.24) {
                        var79 = 0.055872858;
                    } else {
                        var79 = -0.036971714;
                    }
                }
            }
            double var80;
            if (input[2] < 0.57) {
                if (input[13] < 425.0) {
                    if (input[11] < 18.0) {
                        var80 = -0.05082354;
                    } else {
                        var80 = 0.0329272;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var80 = -0.047038466;
                    } else {
                        var80 = 0.05083088;
                    }
                }
            } else {
                if (input[13] < 140.0) {
                    if (input[1] < 6.0) {
                        var80 = -0.041281383;
                    } else {
                        var80 = 0.029622778;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var80 = 0.016485102;
                    } else {
                        var80 = 0.05571385;
                    }
                }
            }
            double var81;
            if (input[1] < 3.0) {
                if (input[11] < 5.0) {
                    if (input[14] < 81.0) {
                        var81 = 0.061966117;
                    } else {
                        var81 = -0.043130334;
                    }
                } else {
                    if (input[5] < 0.15) {
                        var81 = -0.0066290745;
                    } else {
                        var81 = 0.037517827;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[3] < 4.0) {
                        var81 = -0.025491362;
                    } else {
                        var81 = 0.055366267;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var81 = -0.054975808;
                    } else {
                        var81 = -0.027489586;
                    }
                }
            }
            double var82;
            if (input[1] < 2.0) {
                if (input[2] < 0.96) {
                    if (input[2] < 0.8) {
                        var82 = -0.052416272;
                    } else {
                        var82 = -0.023530498;
                    }
                } else {
                    if (input[14] < 165.0) {
                        var82 = 0.0006444635;
                    } else {
                        var82 = 0.101874165;
                    }
                }
            } else {
                if (input[12] < 3.65) {
                    if (input[4] < 3.0) {
                        var82 = 0.045998774;
                    } else {
                        var82 = -0.0112942355;
                    }
                } else {
                    if (input[5] < 0.44) {
                        var82 = 0.0095145535;
                    } else {
                        var82 = -0.04535031;
                    }
                }
            }
            double var83;
            if (input[10] < 15.0) {
                if (input[1] < 2.0) {
                    if (input[5] < 1.04) {
                        var83 = 0.04841147;
                    } else {
                        var83 = -0.029757097;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var83 = 0.021635443;
                    } else {
                        var83 = -0.04394794;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[12] < 3.34) {
                        var83 = 0.020893749;
                    } else {
                        var83 = -0.04992707;
                    }
                } else {
                    var83 = -0.052480966;
                }
            }
            double var84;
            if (input[1] < 2.0) {
                if (input[12] < 4.47) {
                    if (input[13] < 346.0) {
                        var84 = -0.052581824;
                    } else {
                        var84 = -0.009059004;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var84 = -0.051446747;
                    } else {
                        var84 = 0.0289966;
                    }
                }
            } else {
                if (input[13] < 140.0) {
                    if (input[1] < 6.0) {
                        var84 = -0.038652916;
                    } else {
                        var84 = 0.028417328;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var84 = 0.021976728;
                    } else {
                        var84 = 0.063018374;
                    }
                }
            }
            double var85;
            if (input[0] < 5.0) {
                if (input[11] < 4.0) {
                    if (input[3] < 6.0) {
                        var85 = -0.050249636;
                    } else {
                        var85 = 0.033752132;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var85 = -0.0018831947;
                    } else {
                        var85 = 0.039479464;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[10] < 9.0) {
                        var85 = -0.027129604;
                    } else {
                        var85 = 0.042619724;
                    }
                } else {
                    if (input[3] < 7.0) {
                        var85 = -0.05234782;
                    } else {
                        var85 = -0.024349654;
                    }
                }
            }
            double var86;
            if (input[2] < 0.59) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.54) {
                        var86 = -0.05068348;
                    } else {
                        var86 = -0.021562636;
                    }
                } else {
                    if (input[8] < 4.0) {
                        var86 = -0.05589899;
                    } else {
                        var86 = 0.035583533;
                    }
                }
            } else {
                if (input[5] < 0.69) {
                    if (input[0] < 9.0) {
                        var86 = 0.037999544;
                    } else {
                        var86 = -0.022431243;
                    }
                } else {
                    if (input[14] < 99.0) {
                        var86 = -0.049481984;
                    } else {
                        var86 = 0.0065281303;
                    }
                }
            }
            double var87;
            if (input[10] < 15.0) {
                if (input[2] < 0.99) {
                    if (input[11] < 4.0) {
                        var87 = 0.055469412;
                    } else {
                        var87 = 0.012204665;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var87 = -0.0019256845;
                    } else {
                        var87 = -0.050369795;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[10] < 18.0) {
                        var87 = 0.020333258;
                    } else {
                        var87 = -0.049549326;
                    }
                } else {
                    var87 = -0.052275747;
                }
            }
            double var88;
            if (input[1] < 4.0) {
                if (input[10] < 21.0) {
                    if (input[13] < 339.0) {
                        var88 = -0.046023842;
                    } else {
                        var88 = 0.01608531;
                    }
                } else {
                    if (input[2] < 0.41) {
                        var88 = -0.047622975;
                    } else {
                        var88 = 0.041095164;
                    }
                }
            } else {
                if (input[12] < 2.35) {
                    if (input[1] < 8.0) {
                        var88 = -0.042590864;
                    } else {
                        var88 = 0.044862427;
                    }
                } else {
                    if (input[2] < 1.22) {
                        var88 = 0.019732323;
                    } else {
                        var88 = 0.055237472;
                    }
                }
            }
            double var89;
            if (input[1] < 3.0) {
                if (input[14] < 101.0) {
                    if (input[2] < 0.9) {
                        var89 = 0.040290605;
                    } else {
                        var89 = -0.011707566;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var89 = -0.03849167;
                    } else {
                        var89 = 0.012164537;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[5] < 0.4) {
                        var89 = -0.040108487;
                    } else {
                        var89 = 0.03671403;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var89 = -0.05406289;
                    } else {
                        var89 = -0.025793785;
                    }
                }
            }
            double var90;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var90 = -0.0511028;
                } else {
                    var90 = 0.014981155;
                }
            } else {
                if (input[3] < 3.0) {
                    if (input[0] < 10.0) {
                        var90 = 0.035653833;
                    } else {
                        var90 = -0.03566241;
                    }
                } else {
                    if (input[14] < 114.0) {
                        var90 = -0.033623334;
                    } else {
                        var90 = 0.01675096;
                    }
                }
            }
            double var91;
            if (input[10] < 15.0) {
                if (input[0] < 3.0) {
                    if (input[5] < 0.6) {
                        var91 = 0.056910355;
                    } else {
                        var91 = 0.004135722;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var91 = 0.028301155;
                    } else {
                        var91 = -0.04021292;
                    }
                }
            } else {
                if (input[5] < 0.19) {
                    if (input[14] < 124.0) {
                        var91 = -0.03934252;
                    } else {
                        var91 = 0.049106944;
                    }
                } else {
                    var91 = -0.052089285;
                }
            }
            double var92;
            if (input[2] < 0.57) {
                if (input[11] < 14.0) {
                    if (input[13] < 425.0) {
                        var92 = -0.051601995;
                    } else {
                        var92 = 0.02401683;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var92 = -0.049803548;
                    } else {
                        var92 = 0.048138734;
                    }
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[2] < 1.43) {
                        var92 = -0.027280895;
                    } else {
                        var92 = 0.035072334;
                    }
                } else {
                    if (input[12] < 4.28) {
                        var92 = 0.033028074;
                    } else {
                        var92 = 0.06218349;
                    }
                }
            }
            double var93;
            if (input[2] < 0.9) {
                if (input[5] < 0.74) {
                    if (input[14] < 89.0) {
                        var93 = 0.025556052;
                    } else {
                        var93 = -0.02416659;
                    }
                } else {
                    if (input[12] < 1.19) {
                        var93 = -0.035600096;
                    } else {
                        var93 = 0.048951056;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var93 = -0.0308165;
                    } else {
                        var93 = 0.039963808;
                    }
                } else {
                    if (input[3] < 8.0) {
                        var93 = -0.05014814;
                    } else {
                        var93 = -0.0037577462;
                    }
                }
            }
            double var94;
            if (input[1] < 2.0) {
                if (input[2] < 1.06) {
                    if (input[2] < 0.8) {
                        var94 = -0.052193023;
                    } else {
                        var94 = -0.018466108;
                    }
                } else {
                    if (input[5] < 0.62) {
                        var94 = 0.0620371;
                    } else {
                        var94 = -0.0321858;
                    }
                }
            } else {
                if (input[11] < 12.0) {
                    if (input[4] < 3.0) {
                        var94 = 0.03820445;
                    } else {
                        var94 = -0.0181364;
                    }
                } else {
                    if (input[13] < 197.0) {
                        var94 = 0.021830823;
                    } else {
                        var94 = -0.037973236;
                    }
                }
            }
            double var95;
            if (input[11] < 6.0) {
                if (input[2] < 1.1) {
                    if (input[1] < 4.0) {
                        var95 = 0.045491394;
                    } else {
                        var95 = -0.05667299;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var95 = -0.0035243917;
                    } else {
                        var95 = -0.053625908;
                    }
                }
            } else {
                if (input[2] < 0.31) {
                    if (input[14] < 103.0) {
                        var95 = -0.046009902;
                    } else {
                        var95 = 0.041517287;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var95 = -0.021248892;
                    } else {
                        var95 = -0.052642263;
                    }
                }
            }
            double var96;
            if (input[1] < 2.0) {
                if (input[12] < 4.51) {
                    if (input[2] < 1.1) {
                        var96 = -0.050717246;
                    } else {
                        var96 = -0.0006377578;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var96 = -0.05036394;
                    } else {
                        var96 = 0.029219586;
                    }
                }
            } else {
                if (input[10] < 19.0) {
                    if (input[0] < 8.0) {
                        var96 = -0.031871732;
                    } else {
                        var96 = 0.033677574;
                    }
                } else {
                    if (input[11] < 12.0) {
                        var96 = 0.024292927;
                    } else {
                        var96 = 0.057740834;
                    }
                }
            }
            double var97;
            if (input[1] < 3.0) {
                if (input[12] < 1.84) {
                    if (input[5] < 0.74) {
                        var97 = -0.044473317;
                    } else {
                        var97 = 0.004640344;
                    }
                } else {
                    if (input[5] < 0.15) {
                        var97 = -0.009229014;
                    } else {
                        var97 = 0.033923972;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[5] < 0.4) {
                        var97 = -0.038041294;
                    } else {
                        var97 = 0.033596393;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var97 = -0.053339895;
                    } else {
                        var97 = -0.024317661;
                    }
                }
            }
            double var98;
            if (input[2] < 0.67) {
                if (input[1] < 3.0) {
                    if (input[1] < 2.0) {
                        var98 = -0.050930966;
                    } else {
                        var98 = -0.026331006;
                    }
                } else {
                    if (input[5] < 0.29) {
                        var98 = 0.054995038;
                    } else {
                        var98 = -0.041244857;
                    }
                }
            } else {
                if (input[11] < 11.0) {
                    if (input[5] < 0.99) {
                        var98 = 0.036148086;
                    } else {
                        var98 = -0.025092224;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var98 = 0.0062082736;
                    } else {
                        var98 = -0.041195136;
                    }
                }
            }
            double var99;
            if (input[11] < 6.0) {
                if (input[2] < 1.1) {
                    if (input[5] < 1.03) {
                        var99 = 0.045991655;
                    } else {
                        var99 = -0.02343273;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var99 = -0.0023566072;
                    } else {
                        var99 = -0.053189375;
                    }
                }
            } else {
                if (input[2] < 0.31) {
                    if (input[14] < 103.0) {
                        var99 = -0.045241736;
                    } else {
                        var99 = 0.038390532;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var99 = -0.020537456;
                    } else {
                        var99 = -0.05227532;
                    }
                }
            }
            double var100;
            if (input[2] < 0.57) {
                if (input[11] < 14.0) {
                    if (input[13] < 425.0) {
                        var100 = -0.05109624;
                    } else {
                        var100 = 0.024593754;
                    }
                } else {
                    if (input[2] < 0.36) {
                        var100 = -0.048984945;
                    } else {
                        var100 = 0.046088543;
                    }
                }
            } else {
                if (input[11] < 9.0) {
                    if (input[1] < 6.0) {
                        var100 = -0.032659214;
                    } else {
                        var100 = 0.03791165;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var100 = 0.020211153;
                    } else {
                        var100 = 0.0578116;
                    }
                }
            }
            double var101;
            if (input[1] < 3.0) {
                if (input[14] < 103.0) {
                    if (input[4] < 1.0) {
                        var101 = 0.00945159;
                    } else {
                        var101 = 0.042559247;
                    }
                } else {
                    if (input[5] < 0.27) {
                        var101 = -0.043390304;
                    } else {
                        var101 = 0.007416314;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var101 = -0.03927977;
                    } else {
                        var101 = 0.0526369;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var101 = -0.05217401;
                    } else {
                        var101 = -0.016522916;
                    }
                }
            }
            double var102;
            if (input[1] < 2.0) {
                if (input[2] < 0.95) {
                    if (input[2] < 0.8) {
                        var102 = -0.051855005;
                    } else {
                        var102 = -0.025007023;
                    }
                } else {
                    if (input[14] < 168.0) {
                        var102 = -0.0040029213;
                    } else {
                        var102 = 0.078980245;
                    }
                }
            } else {
                if (input[14] < 120.0) {
                    if (input[5] < 0.18) {
                        var102 = 0.03293812;
                    } else {
                        var102 = -0.018833598;
                    }
                } else {
                    if (input[2] < 1.99) {
                        var102 = 0.04873995;
                    } else {
                        var102 = -0.016676402;
                    }
                }
            }
            double var103;
            if (input[11] < 7.0) {
                if (input[1] < 3.0) {
                    if (input[5] < 0.79) {
                        var103 = 0.047463674;
                    } else {
                        var103 = -0.0067968145;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var103 = -0.0053786375;
                    } else {
                        var103 = -0.054427642;
                    }
                }
            } else {
                if (input[14] < 178.0) {
                    if (input[12] < 1.88) {
                        var103 = 0.02529022;
                    } else {
                        var103 = -0.044744767;
                    }
                } else {
                    if (input[2] < 0.31) {
                        var103 = 0.065834135;
                    } else {
                        var103 = -0.039444517;
                    }
                }
            }
            double var104;
            if (input[2] < 0.43) {
                if (input[13] < 442.0) {
                    var104 = -0.05124205;
                } else {
                    if (input[0] < 2.0) {
                        var104 = -0.04066809;
                    } else {
                        var104 = 0.0929428;
                    }
                }
            } else {
                if (input[10] < 21.0) {
                    if (input[2] < 1.29) {
                        var104 = -0.029122135;
                    } else {
                        var104 = 0.026836017;
                    }
                } else {
                    if (input[13] < 277.0) {
                        var104 = 0.032356553;
                    } else {
                        var104 = 0.063164726;
                    }
                }
            }
            double var105;
            if (input[2] < 1.06) {
                if (input[5] < 0.74) {
                    if (input[14] < 89.0) {
                        var105 = 0.019498656;
                    } else {
                        var105 = -0.022957275;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var105 = -0.03676414;
                    } else {
                        var105 = 0.041635934;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[4] < 5.0) {
                        var105 = -0.051932413;
                    } else {
                        var105 = -0.029912299;
                    }
                } else {
                    var105 = 0.0588124;
                }
            }
            double var106;
            if (input[2] < 0.59) {
                if (input[1] < 3.0) {
                    if (input[2] < 0.54) {
                        var106 = -0.049911495;
                    } else {
                        var106 = -0.018748086;
                    }
                } else {
                    if (input[8] < 4.0) {
                        var106 = -0.05599801;
                    } else {
                        var106 = 0.029920781;
                    }
                }
            } else {
                if (input[5] < 0.97) {
                    if (input[1] < 6.0) {
                        var106 = 0.029072;
                    } else {
                        var106 = -0.02064771;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var106 = 0.033014905;
                    } else {
                        var106 = -0.049822167;
                    }
                }
            }
            double var107;
            if (input[13] < 153.0) {
                if (input[2] < 0.93) {
                    if (input[14] < 81.0) {
                        var107 = -0.045270413;
                    } else {
                        var107 = 0.040332418;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var107 = 0.032141645;
                    } else {
                        var107 = -0.03925569;
                    }
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 164.0) {
                        var107 = -0.035663877;
                    } else {
                        var107 = 0.049917065;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var107 = -0.040144548;
                    } else {
                        var107 = -0.054921415;
                    }
                }
            }
            double var108;
            if (input[2] < 0.43) {
                if (input[13] < 442.0) {
                    if (input[2] < 0.41) {
                        var108 = -0.051726438;
                    } else {
                        var108 = -0.03143377;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var108 = -0.039986;
                    } else {
                        var108 = 0.08775059;
                    }
                }
            } else {
                if (input[13] < 140.0) {
                    if (input[1] < 6.0) {
                        var108 = -0.039664567;
                    } else {
                        var108 = 0.018711446;
                    }
                } else {
                    if (input[2] < 1.15) {
                        var108 = 0.0085028475;
                    } else {
                        var108 = 0.046542794;
                    }
                }
            }
            double var109;
            if (input[1] < 3.0) {
                if (input[12] < 1.29) {
                    if (input[4] < 6.0) {
                        var109 = -0.049919657;
                    } else {
                        var109 = 0.06016245;
                    }
                } else {
                    if (input[4] < 2.0) {
                        var109 = 0.0014129496;
                    } else {
                        var109 = 0.040353946;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var109 = -0.037450653;
                    } else {
                        var109 = 0.04884731;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var109 = -0.053717773;
                    } else {
                        var109 = -0.03489514;
                    }
                }
            }
            double var110;
            if (input[1] < 2.0) {
                if (input[2] < 0.95) {
                    if (input[2] < 0.8) {
                        var110 = -0.051612165;
                    } else {
                        var110 = -0.024064016;
                    }
                } else {
                    if (input[14] < 168.0) {
                        var110 = -0.004672985;
                    } else {
                        var110 = 0.07390215;
                    }
                }
            } else {
                if (input[9] < 7.0) {
                    if (input[1] < 7.0) {
                        var110 = 0.032966916;
                    } else {
                        var110 = -0.030410176;
                    }
                } else {
                    if (input[12] < 3.39) {
                        var110 = 0.008509611;
                    } else {
                        var110 = -0.037582576;
                    }
                }
            }
            double var111;
            if (input[13] < 153.0) {
                if (input[1] < 3.0) {
                    if (input[14] < 81.0) {
                        var111 = -0.043994855;
                    } else {
                        var111 = 0.038924154;
                    }
                } else {
                    if (input[12] < 1.16) {
                        var111 = -0.002937418;
                    } else {
                        var111 = -0.05465169;
                    }
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[12] < 2.6) {
                        var111 = 0.032382894;
                    } else {
                        var111 = -0.042114962;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var111 = -0.039402332;
                    } else {
                        var111 = -0.054642398;
                    }
                }
            }
            double var112;
            if (input[2] < 0.43) {
                if (input[13] < 442.0) {
                    if (input[2] < 0.41) {
                        var112 = -0.051563855;
                    } else {
                        var112 = -0.030509982;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var112 = -0.039399818;
                    } else {
                        var112 = 0.08337423;
                    }
                }
            } else {
                if (input[10] < 21.0) {
                    if (input[2] < 1.35) {
                        var112 = -0.02659061;
                    } else {
                        var112 = 0.02561595;
                    }
                } else {
                    if (input[13] < 277.0) {
                        var112 = 0.030465772;
                    } else {
                        var112 = 0.06153307;
                    }
                }
            }
            double var113;
            if (input[2] < 1.06) {
                if (input[5] < 0.74) {
                    if (input[14] < 89.0) {
                        var113 = 0.017418005;
                    } else {
                        var113 = -0.021519057;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var113 = -0.033988025;
                    } else {
                        var113 = 0.0391478;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[4] < 5.0) {
                        var113 = -0.05127124;
                    } else {
                        var113 = -0.028141305;
                    }
                } else {
                    var113 = 0.058125485;
                }
            }
            double var114;
            if (input[2] < 0.67) {
                if (input[1] < 3.0) {
                    if (input[1] < 2.0) {
                        var114 = -0.050192486;
                    } else {
                        var114 = -0.025079194;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var114 = 0.049814068;
                    } else {
                        var114 = -0.038292665;
                    }
                }
            } else {
                if (input[5] < 0.97) {
                    if (input[0] < 9.0) {
                        var114 = 0.0307796;
                    } else {
                        var114 = -0.02208215;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var114 = 0.032486808;
                    } else {
                        var114 = -0.0491631;
                    }
                }
            }
            double var115;
            if (input[10] < 17.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 0.49) {
                        var115 = 0.058104992;
                    } else {
                        var115 = 0.006136357;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var115 = 0.026403923;
                    } else {
                        var115 = -0.032563478;
                    }
                }
            } else {
                if (input[14] < 185.0) {
                    if (input[14] < 124.0) {
                        var115 = -0.051335867;
                    } else {
                        var115 = -0.029010981;
                    }
                } else {
                    var115 = 0.043743115;
                }
            }
            double var116;
            if (input[10] < 18.0) {
                if (input[2] < 1.8) {
                    if (input[9] < 9.0) {
                        var116 = -0.04635724;
                    } else {
                        var116 = 0.006844073;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var116 = -0.039477445;
                    } else {
                        var116 = 0.059892815;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[9] < 10.0) {
                        var116 = -0.050286073;
                    } else {
                        var116 = -0.0051795687;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var116 = 0.016340153;
                    } else {
                        var116 = 0.05696538;
                    }
                }
            }
            double var117;
            if (input[1] < 3.0) {
                if (input[12] < 1.29) {
                    if (input[4] < 6.0) {
                        var117 = -0.048875038;
                    } else {
                        var117 = 0.059841495;
                    }
                } else {
                    if (input[5] < 0.15) {
                        var117 = -0.0142542245;
                    } else {
                        var117 = 0.027390173;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var117 = -0.035904672;
                    } else {
                        var117 = 0.045060437;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var117 = -0.051120367;
                    } else {
                        var117 = -0.012026624;
                    }
                }
            }
            double var118;
            if (input[2] < 0.59) {
                if (input[0] < 3.0) {
                    var118 = -0.0502999;
                } else {
                    if (input[3] < 1.0) {
                        var118 = 0.0252292;
                    } else {
                        var118 = -0.044966456;
                    }
                }
            } else {
                if (input[5] < 0.17) {
                    if (input[0] < 8.0) {
                        var118 = 0.04744325;
                    } else {
                        var118 = -0.007112092;
                    }
                } else {
                    if (input[14] < 120.0) {
                        var118 = -0.018961003;
                    } else {
                        var118 = 0.02350851;
                    }
                }
            }
            double var119;
            if (input[11] < 8.0) {
                if (input[2] < 0.55) {
                    if (input[5] < 0.6) {
                        var119 = 0.05341983;
                    } else {
                        var119 = 0.0011078299;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var119 = 0.026124066;
                    } else {
                        var119 = -0.03907026;
                    }
                }
            } else {
                if (input[14] < 112.0) {
                    if (input[13] < 79.0) {
                        var119 = 0.008075428;
                    } else {
                        var119 = -0.050634872;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var119 = 0.010931415;
                    } else {
                        var119 = -0.0476356;
                    }
                }
            }
            double var120;
            if (input[2] < 0.43) {
                if (input[13] < 442.0) {
                    if (input[2] < 0.41) {
                        var120 = -0.05131753;
                    } else {
                        var120 = -0.028878232;
                    }
                } else {
                    if (input[0] < 2.0) {
                        var120 = -0.038638398;
                    } else {
                        var120 = 0.07829965;
                    }
                }
            } else {
                if (input[11] < 9.0) {
                    if (input[1] < 5.0) {
                        var120 = -0.03710684;
                    } else {
                        var120 = 0.02055644;
                    }
                } else {
                    if (input[9] < 5.0) {
                        var120 = 0.008986956;
                    } else {
                        var120 = 0.04785504;
                    }
                }
            }
            double var121;
            if (input[0] < 6.0) {
                if (input[4] < 2.0) {
                    if (input[14] < 89.0) {
                        var121 = 0.015598716;
                    } else {
                        var121 = -0.024217257;
                    }
                } else {
                    if (input[12] < 1.22) {
                        var121 = -0.035958286;
                    } else {
                        var121 = 0.032741114;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    if (input[4] < 4.0) {
                        var121 = 0.018789096;
                    } else {
                        var121 = -0.030840928;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var121 = -0.018394185;
                    } else {
                        var121 = -0.053184688;
                    }
                }
            }
            double var122;
            if (input[1] < 2.0) {
                if (input[2] < 0.96) {
                    if (input[2] < 0.8) {
                        var122 = -0.051334925;
                    } else {
                        var122 = -0.024035294;
                    }
                } else {
                    if (input[14] < 165.0) {
                        var122 = -0.0046921615;
                    } else {
                        var122 = 0.0772466;
                    }
                }
            } else {
                if (input[13] < 265.0) {
                    if (input[4] < 1.0) {
                        var122 = 0.0448579;
                    } else {
                        var122 = 0.006585897;
                    }
                } else {
                    if (input[2] < 1.2) {
                        var122 = 0.000083700885;
                    } else {
                        var122 = -0.052909594;
                    }
                }
            }
            double var123;
            if (input[13] < 153.0) {
                if (input[0] < 6.0) {
                    if (input[14] < 81.0) {
                        var123 = -0.044011667;
                    } else {
                        var123 = 0.03366102;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var123 = -0.009476806;
                    } else {
                        var123 = -0.05263544;
                    }
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 103.0) {
                        var123 = -0.048597746;
                    } else {
                        var123 = 0.020818789;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var123 = -0.05537031;
                    } else {
                        var123 = -0.04024488;
                    }
                }
            }
            double var124;
            if (input[10] < 18.0) {
                if (input[2] < 1.8) {
                    if (input[9] < 9.0) {
                        var124 = -0.045199685;
                    } else {
                        var124 = 0.006439292;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var124 = -0.03786445;
                    } else {
                        var124 = 0.05825885;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[9] < 10.0) {
                        var124 = -0.049521133;
                    } else {
                        var124 = -0.003743572;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var124 = 0.014831501;
                    } else {
                        var124 = 0.055201847;
                    }
                }
            }
            double var125;
            if (input[0] < 6.0) {
                if (input[5] < 0.79) {
                    if (input[11] < 6.0) {
                        var125 = -0.03363022;
                    } else {
                        var125 = 0.004300419;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var125 = -0.030722355;
                    } else {
                        var125 = 0.035147205;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var125 = -0.0071296333;
                } else {
                    if (input[1] < 1.0) {
                        var125 = -0.017774219;
                    } else {
                        var125 = -0.05295352;
                    }
                }
            }
            double var126;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var126 = -0.05272873;
                    } else {
                        var126 = -0.023334013;
                    }
                } else {
                    var126 = 0.062301118;
                }
            } else {
                if (input[5] < 0.45) {
                    if (input[0] < 10.0) {
                        var126 = 0.031358752;
                    } else {
                        var126 = -0.031711586;
                    }
                } else {
                    if (input[13] < 139.0) {
                        var126 = 0.011231803;
                    } else {
                        var126 = -0.03340127;
                    }
                }
            }
            double var127;
            if (input[11] < 6.0) {
                if (input[1] < 4.0) {
                    if (input[5] < 1.03) {
                        var127 = 0.038656857;
                    } else {
                        var127 = -0.027379265;
                    }
                } else {
                    var127 = -0.05412456;
                }
            } else {
                if (input[2] < 0.31) {
                    if (input[14] < 103.0) {
                        var127 = -0.04204399;
                    } else {
                        var127 = 0.029532908;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var127 = -0.018357472;
                    } else {
                        var127 = -0.05144154;
                    }
                }
            }
            double var128;
            if (input[11] < 11.0) {
                if (input[2] < 1.43) {
                    if (input[9] < 6.0) {
                        var128 = -0.04608695;
                    } else {
                        var128 = -0.0021982263;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var128 = -0.042824544;
                    } else {
                        var128 = 0.04485615;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var128 = -0.049747113;
                } else {
                    if (input[9] < 9.0) {
                        var128 = 0.024468454;
                    } else {
                        var128 = 0.06923887;
                    }
                }
            }
            double var129;
            if (input[1] < 3.0) {
                if (input[12] < 1.29) {
                    if (input[4] < 6.0) {
                        var129 = -0.047326963;
                    } else {
                        var129 = 0.05919332;
                    }
                } else {
                    if (input[4] < 2.0) {
                        var129 = 0.00017249257;
                    } else {
                        var129 = 0.035518125;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var129 = -0.03346245;
                    } else {
                        var129 = 0.041232627;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var129 = -0.053061944;
                    } else {
                        var129 = -0.031722523;
                    }
                }
            }
            double var130;
            if (input[2] < 0.67) {
                if (input[1] < 3.0) {
                    if (input[1] < 2.0) {
                        var130 = -0.049618624;
                    } else {
                        var130 = -0.024545742;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var130 = 0.032095116;
                    } else {
                        var130 = -0.056192584;
                    }
                }
            } else {
                if (input[5] < 1.02) {
                    if (input[1] < 6.0) {
                        var130 = 0.027575169;
                    } else {
                        var130 = -0.017567001;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var130 = 0.022718476;
                    } else {
                        var130 = -0.04800756;
                    }
                }
            }
            double var131;
            if (input[13] < 153.0) {
                if (input[1] < 4.0) {
                    if (input[14] < 79.0) {
                        var131 = -0.044958822;
                    } else {
                        var131 = 0.029522372;
                    }
                } else {
                    var131 = -0.053304087;
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[12] < 2.6) {
                        var131 = 0.02791817;
                    } else {
                        var131 = -0.04049574;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var131 = -0.05529942;
                    } else {
                        var131 = -0.038894337;
                    }
                }
            }
            double var132;
            if (input[2] < 0.41) {
                if (input[13] < 442.0) {
                    var132 = -0.05101196;
                } else {
                    if (input[8] < 7.0) {
                        var132 = -0.03902818;
                    } else {
                        var132 = 0.071970634;
                    }
                }
            } else {
                if (input[13] < 153.0) {
                    if (input[1] < 6.0) {
                        var132 = -0.035806827;
                    } else {
                        var132 = 0.018212264;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var132 = 0.013050519;
                    } else {
                        var132 = 0.05809815;
                    }
                }
            }
            double var133;
            if (input[2] < 1.06) {
                if (input[5] < 0.79) {
                    if (input[14] < 89.0) {
                        var133 = 0.015476321;
                    } else {
                        var133 = -0.017905377;
                    }
                } else {
                    if (input[13] < 32.0) {
                        var133 = -0.032938477;
                    } else {
                        var133 = 0.034997534;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[4] < 5.0) {
                        var133 = -0.05012367;
                    } else {
                        var133 = -0.02352541;
                    }
                } else {
                    var133 = 0.054533567;
                }
            }
            double var134;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var134 = -0.052355822;
                    } else {
                        var134 = -0.021612102;
                    }
                } else {
                    var134 = 0.0599616;
                }
            } else {
                if (input[5] < 0.45) {
                    if (input[13] < 315.0) {
                        var134 = 0.028938083;
                    } else {
                        var134 = -0.0351932;
                    }
                } else {
                    if (input[2] < 0.84) {
                        var134 = -0.04524929;
                    } else {
                        var134 = 0.0027539313;
                    }
                }
            }
            double var135;
            if (input[12] < 3.34) {
                if (input[1] < 1.0) {
                    if (input[3] < 3.0) {
                        var135 = 0.053354204;
                    } else {
                        var135 = 0.0030254207;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var135 = 0.023903199;
                    } else {
                        var135 = -0.03208969;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[3] < 2.0) {
                        var135 = 0.052114177;
                    } else {
                        var135 = -0.004818076;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var135 = -0.051725406;
                    } else {
                        var135 = -0.017495027;
                    }
                }
            }
            double var136;
            if (input[10] < 19.0) {
                if (input[0] < 7.0) {
                    if (input[5] < 0.76) {
                        var136 = -0.05058592;
                    } else {
                        var136 = -0.013548498;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var136 = -0.04727197;
                    } else {
                        var136 = 0.033924527;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[9] < 10.0) {
                        var136 = -0.048210572;
                    } else {
                        var136 = -0.002484462;
                    }
                } else {
                    if (input[11] < 12.0) {
                        var136 = 0.011509161;
                    } else {
                        var136 = 0.04760215;
                    }
                }
            }
            double var137;
            if (input[1] < 3.0) {
                if (input[10] < 6.0) {
                    if (input[3] < 9.0) {
                        var137 = -0.051935878;
                    } else {
                        var137 = 0.06824135;
                    }
                } else {
                    if (input[5] < 0.16) {
                        var137 = -0.013901805;
                    } else {
                        var137 = 0.023777189;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var137 = -0.03168554;
                    } else {
                        var137 = 0.03780317;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var137 = -0.05005032;
                    } else {
                        var137 = -0.0076285093;
                    }
                }
            }
            double var138;
            if (input[2] < 0.54) {
                if (input[0] < 4.0) {
                    var138 = -0.0497879;
                } else {
                    if (input[8] < 4.0) {
                        var138 = -0.04336696;
                    } else {
                        var138 = 0.058138847;
                    }
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var138 = 0.045239665;
                    } else {
                        var138 = -0.0033403002;
                    }
                } else {
                    if (input[14] < 119.0) {
                        var138 = -0.016608004;
                    } else {
                        var138 = 0.018725501;
                    }
                }
            }
            double var139;
            if (input[11] < 8.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 0.6) {
                        var139 = 0.054297592;
                    } else {
                        var139 = 0.0060417615;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var139 = 0.022059599;
                    } else {
                        var139 = -0.030100444;
                    }
                }
            } else {
                if (input[12] < 3.24) {
                    if (input[15] < 1.0) {
                        var139 = -0.043006726;
                    } else {
                        var139 = 0.00914258;
                    }
                } else {
                    var139 = -0.051389527;
                }
            }
            double var140;
            if (input[2] < 0.41) {
                if (input[13] < 442.0) {
                    var140 = -0.05081745;
                } else {
                    if (input[8] < 7.0) {
                        var140 = -0.038351204;
                    } else {
                        var140 = 0.06755519;
                    }
                }
            } else {
                if (input[10] < 21.0) {
                    if (input[2] < 1.32) {
                        var140 = -0.02417947;
                    } else {
                        var140 = 0.020637153;
                    }
                } else {
                    if (input[14] < 122.0) {
                        var140 = 0.041593205;
                    } else {
                        var140 = -0.009518339;
                    }
                }
            }
            double var141;
            if (input[0] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[13] < 48.0) {
                        var141 = -0.052573968;
                    } else {
                        var141 = 0.0025260549;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var141 = 0.04961854;
                    } else {
                        var141 = -0.030878244;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var141 = -0.004258612;
                } else {
                    if (input[1] < 1.0) {
                        var141 = -0.015500106;
                    } else {
                        var141 = -0.052432712;
                    }
                }
            }
            double var142;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    var142 = -0.049613707;
                } else {
                    if (input[5] < 0.24) {
                        var142 = 0.017518228;
                    } else {
                        var142 = -0.03926298;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[2] < 1.96) {
                        var142 = 0.026141876;
                    } else {
                        var142 = -0.029491976;
                    }
                } else {
                    if (input[13] < 113.0) {
                        var142 = 0.009343399;
                    } else {
                        var142 = -0.045239963;
                    }
                }
            }
            double var143;
            if (input[12] < 3.34) {
                if (input[1] < 4.0) {
                    if (input[15] < 1.0) {
                        var143 = -0.0039448286;
                    } else {
                        var143 = 0.035040177;
                    }
                } else {
                    var143 = -0.053091217;
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[3] < 2.0) {
                        var143 = 0.05019133;
                    } else {
                        var143 = -0.0041101538;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var143 = -0.051544625;
                    } else {
                        var143 = -0.016412573;
                    }
                }
            }
            double var144;
            if (input[11] < 8.0) {
                if (input[0] < 7.0) {
                    if (input[5] < 1.11) {
                        var144 = -0.052505493;
                    } else {
                        var144 = -0.014010863;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var144 = -0.054393377;
                    } else {
                        var144 = 0.028248435;
                    }
                }
            } else {
                if (input[2] < 0.41) {
                    if (input[13] < 442.0) {
                        var144 = -0.05025204;
                    } else {
                        var144 = 0.00815632;
                    }
                } else {
                    if (input[9] < 5.0) {
                        var144 = 0.003403815;
                    } else {
                        var144 = 0.04060944;
                    }
                }
            }
            double var145;
            if (input[1] < 3.0) {
                if (input[4] < 2.0) {
                    if (input[14] < 78.0) {
                        var145 = 0.025796039;
                    } else {
                        var145 = -0.017434258;
                    }
                } else {
                    if (input[12] < 1.33) {
                        var145 = -0.034212824;
                    } else {
                        var145 = 0.03260329;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[13] < 164.0) {
                        var145 = 0.05368047;
                    } else {
                        var145 = -0.020475978;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var145 = -0.050516456;
                    } else {
                        var145 = -0.01647302;
                    }
                }
            }
            double var146;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var146 = -0.051907238;
                    } else {
                        var146 = -0.019682227;
                    }
                } else {
                    var146 = 0.05729459;
                }
            } else {
                if (input[14] < 66.0) {
                    if (input[5] < 0.33) {
                        var146 = -0.001521569;
                    } else {
                        var146 = -0.043979198;
                    }
                } else {
                    if (input[4] < 3.0) {
                        var146 = 0.023751918;
                    } else {
                        var146 = -0.016974894;
                    }
                }
            }
            double var147;
            if (input[13] < 153.0) {
                if (input[2] < 1.1) {
                    if (input[14] < 81.0) {
                        var147 = -0.04227096;
                    } else {
                        var147 = 0.028633172;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var147 = -0.010261808;
                    } else {
                        var147 = -0.051716495;
                    }
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 164.0) {
                        var147 = -0.03204694;
                    } else {
                        var147 = 0.039429825;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var147 = -0.055100378;
                    } else {
                        var147 = -0.037178215;
                    }
                }
            }
            double var148;
            if (input[11] < 11.0) {
                if (input[2] < 1.47) {
                    if (input[9] < 6.0) {
                        var148 = -0.043422677;
                    } else {
                        var148 = 0.0005747606;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var148 = -0.03971825;
                    } else {
                        var148 = 0.043461706;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var148 = -0.048831355;
                } else {
                    if (input[9] < 9.0) {
                        var148 = 0.020831523;
                    } else {
                        var148 = 0.06557158;
                    }
                }
            }
            double var149;
            if (input[2] < 1.06) {
                if (input[5] < 0.79) {
                    if (input[14] < 89.0) {
                        var149 = 0.013247435;
                    } else {
                        var149 = -0.01610273;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var149 = 0.034969162;
                    } else {
                        var149 = -0.0098485425;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[4] < 5.0) {
                        var149 = -0.049296785;
                    } else {
                        var149 = -0.020588849;
                    }
                } else {
                    var149 = 0.052980848;
                }
            }
            double var150;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var150 = -0.04974931;
                } else {
                    var150 = 0.002481435;
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var150 = 0.040660985;
                    } else {
                        var150 = -0.0042364723;
                    }
                } else {
                    if (input[14] < 119.0) {
                        var150 = -0.016478883;
                    } else {
                        var150 = 0.016034914;
                    }
                }
            }
            double var151;
            if (input[12] < 3.34) {
                if (input[0] < 3.0) {
                    if (input[3] < 3.0) {
                        var151 = 0.045872767;
                    } else {
                        var151 = -0.0035580043;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var151 = 0.024067208;
                    } else {
                        var151 = -0.040578;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[3] < 2.0) {
                        var151 = 0.04861252;
                    } else {
                        var151 = -0.0044186935;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var151 = -0.05143332;
                    } else {
                        var151 = -0.01584829;
                    }
                }
            }
            double var152;
            if (input[13] < 197.0) {
                if (input[1] < 4.0) {
                    if (input[5] < 0.99) {
                        var152 = -0.049432855;
                    } else {
                        var152 = -0.0065207914;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var152 = -0.051240016;
                    } else {
                        var152 = 0.017276227;
                    }
                }
            } else {
                if (input[2] < 0.43) {
                    if (input[13] < 442.0) {
                        var152 = -0.049834386;
                    } else {
                        var152 = 0.020398995;
                    }
                } else {
                    if (input[9] < 5.0) {
                        var152 = 0.0076309503;
                    } else {
                        var152 = 0.045775548;
                    }
                }
            }
            double var153;
            if (input[0] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[13] < 48.0) {
                        var153 = -0.052126985;
                    } else {
                        var153 = 0.0021266271;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var153 = 0.04708551;
                    } else {
                        var153 = -0.029948274;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var153 = -0.0029809081;
                } else {
                    if (input[1] < 1.0) {
                        var153 = -0.012936197;
                    } else {
                        var153 = -0.05204568;
                    }
                }
            }
            double var154;
            if (input[1] < 2.0) {
                if (input[2] < 0.95) {
                    if (input[5] < 0.14) {
                        var154 = -0.029668212;
                    } else {
                        var154 = -0.05375439;
                    }
                } else {
                    if (input[14] < 168.0) {
                        var154 = -0.0066085006;
                    } else {
                        var154 = 0.060507577;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[13] < 244.0) {
                        var154 = 0.025595525;
                    } else {
                        var154 = -0.012337494;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var154 = 0.06328922;
                    } else {
                        var154 = -0.047557008;
                    }
                }
            }
            double var155;
            if (input[11] < 8.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 0.6) {
                        var155 = 0.051074337;
                    } else {
                        var155 = 0.005733951;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var155 = 0.025024667;
                    } else {
                        var155 = -0.026142215;
                    }
                }
            } else {
                if (input[12] < 3.24) {
                    if (input[5] < 0.27) {
                        var155 = 0.005355436;
                    } else {
                        var155 = -0.043961015;
                    }
                } else {
                    var155 = -0.051123608;
                }
            }
            double var156;
            if (input[10] < 21.0) {
                if (input[1] < 4.0) {
                    if (input[9] < 13.0) {
                        var156 = -0.037221245;
                    } else {
                        var156 = 0.053643513;
                    }
                } else {
                    if (input[13] < 127.0) {
                        var156 = -0.021068206;
                    } else {
                        var156 = 0.029382149;
                    }
                }
            } else {
                if (input[2] < 0.41) {
                    if (input[11] < 17.0) {
                        var156 = -0.048463006;
                    } else {
                        var156 = 0.0062127234;
                    }
                } else {
                    if (input[14] < 122.0) {
                        var156 = 0.038912855;
                    } else {
                        var156 = -0.010779789;
                    }
                }
            }
            double var157;
            if (input[1] < 3.0) {
                if (input[5] < 0.16) {
                    if (input[14] < 78.0) {
                        var157 = 0.019792384;
                    } else {
                        var157 = -0.030225167;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var157 = -0.042624325;
                    } else {
                        var157 = 0.020988334;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[5] < 0.74) {
                        var157 = -0.028794799;
                    } else {
                        var157 = 0.033707883;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var157 = -0.05233627;
                    } else {
                        var157 = -0.027860051;
                    }
                }
            }
            double var158;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    var158 = -0.049290016;
                } else {
                    if (input[5] < 0.24) {
                        var158 = 0.015028566;
                    } else {
                        var158 = -0.038420804;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[0] < 9.0) {
                        var158 = 0.022559375;
                    } else {
                        var158 = -0.021030052;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var158 = 0.019937227;
                    } else {
                        var158 = -0.05420993;
                    }
                }
            }
            double var159;
            if (input[13] < 153.0) {
                if (input[1] < 4.0) {
                    if (input[10] < 6.0) {
                        var159 = 0.044856552;
                    } else {
                        var159 = 0.0073081697;
                    }
                } else {
                    var159 = -0.05280168;
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 103.0) {
                        var159 = -0.047617998;
                    } else {
                        var159 = 0.016424784;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var159 = -0.055049755;
                    } else {
                        var159 = -0.035620686;
                    }
                }
            }
            double var160;
            if (input[11] < 12.0) {
                if (input[2] < 1.11) {
                    if (input[9] < 6.0) {
                        var160 = -0.043886837;
                    } else {
                        var160 = -0.0068147555;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var160 = -0.050572842;
                    } else {
                        var160 = 0.019929886;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var160 = -0.047161438;
                } else {
                    if (input[9] < 9.0) {
                        var160 = 0.022688422;
                    } else {
                        var160 = 0.0690139;
                    }
                }
            }
            double var161;
            if (input[2] < 1.06) {
                if (input[5] < 1.05) {
                    if (input[6] < 2.0) {
                        var161 = -0.008459668;
                    } else {
                        var161 = 0.02881741;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var161 = 0.044891555;
                    } else {
                        var161 = -0.0028066414;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[4] < 5.0) {
                        var161 = -0.048573796;
                    } else {
                        var161 = -0.018327432;
                    }
                } else {
                    var161 = 0.051274;
                }
            }
            double var162;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[13] < 336.0) {
                        var162 = -0.050251614;
                    } else {
                        var162 = -0.007923808;
                    }
                } else {
                    var162 = 0.053681064;
                }
            } else {
                if (input[5] < 0.45) {
                    if (input[1] < 6.0) {
                        var162 = 0.026411852;
                    } else {
                        var162 = -0.021125576;
                    }
                } else {
                    if (input[0] < 5.0) {
                        var162 = -0.03930039;
                    } else {
                        var162 = 0.004115969;
                    }
                }
            }
            double var163;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[11] < 5.0) {
                        var163 = 0.014402394;
                    } else {
                        var163 = -0.029081777;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var163 = 0.0439261;
                    } else {
                        var163 = -0.004226686;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[3] < 2.0) {
                        var163 = 0.047041062;
                    } else {
                        var163 = -0.0041197445;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var163 = -0.051271386;
                    } else {
                        var163 = -0.014580118;
                    }
                }
            }
            double var164;
            if (input[10] < 21.0) {
                if (input[1] < 4.0) {
                    if (input[9] < 13.0) {
                        var164 = -0.035745285;
                    } else {
                        var164 = 0.049937736;
                    }
                } else {
                    if (input[13] < 127.0) {
                        var164 = -0.020616475;
                    } else {
                        var164 = 0.027760232;
                    }
                }
            } else {
                if (input[2] < 0.41) {
                    if (input[11] < 17.0) {
                        var164 = -0.048088603;
                    } else {
                        var164 = 0.0065806373;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var164 = 0.0071585067;
                    } else {
                        var164 = 0.041604966;
                    }
                }
            }
            double var165;
            if (input[1] < 3.0) {
                if (input[4] < 2.0) {
                    if (input[13] < 107.0) {
                        var165 = -0.032784242;
                    } else {
                        var165 = 0.0058013536;
                    }
                } else {
                    if (input[12] < 1.33) {
                        var165 = -0.031378865;
                    } else {
                        var165 = 0.029393971;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[13] < 156.0) {
                        var165 = 0.032193195;
                    } else {
                        var165 = -0.028487144;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var165 = -0.05213548;
                    } else {
                        var165 = -0.027017588;
                    }
                }
            }
            double var166;
            if (input[2] < 0.67) {
                if (input[1] < 2.0) {
                    if (input[2] < 0.65) {
                        var166 = -0.050533574;
                    } else {
                        var166 = -0.0012264585;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var166 = 0.021833602;
                    } else {
                        var166 = -0.04175958;
                    }
                }
            } else {
                if (input[14] < 88.0) {
                    if (input[5] < 0.66) {
                        var166 = 0.0012467068;
                    } else {
                        var166 = -0.04657294;
                    }
                } else {
                    if (input[1] < 8.0) {
                        var166 = 0.023471141;
                    } else {
                        var166 = -0.045689262;
                    }
                }
            }
            double var167;
            if (input[11] < 8.0) {
                if (input[2] < 1.1) {
                    if (input[5] < 0.79) {
                        var167 = 0.028639516;
                    } else {
                        var167 = -0.015547051;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var167 = -0.010572045;
                    } else {
                        var167 = -0.05143531;
                    }
                }
            } else {
                if (input[12] < 3.24) {
                    if (input[15] < 1.0) {
                        var167 = -0.041030537;
                    } else {
                        var167 = 0.0072084977;
                    }
                } else {
                    var167 = -0.050922662;
                }
            }
            double var168;
            if (input[13] < 197.0) {
                if (input[2] < 1.61) {
                    if (input[3] < 4.0) {
                        var168 = -0.04452266;
                    } else {
                        var168 = -0.0054215784;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var168 = -0.032151084;
                    } else {
                        var168 = 0.048490625;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var168 = -0.046580993;
                    } else {
                        var168 = 0.0066928924;
                    }
                } else {
                    if (input[14] < 122.0) {
                        var168 = 0.032578662;
                    } else {
                        var168 = -0.025312448;
                    }
                }
            }
            double var169;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[1] < 2.0) {
                        var169 = 0.0053647794;
                    } else {
                        var169 = -0.02518746;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var169 = 0.035789136;
                    } else {
                        var169 = -0.005988286;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var169 = -0.001362838;
                } else {
                    if (input[1] < 1.0) {
                        var169 = -0.01088465;
                    } else {
                        var169 = -0.051603075;
                    }
                }
            }
            double var170;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var170 = -0.049349394;
                } else {
                    var170 = -0.00094518997;
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 7.0) {
                        var170 = 0.03236529;
                    } else {
                        var170 = -0.03069467;
                    }
                } else {
                    if (input[14] < 119.0) {
                        var170 = -0.015555697;
                    } else {
                        var170 = 0.013094549;
                    }
                }
            }
            double var171;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[11] < 1.0) {
                        var171 = 0.04031413;
                    } else {
                        var171 = -0.019176168;
                    }
                } else {
                    if (input[2] < 0.42) {
                        var171 = 0.04643502;
                    } else {
                        var171 = 0.0015153133;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[10] < 10.0) {
                        var171 = 0.04864035;
                    } else {
                        var171 = -0.00191011;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var171 = -0.05112169;
                    } else {
                        var171 = -0.012859386;
                    }
                }
            }
            double var172;
            if (input[11] < 12.0) {
                if (input[2] < 1.11) {
                    if (input[14] < 83.0) {
                        var172 = -0.010470741;
                    } else {
                        var172 = -0.04577845;
                    }
                } else {
                    if (input[13] < 139.0) {
                        var172 = -0.013871426;
                    } else {
                        var172 = 0.029627373;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var172 = -0.046543714;
                } else {
                    if (input[9] < 9.0) {
                        var172 = 0.020988196;
                    } else {
                        var172 = 0.06628721;
                    }
                }
            }
            double var173;
            if (input[0] < 6.0) {
                if (input[3] < 6.0) {
                    if (input[11] < 3.0) {
                        var173 = -0.050771564;
                    } else {
                        var173 = 0.0011631227;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var173 = 0.043299392;
                    } else {
                        var173 = -0.028013987;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var173 = -0.0009073956;
                } else {
                    if (input[1] < 1.0) {
                        var173 = -0.010631009;
                    } else {
                        var173 = -0.05142175;
                    }
                }
            }
            double var174;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var174 = -0.05104803;
                    } else {
                        var174 = -0.014726765;
                    }
                } else {
                    var174 = 0.051052846;
                }
            } else {
                if (input[14] < 66.0) {
                    if (input[5] < 0.33) {
                        var174 = -0.0027247658;
                    } else {
                        var174 = -0.042274963;
                    }
                } else {
                    if (input[5] < 0.45) {
                        var174 = 0.024561934;
                    } else {
                        var174 = -0.0032009843;
                    }
                }
            }
            double var175;
            if (input[13] < 153.0) {
                if (input[1] < 4.0) {
                    if (input[10] < 6.0) {
                        var175 = 0.04328846;
                    } else {
                        var175 = 0.0066243685;
                    }
                } else {
                    var175 = -0.052417118;
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 103.0) {
                        var175 = -0.046727862;
                    } else {
                        var175 = 0.016092516;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var175 = -0.054781105;
                    } else {
                        var175 = -0.035011705;
                    }
                }
            }
            double var176;
            if (input[10] < 21.0) {
                if (input[2] < 1.29) {
                    if (input[13] < 339.0) {
                        var176 = -0.034661278;
                    } else {
                        var176 = 0.030031476;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var176 = -0.04737581;
                    } else {
                        var176 = 0.025940612;
                    }
                }
            } else {
                if (input[2] < 0.41) {
                    if (input[11] < 17.0) {
                        var176 = -0.047595974;
                    } else {
                        var176 = 0.007473497;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var176 = 0.015942654;
                    } else {
                        var176 = 0.04566466;
                    }
                }
            }
            double var177;
            if (input[2] < 1.06) {
                if (input[5] < 0.27) {
                    if (input[14] < 69.0) {
                        var177 = 0.019536126;
                    } else {
                        var177 = -0.026030486;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var177 = 0.020967085;
                    } else {
                        var177 = -0.018838165;
                    }
                }
            } else {
                if (input[5] < 3.34) {
                    if (input[3] < 7.0) {
                        var177 = -0.048281517;
                    } else {
                        var177 = -0.019536799;
                    }
                } else {
                    var177 = 0.050706696;
                }
            }
            double var178;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var178 = -0.029671637;
                    } else {
                        var178 = -0.051451236;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var178 = 0.0067151817;
                    } else {
                        var178 = -0.046374217;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[0] < 9.0) {
                        var178 = 0.020129561;
                    } else {
                        var178 = -0.020740949;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var178 = 0.055545878;
                    } else {
                        var178 = -0.046493832;
                    }
                }
            }
            double var179;
            if (input[12] < 3.34) {
                if (input[1] < 1.0) {
                    if (input[3] < 2.0) {
                        var179 = 0.050366927;
                    } else {
                        var179 = 0.00746668;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var179 = 0.019623607;
                    } else {
                        var179 = -0.02999105;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[10] < 10.0) {
                        var179 = 0.047802158;
                    } else {
                        var179 = -0.001825093;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var179 = -0.05100272;
                    } else {
                        var179 = -0.011994803;
                    }
                }
            }
            double var180;
            if (input[13] < 197.0) {
                if (input[2] < 1.61) {
                    if (input[3] < 4.0) {
                        var180 = -0.04290809;
                    } else {
                        var180 = -0.0045436407;
                    }
                } else {
                    if (input[10] < 9.0) {
                        var180 = -0.030105;
                    } else {
                        var180 = 0.046736076;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var180 = -0.046075244;
                    } else {
                        var180 = 0.005090593;
                    }
                } else {
                    if (input[9] < 5.0) {
                        var180 = 0.0052425335;
                    } else {
                        var180 = 0.04247034;
                    }
                }
            }
            double var181;
            if (input[1] < 3.0) {
                if (input[5] < 0.14) {
                    if (input[13] < 152.0) {
                        var181 = -0.039775193;
                    } else {
                        var181 = 0.0024416526;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var181 = -0.040330928;
                    } else {
                        var181 = 0.017807124;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[12] < 4.16) {
                        var181 = 0.02665776;
                    } else {
                        var181 = -0.048423555;
                    }
                } else {
                    if (input[3] < 5.0) {
                        var181 = -0.052200407;
                    } else {
                        var181 = -0.020803992;
                    }
                }
            }
            double var182;
            if (input[2] < 0.74) {
                if (input[1] < 2.0) {
                    if (input[13] < 306.0) {
                        var182 = -0.051484283;
                    } else {
                        var182 = -0.02403667;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var182 = 0.022912692;
                    } else {
                        var182 = -0.03752033;
                    }
                }
            } else {
                if (input[13] < 277.0) {
                    if (input[2] < 1.96) {
                        var182 = 0.02155446;
                    } else {
                        var182 = -0.025202135;
                    }
                } else {
                    if (input[14] < 75.0) {
                        var182 = -0.054519493;
                    } else {
                        var182 = -0.00997851;
                    }
                }
            }
            double var183;
            if (input[13] < 153.0) {
                if (input[2] < 1.1) {
                    if (input[5] < 0.79) {
                        var183 = 0.028743967;
                    } else {
                        var183 = -0.013390236;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var183 = -0.009836677;
                    } else {
                        var183 = -0.0511162;
                    }
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[14] < 103.0) {
                        var183 = -0.04621712;
                    } else {
                        var183 = 0.014661296;
                    }
                } else {
                    if (input[15] < 1.0) {
                        var183 = -0.05443693;
                    } else {
                        var183 = -0.033601534;
                    }
                }
            }
            double var184;
            if (input[10] < 19.0) {
                if (input[1] < 6.0) {
                    if (input[9] < 5.0) {
                        var184 = -0.04412938;
                    } else {
                        var184 = -0.0065511153;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var184 = -0.038368758;
                    } else {
                        var184 = 0.04072799;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[9] < 10.0) {
                        var184 = -0.046130568;
                    } else {
                        var184 = -0.00007925485;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var184 = 0.011803568;
                    } else {
                        var184 = 0.04703104;
                    }
                }
            }
            double var185;
            if (input[1] < 4.0) {
                if (input[6] < 2.0) {
                    if (input[5] < 0.14) {
                        var185 = -0.025319433;
                    } else {
                        var185 = 0.0050053312;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var185 = -0.043927703;
                    } else {
                        var185 = 0.0347162;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[3] < 5.0) {
                        var185 = -0.050108876;
                    } else {
                        var185 = 0.011026746;
                    }
                } else {
                    var185 = -0.05108236;
                }
            }
            double var186;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[13] < 336.0) {
                        var186 = -0.04916508;
                    } else {
                        var186 = -0.002594345;
                    }
                } else {
                    var186 = 0.048786942;
                }
            } else {
                if (input[5] < 0.45) {
                    if (input[13] < 336.0) {
                        var186 = 0.021112837;
                    } else {
                        var186 = -0.038528528;
                    }
                } else {
                    if (input[0] < 5.0) {
                        var186 = -0.037989583;
                    } else {
                        var186 = 0.0032976107;
                    }
                }
            }
            double var187;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[11] < 1.0) {
                        var187 = 0.038111776;
                    } else {
                        var187 = -0.018968664;
                    }
                } else {
                    if (input[2] < 0.42) {
                        var187 = 0.04433346;
                    } else {
                        var187 = 0.001712302;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[10] < 10.0) {
                        var187 = 0.046917055;
                    } else {
                        var187 = -0.0017815108;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var187 = -0.05093793;
                    } else {
                        var187 = -0.011314744;
                    }
                }
            }
            double var188;
            if (input[11] < 8.0) {
                if (input[0] < 9.0) {
                    if (input[12] < 3.59) {
                        var188 = -0.049031086;
                    } else {
                        var188 = -0.010286303;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var188 = -0.042490106;
                    } else {
                        var188 = 0.050776888;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var188 = -0.046576716;
                    } else {
                        var188 = -0.0017588576;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var188 = 0.0058026663;
                    } else {
                        var188 = 0.044445653;
                    }
                }
            }
            double var189;
            if (input[2] < 0.67) {
                if (input[14] < 103.0) {
                    if (input[5] < 0.56) {
                        var189 = 0.01357677;
                    } else {
                        var189 = 0.042998996;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var189 = -0.025385726;
                    } else {
                        var189 = 0.016750753;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 3.97) {
                        var189 = 0.036780894;
                    } else {
                        var189 = -0.020890668;
                    }
                } else {
                    if (input[3] < 6.0) {
                        var189 = -0.04697601;
                    } else {
                        var189 = -0.0025936665;
                    }
                }
            }
            double var190;
            if (input[2] < 0.59) {
                if (input[2] < 0.45) {
                    var190 = -0.049089152;
                } else {
                    if (input[8] < 3.0) {
                        var190 = -0.0560628;
                    } else {
                        var190 = 0.0028637263;
                    }
                }
            } else {
                if (input[5] < 0.17) {
                    if (input[1] < 7.0) {
                        var190 = 0.02870794;
                    } else {
                        var190 = -0.033309933;
                    }
                } else {
                    if (input[14] < 154.0) {
                        var190 = -0.010697231;
                    } else {
                        var190 = 0.024065724;
                    }
                }
            }
            double var191;
            if (input[11] < 8.0) {
                if (input[1] < 4.0) {
                    if (input[12] < 0.75) {
                        var191 = 0.04569882;
                    } else {
                        var191 = 0.006180884;
                    }
                } else {
                    var191 = -0.052162386;
                }
            } else {
                if (input[14] < 112.0) {
                    if (input[13] < 79.0) {
                        var191 = 0.007731747;
                    } else {
                        var191 = -0.048426323;
                    }
                } else {
                    if (input[5] < 0.19) {
                        var191 = 0.013349081;
                    } else {
                        var191 = -0.037169203;
                    }
                }
            }
            double var192;
            if (input[11] < 12.0) {
                if (input[2] < 1.44) {
                    if (input[9] < 6.0) {
                        var192 = -0.035934966;
                    } else {
                        var192 = 0.005075587;
                    }
                } else {
                    if (input[10] < 13.0) {
                        var192 = -0.02232486;
                    } else {
                        var192 = 0.04081225;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var192 = -0.04564912;
                } else {
                    if (input[9] < 9.0) {
                        var192 = 0.018516013;
                    } else {
                        var192 = 0.06331879;
                    }
                }
            }
            double var193;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[6] < 1.0) {
                        var193 = -0.014688136;
                    } else {
                        var193 = 0.011984799;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var193 = 0.033620063;
                    } else {
                        var193 = -0.008379552;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var193 = 0.000003585254;
                } else {
                    if (input[1] < 1.0) {
                        var193 = -0.010030745;
                    } else {
                        var193 = -0.05094839;
                    }
                }
            }
            double var194;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var194 = -0.049708847;
                    } else {
                        var194 = -0.010765038;
                    }
                } else {
                    var194 = 0.047998175;
                }
            } else {
                if (input[14] < 66.0) {
                    if (input[6] < 1.0) {
                        var194 = -0.005740448;
                    } else {
                        var194 = -0.046135433;
                    }
                } else {
                    if (input[4] < 3.0) {
                        var194 = 0.018313395;
                    } else {
                        var194 = -0.017143989;
                    }
                }
            }
            double var195;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[11] < 1.0) {
                        var195 = 0.0363726;
                    } else {
                        var195 = -0.018301291;
                    }
                } else {
                    if (input[2] < 0.42) {
                        var195 = 0.042317692;
                    } else {
                        var195 = 0.0015338284;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[10] < 10.0) {
                        var195 = 0.04551221;
                    } else {
                        var195 = -0.0024190766;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var195 = -0.05083991;
                    } else {
                        var195 = -0.010652765;
                    }
                }
            }
            double var196;
            if (input[13] < 154.0) {
                if (input[1] < 5.0) {
                    if (input[5] < 1.29) {
                        var196 = -0.04322426;
                    } else {
                        var196 = 0.00833242;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var196 = -0.038512547;
                    } else {
                        var196 = 0.019698191;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var196 = -0.045928653;
                    } else {
                        var196 = -0.002772134;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var196 = 0.008402509;
                    } else {
                        var196 = 0.050504006;
                    }
                }
            }
            double var197;
            if (input[1] < 3.0) {
                if (input[4] < 2.0) {
                    if (input[11] < 5.0) {
                        var197 = -0.04223938;
                    } else {
                        var197 = 0.0015060692;
                    }
                } else {
                    if (input[14] < 136.0) {
                        var197 = 0.031222805;
                    } else {
                        var197 = -0.002672184;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[11] < 7.0) {
                        var197 = 0.04253223;
                    } else {
                        var197 = -0.021621536;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var197 = -0.046961054;
                    } else {
                        var197 = 0.0041775624;
                    }
                }
            }
            double var198;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var198 = -0.048829686;
                } else {
                    var198 = -0.0053390814;
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var198 = 0.032041702;
                    } else {
                        var198 = -0.00845342;
                    }
                } else {
                    if (input[2] < 0.74) {
                        var198 = -0.03308003;
                    } else {
                        var198 = 0.0021537533;
                    }
                }
            }
            double var199;
            if (input[13] < 153.0) {
                if (input[1] < 4.0) {
                    if (input[14] < 81.0) {
                        var199 = -0.04107738;
                    } else {
                        var199 = 0.02102287;
                    }
                } else {
                    var199 = -0.051915284;
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[12] < 2.6) {
                        var199 = 0.021202935;
                    } else {
                        var199 = -0.03653775;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var199 = -0.027630756;
                    } else {
                        var199 = -0.051876523;
                    }
                }
            }
            double var200;
            if (input[13] < 197.0) {
                if (input[1] < 3.0) {
                    if (input[10] < 23.0) {
                        var200 = -0.047094554;
                    } else {
                        var200 = -0.003781339;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var200 = -0.01034752;
                    } else {
                        var200 = 0.034233198;
                    }
                }
            } else {
                if (input[2] < 0.49) {
                    if (input[11] < 17.0) {
                        var200 = -0.041819282;
                    } else {
                        var200 = 0.034745432;
                    }
                } else {
                    if (input[14] < 122.0) {
                        var200 = 0.029616252;
                    } else {
                        var200 = -0.027573843;
                    }
                }
            }
            double var201;
            if (input[2] < 1.13) {
                if (input[5] < 1.05) {
                    if (input[6] < 2.0) {
                        var201 = -0.009186572;
                    } else {
                        var201 = 0.023911472;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var201 = 0.041728105;
                    } else {
                        var201 = -0.0069382573;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[12] < 3.6) {
                        var201 = -0.035855897;
                    } else {
                        var201 = 0.033746477;
                    }
                } else {
                    if (input[5] < 2.79) {
                        var201 = -0.048137076;
                    } else {
                        var201 = 0.0009068317;
                    }
                }
            }
            double var202;
            if (input[0] < 3.0) {
                if (input[2] < 0.98) {
                    var202 = -0.048697863;
                } else {
                    var202 = -0.005213248;
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var202 = 0.03065875;
                    } else {
                        var202 = -0.008037648;
                    }
                } else {
                    if (input[14] < 119.0) {
                        var202 = -0.014689097;
                    } else {
                        var202 = 0.010818773;
                    }
                }
            }
            double var203;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[3] < 2.0) {
                        var203 = 0.009518241;
                    } else {
                        var203 = -0.027515152;
                    }
                } else {
                    if (input[2] < 0.28) {
                        var203 = 0.044556748;
                    } else {
                        var203 = 0.0048239115;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[3] < 2.0) {
                        var203 = 0.042407587;
                    } else {
                        var203 = -0.0057754065;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var203 = -0.05071619;
                    } else {
                        var203 = -0.010770775;
                    }
                }
            }
            double var204;
            if (input[9] < 6.0) {
                if (input[2] < 1.35) {
                    if (input[11] < 11.0) {
                        var204 = -0.041422114;
                    } else {
                        var204 = 0.0030439189;
                    }
                } else {
                    if (input[13] < 115.0) {
                        var204 = -0.022457737;
                    } else {
                        var204 = 0.0393049;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var204 = -0.047460984;
                } else {
                    if (input[13] < 259.0) {
                        var204 = 0.0138422875;
                    } else {
                        var204 = 0.046250645;
                    }
                }
            }
            double var205;
            if (input[0] < 6.0) {
                if (input[3] < 7.0) {
                    if (input[6] < 2.0) {
                        var205 = -0.0066482536;
                    } else {
                        var205 = 0.022757947;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var205 = 0.05201411;
                    } else {
                        var205 = -0.031102514;
                    }
                }
            } else {
                if (input[14] < 27.0) {
                    var205 = 0.0011980833;
                } else {
                    if (input[1] < 1.0) {
                        var205 = -0.010098494;
                    } else {
                        var205 = -0.050669502;
                    }
                }
            }
            double var206;
            if (input[1] < 2.0) {
                if (input[2] < 0.96) {
                    if (input[10] < 20.0) {
                        var206 = -0.04938297;
                    } else {
                        var206 = -0.015016428;
                    }
                } else {
                    if (input[14] < 165.0) {
                        var206 = -0.007008783;
                    } else {
                        var206 = 0.061217573;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[0] < 9.0) {
                        var206 = 0.01746589;
                    } else {
                        var206 = -0.019991962;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var206 = 0.013291949;
                    } else {
                        var206 = -0.05397702;
                    }
                }
            }
            double var207;
            if (input[11] < 8.0) {
                if (input[1] < 1.0) {
                    if (input[14] < 87.0) {
                        var207 = -0.023795387;
                    } else {
                        var207 = 0.036526855;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var207 = 0.022491273;
                    } else {
                        var207 = -0.025480209;
                    }
                }
            } else {
                if (input[14] < 112.0) {
                    if (input[13] < 79.0) {
                        var207 = 0.007296491;
                    } else {
                        var207 = -0.04796555;
                    }
                } else {
                    if (input[5] < 0.19) {
                        var207 = 0.0125222355;
                    } else {
                        var207 = -0.03657962;
                    }
                }
            }
            double var208;
            if (input[10] < 21.0) {
                if (input[1] < 4.0) {
                    if (input[9] < 13.0) {
                        var208 = -0.03167664;
                    } else {
                        var208 = 0.047822963;
                    }
                } else {
                    if (input[13] < 127.0) {
                        var208 = -0.01730076;
                    } else {
                        var208 = 0.02340881;
                    }
                }
            } else {
                if (input[2] < 0.41) {
                    if (input[11] < 17.0) {
                        var208 = -0.046597548;
                    } else {
                        var208 = 0.006317895;
                    }
                } else {
                    if (input[14] < 122.0) {
                        var208 = 0.031375766;
                    } else {
                        var208 = -0.016826116;
                    }
                }
            }
            double var209;
            if (input[1] < 4.0) {
                if (input[3] < 7.0) {
                    if (input[2] < 1.06) {
                        var209 = 0.0018554426;
                    } else {
                        var209 = -0.044826;
                    }
                } else {
                    if (input[0] < 6.0) {
                        var209 = 0.05027291;
                    } else {
                        var209 = -0.025390074;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    if (input[2] < 0.7) {
                        var209 = -0.0099616395;
                    } else {
                        var209 = -0.051555175;
                    }
                } else {
                    if (input[2] < 0.83) {
                        var209 = 0.020476202;
                    } else {
                        var209 = -0.046828967;
                    }
                }
            }
            double var210;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var210 = -0.024080904;
                    } else {
                        var210 = -0.051544588;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var210 = 0.0047783973;
                    } else {
                        var210 = -0.04489339;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[2] < 1.96) {
                        var210 = 0.018342156;
                    } else {
                        var210 = -0.028005539;
                    }
                } else {
                    if (input[13] < 113.0) {
                        var210 = 0.0025596959;
                    } else {
                        var210 = -0.041887376;
                    }
                }
            }
            double var211;
            if (input[13] < 205.0) {
                if (input[2] < 1.1) {
                    if (input[11] < 3.0) {
                        var211 = 0.043701287;
                    } else {
                        var211 = 0.0024046996;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var211 = -0.011719934;
                    } else {
                        var211 = -0.05071139;
                    }
                }
            } else {
                if (input[3] < 1.0) {
                    if (input[14] < 103.0) {
                        var211 = -0.05105378;
                    } else {
                        var211 = 0.007700629;
                    }
                } else {
                    var211 = -0.052494336;
                }
            }
            double var212;
            if (input[11] < 12.0) {
                if (input[1] < 3.0) {
                    if (input[12] < 5.6) {
                        var212 = -0.037756268;
                    } else {
                        var212 = 0.025706748;
                    }
                } else {
                    if (input[9] < 6.0) {
                        var212 = -0.00999227;
                    } else {
                        var212 = 0.029949514;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var212 = -0.04471039;
                } else {
                    if (input[9] < 9.0) {
                        var212 = 0.016375938;
                    } else {
                        var212 = 0.05953726;
                    }
                }
            }
            double var213;
            if (input[1] < 4.0) {
                if (input[3] < 7.0) {
                    if (input[6] < 2.0) {
                        var213 = -0.006447387;
                    } else {
                        var213 = 0.022896808;
                    }
                } else {
                    if (input[2] < 1.19) {
                        var213 = 0.04881143;
                    } else {
                        var213 = -0.02554602;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[3] < 5.0) {
                        var213 = -0.048352536;
                    } else {
                        var213 = 0.011108739;
                    }
                } else {
                    var213 = -0.0503851;
                }
            }
            double var214;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[13] < 336.0) {
                        var214 = -0.0476188;
                    } else {
                        var214 = 0.0021604176;
                    }
                } else {
                    var214 = 0.044401925;
                }
            } else {
                if (input[14] < 66.0) {
                    if (input[6] < 1.0) {
                        var214 = -0.0060215704;
                    } else {
                        var214 = -0.04544481;
                    }
                } else {
                    if (input[1] < 7.0) {
                        var214 = 0.015184293;
                    } else {
                        var214 = -0.02917716;
                    }
                }
            }
            double var215;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var215 = -0.039862737;
                    } else {
                        var215 = 0.02911893;
                    }
                } else {
                    var215 = -0.050742228;
                }
            } else {
                if (input[1] < 4.0) {
                    if (input[13] < 79.0) {
                        var215 = 0.031775445;
                    } else {
                        var215 = -0.0025251107;
                    }
                } else {
                    var215 = -0.051419497;
                }
            }
            double var216;
            if (input[12] < 3.59) {
                if (input[0] < 9.0) {
                    if (input[11] < 9.0) {
                        var216 = -0.044452533;
                    } else {
                        var216 = -0.0053276825;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var216 = -0.03911788;
                    } else {
                        var216 = 0.045495544;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[13] < 343.0) {
                        var216 = -0.026514644;
                    } else {
                        var216 = 0.018433806;
                    }
                } else {
                    if (input[5] < 0.32) {
                        var216 = 0.0036465712;
                    } else {
                        var216 = 0.03680948;
                    }
                }
            }
            double var217;
            if (input[2] < 0.81) {
                if (input[5] < 0.6) {
                    if (input[6] < 1.0) {
                        var217 = -0.0143864155;
                    } else {
                        var217 = 0.012985374;
                    }
                } else {
                    if (input[12] < 1.19) {
                        var217 = -0.021458834;
                    } else {
                        var217 = 0.02877226;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 3.97) {
                        var217 = 0.026388302;
                    } else {
                        var217 = -0.029119253;
                    }
                } else {
                    if (input[3] < 8.0) {
                        var217 = -0.04450416;
                    } else {
                        var217 = 0.008998764;
                    }
                }
            }
            double var218;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var218 = -0.023030661;
                    } else {
                        var218 = -0.051301457;
                    }
                } else {
                    if (input[5] < 0.41) {
                        var218 = 0.004915563;
                    } else {
                        var218 = -0.04427091;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[1] < 6.0) {
                        var218 = 0.0165693;
                    } else {
                        var218 = -0.01726958;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var218 = 0.047593106;
                    } else {
                        var218 = -0.04629923;
                    }
                }
            }
            double var219;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var219 = -0.039453227;
                    } else {
                        var219 = 0.027855465;
                    }
                } else {
                    var219 = -0.050517123;
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[13] < 213.0) {
                        var219 = 0.030012552;
                    } else {
                        var219 = -0.031665783;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var219 = 0.017776785;
                    } else {
                        var219 = -0.029114416;
                    }
                }
            }
            double var220;
            if (input[10] < 23.0) {
                if (input[1] < 4.0) {
                    if (input[13] < 339.0) {
                        var220 = -0.027866501;
                    } else {
                        var220 = 0.022834567;
                    }
                } else {
                    if (input[13] < 128.0) {
                        var220 = -0.013696958;
                    } else {
                        var220 = 0.024137083;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[9] < 4.0) {
                        var220 = -0.02556778;
                    } else {
                        var220 = 0.023018852;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var220 = -0.02623627;
                    } else {
                        var220 = 0.058369737;
                    }
                }
            }
            double var221;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[1] < 2.0) {
                        var221 = 0.003400543;
                    } else {
                        var221 = -0.021515677;
                    }
                } else {
                    if (input[12] < 4.16) {
                        var221 = 0.032393463;
                    } else {
                        var221 = -0.0046363603;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 135.0) {
                        var221 = 0.0420154;
                    } else {
                        var221 = -0.038308345;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var221 = -0.019737428;
                    } else {
                        var221 = -0.05018573;
                    }
                }
            }
            double var222;
            if (input[1] < 2.0) {
                if (input[2] < 0.96) {
                    if (input[10] < 20.0) {
                        var222 = -0.04860623;
                    } else {
                        var222 = -0.0129557075;
                    }
                } else {
                    if (input[14] < 165.0) {
                        var222 = -0.0072329864;
                    } else {
                        var222 = 0.05926707;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[13] < 336.0) {
                        var222 = 0.014213109;
                    } else {
                        var222 = -0.03822438;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var222 = 0.011210171;
                    } else {
                        var222 = -0.053349722;
                    }
                }
            }
            double var223;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[11] < 1.0) {
                        var223 = 0.034381893;
                    } else {
                        var223 = -0.017720584;
                    }
                } else {
                    if (input[5] < 1.04) {
                        var223 = 0.027365133;
                    } else {
                        var223 = -0.035680905;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    if (input[10] < 10.0) {
                        var223 = 0.043068796;
                    } else {
                        var223 = -0.004165557;
                    }
                } else {
                    if (input[14] < 185.0) {
                        var223 = -0.050559122;
                    } else {
                        var223 = -0.010425343;
                    }
                }
            }
            double var224;
            if (input[9] < 9.0) {
                if (input[12] < 3.72) {
                    if (input[1] < 7.0) {
                        var224 = -0.030186424;
                    } else {
                        var224 = 0.036191136;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var224 = -0.021068882;
                    } else {
                        var224 = 0.01855141;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var224 = -0.04327811;
                } else {
                    if (input[13] < 142.0) {
                        var224 = -0.0020647787;
                    } else {
                        var224 = 0.043812733;
                    }
                }
            }
            double var225;
            if (input[2] < 1.13) {
                if (input[5] < 1.05) {
                    if (input[6] < 2.0) {
                        var225 = -0.008559165;
                    } else {
                        var225 = 0.020423504;
                    }
                } else {
                    if (input[9] < 8.0) {
                        var225 = 0.03874464;
                    } else {
                        var225 = -0.0064962776;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[6] < 1.0) {
                        var225 = -0.03970859;
                    } else {
                        var225 = 0.008744302;
                    }
                } else {
                    if (input[5] < 2.38) {
                        var225 = -0.05012334;
                    } else {
                        var225 = -0.0026949544;
                    }
                }
            }
            double var226;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var226 = -0.0220332;
                    } else {
                        var226 = -0.051232368;
                    }
                } else {
                    if (input[12] < 3.23) {
                        var226 = -0.029422546;
                    } else {
                        var226 = 0.014309652;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[2] < 1.96) {
                        var226 = 0.016807972;
                    } else {
                        var226 = -0.027206099;
                    }
                } else {
                    if (input[14] < 114.0) {
                        var226 = -0.042678706;
                    } else {
                        var226 = 0.0003524285;
                    }
                }
            }
            double var227;
            if (input[13] < 205.0) {
                if (input[2] < 0.3) {
                    if (input[5] < 0.83) {
                        var227 = 0.03846279;
                    } else {
                        var227 = -0.012518159;
                    }
                } else {
                    if (input[13] < 82.0) {
                        var227 = 0.014717837;
                    } else {
                        var227 = -0.033804093;
                    }
                }
            } else {
                if (input[3] < 1.0) {
                    if (input[12] < 3.12) {
                        var227 = 0.0100107035;
                    } else {
                        var227 = -0.049188726;
                    }
                } else {
                    var227 = -0.05183053;
                }
            }
            double var228;
            if (input[13] < 240.0) {
                if (input[1] < 4.0) {
                    if (input[12] < 4.6) {
                        var228 = -0.034096446;
                    } else {
                        var228 = 0.010006217;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var228 = -0.015277132;
                    } else {
                        var228 = 0.02544343;
                    }
                }
            } else {
                if (input[2] < 0.49) {
                    if (input[13] < 442.0) {
                        var228 = -0.045969762;
                    } else {
                        var228 = 0.02138613;
                    }
                } else {
                    if (input[14] < 88.0) {
                        var228 = 0.045824375;
                    } else {
                        var228 = 0.005543928;
                    }
                }
            }
            double var229;
            if (input[1] < 4.0) {
                if (input[5] < 0.14) {
                    if (input[14] < 78.0) {
                        var229 = 0.012096531;
                    } else {
                        var229 = -0.027842015;
                    }
                } else {
                    if (input[2] < 1.13) {
                        var229 = 0.01095304;
                    } else {
                        var229 = -0.035072964;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    if (input[5] < 1.81) {
                        var229 = -0.05100757;
                    } else {
                        var229 = -0.009773861;
                    }
                } else {
                    if (input[2] < 0.83) {
                        var229 = 0.019883724;
                    } else {
                        var229 = -0.045674574;
                    }
                }
            }
            double var230;
            if (input[1] < 2.0) {
                if (input[2] < 0.8) {
                    if (input[13] < 306.0) {
                        var230 = -0.05177289;
                    } else {
                        var230 = -0.023013782;
                    }
                } else {
                    if (input[5] < 0.14) {
                        var230 = 0.027564302;
                    } else {
                        var230 = -0.024248803;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[13] < 244.0) {
                        var230 = 0.017121376;
                    } else {
                        var230 = -0.011649672;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var230 = 0.045110136;
                    } else {
                        var230 = -0.044871658;
                    }
                }
            }
            double var231;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var231 = -0.03877324;
                    } else {
                        var231 = 0.02547226;
                    }
                } else {
                    var231 = -0.050296117;
                }
            } else {
                if (input[2] < 1.21) {
                    if (input[10] < 2.0) {
                        var231 = 0.059491437;
                    } else {
                        var231 = 0.004297336;
                    }
                } else {
                    var231 = -0.048587248;
                }
            }
            double var232;
            if (input[9] < 6.0) {
                if (input[11] < 11.0) {
                    if (input[0] < 8.0) {
                        var232 = -0.036065012;
                    } else {
                        var232 = 0.014378898;
                    }
                } else {
                    if (input[2] < 0.7) {
                        var232 = -0.0190118;
                    } else {
                        var232 = 0.023998862;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var232 = -0.0464835;
                } else {
                    if (input[13] < 197.0) {
                        var232 = 0.0063890065;
                    } else {
                        var232 = 0.03497996;
                    }
                }
            }
            double var233;
            if (input[0] < 6.0) {
                if (input[4] < 2.0) {
                    if (input[13] < 99.0) {
                        var233 = -0.03486721;
                    } else {
                        var233 = -0.0011501116;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var233 = 0.023383817;
                    } else {
                        var233 = -0.011677627;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 148.0) {
                        var233 = 0.039568987;
                    } else {
                        var233 = -0.036705416;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var233 = -0.018307803;
                    } else {
                        var233 = -0.049887687;
                    }
                }
            }
            double var234;
            if (input[14] < 66.0) {
                if (input[5] < 0.33) {
                    if (input[9] < 5.0) {
                        var234 = 0.019484231;
                    } else {
                        var234 = -0.0287915;
                    }
                } else {
                    if (input[8] < 1.0) {
                        var234 = -0.0016226106;
                    } else {
                        var234 = -0.051313777;
                    }
                }
            } else {
                if (input[2] < 0.45) {
                    var234 = -0.04731682;
                } else {
                    if (input[5] < 0.17) {
                        var234 = 0.023405893;
                    } else {
                        var234 = 0.00032553184;
                    }
                }
            }
            double var235;
            if (input[13] < 213.0) {
                if (input[1] < 4.0) {
                    if (input[14] < 87.0) {
                        var235 = -0.03418073;
                    } else {
                        var235 = 0.015694132;
                    }
                } else {
                    var235 = -0.051194757;
                }
            } else {
                if (input[5] < 0.18) {
                    if (input[14] < 103.0) {
                        var235 = -0.051801868;
                    } else {
                        var235 = 0.0017898841;
                    }
                } else {
                    var235 = -0.05425183;
                }
            }
            double var236;
            if (input[10] < 23.0) {
                if (input[2] < 0.53) {
                    if (input[9] < 12.0) {
                        var236 = -0.048752736;
                    } else {
                        var236 = -0.00024928898;
                    }
                } else {
                    if (input[13] < 339.0) {
                        var236 = -0.00657337;
                    } else {
                        var236 = 0.04421873;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[0] < 2.0) {
                        var236 = -0.041562803;
                    } else {
                        var236 = 0.01484473;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var236 = -0.024554383;
                    } else {
                        var236 = 0.056643933;
                    }
                }
            }
            double var237;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[13] < 152.0) {
                        var237 = -0.024845535;
                    } else {
                        var237 = 0.00088786596;
                    }
                } else {
                    if (input[14] < 136.0) {
                        var237 = 0.022074498;
                    } else {
                        var237 = -0.005743951;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[12] < 4.16) {
                        var237 = 0.023728259;
                    } else {
                        var237 = -0.042351592;
                    }
                } else {
                    if (input[3] < 5.0) {
                        var237 = -0.050707366;
                    } else {
                        var237 = -0.016960058;
                    }
                }
            }
            double var238;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var238 = -0.04763105;
                    } else {
                        var238 = -0.0038925398;
                    }
                } else {
                    var238 = 0.04162247;
                }
            } else {
                if (input[5] < 0.45) {
                    if (input[2] < 2.11) {
                        var238 = 0.01683656;
                    } else {
                        var238 = -0.03825761;
                    }
                } else {
                    if (input[0] < 5.0) {
                        var238 = -0.03657071;
                    } else {
                        var238 = 0.0018293044;
                    }
                }
            }
            double var239;
            if (input[12] < 3.34) {
                if (input[15] < 1.0) {
                    if (input[3] < 2.0) {
                        var239 = 0.008329502;
                    } else {
                        var239 = -0.026650831;
                    }
                } else {
                    if (input[2] < 0.28) {
                        var239 = 0.041625824;
                    } else {
                        var239 = 0.004266762;
                    }
                }
            } else {
                if (input[10] < 10.0) {
                    var239 = 0.04175956;
                } else {
                    if (input[10] < 12.0) {
                        var239 = -0.0049807704;
                    } else {
                        var239 = -0.048625685;
                    }
                }
            }
            double var240;
            if (input[14] < 122.0) {
                if (input[1] < 1.0) {
                    if (input[11] < 12.0) {
                        var240 = -0.050624456;
                    } else {
                        var240 = -0.014214027;
                    }
                } else {
                    if (input[10] < 23.0) {
                        var240 = 0.0048904414;
                    } else {
                        var240 = 0.0451896;
                    }
                }
            } else {
                if (input[2] < 1.99) {
                    if (input[5] < 0.66) {
                        var240 = -0.05320817;
                    } else {
                        var240 = -0.016932672;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var240 = -0.053113867;
                    } else {
                        var240 = 0.04145895;
                    }
                }
            }
            double var241;
            if (input[2] < 0.84) {
                if (input[5] < 0.74) {
                    if (input[6] < 2.0) {
                        var241 = -0.009796734;
                    } else {
                        var241 = 0.024131704;
                    }
                } else {
                    if (input[11] < 13.0) {
                        var241 = 0.02944438;
                    } else {
                        var241 = -0.007031607;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[11] < 12.0) {
                        var241 = 0.035754718;
                    } else {
                        var241 = -0.035288386;
                    }
                } else {
                    if (input[3] < 8.0) {
                        var241 = -0.035823684;
                    } else {
                        var241 = 0.016613107;
                    }
                }
            }
            double var242;
            if (input[2] < 0.59) {
                if (input[14] < 155.0) {
                    if (input[7] < 2.0) {
                        var242 = -0.030266086;
                    } else {
                        var242 = -0.056811996;
                    }
                } else {
                    if (input[2] < 0.45) {
                        var242 = -0.039100524;
                    } else {
                        var242 = 0.028913448;
                    }
                }
            } else {
                if (input[5] < 0.28) {
                    if (input[1] < 5.0) {
                        var242 = 0.025083372;
                    } else {
                        var242 = -0.0110527;
                    }
                } else {
                    if (input[14] < 80.0) {
                        var242 = -0.032055333;
                    } else {
                        var242 = 0.0017512449;
                    }
                }
            }
            double var243;
            if (input[11] < 7.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 1.43) {
                        var243 = 0.037123773;
                    } else {
                        var243 = -0.052129444;
                    }
                } else {
                    if (input[12] < 0.22) {
                        var243 = 0.041448448;
                    } else {
                        var243 = -0.015079736;
                    }
                }
            } else {
                if (input[2] < 0.31) {
                    if (input[13] < 198.0) {
                        var243 = 0.014183466;
                    } else {
                        var243 = -0.038778692;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var243 = -0.020571278;
                    } else {
                        var243 = -0.05342398;
                    }
                }
            }
            double var244;
            if (input[9] < 6.0) {
                if (input[2] < 1.35) {
                    if (input[11] < 11.0) {
                        var244 = -0.037650224;
                    } else {
                        var244 = 0.0018000845;
                    }
                } else {
                    if (input[13] < 115.0) {
                        var244 = -0.020893201;
                    } else {
                        var244 = 0.037470885;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var244 = -0.04593418;
                } else {
                    if (input[14] < 79.0) {
                        var244 = 0.036819454;
                    } else {
                        var244 = 0.009561515;
                    }
                }
            }
            double var245;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[6] < 1.0) {
                        var245 = -0.012860799;
                    } else {
                        var245 = 0.0096985465;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var245 = 0.027330194;
                    } else {
                        var245 = -0.010488556;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 148.0) {
                        var245 = 0.037478454;
                    } else {
                        var245 = -0.035455603;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var245 = -0.018609433;
                    } else {
                        var245 = -0.049564764;
                    }
                }
            }
            double var246;
            if (input[2] < 0.74) {
                if (input[5] < 0.41) {
                    if (input[1] < 3.0) {
                        var246 = -0.02789337;
                    } else {
                        var246 = 0.026109641;
                    }
                } else {
                    var246 = -0.052515972;
                }
            } else {
                if (input[13] < 277.0) {
                    if (input[5] < 0.77) {
                        var246 = 0.017938338;
                    } else {
                        var246 = -0.013260933;
                    }
                } else {
                    if (input[2] < 1.2) {
                        var246 = -0.005973775;
                    } else {
                        var246 = -0.051727545;
                    }
                }
            }
            double var247;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var247 = -0.037858147;
                    } else {
                        var247 = 0.024235006;
                    }
                } else {
                    var247 = -0.049906462;
                }
            } else {
                if (input[2] < 1.1) {
                    if (input[12] < 0.33) {
                        var247 = 0.059031885;
                    } else {
                        var247 = 0.004587888;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var247 = -0.009832087;
                    } else {
                        var247 = -0.05016644;
                    }
                }
            }
            double var248;
            if (input[15] < 1.0) {
                if (input[1] < 1.0) {
                    if (input[2] < 1.09) {
                        var248 = -0.044359963;
                    } else {
                        var248 = 0.017815154;
                    }
                } else {
                    if (input[11] < 13.0) {
                        var248 = 0.006240405;
                    } else {
                        var248 = 0.0421983;
                    }
                }
            } else {
                if (input[9] < 12.0) {
                    if (input[0] < 7.0) {
                        var248 = -0.03699583;
                    } else {
                        var248 = 0.006480074;
                    }
                } else {
                    if (input[5] < 0.15) {
                        var248 = 0.0005520423;
                    } else {
                        var248 = 0.057145327;
                    }
                }
            }
            double var249;
            if (input[1] < 4.0) {
                if (input[3] < 7.0) {
                    if (input[2] < 1.06) {
                        var249 = 0.0010986691;
                    } else {
                        var249 = -0.042963285;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var249 = -0.034503352;
                    } else {
                        var249 = 0.042320523;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    if (input[5] < 1.75) {
                        var249 = -0.05043869;
                    } else {
                        var249 = -0.0111686485;
                    }
                } else {
                    if (input[2] < 0.83) {
                        var249 = 0.017716048;
                    } else {
                        var249 = -0.04501592;
                    }
                }
            }
            double var250;
            if (input[14] < 66.0) {
                if (input[5] < 0.33) {
                    if (input[1] < 2.0) {
                        var250 = -0.054170687;
                    } else {
                        var250 = 0.004437402;
                    }
                } else {
                    if (input[8] < 1.0) {
                        var250 = 0.00047568078;
                    } else {
                        var250 = -0.050635844;
                    }
                }
            } else {
                if (input[2] < 0.45) {
                    var250 = -0.04674773;
                } else {
                    if (input[5] < 0.17) {
                        var250 = 0.021567835;
                    } else {
                        var250 = -0.000056534653;
                    }
                }
            }
            double var251;
            if (input[11] < 6.0) {
                if (input[1] < 4.0) {
                    if (input[5] < 0.96) {
                        var251 = 0.02713719;
                    } else {
                        var251 = -0.021146933;
                    }
                } else {
                    var251 = -0.050879806;
                }
            } else {
                if (input[0] < 3.0) {
                    if (input[5] < 0.27) {
                        var251 = 0.019371947;
                    } else {
                        var251 = -0.023759952;
                    }
                } else {
                    if (input[13] < 58.0) {
                        var251 = -0.0018081922;
                    } else {
                        var251 = -0.052343797;
                    }
                }
            }
            double var252;
            if (input[9] < 9.0) {
                if (input[10] < 22.0) {
                    if (input[1] < 4.0) {
                        var252 = -0.029007828;
                    } else {
                        var252 = 0.00482603;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var252 = -0.03408207;
                    } else {
                        var252 = 0.026048994;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var252 = -0.041521218;
                } else {
                    if (input[13] < 142.0) {
                        var252 = -0.002901688;
                    } else {
                        var252 = 0.039589025;
                    }
                }
            }
            double var253;
            if (input[1] < 3.0) {
                if (input[14] < 135.0) {
                    if (input[13] < 341.0) {
                        var253 = 0.01671813;
                    } else {
                        var253 = -0.02041301;
                    }
                } else {
                    if (input[13] < 154.0) {
                        var253 = -0.02533753;
                    } else {
                        var253 = 0.010506663;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[13] < 164.0) {
                        var253 = 0.044298485;
                    } else {
                        var253 = -0.01505045;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var253 = -0.013888282;
                    } else {
                        var253 = -0.048977926;
                    }
                }
            }
            double var254;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[13] < 336.0) {
                        var254 = -0.04526378;
                    } else {
                        var254 = 0.0076160836;
                    }
                } else {
                    var254 = 0.03984277;
                }
            } else {
                if (input[14] < 66.0) {
                    if (input[6] < 1.0) {
                        var254 = -0.00515563;
                    } else {
                        var254 = -0.043664433;
                    }
                } else {
                    if (input[1] < 7.0) {
                        var254 = 0.012529807;
                    } else {
                        var254 = -0.028982198;
                    }
                }
            }
            double var255;
            if (input[15] < 1.0) {
                if (input[11] < 5.0) {
                    if (input[1] < 3.0) {
                        var255 = 0.021545865;
                    } else {
                        var255 = -0.034025922;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var255 = -0.008376966;
                    } else {
                        var255 = -0.045683995;
                    }
                }
            } else {
                if (input[2] < 1.19) {
                    if (input[12] < 3.54) {
                        var255 = 0.023933198;
                    } else {
                        var255 = -0.041727364;
                    }
                } else {
                    var255 = -0.048644718;
                }
            }
            double var256;
            if (input[14] < 122.0) {
                if (input[2] < 0.41) {
                    if (input[13] < 442.0) {
                        var256 = -0.048293464;
                    } else {
                        var256 = 0.008473516;
                    }
                } else {
                    if (input[13] < 197.0) {
                        var256 = -0.006243588;
                    } else {
                        var256 = 0.022637771;
                    }
                }
            } else {
                if (input[2] < 1.99) {
                    if (input[5] < 0.66) {
                        var256 = -0.051741183;
                    } else {
                        var256 = -0.015081848;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var256 = -0.051759142;
                    } else {
                        var256 = 0.039686173;
                    }
                }
            }
            double var257;
            if (input[2] < 0.67) {
                if (input[14] < 103.0) {
                    if (input[5] < 0.56) {
                        var257 = 0.009891356;
                    } else {
                        var257 = 0.039683685;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var257 = -0.024235832;
                    } else {
                        var257 = 0.016110176;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 3.97) {
                        var257 = 0.032839306;
                    } else {
                        var257 = -0.01936545;
                    }
                } else {
                    if (input[3] < 5.0) {
                        var257 = -0.047349367;
                    } else {
                        var257 = -0.007223961;
                    }
                }
            }
            double var258;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var258 = -0.01675984;
                    } else {
                        var258 = -0.05085769;
                    }
                } else {
                    if (input[12] < 3.23) {
                        var258 = -0.029616091;
                    } else {
                        var258 = 0.014671976;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[1] < 6.0) {
                        var258 = 0.013848196;
                    } else {
                        var258 = -0.017309798;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var258 = 0.009354027;
                    } else {
                        var258 = -0.05282123;
                    }
                }
            }
            double var259;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var259 = -0.03725053;
                    } else {
                        var259 = 0.023006165;
                    }
                } else {
                    var259 = -0.04958202;
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[11] < 7.0) {
                        var259 = 0.034467593;
                    } else {
                        var259 = -0.0015785277;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var259 = 0.020290969;
                    } else {
                        var259 = -0.025400078;
                    }
                }
            }
            double var260;
            if (input[12] < 4.38) {
                if (input[0] < 8.0) {
                    if (input[3] < 2.0) {
                        var260 = -0.03652702;
                    } else {
                        var260 = -0.0022561313;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var260 = -0.03176486;
                    } else {
                        var260 = 0.036378637;
                    }
                }
            } else {
                if (input[0] < 2.0) {
                    var260 = -0.04298061;
                } else {
                    if (input[9] < 9.0) {
                        var260 = 0.018031366;
                    } else {
                        var260 = 0.04937246;
                    }
                }
            }
            double var261;
            if (input[2] < 1.13) {
                if (input[5] < 1.05) {
                    if (input[6] < 2.0) {
                        var261 = -0.008140118;
                    } else {
                        var261 = 0.018447768;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var261 = 0.033984672;
                    } else {
                        var261 = -0.00929748;
                    }
                }
            } else {
                if (input[14] < 61.0) {
                    if (input[13] < 130.0) {
                        var261 = 0.02939688;
                    } else {
                        var261 = -0.037778433;
                    }
                } else {
                    if (input[0] < 4.0) {
                        var261 = -0.016457522;
                    } else {
                        var261 = -0.049112603;
                    }
                }
            }
            double var262;
            if (input[0] < 3.0) {
                var262 = -0.04595655;
            } else {
                if (input[5] < 0.12) {
                    if (input[2] < 1.33) {
                        var262 = 0.027532114;
                    } else {
                        var262 = -0.0052750213;
                    }
                } else {
                    if (input[2] < 0.74) {
                        var262 = -0.031433757;
                    } else {
                        var262 = 0.0002899052;
                    }
                }
            }
            double var263;
            if (input[13] < 205.0) {
                if (input[1] < 4.0) {
                    if (input[12] < 0.75) {
                        var263 = 0.039571498;
                    } else {
                        var263 = 0.0020778922;
                    }
                } else {
                    var263 = -0.050422516;
                }
            } else {
                if (input[3] < 1.0) {
                    if (input[12] < 3.12) {
                        var263 = 0.008729343;
                    } else {
                        var263 = -0.048776932;
                    }
                } else {
                    var263 = -0.050495215;
                }
            }
            double var264;
            if (input[15] < 1.0) {
                if (input[1] < 1.0) {
                    if (input[2] < 1.09) {
                        var264 = -0.043168176;
                    } else {
                        var264 = 0.016619703;
                    }
                } else {
                    if (input[13] < 259.0) {
                        var264 = 0.0034385666;
                    } else {
                        var264 = 0.035464294;
                    }
                }
            } else {
                if (input[9] < 12.0) {
                    if (input[0] < 7.0) {
                        var264 = -0.035347223;
                    } else {
                        var264 = 0.005080554;
                    }
                } else {
                    if (input[14] < 33.0) {
                        var264 = -0.011630229;
                    } else {
                        var264 = 0.05114301;
                    }
                }
            }
            double var265;
            if (input[1] < 3.0) {
                if (input[4] < 2.0) {
                    if (input[13] < 99.0) {
                        var265 = -0.03239281;
                    } else {
                        var265 = 0.0015388398;
                    }
                } else {
                    if (input[14] < 139.0) {
                        var265 = 0.026602944;
                    } else {
                        var265 = -0.003968069;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[12] < 4.16) {
                        var265 = 0.02056385;
                    } else {
                        var265 = -0.03985084;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var265 = -0.012157651;
                    } else {
                        var265 = -0.048140433;
                    }
                }
            }
            double var266;
            if (input[14] < 66.0) {
                if (input[5] < 0.33) {
                    if (input[1] < 2.0) {
                        var266 = -0.053563364;
                    } else {
                        var266 = 0.004141519;
                    }
                } else {
                    if (input[8] < 1.0) {
                        var266 = 0.0017009778;
                    } else {
                        var266 = -0.049847953;
                    }
                }
            } else {
                if (input[2] < 0.45) {
                    var266 = -0.046001267;
                } else {
                    if (input[5] < 0.45) {
                        var266 = 0.015513909;
                    } else {
                        var266 = -0.0058952565;
                    }
                }
            }
            double var267;
            if (input[15] < 1.0) {
                if (input[11] < 1.0) {
                    if (input[1] < 4.0) {
                        var267 = 0.048439223;
                    } else {
                        var267 = -0.040867757;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var267 = -0.0031779509;
                    } else {
                        var267 = -0.041804507;
                    }
                }
            } else {
                if (input[2] < 1.19) {
                    if (input[5] < 1.04) {
                        var267 = 0.024054492;
                    } else {
                        var267 = -0.030298203;
                    }
                } else {
                    var267 = -0.048281305;
                }
            }
            double var268;
            if (input[11] < 8.0) {
                if (input[0] < 9.0) {
                    if (input[12] < 3.59) {
                        var268 = -0.044811167;
                    } else {
                        var268 = -0.008615659;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var268 = -0.028691202;
                    } else {
                        var268 = 0.05298266;
                    }
                }
            } else {
                if (input[10] < 22.0) {
                    if (input[2] < 0.9) {
                        var268 = -0.019974938;
                    } else {
                        var268 = 0.01531255;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var268 = -0.00017890777;
                    } else {
                        var268 = 0.04436947;
                    }
                }
            }
            double var269;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[6] < 1.0) {
                        var269 = -0.012571338;
                    } else {
                        var269 = 0.008864512;
                    }
                } else {
                    if (input[2] < 0.8) {
                        var269 = 0.02878939;
                    } else {
                        var269 = -0.0013195087;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 155.0) {
                        var269 = 0.033429205;
                    } else {
                        var269 = -0.0334475;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var269 = -0.01699028;
                    } else {
                        var269 = -0.048985373;
                    }
                }
            }
            double var270;
            if (input[1] < 2.0) {
                if (input[2] < 0.96) {
                    if (input[10] < 20.0) {
                        var270 = -0.047580916;
                    } else {
                        var270 = -0.0067916173;
                    }
                } else {
                    if (input[14] < 165.0) {
                        var270 = -0.0071262084;
                    } else {
                        var270 = 0.05506701;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[13] < 336.0) {
                        var270 = 0.01131077;
                    } else {
                        var270 = -0.035875857;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var270 = 0.008835024;
                    } else {
                        var270 = -0.05228736;
                    }
                }
            }
            double var271;
            if (input[12] < 3.3) {
                if (input[2] < 0.27) {
                    if (input[9] < 7.0) {
                        var271 = 0.029540977;
                    } else {
                        var271 = -0.02719532;
                    }
                } else {
                    if (input[13] < 79.0) {
                        var271 = 0.0155381905;
                    } else {
                        var271 = -0.030007927;
                    }
                }
            } else {
                if (input[10] < 10.0) {
                    var271 = 0.04006735;
                } else {
                    if (input[11] < 5.0) {
                        var271 = -0.0033333648;
                    } else {
                        var271 = -0.048732642;
                    }
                }
            }
            double var272;
            if (input[9] < 6.0) {
                if (input[15] < 1.0) {
                    if (input[2] < 1.35) {
                        var272 = -0.008439976;
                    } else {
                        var272 = 0.027481848;
                    }
                } else {
                    if (input[2] < 1.61) {
                        var272 = -0.038773984;
                    } else {
                        var272 = 0.005314709;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var272 = -0.044685867;
                } else {
                    if (input[14] < 79.0) {
                        var272 = 0.03432065;
                    } else {
                        var272 = 0.008433815;
                    }
                }
            }
            double var273;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[13] < 91.0) {
                        var273 = -0.040272187;
                    } else {
                        var273 = -0.005653571;
                    }
                } else {
                    if (input[14] < 102.0) {
                        var273 = 0.025299788;
                    } else {
                        var273 = 0.0013437251;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[10] < 19.0) {
                        var273 = 0.021299733;
                    } else {
                        var273 = -0.029806687;
                    }
                } else {
                    if (input[4] < 4.0) {
                        var273 = -0.050555933;
                    } else {
                        var273 = -0.018784104;
                    }
                }
            }
            double var274;
            if (input[2] < 0.79) {
                if (input[1] < 2.0) {
                    if (input[11] < 12.0) {
                        var274 = -0.051857848;
                    } else {
                        var274 = -0.020842535;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var274 = 0.017650966;
                    } else {
                        var274 = -0.02824196;
                    }
                }
            } else {
                if (input[1] < 6.0) {
                    if (input[13] < 338.0) {
                        var274 = 0.01563651;
                    } else {
                        var274 = -0.04130561;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var274 = 0.04229025;
                    } else {
                        var274 = -0.03534523;
                    }
                }
            }
            double var275;
            if (input[13] < 205.0) {
                if (input[2] < 1.1) {
                    if (input[12] < 0.33) {
                        var275 = 0.056618657;
                    } else {
                        var275 = 0.0044990224;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var275 = -0.010820179;
                    } else {
                        var275 = -0.04954953;
                    }
                }
            } else {
                if (input[3] < 1.0) {
                    if (input[14] < 103.0) {
                        var275 = -0.04982946;
                    } else {
                        var275 = 0.007498776;
                    }
                } else {
                    var275 = -0.05019426;
                }
            }
            double var276;
            if (input[14] < 122.0) {
                if (input[13] < 197.0) {
                    if (input[8] < 5.0) {
                        var276 = -0.026364474;
                    } else {
                        var276 = 0.013734463;
                    }
                } else {
                    if (input[2] < 1.17) {
                        var276 = 0.0091423355;
                    } else {
                        var276 = 0.046627343;
                    }
                }
            } else {
                if (input[2] < 1.99) {
                    if (input[5] < 0.66) {
                        var276 = -0.05039491;
                    } else {
                        var276 = -0.014346118;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var276 = -0.049531408;
                    } else {
                        var276 = 0.03759649;
                    }
                }
            }
            double var277;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[6] < 1.0) {
                        var277 = -0.01224247;
                    } else {
                        var277 = 0.008425952;
                    }
                } else {
                    if (input[3] < 8.0) {
                        var277 = 0.012114414;
                    } else {
                        var277 = 0.048541676;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 156.0) {
                        var277 = 0.03181981;
                    } else {
                        var277 = -0.032683037;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var277 = -0.016685812;
                    } else {
                        var277 = -0.048719656;
                    }
                }
            }
            double var278;
            if (input[14] < 66.0) {
                if (input[6] < 1.0) {
                    if (input[11] < 11.0) {
                        var278 = 0.0050264476;
                    } else {
                        var278 = -0.035883132;
                    }
                } else {
                    if (input[13] < 55.0) {
                        var278 = 0.0023051712;
                    } else {
                        var278 = -0.045979336;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 1.04) {
                        var278 = -0.04105529;
                    } else {
                        var278 = 0.016976828;
                    }
                } else {
                    if (input[5] < 1.03) {
                        var278 = 0.01153531;
                    } else {
                        var278 = -0.026296033;
                    }
                }
            }
            double var279;
            if (input[15] < 1.0) {
                if (input[11] < 1.0) {
                    if (input[1] < 4.0) {
                        var279 = 0.046776455;
                    } else {
                        var279 = -0.040333178;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var279 = -0.003499314;
                    } else {
                        var279 = -0.040408514;
                    }
                }
            } else {
                if (input[12] < 3.54) {
                    if (input[2] < 0.41) {
                        var279 = 0.034154255;
                    } else {
                        var279 = 0.00068183336;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var279 = 0.003297555;
                    } else {
                        var279 = -0.048894193;
                    }
                }
            }
            double var280;
            if (input[10] < 23.0) {
                if (input[15] < 1.0) {
                    if (input[2] < 0.55) {
                        var280 = -0.040654212;
                    } else {
                        var280 = 0.009142822;
                    }
                } else {
                    if (input[2] < 1.17) {
                        var280 = -0.040777396;
                    } else {
                        var280 = -0.002847247;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[9] < 4.0) {
                        var280 = -0.021877533;
                    } else {
                        var280 = 0.01877706;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var280 = -0.02334681;
                    } else {
                        var280 = 0.05292484;
                    }
                }
            }
            double var281;
            if (input[2] < 0.81) {
                if (input[5] < 0.6) {
                    if (input[13] < 99.0) {
                        var281 = -0.027925555;
                    } else {
                        var281 = -0.00015853181;
                    }
                } else {
                    if (input[14] < 166.0) {
                        var281 = 0.027623033;
                    } else {
                        var281 = -0.0037242796;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[4] < 1.0) {
                        var281 = -0.020764912;
                    } else {
                        var281 = 0.0363242;
                    }
                } else {
                    if (input[6] < 2.0) {
                        var281 = -0.036257904;
                    } else {
                        var281 = 0.0001957612;
                    }
                }
            }
            double var282;
            if (input[0] < 4.0) {
                if (input[2] < 0.54) {
                    if (input[9] < 1.0) {
                        var282 = -0.013082477;
                    } else {
                        var282 = -0.05075074;
                    }
                } else {
                    if (input[12] < 3.23) {
                        var282 = -0.029700924;
                    } else {
                        var282 = 0.015026673;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[2] < 2.23) {
                        var282 = 0.012353328;
                    } else {
                        var282 = -0.03974611;
                    }
                } else {
                    if (input[13] < 113.0) {
                        var282 = 0.00024278292;
                    } else {
                        var282 = -0.039409004;
                    }
                }
            }
            double var283;
            if (input[14] < 87.0) {
                if (input[10] < 8.0) {
                    var283 = 0.028115993;
                } else {
                    if (input[5] < 0.09) {
                        var283 = -0.01681136;
                    } else {
                        var283 = -0.052316792;
                    }
                }
            } else {
                if (input[1] < 4.0) {
                    if (input[13] < 67.0) {
                        var283 = 0.03121014;
                    } else {
                        var283 = -0.0016031399;
                    }
                } else {
                    var283 = -0.049848262;
                }
            }
            double var284;
            if (input[13] < 240.0) {
                if (input[1] < 4.0) {
                    if (input[8] < 5.0) {
                        var284 = -0.038146444;
                    } else {
                        var284 = -0.0029883909;
                    }
                } else {
                    if (input[12] < 2.98) {
                        var284 = -0.017799132;
                    } else {
                        var284 = 0.021702345;
                    }
                }
            } else {
                if (input[2] < 0.49) {
                    if (input[13] < 432.0) {
                        var284 = -0.047512185;
                    } else {
                        var284 = 0.014694615;
                    }
                } else {
                    if (input[14] < 88.0) {
                        var284 = 0.041107975;
                    } else {
                        var284 = 0.0033802737;
                    }
                }
            }
            double var285;
            if (input[1] < 3.0) {
                if (input[3] < 8.0) {
                    if (input[10] < 6.0) {
                        var285 = -0.048403386;
                    } else {
                        var285 = 0.003297884;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var285 = 0.06311851;
                    } else {
                        var285 = 0.0068997457;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[13] < 164.0) {
                        var285 = 0.0377838;
                    } else {
                        var285 = -0.015590489;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var285 = -0.010464855;
                    } else {
                        var285 = -0.047562238;
                    }
                }
            }
            double var286;
            if (input[5] < 0.12) {
                if (input[1] < 7.0) {
                    if (input[0] < 3.0) {
                        var286 = -0.039671358;
                    } else {
                        var286 = 0.021002633;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var286 = 0.032309808;
                    } else {
                        var286 = -0.055468794;
                    }
                }
            } else {
                if (input[2] < 0.74) {
                    if (input[1] < 3.0) {
                        var286 = -0.04778926;
                    } else {
                        var286 = -0.0132505065;
                    }
                } else {
                    if (input[14] < 80.0) {
                        var286 = -0.022022244;
                    } else {
                        var286 = 0.006948211;
                    }
                }
            }
            double var287;
            if (input[13] < 213.0) {
                if (input[5] < 0.74) {
                    if (input[0] < 6.0) {
                        var287 = 0.018549489;
                    } else {
                        var287 = -0.040632382;
                    }
                } else {
                    if (input[12] < 0.43) {
                        var287 = 0.034092803;
                    } else {
                        var287 = -0.027011413;
                    }
                }
            } else {
                if (input[5] < 0.18) {
                    if (input[14] < 103.0) {
                        var287 = -0.051039677;
                    } else {
                        var287 = 0.0028454422;
                    }
                } else {
                    var287 = -0.053511202;
                }
            }
            double var288;
            if (input[10] < 21.0) {
                if (input[2] < 0.76) {
                    if (input[9] < 13.0) {
                        var288 = -0.045403894;
                    } else {
                        var288 = 0.02549546;
                    }
                } else {
                    if (input[13] < 246.0) {
                        var288 = -0.010891602;
                    } else {
                        var288 = 0.024126388;
                    }
                }
            } else {
                if (input[8] < 5.0) {
                    if (input[5] < 0.14) {
                        var288 = -0.029974246;
                    } else {
                        var288 = 0.017324904;
                    }
                } else {
                    if (input[2] < 0.55) {
                        var288 = -0.0075733275;
                    } else {
                        var288 = 0.040902775;
                    }
                }
            }
            double var289;
            if (input[1] < 4.0) {
                if (input[3] < 7.0) {
                    if (input[11] < 14.0) {
                        var289 = 0.0014683102;
                    } else {
                        var289 = -0.030913958;
                    }
                } else {
                    if (input[0] < 6.0) {
                        var289 = 0.039823674;
                    } else {
                        var289 = -0.02287495;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    if (input[5] < 1.6) {
                        var289 = -0.049070872;
                    } else {
                        var289 = -0.014260246;
                    }
                } else {
                    if (input[2] < 0.83) {
                        var289 = 0.01839791;
                    } else {
                        var289 = -0.042638015;
                    }
                }
            }
            double var290;
            if (input[5] < 0.28) {
                if (input[1] < 6.0) {
                    if (input[0] < 4.0) {
                        var290 = -0.009199581;
                    } else {
                        var290 = 0.021948544;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var290 = 0.041262172;
                    } else {
                        var290 = -0.04060847;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[2] < 1.41) {
                        var290 = -0.032300282;
                    } else {
                        var290 = 0.04797957;
                    }
                } else {
                    if (input[13] < 140.0) {
                        var290 = 0.018083079;
                    } else {
                        var290 = -0.017939022;
                    }
                }
            }
            double var291;
            if (input[15] < 1.0) {
                if (input[11] < 5.0) {
                    if (input[1] < 3.0) {
                        var291 = 0.01874773;
                    } else {
                        var291 = -0.031144822;
                    }
                } else {
                    if (input[5] < 0.24) {
                        var291 = -0.0065188357;
                    } else {
                        var291 = -0.043557476;
                    }
                }
            } else {
                if (input[12] < 3.54) {
                    if (input[2] < 0.41) {
                        var291 = 0.033073545;
                    } else {
                        var291 = 0.0004891813;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var291 = 0.0030096965;
                    } else {
                        var291 = -0.048650917;
                    }
                }
            }
            double var292;
            if (input[9] < 6.0) {
                if (input[11] < 11.0) {
                    if (input[1] < 7.0) {
                        var292 = -0.027787093;
                    } else {
                        var292 = 0.03067779;
                    }
                } else {
                    if (input[2] < 0.7) {
                        var292 = -0.01599555;
                    } else {
                        var292 = 0.020272171;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[11] < 12.0) {
                        var292 = -0.047625143;
                    } else {
                        var292 = 0.0005483478;
                    }
                } else {
                    if (input[13] < 259.0) {
                        var292 = 0.011052455;
                    } else {
                        var292 = 0.03900672;
                    }
                }
            }
            double var293;
            if (input[6] < 2.0) {
                if (input[2] < 0.8) {
                    if (input[5] < 0.6) {
                        var293 = -0.009976315;
                    } else {
                        var293 = 0.019195572;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var293 = -0.0018859102;
                    } else {
                        var293 = -0.04121124;
                    }
                }
            } else {
                if (input[10] < 6.0) {
                    var293 = -0.041821443;
                } else {
                    if (input[0] < 5.0) {
                        var293 = 0.027461693;
                    } else {
                        var293 = -0.0075368145;
                    }
                }
            }
            double var294;
            if (input[1] < 2.0) {
                if (input[2] < 0.81) {
                    if (input[10] < 20.0) {
                        var294 = -0.05399206;
                    } else {
                        var294 = -0.019299049;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var294 = 0.026902128;
                    } else {
                        var294 = -0.021828534;
                    }
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[1] < 6.0) {
                        var294 = 0.0126575325;
                    } else {
                        var294 = -0.018133927;
                    }
                } else {
                    if (input[13] < 35.0) {
                        var294 = 0.008764393;
                    } else {
                        var294 = -0.046674453;
                    }
                }
            }
            double var295;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var295 = -0.035670463;
                    } else {
                        var295 = 0.021854963;
                    }
                } else {
                    var295 = -0.049241867;
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[11] < 7.0) {
                        var295 = 0.03179883;
                    } else {
                        var295 = -0.0029226884;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var295 = 0.019450836;
                    } else {
                        var295 = -0.023846783;
                    }
                }
            }
            double var296;
            if (input[10] < 23.0) {
                if (input[15] < 1.0) {
                    if (input[2] < 0.55) {
                        var296 = -0.03938405;
                    } else {
                        var296 = 0.008485349;
                    }
                } else {
                    if (input[9] < 12.0) {
                        var296 = -0.029748479;
                    } else {
                        var296 = 0.037093014;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[0] < 2.0) {
                        var296 = -0.039072018;
                    } else {
                        var296 = 0.012383452;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var296 = -0.021914437;
                    } else {
                        var296 = 0.051656593;
                    }
                }
            }
            double var297;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[9] < 7.0) {
                        var297 = -0.01597785;
                    } else {
                        var297 = 0.009306924;
                    }
                } else {
                    if (input[14] < 102.0) {
                        var297 = 0.023962567;
                    } else {
                        var297 = 0.0011100817;
                    }
                }
            } else {
                if (input[10] < 17.0) {
                    if (input[2] < 0.66) {
                        var297 = 0.03540018;
                    } else {
                        var297 = -0.0139441015;
                    }
                } else {
                    if (input[2] < 0.63) {
                        var297 = -0.005693588;
                    } else {
                        var297 = -0.048278183;
                    }
                }
            }
            double var298;
            if (input[14] < 66.0) {
                if (input[5] < 0.33) {
                    if (input[1] < 2.0) {
                        var298 = -0.052402604;
                    } else {
                        var298 = 0.0046457127;
                    }
                } else {
                    if (input[8] < 1.0) {
                        var298 = 0.00405017;
                    } else {
                        var298 = -0.0491;
                    }
                }
            } else {
                if (input[5] < 1.02) {
                    if (input[2] < 0.7) {
                        var298 = -0.012566392;
                    } else {
                        var298 = 0.012403229;
                    }
                } else {
                    if (input[11] < 6.0) {
                        var298 = 0.00030611383;
                    } else {
                        var298 = -0.045115262;
                    }
                }
            }
            double var299;
            if (input[14] < 87.0) {
                if (input[15] < 1.0) {
                    if (input[13] < 55.0) {
                        var299 = -0.0029283147;
                    } else {
                        var299 = -0.05119582;
                    }
                } else {
                    if (input[13] < 121.0) {
                        var299 = 0.023230517;
                    } else {
                        var299 = -0.044198148;
                    }
                }
            } else {
                if (input[2] < 1.21) {
                    if (input[10] < 2.0) {
                        var299 = 0.054311734;
                    } else {
                        var299 = 0.003262907;
                    }
                } else {
                    var299 = -0.045780957;
                }
            }
            double var300;
            if (input[13] < 339.0) {
                if (input[2] < 1.13) {
                    if (input[5] < 0.3) {
                        var300 = -0.036138624;
                    } else {
                        var300 = -0.0029546309;
                    }
                } else {
                    if (input[13] < 140.0) {
                        var300 = -0.010601602;
                    } else {
                        var300 = 0.026087841;
                    }
                }
            } else {
                if (input[2] < 0.68) {
                    if (input[9] < 3.0) {
                        var300 = -0.052495223;
                    } else {
                        var300 = 0.018904937;
                    }
                } else {
                    if (input[12] < 2.98) {
                        var300 = -0.010638664;
                    } else {
                        var300 = 0.059833325;
                    }
                }
            }
            double var301;
            if (input[2] < 1.13) {
                if (input[5] < 1.05) {
                    if (input[14] < 153.0) {
                        var301 = 0.002148152;
                    } else {
                        var301 = -0.01969149;
                    }
                } else {
                    if (input[9] < 9.0) {
                        var301 = 0.03130835;
                    } else {
                        var301 = -0.011157426;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    if (input[5] < 1.7) {
                        var301 = -0.049746677;
                    } else {
                        var301 = -0.01036923;
                    }
                } else {
                    if (input[14] < 61.0) {
                        var301 = 0.025383392;
                    } else {
                        var301 = -0.03807895;
                    }
                }
            }
            double var302;
            if (input[5] < 0.28) {
                if (input[2] < 2.14) {
                    if (input[0] < 3.0) {
                        var302 = -0.0411853;
                    } else {
                        var302 = 0.015183057;
                    }
                } else {
                    if (input[10] < 4.0) {
                        var302 = 0.038694058;
                    } else {
                        var302 = -0.052139413;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[2] < 1.41) {
                        var302 = -0.03104702;
                    } else {
                        var302 = 0.04593401;
                    }
                } else {
                    if (input[13] < 140.0) {
                        var302 = 0.016744118;
                    } else {
                        var302 = -0.01728961;
                    }
                }
            }
            double var303;
            if (input[13] < 205.0) {
                if (input[5] < 0.67) {
                    if (input[0] < 6.0) {
                        var303 = 0.01887353;
                    } else {
                        var303 = -0.039014023;
                    }
                } else {
                    if (input[14] < 158.0) {
                        var303 = -0.03345139;
                    } else {
                        var303 = 0.010426399;
                    }
                }
            } else {
                if (input[7] < 1.0) {
                    if (input[12] < 2.93) {
                        var303 = 0.014715232;
                    } else {
                        var303 = -0.04539474;
                    }
                } else {
                    if (input[8] < 2.0) {
                        var303 = -0.023087258;
                    } else {
                        var303 = -0.05255903;
                    }
                }
            }
            double var304;
            if (input[10] < 19.0) {
                if (input[0] < 8.0) {
                    if (input[5] < 0.62) {
                        var304 = -0.039354976;
                    } else {
                        var304 = -0.002506569;
                    }
                } else {
                    if (input[12] < 2.32) {
                        var304 = -0.018831694;
                    } else {
                        var304 = 0.04042205;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[9] < 10.0) {
                        var304 = -0.03969537;
                    } else {
                        var304 = 0.006126752;
                    }
                } else {
                    if (input[9] < 4.0) {
                        var304 = -0.0017490153;
                    } else {
                        var304 = 0.027243683;
                    }
                }
            }
            double var305;
            if (input[1] < 3.0) {
                if (input[5] < 0.27) {
                    if (input[14] < 78.0) {
                        var305 = 0.020164317;
                    } else {
                        var305 = -0.019935336;
                    }
                } else {
                    if (input[13] < 341.0) {
                        var305 = 0.0148916645;
                    } else {
                        var305 = -0.018999878;
                    }
                }
            } else {
                if (input[10] < 19.0) {
                    if (input[2] < 0.66) {
                        var305 = 0.029643971;
                    } else {
                        var305 = -0.02223981;
                    }
                } else {
                    if (input[13] < 367.0) {
                        var305 = -0.04327209;
                    } else {
                        var305 = 0.006393095;
                    }
                }
            }
            double var306;
            if (input[14] < 39.0) {
                if (input[5] < 0.18) {
                    if (input[0] < 4.0) {
                        var306 = -0.044382717;
                    } else {
                        var306 = 0.013904139;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var306 = -0.0059537147;
                    } else {
                        var306 = -0.054476645;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 1.21) {
                        var306 = -0.036668494;
                    } else {
                        var306 = 0.034904443;
                    }
                } else {
                    if (input[3] < 6.0) {
                        var306 = 0.0080636395;
                    } else {
                        var306 = -0.033753674;
                    }
                }
            }
            double var307;
            if (input[11] < 8.0) {
                if (input[2] < 0.18) {
                    if (input[5] < 1.43) {
                        var307 = 0.033836752;
                    } else {
                        var307 = -0.049243752;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var307 = 0.021541819;
                    } else {
                        var307 = -0.01876363;
                    }
                }
            } else {
                if (input[15] < 1.0) {
                    if (input[13] < 188.0) {
                        var307 = -0.023721527;
                    } else {
                        var307 = -0.05679508;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var307 = 0.0123134395;
                    } else {
                        var307 = -0.036220375;
                    }
                }
            }
            double var308;
            if (input[14] < 122.0) {
                if (input[13] < 197.0) {
                    if (input[8] < 5.0) {
                        var308 = -0.024800904;
                    } else {
                        var308 = 0.013205265;
                    }
                } else {
                    if (input[2] < 1.17) {
                        var308 = 0.00854959;
                    } else {
                        var308 = 0.044717252;
                    }
                }
            } else {
                if (input[2] < 1.61) {
                    if (input[5] < 0.66) {
                        var308 = -0.052618038;
                    } else {
                        var308 = -0.0151002575;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var308 = -0.027791215;
                    } else {
                        var308 = 0.031823386;
                    }
                }
            }
            double var309;
            if (input[6] < 2.0) {
                if (input[2] < 0.8) {
                    if (input[5] < 0.6) {
                        var309 = -0.00979945;
                    } else {
                        var309 = 0.01807587;
                    }
                } else {
                    if (input[10] < 15.0) {
                        var309 = 0.0040065465;
                    } else {
                        var309 = -0.037920874;
                    }
                }
            } else {
                if (input[10] < 6.0) {
                    var309 = -0.04100796;
                } else {
                    if (input[11] < 17.0) {
                        var309 = 0.022864006;
                    } else {
                        var309 = -0.03854566;
                    }
                }
            }
            double var310;
            if (input[14] < 66.0) {
                if (input[6] < 1.0) {
                    if (input[9] < 6.0) {
                        var310 = 0.007787914;
                    } else {
                        var310 = -0.030439883;
                    }
                } else {
                    if (input[13] < 55.0) {
                        var310 = 0.003374472;
                    } else {
                        var310 = -0.04429057;
                    }
                }
            } else {
                if (input[5] < 0.44) {
                    if (input[2] < 2.11) {
                        var310 = 0.01470632;
                    } else {
                        var310 = -0.03736463;
                    }
                } else {
                    if (input[2] < 0.75) {
                        var310 = -0.05254954;
                    } else {
                        var310 = -0.00009041442;
                    }
                }
            }
            double var311;
            if (input[15] < 1.0) {
                if (input[10] < 2.0) {
                    if (input[2] < 1.28) {
                        var311 = 0.0477493;
                    } else {
                        var311 = -0.03510907;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var311 = -0.0030657137;
                    } else {
                        var311 = -0.037002627;
                    }
                }
            } else {
                if (input[12] < 3.54) {
                    if (input[5] < 1.04) {
                        var311 = 0.021640636;
                    } else {
                        var311 = -0.027068159;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var311 = 0.0021642537;
                    } else {
                        var311 = -0.048371475;
                    }
                }
            }
            double var312;
            if (input[10] < 23.0) {
                if (input[1] < 4.0) {
                    if (input[5] < 0.26) {
                        var312 = -0.039593723;
                    } else {
                        var312 = -0.003348507;
                    }
                } else {
                    if (input[2] < 1.01) {
                        var312 = -0.017453684;
                    } else {
                        var312 = 0.019010618;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[0] < 2.0) {
                        var312 = -0.0384745;
                    } else {
                        var312 = 0.012219436;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var312 = -0.021064306;
                    } else {
                        var312 = 0.050376713;
                    }
                }
            }
            double var313;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[13] < 99.0) {
                        var313 = -0.023058563;
                    } else {
                        var313 = 0.00049795624;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var313 = 0.012605973;
                    } else {
                        var313 = 0.056193918;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    if (input[13] < 184.0) {
                        var313 = 0.025068635;
                    } else {
                        var313 = -0.027720202;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var313 = -0.017020991;
                    } else {
                        var313 = -0.04778779;
                    }
                }
            }
            double var314;
            if (input[1] < 2.0) {
                if (input[0] < 5.0) {
                    if (input[12] < 3.91) {
                        var314 = -0.05204412;
                    } else {
                        var314 = -0.0027303589;
                    }
                } else {
                    if (input[14] < 159.0) {
                        var314 = -0.012453905;
                    } else {
                        var314 = 0.04846747;
                    }
                }
            } else {
                if (input[1] < 7.0) {
                    if (input[13] < 336.0) {
                        var314 = 0.010064696;
                    } else {
                        var314 = -0.034268565;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var314 = 0.02418652;
                    } else {
                        var314 = -0.05171268;
                    }
                }
            }
            double var315;
            if (input[13] < 153.0) {
                if (input[1] < 4.0) {
                    if (input[5] < 0.79) {
                        var315 = 0.019005638;
                    } else {
                        var315 = -0.013265113;
                    }
                } else {
                    var315 = -0.049271118;
                }
            } else {
                if (input[2] < 0.24) {
                    if (input[12] < 2.6) {
                        var315 = 0.018831303;
                    } else {
                        var315 = -0.03397618;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var315 = -0.022647854;
                    } else {
                        var315 = -0.052260704;
                    }
                }
            }
            double var316;
            if (input[11] < 8.0) {
                if (input[0] < 9.0) {
                    if (input[12] < 3.17) {
                        var316 = -0.051522493;
                    } else {
                        var316 = -0.014749085;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var316 = -0.024944015;
                    } else {
                        var316 = 0.05112474;
                    }
                }
            } else {
                if (input[9] < 3.0) {
                    if (input[2] < 1.36) {
                        var316 = -0.019465564;
                    } else {
                        var316 = 0.039478954;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var316 = -0.02648128;
                    } else {
                        var316 = 0.02145437;
                    }
                }
            }
            double var317;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[13] < 91.0) {
                        var317 = -0.03719724;
                    } else {
                        var317 = -0.005163397;
                    }
                } else {
                    if (input[14] < 103.0) {
                        var317 = 0.022607742;
                    } else {
                        var317 = 0.00065551605;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[13] < 156.0) {
                        var317 = 0.024171917;
                    } else {
                        var317 = -0.023341974;
                    }
                } else {
                    if (input[12] < 3.14) {
                        var317 = -0.017094964;
                    } else {
                        var317 = -0.051140137;
                    }
                }
            }
            double var318;
            if (input[0] < 3.0) {
                if (input[14] < 173.0) {
                    var318 = -0.046987064;
                } else {
                    var318 = -0.017017713;
                }
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var318 = 0.021586778;
                    } else {
                        var318 = -0.010316491;
                    }
                } else {
                    if (input[14] < 39.0) {
                        var318 = -0.04451297;
                    } else {
                        var318 = -0.0017950848;
                    }
                }
            }
            double var319;
            if (input[11] < 7.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 1.43) {
                        var319 = 0.031466197;
                    } else {
                        var319 = -0.040867332;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var319 = 0.01515564;
                    } else {
                        var319 = -0.023883468;
                    }
                }
            } else {
                if (input[2] < 0.31) {
                    if (input[9] < 7.0) {
                        var319 = 0.007814177;
                    } else {
                        var319 = -0.053204652;
                    }
                } else {
                    if (input[10] < 10.0) {
                        var319 = 0.0030221625;
                    } else {
                        var319 = -0.046614066;
                    }
                }
            }
            double var320;
            if (input[10] < 21.0) {
                if (input[9] < 13.0) {
                    if (input[2] < 0.76) {
                        var320 = -0.043881267;
                    } else {
                        var320 = -0.004430162;
                    }
                } else {
                    if (input[2] < 0.52) {
                        var320 = -0.003961205;
                    } else {
                        var320 = 0.055661738;
                    }
                }
            } else {
                if (input[8] < 5.0) {
                    if (input[5] < 0.14) {
                        var320 = -0.027474707;
                    } else {
                        var320 = 0.015622306;
                    }
                } else {
                    if (input[2] < 0.55) {
                        var320 = -0.008477763;
                    } else {
                        var320 = 0.03915793;
                    }
                }
            }
            double var321;
            if (input[6] < 2.0) {
                if (input[2] < 0.8) {
                    if (input[5] < 0.6) {
                        var321 = -0.009273038;
                    } else {
                        var321 = 0.017075235;
                    }
                } else {
                    if (input[10] < 15.0) {
                        var321 = 0.0049364627;
                    } else {
                        var321 = -0.03706447;
                    }
                }
            } else {
                if (input[10] < 6.0) {
                    var321 = -0.040557694;
                } else {
                    if (input[0] < 5.0) {
                        var321 = 0.025831217;
                    } else {
                        var321 = -0.008266283;
                    }
                }
            }
            double var322;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var322 = -0.043902278;
                    } else {
                        var322 = 0.00533919;
                    }
                } else {
                    var322 = 0.034041114;
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[13] < 336.0) {
                        var322 = 0.00781253;
                    } else {
                        var322 = -0.032308113;
                    }
                } else {
                    if (input[13] < 41.0) {
                        var322 = 0.0049760253;
                    } else {
                        var322 = -0.047322497;
                    }
                }
            }
            double var323;
            if (input[15] < 1.0) {
                if (input[11] < 1.0) {
                    if (input[2] < 1.02) {
                        var323 = 0.049517192;
                    } else {
                        var323 = -0.023683783;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var323 = -0.0037800134;
                    } else {
                        var323 = -0.037620902;
                    }
                }
            } else {
                if (input[12] < 3.54) {
                    if (input[2] < 0.42) {
                        var323 = 0.030141965;
                    } else {
                        var323 = 0.000036247446;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var323 = 0.0014082849;
                    } else {
                        var323 = -0.048082836;
                    }
                }
            }
            double var324;
            if (input[15] < 1.0) {
                if (input[11] < 13.0) {
                    if (input[1] < 3.0) {
                        var324 = -0.018446205;
                    } else {
                        var324 = 0.012370492;
                    }
                } else {
                    if (input[3] < 8.0) {
                        var324 = 0.037938934;
                    } else {
                        var324 = -0.05028823;
                    }
                }
            } else {
                if (input[9] < 12.0) {
                    if (input[2] < 1.17) {
                        var324 = -0.03523414;
                    } else {
                        var324 = -0.0024691836;
                    }
                } else {
                    if (input[14] < 39.0) {
                        var324 = -0.012748881;
                    } else {
                        var324 = 0.04705019;
                    }
                }
            }
            double var325;
            if (input[1] < 4.0) {
                if (input[3] < 7.0) {
                    if (input[2] < 1.06) {
                        var325 = 0.00065289385;
                    } else {
                        var325 = -0.041144665;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var325 = -0.032607615;
                    } else {
                        var325 = 0.036982175;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    var325 = -0.04643141;
                } else {
                    if (input[2] < 0.83) {
                        var325 = 0.015290392;
                    } else {
                        var325 = -0.04141244;
                    }
                }
            }
            double var326;
            if (input[2] < 0.79) {
                if (input[1] < 2.0) {
                    if (input[13] < 306.0) {
                        var326 = -0.050341386;
                    } else {
                        var326 = -0.0120714875;
                    }
                } else {
                    if (input[6] < 1.0) {
                        var326 = 0.009455979;
                    } else {
                        var326 = -0.033580784;
                    }
                }
            } else {
                if (input[1] < 7.0) {
                    if (input[14] < 159.0) {
                        var326 = 0.0032756727;
                    } else {
                        var326 = 0.032113932;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var326 = 0.022811774;
                    } else {
                        var326 = -0.050742775;
                    }
                }
            }
            double var327;
            if (input[14] < 87.0) {
                if (input[15] < 1.0) {
                    if (input[13] < 55.0) {
                        var327 = -0.005833403;
                    } else {
                        var327 = -0.050664544;
                    }
                } else {
                    if (input[13] < 121.0) {
                        var327 = 0.02020592;
                    } else {
                        var327 = -0.04311808;
                    }
                }
            } else {
                if (input[1] < 4.0) {
                    if (input[13] < 67.0) {
                        var327 = 0.029280802;
                    } else {
                        var327 = -0.001987726;
                    }
                } else {
                    var327 = -0.04908089;
                }
            }
            double var328;
            if (input[13] < 240.0) {
                if (input[1] < 4.0) {
                    if (input[8] < 5.0) {
                        var328 = -0.035419136;
                    } else {
                        var328 = -0.0019038927;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var328 = -0.014350861;
                    } else {
                        var328 = 0.02139828;
                    }
                }
            } else {
                if (input[14] < 122.0) {
                    if (input[2] < 0.49) {
                        var328 = -0.01703658;
                    } else {
                        var328 = 0.026288986;
                    }
                } else {
                    if (input[2] < 1.94) {
                        var328 = -0.04365633;
                    } else {
                        var328 = 0.037050262;
                    }
                }
            }
            double var329;
            if (input[6] < 1.0) {
                if (input[5] < 0.32) {
                    if (input[14] < 42.0) {
                        var329 = 0.0165746;
                    } else {
                        var329 = -0.024797993;
                    }
                } else {
                    if (input[12] < 3.79) {
                        var329 = 0.012206872;
                    } else {
                        var329 = -0.020741826;
                    }
                }
            } else {
                if (input[12] < 1.25) {
                    if (input[14] < 201.0) {
                        var329 = -0.04706091;
                    } else {
                        var329 = 0.039856423;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var329 = 0.018233381;
                    } else {
                        var329 = -0.01021663;
                    }
                }
            }
            double var330;
            if (input[14] < 66.0) {
                if (input[6] < 1.0) {
                    if (input[9] < 6.0) {
                        var330 = 0.0069982656;
                    } else {
                        var330 = -0.029986087;
                    }
                } else {
                    if (input[13] < 79.0) {
                        var330 = 0.0030913528;
                    } else {
                        var330 = -0.043010067;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[11] < 1.0) {
                        var330 = -0.021668496;
                    } else {
                        var330 = 0.01094988;
                    }
                } else {
                    if (input[11] < 1.0) {
                        var330 = 0.018278321;
                    } else {
                        var330 = -0.026118899;
                    }
                }
            }
            double var331;
            if (input[13] < 205.0) {
                if (input[2] < 0.42) {
                    if (input[9] < 6.0) {
                        var331 = 0.027190035;
                    } else {
                        var331 = -0.016333558;
                    }
                } else {
                    if (input[13] < 82.0) {
                        var331 = 0.011944437;
                    } else {
                        var331 = -0.03913569;
                    }
                }
            } else {
                if (input[7] < 1.0) {
                    if (input[12] < 2.93) {
                        var331 = 0.014510485;
                    } else {
                        var331 = -0.044007983;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var331 = -0.053799927;
                    } else {
                        var331 = -0.025062656;
                    }
                }
            }
            double var332;
            if (input[9] < 9.0) {
                if (input[12] < 3.72) {
                    if (input[1] < 7.0) {
                        var332 = -0.02490542;
                    } else {
                        var332 = 0.030436182;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var332 = -0.0023902808;
                    } else {
                        var332 = 0.03151816;
                    }
                }
            } else {
                if (input[5] < 0.39) {
                    if (input[12] < 4.51) {
                        var332 = -0.014108108;
                    } else {
                        var332 = 0.035022322;
                    }
                } else {
                    if (input[2] < 0.8) {
                        var332 = 0.008591472;
                    } else {
                        var332 = 0.05199969;
                    }
                }
            }
            double var333;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[9] < 7.0) {
                        var333 = -0.014384679;
                    } else {
                        var333 = 0.008440761;
                    }
                } else {
                    if (input[14] < 136.0) {
                        var333 = 0.017886503;
                    } else {
                        var333 = -0.004588455;
                    }
                }
            } else {
                if (input[2] < 0.77) {
                    if (input[10] < 21.0) {
                        var333 = 0.008754036;
                    } else {
                        var333 = -0.041854676;
                    }
                } else {
                    if (input[12] < 3.14) {
                        var333 = -0.016940849;
                    } else {
                        var333 = -0.05074401;
                    }
                }
            }
            double var334;
            if (input[0] < 4.0) {
                if (input[12] < 3.23) {
                    if (input[1] < 3.0) {
                        var334 = -0.042713806;
                    } else {
                        var334 = -0.002705884;
                    }
                } else {
                    if (input[14] < 59.0) {
                        var334 = -0.04123738;
                    } else {
                        var334 = 0.018621303;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[0] < 9.0) {
                        var334 = 0.010574239;
                    } else {
                        var334 = -0.017504446;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var334 = 0.0061124833;
                    } else {
                        var334 = -0.051353153;
                    }
                }
            }
            double var335;
            if (input[12] < 3.54) {
                if (input[15] < 1.0) {
                    if (input[3] < 2.0) {
                        var335 = 0.0054939077;
                    } else {
                        var335 = -0.023894593;
                    }
                } else {
                    if (input[2] < 1.19) {
                        var335 = 0.018758489;
                    } else {
                        var335 = -0.04545157;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    var335 = 0.00021259536;
                } else {
                    var335 = -0.049157888;
                }
            }
            double var336;
            if (input[15] < 1.0) {
                if (input[10] < 18.0) {
                    if (input[1] < 6.0) {
                        var336 = -0.023834586;
                    } else {
                        var336 = 0.025054604;
                    }
                } else {
                    if (input[8] < 5.0) {
                        var336 = 0.0031012462;
                    } else {
                        var336 = 0.03190626;
                    }
                }
            } else {
                if (input[9] < 12.0) {
                    if (input[2] < 1.17) {
                        var336 = -0.034192055;
                    } else {
                        var336 = -0.002263854;
                    }
                } else {
                    if (input[14] < 42.0) {
                        var336 = -0.012004098;
                    } else {
                        var336 = 0.045639407;
                    }
                }
            }
            double var337;
            if (input[2] < 1.13) {
                if (input[5] < 0.79) {
                    if (input[14] < 135.0) {
                        var337 = 0.0013956638;
                    } else {
                        var337 = -0.017820915;
                    }
                } else {
                    if (input[5] < 2.1) {
                        var337 = 0.011458239;
                    } else {
                        var337 = 0.06914617;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[6] < 1.0) {
                        var337 = -0.032954894;
                    } else {
                        var337 = 0.009272607;
                    }
                } else {
                    if (input[5] < 2.1) {
                        var337 = -0.04760958;
                    } else {
                        var337 = -0.009033975;
                    }
                }
            }
            double var338;
            if (input[1] < 2.0) {
                if (input[0] < 5.0) {
                    if (input[12] < 3.91) {
                        var338 = -0.05166173;
                    } else {
                        var338 = -0.0029142606;
                    }
                } else {
                    if (input[14] < 159.0) {
                        var338 = -0.013000761;
                    } else {
                        var338 = 0.0455838;
                    }
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[9] < 7.0) {
                        var338 = 0.012134359;
                    } else {
                        var338 = -0.011250354;
                    }
                } else {
                    if (input[13] < 35.0) {
                        var338 = 0.0055119745;
                    } else {
                        var338 = -0.04463054;
                    }
                }
            }
            double var339;
            if (input[11] < 8.0) {
                if (input[2] < 0.18) {
                    if (input[5] < 1.43) {
                        var339 = 0.031172961;
                    } else {
                        var339 = -0.043922365;
                    }
                } else {
                    if (input[10] < 6.0) {
                        var339 = 0.01982101;
                    } else {
                        var339 = -0.01742102;
                    }
                }
            } else {
                if (input[12] < 3.24) {
                    if (input[5] < 0.19) {
                        var339 = 0.0029301036;
                    } else {
                        var339 = -0.032719634;
                    }
                } else {
                    var339 = -0.04916572;
                }
            }
            double var340;
            if (input[13] < 197.0) {
                if (input[5] < 0.66) {
                    if (input[2] < 1.47) {
                        var340 = -0.038068485;
                    } else {
                        var340 = 0.012963578;
                    }
                } else {
                    if (input[11] < 6.0) {
                        var340 = -0.024055915;
                    } else {
                        var340 = 0.017451858;
                    }
                }
            } else {
                if (input[14] < 122.0) {
                    if (input[2] < 1.17) {
                        var340 = 0.008379644;
                    } else {
                        var340 = 0.043485638;
                    }
                } else {
                    if (input[0] < 8.0) {
                        var340 = -0.043349307;
                    } else {
                        var340 = 0.02763246;
                    }
                }
            }
            double var341;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[11] < 5.0) {
                        var341 = -0.0361258;
                    } else {
                        var341 = -0.0047474713;
                    }
                } else {
                    if (input[14] < 166.0) {
                        var341 = 0.014906493;
                    } else {
                        var341 = -0.010423849;
                    }
                }
            } else {
                if (input[10] < 17.0) {
                    if (input[4] < 4.0) {
                        var341 = -0.012866738;
                    } else {
                        var341 = 0.032100376;
                    }
                } else {
                    if (input[2] < 0.63) {
                        var341 = -0.005184422;
                    } else {
                        var341 = -0.04664566;
                    }
                }
            }
            double var342;
            if (input[5] < 0.12) {
                if (input[13] < 338.0) {
                    if (input[1] < 7.0) {
                        var342 = 0.01826716;
                    } else {
                        var342 = -0.026703997;
                    }
                } else {
                    if (input[12] < 2.89) {
                        var342 = 0.037875302;
                    } else {
                        var342 = -0.046115354;
                    }
                }
            } else {
                if (input[2] < 0.74) {
                    if (input[12] < 3.36) {
                        var342 = -0.042836126;
                    } else {
                        var342 = -0.0026090716;
                    }
                } else {
                    if (input[14] < 36.0) {
                        var342 = -0.050983544;
                    } else {
                        var342 = 0.002024366;
                    }
                }
            }
            double var343;
            if (input[13] < 205.0) {
                if (input[1] < 4.0) {
                    if (input[10] < 2.0) {
                        var343 = 0.04352823;
                    } else {
                        var343 = 0.0025456313;
                    }
                } else {
                    var343 = -0.04869763;
                }
            } else {
                if (input[7] < 1.0) {
                    if (input[12] < 2.93) {
                        var343 = 0.013114889;
                    } else {
                        var343 = -0.043120354;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var343 = -0.05334396;
                    } else {
                        var343 = -0.023461543;
                    }
                }
            }
            double var344;
            if (input[11] < 8.0) {
                if (input[0] < 9.0) {
                    if (input[12] < 3.17) {
                        var344 = -0.050898194;
                    } else {
                        var344 = -0.0144123165;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var344 = -0.024402423;
                    } else {
                        var344 = 0.05008899;
                    }
                }
            } else {
                if (input[10] < 22.0) {
                    if (input[2] < 0.9) {
                        var344 = -0.017598113;
                    } else {
                        var344 = 0.012917282;
                    }
                } else {
                    if (input[1] < 2.0) {
                        var344 = 0.00045730485;
                    } else {
                        var344 = 0.03959805;
                    }
                }
            }
            double var345;
            if (input[6] < 1.0) {
                if (input[5] < 0.32) {
                    if (input[14] < 42.0) {
                        var345 = 0.015271327;
                    } else {
                        var345 = -0.023425564;
                    }
                } else {
                    if (input[12] < 3.79) {
                        var345 = 0.01150701;
                    } else {
                        var345 = -0.02009054;
                    }
                }
            } else {
                if (input[9] < 10.0) {
                    if (input[12] < 1.25) {
                        var345 = -0.030140847;
                    } else {
                        var345 = 0.015328231;
                    }
                } else {
                    if (input[2] < 0.8) {
                        var345 = 0.003009376;
                    } else {
                        var345 = -0.05164913;
                    }
                }
            }
            double var346;
            if (input[0] < 3.0) {
                var346 = -0.043946084;
            } else {
                if (input[5] < 0.28) {
                    if (input[1] < 5.0) {
                        var346 = 0.01657535;
                    } else {
                        var346 = -0.01153535;
                    }
                } else {
                    if (input[0] < 5.0) {
                        var346 = -0.022723913;
                    } else {
                        var346 = 0.0010700981;
                    }
                }
            }
            double var347;
            if (input[14] < 87.0) {
                if (input[15] < 1.0) {
                    if (input[8] < 1.0) {
                        var347 = -0.020671457;
                    } else {
                        var347 = -0.05103749;
                    }
                } else {
                    if (input[13] < 121.0) {
                        var347 = 0.018849753;
                    } else {
                        var347 = -0.04224412;
                    }
                }
            } else {
                if (input[2] < 1.21) {
                    if (input[10] < 2.0) {
                        var347 = 0.049969904;
                    } else {
                        var347 = 0.0024477134;
                    }
                } else {
                    if (input[4] < 2.0) {
                        var347 = -0.049166378;
                    } else {
                        var347 = -0.023139028;
                    }
                }
            }
            double var348;
            if (input[13] < 339.0) {
                if (input[8] < 5.0) {
                    if (input[1] < 4.0) {
                        var348 = -0.027511284;
                    } else {
                        var348 = 0.0017771766;
                    }
                } else {
                    if (input[2] < 0.57) {
                        var348 = -0.04020336;
                    } else {
                        var348 = 0.016002815;
                    }
                }
            } else {
                if (input[2] < 0.68) {
                    if (input[4] < 3.0) {
                        var348 = 0.0196883;
                    } else {
                        var348 = -0.041885886;
                    }
                } else {
                    if (input[12] < 2.98) {
                        var348 = -0.010773655;
                    } else {
                        var348 = 0.05761056;
                    }
                }
            }
            double var349;
            if (input[1] < 3.0) {
                if (input[3] < 8.0) {
                    if (input[13] < 48.0) {
                        var349 = -0.042498246;
                    } else {
                        var349 = 0.0026921786;
                    }
                } else {
                    if (input[5] < 2.25) {
                        var349 = 0.027177665;
                    } else {
                        var349 = 0.07611524;
                    }
                }
            } else {
                if (input[0] < 4.0) {
                    if (input[8] < 5.0) {
                        var349 = 0.02615844;
                    } else {
                        var349 = -0.02243442;
                    }
                } else {
                    if (input[3] < 5.0) {
                        var349 = -0.046980318;
                    } else {
                        var349 = -0.011375026;
                    }
                }
            }
            double var350;
            if (input[1] < 2.0) {
                if (input[2] < 0.81) {
                    if (input[10] < 20.0) {
                        var350 = -0.05381806;
                    } else {
                        var350 = -0.0160204;
                    }
                } else {
                    if (input[3] < 1.0) {
                        var350 = 0.022946035;
                    } else {
                        var350 = -0.020988492;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[13] < 336.0) {
                        var350 = 0.008879843;
                    } else {
                        var350 = -0.031468447;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var350 = 0.0053864657;
                    } else {
                        var350 = -0.05040541;
                    }
                }
            }
            double var351;
            if (input[9] < 7.0) {
                if (input[2] < 0.28) {
                    if (input[13] < 205.0) {
                        var351 = 0.026766723;
                    } else {
                        var351 = -0.02600048;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var351 = 0.021917842;
                    } else {
                        var351 = -0.022253402;
                    }
                }
            } else {
                if (input[13] < 91.0) {
                    if (input[14] < 124.0) {
                        var351 = -0.037027996;
                    } else {
                        var351 = 0.023060532;
                    }
                } else {
                    if (input[14] < 147.0) {
                        var351 = -0.053743567;
                    } else {
                        var351 = -0.01350627;
                    }
                }
            }
            double var352;
            if (input[10] < 23.0) {
                if (input[15] < 1.0) {
                    if (input[5] < 0.29) {
                        var352 = -0.012741211;
                    } else {
                        var352 = 0.0148626035;
                    }
                } else {
                    if (input[9] < 12.0) {
                        var352 = -0.02770248;
                    } else {
                        var352 = 0.03214812;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var352 = -0.03803405;
                } else {
                    if (input[14] < 96.0) {
                        var352 = 0.039858617;
                    } else {
                        var352 = 0.0063125016;
                    }
                }
            }
            double var353;
            if (input[2] < 1.13) {
                if (input[5] < 0.79) {
                    if (input[14] < 135.0) {
                        var353 = 0.0011259358;
                    } else {
                        var353 = -0.017447604;
                    }
                } else {
                    if (input[13] < 341.0) {
                        var353 = 0.018692298;
                    } else {
                        var353 = -0.01534822;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[14] < 61.0) {
                        var353 = 0.010675035;
                    } else {
                        var353 = -0.030477453;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var353 = -0.047161404;
                    } else {
                        var353 = -0.011958353;
                    }
                }
            }
            double var354;
            if (input[0] < 4.0) {
                if (input[12] < 3.23) {
                    if (input[1] < 3.0) {
                        var354 = -0.042087507;
                    } else {
                        var354 = -0.0024391979;
                    }
                } else {
                    if (input[14] < 95.0) {
                        var354 = -0.022441925;
                    } else {
                        var354 = 0.031552922;
                    }
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[2] < 1.96) {
                        var354 = 0.009749009;
                    } else {
                        var354 = -0.023215508;
                    }
                } else {
                    if (input[13] < 41.0) {
                        var354 = 0.004249084;
                    } else {
                        var354 = -0.044798054;
                    }
                }
            }
            double var355;
            if (input[15] < 1.0) {
                if (input[13] < 152.0) {
                    if (input[5] < 0.58) {
                        var355 = 0.010941437;
                    } else {
                        var355 = -0.028742969;
                    }
                } else {
                    if (input[14] < 188.0) {
                        var355 = -0.04485084;
                    } else {
                        var355 = 0.007700385;
                    }
                }
            } else {
                if (input[5] < 1.04) {
                    if (input[12] < 3.54) {
                        var355 = 0.019395953;
                    } else {
                        var355 = -0.03988465;
                    }
                } else {
                    if (input[13] < 67.0) {
                        var355 = -0.00031973253;
                    } else {
                        var355 = -0.052914448;
                    }
                }
            }
            double var356;
            if (input[14] < 122.0) {
                if (input[9] < 4.0) {
                    if (input[2] < 1.35) {
                        var356 = -0.015702907;
                    } else {
                        var356 = 0.025218977;
                    }
                } else {
                    if (input[1] < 1.0) {
                        var356 = -0.025438128;
                    } else {
                        var356 = 0.019320583;
                    }
                }
            } else {
                if (input[2] < 1.61) {
                    if (input[5] < 0.66) {
                        var356 = -0.04997652;
                    } else {
                        var356 = -0.012380074;
                    }
                } else {
                    if (input[12] < 1.63) {
                        var356 = -0.020589538;
                    } else {
                        var356 = 0.032227155;
                    }
                }
            }
            double var357;
            if (input[6] < 2.0) {
                if (input[2] < 0.8) {
                    if (input[5] < 0.6) {
                        var357 = -0.008662821;
                    } else {
                        var357 = 0.015794294;
                    }
                } else {
                    if (input[10] < 15.0) {
                        var357 = 0.0068492307;
                    } else {
                        var357 = -0.035696637;
                    }
                }
            } else {
                if (input[14] < 164.0) {
                    if (input[12] < 3.75) {
                        var357 = 0.03243398;
                    } else {
                        var357 = -0.0009469256;
                    }
                } else {
                    if (input[2] < 0.56) {
                        var357 = -0.0364719;
                    } else {
                        var357 = 0.020072913;
                    }
                }
            }
            double var358;
            if (input[14] < 159.0) {
                if (input[2] < 0.59) {
                    if (input[8] < 4.0) {
                        var358 = -0.052815;
                    } else {
                        var358 = -0.01869403;
                    }
                } else {
                    if (input[5] < 0.87) {
                        var358 = 0.0035224229;
                    } else {
                        var358 = -0.032068275;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[1] < 3.0) {
                        var358 = -0.028197125;
                    } else {
                        var358 = 0.027505625;
                    }
                } else {
                    if (input[1] < 7.0) {
                        var358 = 0.04357704;
                    } else {
                        var358 = -0.024509234;
                    }
                }
            }
            double var359;
            if (input[8] < 7.0) {
                if (input[13] < 79.0) {
                    if (input[2] < 1.2) {
                        var359 = 0.03105324;
                    } else {
                        var359 = -0.036532324;
                    }
                } else {
                    if (input[2] < 0.51) {
                        var359 = 0.010117701;
                    } else {
                        var359 = -0.039370023;
                    }
                }
            } else {
                if (input[11] < 6.0) {
                    if (input[2] < 0.27) {
                        var359 = 0.026763862;
                    } else {
                        var359 = -0.018947087;
                    }
                } else {
                    if (input[14] < 164.0) {
                        var359 = -0.05069082;
                    } else {
                        var359 = -0.001378693;
                    }
                }
            }
            double var360;
            if (input[13] < 197.0) {
                if (input[8] < 5.0) {
                    if (input[1] < 4.0) {
                        var360 = -0.041841544;
                    } else {
                        var360 = -0.004736911;
                    }
                } else {
                    if (input[0] < 8.0) {
                        var360 = -0.0021946735;
                    } else {
                        var360 = 0.045435634;
                    }
                }
            } else {
                if (input[14] < 122.0) {
                    if (input[2] < 1.17) {
                        var360 = 0.007875805;
                    } else {
                        var360 = 0.042349547;
                    }
                } else {
                    if (input[0] < 8.0) {
                        var360 = -0.04094403;
                    } else {
                        var360 = 0.026591752;
                    }
                }
            }
            double var361;
            if (input[1] < 3.0) {
                if (input[3] < 8.0) {
                    if (input[10] < 6.0) {
                        var361 = -0.046804413;
                    } else {
                        var361 = 0.002381209;
                    }
                } else {
                    if (input[5] < 2.23) {
                        var361 = 0.026000513;
                    } else {
                        var361 = 0.07361234;
                    }
                }
            } else {
                if (input[13] < 156.0) {
                    if (input[2] < 0.83) {
                        var361 = 0.019792581;
                    } else {
                        var361 = -0.035631847;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var361 = -0.03659777;
                    } else {
                        var361 = 0.028037881;
                    }
                }
            }
            double var362;
            if (input[1] < 1.0) {
                if (input[2] < 1.21) {
                    if (input[9] < 9.0) {
                        var362 = -0.04357229;
                    } else {
                        var362 = 0.006346278;
                    }
                } else {
                    var362 = 0.030947188;
                }
            } else {
                if (input[14] < 39.0) {
                    if (input[2] < 0.97) {
                        var362 = -0.0067004836;
                    } else {
                        var362 = -0.051016737;
                    }
                } else {
                    if (input[9] < 13.0) {
                        var362 = 0.0062761367;
                    } else {
                        var362 = -0.04607522;
                    }
                }
            }
            double var363;
            if (input[14] < 81.0) {
                if (input[14] < 23.0) {
                    if (input[15] < 1.0) {
                        var363 = -0.032374498;
                    } else {
                        var363 = 0.019577853;
                    }
                } else {
                    var363 = -0.04818378;
                }
            } else {
                if (input[1] < 4.0) {
                    if (input[8] < 7.0) {
                        var363 = 0.012511118;
                    } else {
                        var363 = -0.016430251;
                    }
                } else {
                    var363 = -0.048448633;
                }
            }
            double var364;
            if (input[11] < 12.0) {
                if (input[2] < 1.44) {
                    if (input[5] < 0.66) {
                        var364 = -0.026399715;
                    } else {
                        var364 = 0.0066117435;
                    }
                } else {
                    if (input[10] < 13.0) {
                        var364 = -0.017310873;
                    } else {
                        var364 = 0.03271979;
                    }
                }
            } else {
                if (input[3] < 8.0) {
                    if (input[10] < 19.0) {
                        var364 = -0.014430354;
                    } else {
                        var364 = 0.026856532;
                    }
                } else {
                    if (input[11] < 13.0) {
                        var364 = 0.0081738485;
                    } else {
                        var364 = -0.052992154;
                    }
                }
            }
            double var365;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[8] < 10.0) {
                        var365 = -0.006705662;
                    } else {
                        var365 = 0.023957325;
                    }
                } else {
                    if (input[14] < 162.0) {
                        var365 = 0.021316791;
                    } else {
                        var365 = -0.011741522;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    var365 = 0.0007634196;
                } else {
                    if (input[13] < 55.0) {
                        var365 = -0.016492184;
                    } else {
                        var365 = -0.047290538;
                    }
                }
            }
            double var366;
            if (input[1] < 2.0) {
                if (input[0] < 5.0) {
                    if (input[12] < 3.91) {
                        var366 = -0.051024724;
                    } else {
                        var366 = -0.0030960718;
                    }
                } else {
                    if (input[14] < 159.0) {
                        var366 = -0.012405511;
                    } else {
                        var366 = 0.042569533;
                    }
                }
            } else {
                if (input[4] < 4.0) {
                    if (input[1] < 6.0) {
                        var366 = 0.010135106;
                    } else {
                        var366 = -0.016387409;
                    }
                } else {
                    if (input[13] < 41.0) {
                        var366 = 0.002804208;
                    } else {
                        var366 = -0.043462433;
                    }
                }
            }
            double var367;
            if (input[9] < 7.0) {
                if (input[2] < 0.32) {
                    if (input[5] < 0.45) {
                        var367 = 0.03552308;
                    } else {
                        var367 = -0.00018881714;
                    }
                } else {
                    if (input[11] < 4.0) {
                        var367 = 0.016030103;
                    } else {
                        var367 = -0.025594905;
                    }
                }
            } else {
                if (input[13] < 91.0) {
                    if (input[14] < 124.0) {
                        var367 = -0.035901;
                    } else {
                        var367 = 0.020820087;
                    }
                } else {
                    if (input[14] < 147.0) {
                        var367 = -0.052762028;
                    } else {
                        var367 = -0.013266406;
                    }
                }
            }
            double var368;
            if (input[10] < 23.0) {
                if (input[15] < 1.0) {
                    if (input[2] < 0.46) {
                        var368 = -0.044414125;
                    } else {
                        var368 = 0.0067994012;
                    }
                } else {
                    if (input[2] < 1.17) {
                        var368 = -0.0360247;
                    } else {
                        var368 = -0.002835079;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 4.87) {
                        var368 = -0.013408928;
                    } else {
                        var368 = 0.025249967;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var368 = -0.019262252;
                    } else {
                        var368 = 0.047415037;
                    }
                }
            }
            double var369;
            if (input[1] < 4.0) {
                if (input[4] < 2.0) {
                    if (input[13] < 99.0) {
                        var369 = -0.03021476;
                    } else {
                        var369 = -0.00018452486;
                    }
                } else {
                    if (input[10] < 21.0) {
                        var369 = 0.01759973;
                    } else {
                        var369 = -0.01336765;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    var369 = -0.04493749;
                } else {
                    if (input[2] < 0.83) {
                        var369 = 0.011997946;
                    } else {
                        var369 = -0.039313387;
                    }
                }
            }
            double var370;
            if (input[14] < 66.0) {
                if (input[5] < 0.33) {
                    if (input[1] < 2.0) {
                        var370 = -0.05004127;
                    } else {
                        var370 = 0.0039164484;
                    }
                } else {
                    if (input[8] < 1.0) {
                        var370 = 0.008731878;
                    } else {
                        var370 = -0.04734039;
                    }
                }
            } else {
                if (input[5] < 0.44) {
                    if (input[2] < 2.11) {
                        var370 = 0.012835525;
                    } else {
                        var370 = -0.034490667;
                    }
                } else {
                    if (input[2] < 0.75) {
                        var370 = -0.05120794;
                    } else {
                        var370 = -0.00079703145;
                    }
                }
            }
            double var371;
            if (input[11] < 8.0) {
                if (input[5] < 0.6) {
                    if (input[2] < 0.36) {
                        var371 = 0.038858563;
                    } else {
                        var371 = 0.001768634;
                    }
                } else {
                    if (input[14] < 147.0) {
                        var371 = -0.032446455;
                    } else {
                        var371 = 0.009747369;
                    }
                }
            } else {
                if (input[15] < 1.0) {
                    if (input[13] < 188.0) {
                        var371 = -0.020702725;
                    } else {
                        var371 = -0.057294887;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var371 = 0.009427753;
                    } else {
                        var371 = -0.0330958;
                    }
                }
            }
            double var372;
            if (input[11] < 8.0) {
                if (input[1] < 7.0) {
                    if (input[10] < 18.0) {
                        var372 = -0.03833955;
                    } else {
                        var372 = -0.008240611;
                    }
                } else {
                    if (input[12] < 1.38) {
                        var372 = -0.014991425;
                    } else {
                        var372 = 0.045694403;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var372 = -0.0411263;
                    } else {
                        var372 = 0.0014527546;
                    }
                } else {
                    if (input[10] < 22.0) {
                        var372 = 0.0021036656;
                    } else {
                        var372 = 0.029703785;
                    }
                }
            }
            double var373;
            if (input[2] < 0.67) {
                if (input[14] < 103.0) {
                    if (input[5] < 0.56) {
                        var373 = 0.007844099;
                    } else {
                        var373 = 0.034346063;
                    }
                } else {
                    if (input[2] < 0.26) {
                        var373 = -0.01974581;
                    } else {
                        var373 = 0.012717843;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 3.97) {
                        var373 = 0.029855967;
                    } else {
                        var373 = -0.017942544;
                    }
                } else {
                    if (input[3] < 5.0) {
                        var373 = -0.04332129;
                    } else {
                        var373 = -0.0035558422;
                    }
                }
            }
            double var374;
            if (input[2] < 0.79) {
                if (input[4] < 1.0) {
                    if (input[1] < 2.0) {
                        var374 = -0.037881117;
                    } else {
                        var374 = 0.012279311;
                    }
                } else {
                    if (input[1] < 4.0) {
                        var374 = -0.03539712;
                    } else {
                        var374 = 0.014862618;
                    }
                }
            } else {
                if (input[13] < 259.0) {
                    if (input[5] < 0.78) {
                        var374 = 0.015316396;
                    } else {
                        var374 = -0.011640773;
                    }
                } else {
                    if (input[2] < 1.2) {
                        var374 = 0.0025809628;
                    } else {
                        var374 = -0.043772843;
                    }
                }
            }
            double var375;
            if (input[15] < 1.0) {
                if (input[14] < 89.0) {
                    if (input[8] < 1.0) {
                        var375 = -0.019778421;
                    } else {
                        var375 = -0.05066603;
                    }
                } else {
                    if (input[13] < 152.0) {
                        var375 = 0.0022442918;
                    } else {
                        var375 = -0.032475688;
                    }
                }
            } else {
                if (input[12] < 3.54) {
                    if (input[2] < 1.19) {
                        var375 = 0.017120857;
                    } else {
                        var375 = -0.04420764;
                    }
                } else {
                    if (input[10] < 12.0) {
                        var375 = -0.0018214695;
                    } else {
                        var375 = -0.04696234;
                    }
                }
            }
            double var376;
            if (input[9] < 6.0) {
                if (input[11] < 11.0) {
                    if (input[2] < 1.44) {
                        var376 = -0.028541623;
                    } else {
                        var376 = 0.009609443;
                    }
                } else {
                    if (input[8] < 5.0) {
                        var376 = -0.0060126563;
                    } else {
                        var376 = 0.025840094;
                    }
                }
            } else {
                if (input[2] < 0.36) {
                    var376 = -0.041597713;
                } else {
                    if (input[14] < 79.0) {
                        var376 = 0.028997356;
                    } else {
                        var376 = 0.0059592067;
                    }
                }
            }
            double var377;
            if (input[1] < 3.0) {
                if (input[3] < 8.0) {
                    if (input[13] < 48.0) {
                        var377 = -0.04115997;
                    } else {
                        var377 = 0.0025855515;
                    }
                } else {
                    if (input[5] < 2.23) {
                        var377 = 0.024553679;
                    } else {
                        var377 = 0.07157346;
                    }
                }
            } else {
                if (input[13] < 156.0) {
                    if (input[2] < 0.83) {
                        var377 = 0.018675622;
                    } else {
                        var377 = -0.034341898;
                    }
                } else {
                    if (input[3] < 9.0) {
                        var377 = -0.035667468;
                    } else {
                        var377 = 0.02639982;
                    }
                }
            }
            double var378;
            if (input[14] < 39.0) {
                if (input[5] < 0.18) {
                    if (input[8] < 5.0) {
                        var378 = -0.037238646;
                    } else {
                        var378 = 0.018059822;
                    }
                } else {
                    if (input[4] < 1.0) {
                        var378 = -0.001299966;
                    } else {
                        var378 = -0.0520971;
                    }
                }
            } else {
                if (input[1] < 1.0) {
                    if (input[2] < 1.21) {
                        var378 = -0.033900045;
                    } else {
                        var378 = 0.02938039;
                    }
                } else {
                    if (input[9] < 13.0) {
                        var378 = 0.005776495;
                    } else {
                        var378 = -0.04551895;
                    }
                }
            }
            double var379;
            if (input[11] < 10.0) {
                if (input[1] < 4.0) {
                    if (input[8] < 5.0) {
                        var379 = 0.015591941;
                    } else {
                        var379 = -0.009234416;
                    }
                } else {
                    var379 = -0.04802869;
                }
            } else {
                if (input[15] < 1.0) {
                    var379 = -0.053145856;
                } else {
                    if (input[11] < 11.0) {
                        var379 = 0.0011014128;
                    } else {
                        var379 = -0.043298107;
                    }
                }
            }
            double var380;
            if (input[13] < 339.0) {
                if (input[2] < 1.13) {
                    if (input[14] < 79.0) {
                        var380 = 0.0015343416;
                    } else {
                        var380 = -0.027966142;
                    }
                } else {
                    if (input[13] < 140.0) {
                        var380 = -0.010085351;
                    } else {
                        var380 = 0.023217224;
                    }
                }
            } else {
                if (input[2] < 0.68) {
                    if (input[9] < 3.0) {
                        var380 = -0.048773438;
                    } else {
                        var380 = 0.015548755;
                    }
                } else {
                    if (input[12] < 2.98) {
                        var380 = -0.0119508635;
                    } else {
                        var380 = 0.055991173;
                    }
                }
            }
            double var381;
            if (input[6] < 1.0) {
                if (input[5] < 0.32) {
                    if (input[14] < 42.0) {
                        var381 = 0.013934036;
                    } else {
                        var381 = -0.02189898;
                    }
                } else {
                    if (input[12] < 3.79) {
                        var381 = 0.010822789;
                    } else {
                        var381 = -0.018143665;
                    }
                }
            } else {
                if (input[9] < 9.0) {
                    if (input[14] < 159.0) {
                        var381 = 0.018964214;
                    } else {
                        var381 = -0.008198483;
                    }
                } else {
                    if (input[2] < 0.8) {
                        var381 = 0.008627602;
                    } else {
                        var381 = -0.051136125;
                    }
                }
            }
            double var382;
            if (input[14] < 159.0) {
                if (input[6] < 1.0) {
                    if (input[2] < 1.32) {
                        var382 = 0.010517626;
                    } else {
                        var382 = -0.017340358;
                    }
                } else {
                    if (input[2] < 0.81) {
                        var382 = -0.04184692;
                    } else {
                        var382 = -0.008778176;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[10] < 14.0) {
                        var382 = -0.019063307;
                    } else {
                        var382 = 0.047070097;
                    }
                } else {
                    if (input[1] < 7.0) {
                        var382 = 0.041430034;
                    } else {
                        var382 = -0.024561295;
                    }
                }
            }
            double var383;
            if (input[13] < 205.0) {
                if (input[9] < 7.0) {
                    if (input[2] < 0.21) {
                        var383 = 0.026123062;
                    } else {
                        var383 = -0.0023045102;
                    }
                } else {
                    if (input[13] < 91.0) {
                        var383 = 0.0026805697;
                    } else {
                        var383 = -0.043410484;
                    }
                }
            } else {
                if (input[7] < 1.0) {
                    if (input[12] < 2.93) {
                        var383 = 0.013519907;
                    } else {
                        var383 = -0.04146144;
                    }
                } else {
                    if (input[10] < 17.0) {
                        var383 = -0.052120674;
                    } else {
                        var383 = -0.018850563;
                    }
                }
            }
            double var384;
            if (input[15] < 1.0) {
                if (input[1] < 1.0) {
                    if (input[2] < 0.84) {
                        var384 = -0.046285015;
                    } else {
                        var384 = -0.0072271186;
                    }
                } else {
                    if (input[11] < 13.0) {
                        var384 = 0.0033805668;
                    } else {
                        var384 = 0.034063507;
                    }
                }
            } else {
                if (input[9] < 12.0) {
                    if (input[2] < 1.01) {
                        var384 = -0.034244712;
                    } else {
                        var384 = -0.005348033;
                    }
                } else {
                    if (input[5] < 0.15) {
                        var384 = -0.0045120367;
                    } else {
                        var384 = 0.04288062;
                    }
                }
            }
            double var385;
            if (input[2] < 1.13) {
                if (input[5] < 0.79) {
                    if (input[14] < 135.0) {
                        var385 = 0.0015166722;
                    } else {
                        var385 = -0.016159885;
                    }
                } else {
                    if (input[5] < 2.1) {
                        var385 = 0.010429426;
                    } else {
                        var385 = 0.06235507;
                    }
                }
            } else {
                if (input[5] < 1.7) {
                    if (input[6] < 2.0) {
                        var385 = -0.047828335;
                    } else {
                        var385 = -0.009525463;
                    }
                } else {
                    if (input[5] < 1.83) {
                        var385 = 0.014032175;
                    } else {
                        var385 = -0.021393776;
                    }
                }
            }
            double var386;
            if (input[0] < 3.0) {
                var386 = -0.043135855;
            } else {
                if (input[5] < 0.12) {
                    if (input[1] < 5.0) {
                        var386 = 0.018617386;
                    } else {
                        var386 = -0.009403419;
                    }
                } else {
                    if (input[2] < 0.74) {
                        var386 = -0.026965499;
                    } else {
                        var386 = -0.00063331774;
                    }
                }
            }
            double var387;
            if (input[12] < 3.54) {
                if (input[15] < 1.0) {
                    if (input[10] < 2.0) {
                        var387 = 0.031362467;
                    } else {
                        var387 = -0.0140155405;
                    }
                } else {
                    if (input[5] < 1.04) {
                        var387 = 0.01816004;
                    } else {
                        var387 = -0.02528107;
                    }
                }
            } else {
                if (input[10] < 12.0) {
                    var387 = -0.0034849716;
                } else {
                    var387 = -0.04837946;
                }
            }
            double var388;
            if (input[13] < 197.0) {
                if (input[5] < 0.87) {
                    if (input[2] < 1.47) {
                        var388 = -0.029517759;
                    } else {
                        var388 = 0.008917902;
                    }
                } else {
                    if (input[0] < 5.0) {
                        var388 = -0.016887603;
                    } else {
                        var388 = 0.027579773;
                    }
                }
            } else {
                if (input[2] < 0.49) {
                    if (input[11] < 17.0) {
                        var388 = -0.037417904;
                    } else {
                        var388 = 0.024438355;
                    }
                } else {
                    if (input[14] < 88.0) {
                        var388 = 0.02819514;
                    } else {
                        var388 = -0.0008915257;
                    }
                }
            }
            double var389;
            if (input[1] < 3.0) {
                if (input[4] < 1.0) {
                    if (input[11] < 5.0) {
                        var389 = -0.033972293;
                    } else {
                        var389 = -0.004494837;
                    }
                } else {
                    if (input[14] < 103.0) {
                        var389 = 0.020236326;
                    } else {
                        var389 = 0.0009814264;
                    }
                }
            } else {
                if (input[10] < 19.0) {
                    if (input[2] < 0.66) {
                        var389 = 0.026512742;
                    } else {
                        var389 = -0.020350922;
                    }
                } else {
                    if (input[13] < 367.0) {
                        var389 = -0.03994234;
                    } else {
                        var389 = 0.008602878;
                    }
                }
            }
            double var390;
            if (input[1] < 2.0) {
                if (input[2] < 0.81) {
                    if (input[10] < 20.0) {
                        var390 = -0.053196233;
                    } else {
                        var390 = -0.01341525;
                    }
                } else {
                    if (input[3] < 2.0) {
                        var390 = 0.014879514;
                    } else {
                        var390 = -0.025715549;
                    }
                }
            } else {
                if (input[3] < 6.0) {
                    if (input[1] < 5.0) {
                        var390 = 0.010757154;
                    } else {
                        var390 = -0.008968043;
                    }
                } else {
                    if (input[13] < 81.0) {
                        var390 = 0.005451652;
                    } else {
                        var390 = -0.048984993;
                    }
                }
            }
            double var391;
            if (input[11] < 7.0) {
                if (input[1] < 1.0) {
                    if (input[5] < 0.57) {
                        var391 = 0.040381763;
                    } else {
                        var391 = 0.0058517586;
                    }
                } else {
                    if (input[11] < 3.0) {
                        var391 = 0.015608042;
                    } else {
                        var391 = -0.019261222;
                    }
                }
            } else {
                if (input[9] < 7.0) {
                    if (input[2] < 0.31) {
                        var391 = 0.005042333;
                    } else {
                        var391 = -0.03431529;
                    }
                } else {
                    var391 = -0.05326547;
                }
            }
            double var392;
            if (input[10] < 23.0) {
                if (input[9] < 7.0) {
                    if (input[14] < 50.0) {
                        var392 = 0.01685964;
                    } else {
                        var392 = -0.018054748;
                    }
                } else {
                    if (input[2] < 0.83) {
                        var392 = -0.008354853;
                    } else {
                        var392 = 0.024927298;
                    }
                }
            } else {
                if (input[1] < 2.0) {
                    if (input[12] < 4.87) {
                        var392 = -0.012445181;
                    } else {
                        var392 = 0.024344452;
                    }
                } else {
                    if (input[13] < 100.0) {
                        var392 = -0.016819991;
                    } else {
                        var392 = 0.04553997;
                    }
                }
            }
            double var393;
            if (input[0] < 6.0) {
                if (input[4] < 3.0) {
                    if (input[11] < 14.0) {
                        var393 = -0.0007300932;
                    } else {
                        var393 = -0.03041252;
                    }
                } else {
                    if (input[14] < 162.0) {
                        var393 = 0.01994544;
                    } else {
                        var393 = -0.010737351;
                    }
                }
            } else {
                if (input[14] < 41.0) {
                    var393 = 0.0014056455;
                } else {
                    if (input[13] < 55.0) {
                        var393 = -0.014618878;
                    } else {
                        var393 = -0.046552375;
                    }
                }
            }
            double var394;
            if (input[0] < 4.0) {
                if (input[12] < 3.23) {
                    if (input[2] < 0.92) {
                        var394 = -0.036091644;
                    } else {
                        var394 = 0.023486434;
                    }
                } else {
                    if (input[14] < 59.0) {
                        var394 = -0.038976748;
                    } else {
                        var394 = 0.01811976;
                    }
                }
            } else {
                if (input[4] < 3.0) {
                    if (input[2] < 2.23) {
                        var394 = 0.009117937;
                    } else {
                        var394 = -0.035161998;
                    }
                } else {
                    if (input[13] < 113.0) {
                        var394 = -0.00093323115;
                    } else {
                        var394 = -0.035762068;
                    }
                }
            }
            double var395;
            if (input[13] < 205.0) {
                if (input[1] < 4.0) {
                    if (input[10] < 2.0) {
                        var395 = 0.040397573;
                    } else {
                        var395 = 0.0019631677;
                    }
                } else {
                    var395 = -0.04757965;
                }
            } else {
                if (input[3] < 1.0) {
                    if (input[12] < 3.12) {
                        var395 = 0.0074461848;
                    } else {
                        var395 = -0.045312423;
                    }
                } else {
                    var395 = -0.048069406;
                }
            }
            double var396;
            if (input[11] < 7.0) {
                if (input[1] < 8.0) {
                    if (input[4] < 3.0) {
                        var396 = -0.03758903;
                    } else {
                        var396 = 0.00319831;
                    }
                } else {
                    if (input[2] < 1.99) {
                        var396 = 0.008018377;
                    } else {
                        var396 = 0.044936445;
                    }
                }
            } else {
                if (input[2] < 1.49) {
                    if (input[14] < 79.0) {
                        var396 = 0.014378068;
                    } else {
                        var396 = -0.010670792;
                    }
                } else {
                    if (input[10] < 13.0) {
                        var396 = -0.008194832;
                    } else {
                        var396 = 0.044458937;
                    }
                }
            }
            double var397;
            if (input[1] < 4.0) {
                if (input[5] < 1.08) {
                    if (input[14] < 153.0) {
                        var397 = 0.002586357;
                    } else {
                        var397 = -0.01671304;
                    }
                } else {
                    if (input[9] < 8.0) {
                        var397 = 0.026380166;
                    } else {
                        var397 = -0.011452338;
                    }
                }
            } else {
                if (input[6] < 2.0) {
                    var397 = -0.04389925;
                } else {
                    if (input[2] < 0.83) {
                        var397 = 0.010760067;
                    } else {
                        var397 = -0.038263112;
                    }
                }
            }
            double var398;
            if (input[14] < 159.0) {
                if (input[2] < 0.59) {
                    if (input[8] < 4.0) {
                        var398 = -0.0519766;
                    } else {
                        var398 = -0.018455254;
                    }
                } else {
                    if (input[5] < 0.81) {
                        var398 = 0.003579116;
                    } else {
                        var398 = -0.025069654;
                    }
                }
            } else {
                if (input[0] < 5.0) {
                    if (input[1] < 3.0) {
                        var398 = -0.02666404;
                    } else {
                        var398 = 0.027938241;
                    }
                } else {
                    if (input[1] < 7.0) {
                        var398 = 0.040387087;
                    } else {
                        var398 = -0.023660995;
                    }
                }
            }
            double var399;
            if (input[12] < 3.3) {
                if (input[1] < 1.0) {
                    if (input[9] < 7.0) {
                        var399 = 0.020648645;
                    } else {
                        var399 = -0.026185885;
                    }
                } else {
                    if (input[13] < 68.0) {
                        var399 = 0.012073877;
                    } else {
                        var399 = -0.02342958;
                    }
                }
            } else {
                if (input[10] < 10.0) {
                    var399 = 0.036330264;
                } else {
                    if (input[11] < 5.0) {
                        var399 = -0.0023269635;
                    } else {
                        var399 = -0.048398275;
                    }
                }
            }
            return Softmax(new double[4] {nan + (var0 + var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10 + var11 + var12 + var13 + var14 + var15 + var16 + var17 + var18 + var19 + var20 + var21 + var22 + var23 + var24 + var25 + var26 + var27 + var28 + var29 + var30 + var31 + var32 + var33 + var34 + var35 + var36 + var37 + var38 + var39 + var40 + var41 + var42 + var43 + var44 + var45 + var46 + var47 + var48 + var49 + var50 + var51 + var52 + var53 + var54 + var55 + var56 + var57 + var58 + var59 + var60 + var61 + var62 + var63 + var64 + var65 + var66 + var67 + var68 + var69 + var70 + var71 + var72 + var73 + var74 + var75 + var76 + var77 + var78 + var79 + var80 + var81 + var82 + var83 + var84 + var85 + var86 + var87 + var88 + var89 + var90 + var91 + var92 + var93 + var94 + var95 + var96 + var97 + var98 + var99), nan + (var100 + var101 + var102 + var103 + var104 + var105 + var106 + var107 + var108 + var109 + var110 + var111 + var112 + var113 + var114 + var115 + var116 + var117 + var118 + var119 + var120 + var121 + var122 + var123 + var124 + var125 + var126 + var127 + var128 + var129 + var130 + var131 + var132 + var133 + var134 + var135 + var136 + var137 + var138 + var139 + var140 + var141 + var142 + var143 + var144 + var145 + var146 + var147 + var148 + var149 + var150 + var151 + var152 + var153 + var154 + var155 + var156 + var157 + var158 + var159 + var160 + var161 + var162 + var163 + var164 + var165 + var166 + var167 + var168 + var169 + var170 + var171 + var172 + var173 + var174 + var175 + var176 + var177 + var178 + var179 + var180 + var181 + var182 + var183 + var184 + var185 + var186 + var187 + var188 + var189 + var190 + var191 + var192 + var193 + var194 + var195 + var196 + var197 + var198 + var199), nan + (var200 + var201 + var202 + var203 + var204 + var205 + var206 + var207 + var208 + var209 + var210 + var211 + var212 + var213 + var214 + var215 + var216 + var217 + var218 + var219 + var220 + var221 + var222 + var223 + var224 + var225 + var226 + var227 + var228 + var229 + var230 + var231 + var232 + var233 + var234 + var235 + var236 + var237 + var238 + var239 + var240 + var241 + var242 + var243 + var244 + var245 + var246 + var247 + var248 + var249 + var250 + var251 + var252 + var253 + var254 + var255 + var256 + var257 + var258 + var259 + var260 + var261 + var262 + var263 + var264 + var265 + var266 + var267 + var268 + var269 + var270 + var271 + var272 + var273 + var274 + var275 + var276 + var277 + var278 + var279 + var280 + var281 + var282 + var283 + var284 + var285 + var286 + var287 + var288 + var289 + var290 + var291 + var292 + var293 + var294 + var295 + var296 + var297 + var298 + var299), nan + (var300 + var301 + var302 + var303 + var304 + var305 + var306 + var307 + var308 + var309 + var310 + var311 + var312 + var313 + var314 + var315 + var316 + var317 + var318 + var319 + var320 + var321 + var322 + var323 + var324 + var325 + var326 + var327 + var328 + var329 + var330 + var331 + var332 + var333 + var334 + var335 + var336 + var337 + var338 + var339 + var340 + var341 + var342 + var343 + var344 + var345 + var346 + var347 + var348 + var349 + var350 + var351 + var352 + var353 + var354 + var355 + var356 + var357 + var358 + var359 + var360 + var361 + var362 + var363 + var364 + var365 + var366 + var367 + var368 + var369 + var370 + var371 + var372 + var373 + var374 + var375 + var376 + var377 + var378 + var379 + var380 + var381 + var382 + var383 + var384 + var385 + var386 + var387 + var388 + var389 + var390 + var391 + var392 + var393 + var394 + var395 + var396 + var397 + var398 + var399)});
        }
        private static double[] Softmax(double[] x) {
            int size = x.Length;
            double[] result = new double[size];
            double max = x[0];
            for (int i = 1; i < size; ++i) {
                if (x[i] > max)
                    max = x[i];
            }
            double sum = 0.0;
            for (int i = 0; i < size; ++i) {
                result[i] = Exp(x[i] - max);
                sum += result[i];
            }
            for (int i = 0; i < size; ++i)
                result[i] /= sum;
            return result;
        }
    }
}
