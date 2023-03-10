// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBloodBase : Table {
  public static FB_DestinyBloodBase GetRootAsFB_DestinyBloodBase(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodBase(_bb, new FB_DestinyBloodBase()); }
  public static FB_DestinyBloodBase GetRootAsFB_DestinyBloodBase(ByteBuffer _bb, FB_DestinyBloodBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBloodBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LimitBloodId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetImpactList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ImpactListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int BloodPossessedId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_DestinyBloodBase> CreateFB_DestinyBloodBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int LimitBloodId = -1,
      int LimitLevel = -1,
      VectorOffset PassiveSkillList = default(VectorOffset),
      VectorOffset ImpactList = default(VectorOffset),
      int BloodPossessedId = -1) {
    builder.StartObject(7);
    FB_DestinyBloodBase.AddBloodPossessedId(builder, BloodPossessedId);
    FB_DestinyBloodBase.AddImpactList(builder, ImpactList);
    FB_DestinyBloodBase.AddPassiveSkillList(builder, PassiveSkillList);
    FB_DestinyBloodBase.AddLimitLevel(builder, LimitLevel);
    FB_DestinyBloodBase.AddLimitBloodId(builder, LimitBloodId);
    FB_DestinyBloodBase.AddName(builder, Name);
    FB_DestinyBloodBase.AddID(builder, ID);
    return FB_DestinyBloodBase.EndFB_DestinyBloodBase(builder);
  }

  public static void StartFB_DestinyBloodBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLimitBloodId(FlatBufferBuilder builder, int LimitBloodId) { builder.AddInt(2, LimitBloodId, -1); }
  public static void AddLimitLevel(FlatBufferBuilder builder, int LimitLevel) { builder.AddInt(3, LimitLevel, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(4, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddImpactList(FlatBufferBuilder builder, VectorOffset ImpactListOffset) { builder.AddOffset(5, ImpactListOffset.Value, 0); }
  public static VectorOffset CreateImpactListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartImpactListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBloodPossessedId(FlatBufferBuilder builder, int BloodPossessedId) { builder.AddInt(6, BloodPossessedId, -1); }
  public static Offset<FB_DestinyBloodBase> EndFB_DestinyBloodBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodBase>(o);
  }
};

public sealed class FB_DestinyBloodBaseContainer : Table {
  public static FB_DestinyBloodBaseContainer GetRootAsFB_DestinyBloodBaseContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodBaseContainer(_bb, new FB_DestinyBloodBaseContainer()); }
  public static FB_DestinyBloodBaseContainer GetRootAsFB_DestinyBloodBaseContainer(ByteBuffer _bb, FB_DestinyBloodBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBloodBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBloodBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBloodBase GetItems(int j) { return GetItems(new FB_DestinyBloodBase(), j); }
  public FB_DestinyBloodBase GetItems(FB_DestinyBloodBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodBaseContainer> CreateFB_DestinyBloodBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBloodBaseContainer.AddItems(builder, items);
    return FB_DestinyBloodBaseContainer.EndFB_DestinyBloodBaseContainer(builder);
  }

  public static void StartFB_DestinyBloodBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBloodBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBloodBaseContainer> EndFB_DestinyBloodBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodBaseContainer>(o);
  }
  public static void FinishFB_DestinyBloodBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBloodBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
