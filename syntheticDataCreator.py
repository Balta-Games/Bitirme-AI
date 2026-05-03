import pandas as pd
import numpy as np

class Sample:
    dodgeCount: int
    blockCount: int
    parryCount: int
    dc_Categorized: int
    bc_Categorized: int
    pc_Categorized: int

    attackCount: int
    heavyAttackCount: int
    lightAttackCount: int
    ac_Categorized: int
    hac_Categorized: int
    lac_Categorized: int

    aggressivePlaystyle: bool

    def setAttackFeatures(self):
        self.attackCount = np.random.randint(1, 91)
        self.heavyAttackCount = np.random.randint(0, self.attackCount + 1)
        self.lightAttackCount = self.attackCount - self.heavyAttackCount

        heavyAttackPercentage = self.heavyAttackCount / self.attackCount
        self.ac_Categorized = 0 if self.attackCount <= 30 else (1 if self.attackCount <= 60 else 2)
        self.hac_Categorized = 0 if heavyAttackPercentage <= 0.3 else (1 if heavyAttackPercentage <= 0.7 else 2)
        self.lac_Categorized = 0 if self.hac_Categorized == 2 else (1 if self.hac_Categorized == 1 else 2)

    def setDefenseFeatures(self):
        self.dodgeCount = np.random.randint(0, 10)
        self.blockCount = np.random.randint(0, 10)
        self.parryCount = np.random.randint(0, 10)

        self.dc_Categorized = 0 if self.dodgeCount <= 3 else (1 if self.dodgeCount <= 7 else 2)
        self.bc_Categorized = 0 if self.blockCount <= 3 else (1 if self.blockCount <= 7 else 2)
        self.pc_Categorized = 0 if self.parryCount <= 3 else (1 if self.parryCount <= 7 else 2)

        defenseValues = [self.dc_Categorized, self.bc_Categorized, self.pc_Categorized]
        highDefenseValueCount = defenseValues.count(2)
        if highDefenseValueCount > 2:
            self.setDefenseFeatures()
        elif highDefenseValueCount == 2 and self.ac_Categorized == 2:
            self.setDefenseFeatures()
    
    def setPlaystyle(self):
        defenseValues = [self.dc_Categorized, self.bc_Categorized, self.pc_Categorized]
        highDefenseValueCount = defenseValues.count(2)
        lowDefenseValueCount = defenseValues.count(0)
        self.aggressivePlaystyle = (self.ac_Categorized == 2 and highDefenseValueCount == 0) or (
                                    self.ac_Categorized == 1 and lowDefenseValueCount == 0)
        
    def __init__(self):
        self.setAttackFeatures()
        self.setDefenseFeatures()
        self.setPlaystyle()
