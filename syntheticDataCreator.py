import pandas as pd
import numpy as np
import json

LOW = 0
MEDIUM = 1
HIGH = 2

class Numerical_Features:
    dodgeCount: int
    blockCount: int
    parryCount: int

    attackCount: int
    heavyAttackCount: int
    lightAttackCount: int

    aggressivePlaystyle: bool

    def setAttackFeatures_Random(self):
        self.attackCount = np.random.randint(1, 101)
        self.heavyAttackCount = np.random.randint(0, self.attackCount + 1)
        self.lightAttackCount = self.attackCount - self.heavyAttackCount

    def setAttackFeatures(self, attack, heavyAttack, lightAttack):
        self.attackCount = attack
        self.heavyAttackCount = heavyAttack
        self.lightAttackCount = lightAttack

    def setDefenseFeatures_Random(self):
        self.dodgeCount = np.random.randint(0, 101)
        self.blockCount = np.random.randint(0, 101)
        self.parryCount = np.random.randint(0, 101)

        meanDefenseValue = (self.dodgeCount + self.blockCount + self.parryCount) / 3
        if meanDefenseValue > 70:
            self.setDefenseFeatures_Random()

    def setDefenseFeatures(self, dodge, block, parry):
        self.dodgeCount = dodge
        self.blockCount = block
        self.parryCount = parry

    def setPlaystyle(self):
        self.aggressivePlaystyle = False

    def getDominantFeatures(self):
        dominantAttackValues = []
        dominantDefenseValues = []
        
        attackFeatures = [self.heavyAttackCount, self.lightAttackCount]
        dominantValue = max(attackFeatures)

        if dominantValue == self.heavyAttackCount:
            dominantAttackValues.append("Heavy Attack")
        if dominantValue == self.lightAttackCount:
            dominantAttackValues.append("Light Attack")
    
        defenseFeatures = [self.dodgeCount, self.blockCount, self.parryCount]
        dominantValue = max(defenseFeatures)

        if dominantValue == self.dodgeCount:
            dominantDefenseValues.append("Dodge")
        if dominantValue == self.blockCount:
            dominantDefenseValues.append("Block")
        if dominantValue == self.parryCount:
            dominantDefenseValues.append("Parry")

        dominantFeatures = {"attack": dominantAttackValues, "defense": dominantDefenseValues}
        return dominantFeatures

    def printSample(self):
        print(f"Attack Count: {self.attackCount}, Heavy Attack Count: {self.heavyAttackCount}, Light Attack Count: {self.lightAttackCount}")
        print(f"Dodge Count: {self.dodgeCount}, Block Count: {self.blockCount}, Parry Count: {self.parryCount}")

    def __init__(self, feature=None):
        if(feature == None):
            self.setAttackFeatures_Random()
            self.setDefenseFeatures_Random()
        else:
            self.setAttackFeatures(feature['attack'],feature['heavyAttack'],feature['lightAttack'])
            self.setDefenseFeatures(feature['dodge'],feature['block'],feature['parry'])
        self.setPlaystyle()
        self.printSample()

class Categorical_Features:
    dodge: int
    block: int
    parry: int

    attackTotal: int
    heavyAttack: int
    lightAttack: int

    aggressivePlaystyle: bool

    def setAttackFeatures_Random(self):
        self.attackTotal = np.random.randint(LOW, HIGH+1)
        self.heavyAttack = np.random.randint(LOW, HIGH+1)
        self.lightAttack = LOW if self.heavyAttack == HIGH else (MEDIUM if self.heavyAttack == MEDIUM else HIGH)
    
    def setAttackFeatures(self, heavyAttackCount, lightAttackCount):
        attackCount = heavyAttackCount + lightAttackCount
        heavyAttackPercentage = heavyAttackCount / attackCount

        self.attackTotal = np.random.randint(0, 3)

        if(heavyAttackPercentage <= 0.3):
            self.heavyAttack = LOW
            self.lightAttack = HIGH
        elif(heavyAttackPercentage <= 0.7):
            self.heavyAttack = MEDIUM
            self.lightAttack = MEDIUM
        else:
            self.heavyAttack = HIGH
            self.lightAttack = LOW

    def setDefenseFeatures_Random(self):
        self.dodge = np.random.randint(LOW, HIGH+1)
        self.block = np.random.randint(LOW, HIGH+1)
        self.parry = np.random.randint(LOW, HIGH+1)

        defenseValues = [self.dodge, self.block, self.parry]
        highDefenseValueCount = defenseValues.count(HIGH)
        if highDefenseValueCount > 2:
            self.setDefenseFeatures_Random()

    def setPlaystyle(self):
        self.aggressivePlaystyle = False

    def getDominantFeatures(self):
        dominantAttackValues = []
        dominantDefenseValues = []
        
        attackFeatures = [self.heavyAttack, self.lightAttack]
        dominantValue = max(attackFeatures)

        if dominantValue == self.heavyAttack:
            dominantAttackValues.append("Heavy Attack")
        if dominantValue == self.lightAttack:
            dominantAttackValues.append("Light Attack")
    
        defenseFeatures = [self.dodge, self.block, self.parry]
        dominantValue = max(defenseFeatures)

        if dominantValue == self.dodge:
            dominantDefenseValues.append("Dodge")
        if dominantValue == self.block:
            dominantDefenseValues.append("Block")
        if dominantValue == self.parry:
            dominantDefenseValues.append("Parry")

        dominantFeatures = {"attack": dominantAttackValues, "defense": dominantDefenseValues}
        return dominantFeatures

    def printSample(self):
        print(f"Attack: {self.attackTotal}, Heavy Attack: {self.heavyAttack}, Light Attack: {self.lightAttack}")
        print(f"Dodge: {self.dodge}, Block: {self.block}, Parry: {self.parry}")

    def __init__(self, heavyAttackCount=None, lightAttackCount=None):
        if(heavyAttackCount == None):
            self.setAttackFeatures_Random()
            self.setDefenseFeatures_Random()
        else:
            self.setAttackFeatures(heavyAttackCount,lightAttackCount)
            self.setDefenseFeatures_Random()

        self.printSample()

class Labels:
    consecutive: bool
    aoe: bool
    dot: bool

    dodge: bool
    block_parry: bool

    def setAttackLabels(self, dominantDefense):
        self.consecutive = False
        self.aoe = False
        self.dot = False

        if("Block" in dominantDefense):
            self.dot = True
        if("Dodge" in dominantDefense):
            self.aoe = True
        if("Parry" in dominantDefense):
            self.consecutive = True

    def setDefenseLabels(self, dominantAttack):
        self.block_parry = False
        self.dodge = False

        if("Heavy Attack" in dominantAttack):
            self.dodge = True
        if("Light Attack" in dominantAttack):
            self.block_parry = True

    def __init__(self, dominantFeatures):
        self.setAttackLabels(dominantFeatures["defense"])
        self.setDefenseLabels(dominantFeatures["attack"])

class Sample:
    features: Numerical_Features
    labels: Labels

    def __init__(self):
        self.features = Numerical_Features()
        self.labels = Labels(self.features.getDominantFeatures())

    def to_dict(self):
        return {
            "dodge_feature": self.features.dodgeCount,
            "block": self.features.blockCount,
            "parry": self.features.parryCount,
            "attackTotal": self.features.attackCount,
            "heavyAttack": self.features.heavyAttackCount,
            "lightAttack": self.features.lightAttackCount,
            "aggressivePlaystyle": self.features.aggressivePlaystyle,

            "consecutive": self.labels.consecutive,
            "aoe": self.labels.aoe,
            "dot": self.labels.dot,
            "dodge_label": self.labels.dodge,
            "block_parry": self.labels.block_parry
        }

def create_dataset(n_rows, filename="Dataset/dataset.csv"):
    samples = [s.to_dict() for s in (Sample() for _ in range(n_rows))]
    with open("Dataset/dataset.json", "w") as f:
        json.dump(samples, f, indent=4)

    # Sonradan CSV’ye dönüştür
    df = pd.read_json("Dataset/dataset.json")
    df.to_csv(filename, index=False)
