// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PetBase : Table {
  public static FB_PetBase GetRootAsFB_PetBase(ByteBuffer _bb) { return GetRootAsFB_PetBase(_bb, new FB_PetBase()); }
  public static FB_PetBase GetRootAsFB_PetBase(ByteBuffer _bb, FB_PetBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PetBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Step { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string StepSprite { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Exp { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HpMax { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PMAttack { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PMDefence { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Speed { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int ItemID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyType { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int QuickItemCount { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatPower { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PetBase> CreateFB_PetBase(FlatBufferBuilder builder,
      int Id = 0,
      int Level = 1,
      int Step = 1,
      StringOffset StepSprite = default(StringOffset),
      int Exp = -1,
      int HpMax = -1,
      int PMAttack = -1,
      int PMDefence = -1,
      float Speed = 0,
      int ItemID = -1,
      int MoneyType = -1,
      int QuickItemCount = -1,
      int CombatPower = -1) {
    builder.StartObject(13);
    FB_PetBase.AddCombatPower(builder, CombatPower);
    FB_PetBase.AddQuickItemCount(builder, QuickItemCount);
    FB_PetBase.AddMoneyType(builder, MoneyType);
    FB_PetBase.AddItemID(builder, ItemID);
    FB_PetBase.AddSpeed(builder, Speed);
    FB_PetBase.AddPMDefence(builder, PMDefence);
    FB_PetBase.AddPMAttack(builder, PMAttack);
    FB_PetBase.AddHpMax(builder, HpMax);
    FB_PetBase.AddExp(builder, Exp);
    FB_PetBase.AddStepSprite(builder, StepSprite);
    FB_PetBase.AddStep(builder, Step);
    FB_PetBase.AddLevel(builder, Level);
    FB_PetBase.AddId(builder, Id);
    return FB_PetBase.EndFB_PetBase(builder);
  }

  public static void StartFB_PetBase(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, 1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(2, Step, 1); }
  public static void AddStepSprite(FlatBufferBuilder builder, StringOffset StepSpriteOffset) { builder.AddOffset(3, StepSpriteOffset.Value, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(4, Exp, -1); }
  public static void AddHpMax(FlatBufferBuilder builder, int HpMax) { builder.AddInt(5, HpMax, -1); }
  public static void AddPMAttack(FlatBufferBuilder builder, int PMAttack) { builder.AddInt(6, PMAttack, -1); }
  public static void AddPMDefence(FlatBufferBuilder builder, int PMDefence) { builder.AddInt(7, PMDefence, -1); }
  public static void AddSpeed(FlatBufferBuilder builder, float Speed) { builder.AddFloat(8, Speed, 0); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(9, ItemID, -1); }
  public static void AddMoneyType(FlatBufferBuilder builder, int MoneyType) { builder.AddInt(10, MoneyType, -1); }
  public static void AddQuickItemCount(FlatBufferBuilder builder, int QuickItemCount) { builder.AddInt(11, QuickItemCount, -1); }
  public static void AddCombatPower(FlatBufferBuilder builder, int CombatPower) { builder.AddInt(12, CombatPower, -1); }
  public static Offset<FB_PetBase> EndFB_PetBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetBase>(o);
  }
};

public sealed class FB_PetBaseContainer : Table {
  public static FB_PetBaseContainer GetRootAsFB_PetBaseContainer(ByteBuffer _bb) { return GetRootAsFB_PetBaseContainer(_bb, new FB_PetBaseContainer()); }
  public static FB_PetBaseContainer GetRootAsFB_PetBaseContainer(ByteBuffer _bb, FB_PetBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PetBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PetBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PetBase GetItems(int j) { return GetItems(new FB_PetBase(), j); }
  public FB_PetBase GetItems(FB_PetBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PetBaseContainer> CreateFB_PetBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PetBaseContainer.AddItems(builder, items);
    return FB_PetBaseContainer.EndFB_PetBaseContainer(builder);
  }

  public static void StartFB_PetBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PetBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PetBaseContainer> EndFB_PetBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetBaseContainer>(o);
  }
  public static void FinishFB_PetBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_PetBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
