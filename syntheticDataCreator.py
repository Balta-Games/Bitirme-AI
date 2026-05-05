import pandas as pd
import numpy as np
import json

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

    #labels
    consecutive: bool
    aoe: bool
    dot: bool

    dodge: bool
    block_parry: bool
    #speacial: bool

    def to_dict(self):
        return {
            "dc_Categorized": self.dc_Categorized,
            "bc_Categorized": self.bc_Categorized,
            "pc_Categorized": self.pc_Categorized,
            "ac_Categorized": self.ac_Categorized,
            "hac_Categorized": self.hac_Categorized,
            "lac_Categorized": self.lac_Categorized,
            "aggressivePlaystyle": self.aggressivePlaystyle,

            "consecutive": self.consecutive,
            "aoe": self.aoe,
            "dot": self.dot,
            "dodge": self.dodge,
            "block_parry": self.block_parry
        }

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

    def getDominantFeatures(self, isAttack):
        dominantValues = []

        if isAttack:
            features = [self.hac_Categorized, self.lac_Categorized]
            dominantValue = max(features)

            if dominantValue == self.hac_Categorized:
                dominantValues.append("HAC")
            if dominantValue == self.lac_Categorized:
                dominantValues.append("LAC")
        else:
            features = [self.bc_Categorized, self.dc_Categorized, self.pc_Categorized]
            dominantValue = max(features)

            if dominantValue == self.bc_Categorized:
                dominantValues.append("BC")
            if dominantValue == self.dc_Categorized:
                dominantValues.append("DC")
            if dominantValue == self.pc_Categorized:
                dominantValues.append("PC")
        
        return dominantValues
    
    def setAttackLabels(self):
        dominantDefense = self.getDominantFeatures(isAttack=False)
        self.consecutive = False
        self.aoe = False
        self.dot = False

        if("BC" in dominantDefense):
            self.dot = True
        if("DC" in dominantDefense):
            self.aoe = True
        if("PC" in dominantDefense):
            self.consecutive = True

    def setDefenseLabels(self):
        dominantAttack = self.getDominantFeatures(isAttack=True)
        self.block_parry = False
        self.dodge = False

        if("HAC" in dominantAttack):
            self.dodge = True
        if("LAC" in dominantAttack):
            self.block_parry = True

    def printSample(self):
        print(f"Attack Count: {self.attackCount}, Heavy Attack Count: {self.heavyAttackCount}, Light Attack Count: {self.lightAttackCount}")
        print(f"Dodge Count: {self.dodgeCount}, Block Count: {self.blockCount}, Parry Count: {self.parryCount}")
        print(f"Aggressive Playstyle: {self.aggressivePlaystyle}")
        print(f"Attack Categories: AC: {self.ac_Categorized}, HAC: {self.hac_Categorized}, LAC: {self.lac_Categorized}")
        print(f"Defense Categories: DC: {self.dc_Categorized}, BC: {self.bc_Categorized}, PC: {self.pc_Categorized}")
        print(f"Combat Labels: Dodge: {self.dodge}, Block/Parry: {self.block_parry}")
        print(f"Attack Labels: Consecutive: {self.consecutive}, AoE: {self.aoe}, DoT: {self.dot}")

    def __init__(self):
        self.setAttackFeatures()
        self.setDefenseFeatures()
        self.setPlaystyle()
        self.setAttackLabels()
        self.setDefenseLabels()
        self.printSample()

class Numerical_Features:
    dodgeCount: int
    blockCount: int
    parryCount: int

    attackCount: int
    heavyAttackCount: int
    lightAttackCount: int

    def setAttackFeatures(self):
        self.attackCount = np.random.randint(1, 91)
        self.heavyAttackCount = np.random.randint(0, self.attackCount + 1)
        self.lightAttackCount = self.attackCount - self.heavyAttackCount

    def setDefenseFeatures(self):
        self.dodgeCount = np.random.randint(0, 10)
        self.blockCount = np.random.randint(0, 10)
        self.parryCount = np.random.randint(0, 10)

        meanDefenseValue = (self.dodgeCount + self.blockCount + self.parryCount) / 3
        if meanDefenseValue > 7:
            self.setDefenseFeatures()

    def printSample(self):
        print(f"Attack Count: {self.attackCount}, Heavy Attack Count: {self.heavyAttackCount}, Light Attack Count: {self.lightAttackCount}")
        print(f"Dodge Count: {self.dodgeCount}, Block Count: {self.blockCount}, Parry Count: {self.parryCount}")

    def __init__(self):
        self.setAttackFeatures()
        self.setDefenseFeatures()
        self.printSample()

def create_dataset(n_rows, filename="Dataset/dataset.csv"):
    samples = [s.to_dict() for s in (Sample() for _ in range(n_rows))]
    with open("Dataset/dataset.json", "w") as f:
        json.dump(samples, f, indent=4)

    # Sonradan CSV’ye dönüştür
    df = pd.read_json("Dataset/dataset.json")
    df.to_csv(filename, index=False)
