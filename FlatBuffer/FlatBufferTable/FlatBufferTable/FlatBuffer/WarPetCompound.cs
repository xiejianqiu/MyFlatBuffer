// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetCompound : Table {
  public static FB_WarPetCompound GetRootAsFB_WarPetCompound(ByteBuffer _bb) { return GetRootAsFB_WarPetCompound(_bb, new FB_WarPetCompound()); }
  public static FB_WarPetCompound GetRootAsFB_WarPetCompound(ByteBuffer _bb, FB_WarPetCompound obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetCompound __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DroBoxId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DroBoxIdSecond { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillTabTipStrId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TianFuTabTipStrId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SkillSubTabStrId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TianFuSubTabStrId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_WarPetCompound> CreateFB_WarPetCompound(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Quality = 0,
      int ItemCount = 0,
      int DroBoxId = 0,
      int DroBoxIdSecond = 0,
      int SkillTabTipStrId = 0,
      int TianFuTabTipStrId = 0,
      int SkillSubTabStrId = 0,
      int TianFuSubTabStrId = 0) {
    builder.StartObject(10);
    FB_WarPetCompound.AddTianFuSubTabStrId(builder, TianFuSubTabStrId);
    FB_WarPetCompound.AddSkillSubTabStrId(builder, SkillSubTabStrId);
    FB_WarPetCompound.AddTianFuTabTipStrId(builder, TianFuTabTipStrId);
    FB_WarPetCompound.AddSkillTabTipStrId(builder, SkillTabTipStrId);
    FB_WarPetCompound.AddDroBoxIdSecond(builder, DroBoxIdSecond);
    FB_WarPetCompound.AddDroBoxId(builder, DroBoxId);
    FB_WarPetCompound.AddItemCount(builder, ItemCount);
    FB_WarPetCompound.AddQuality(builder, Quality);
    FB_WarPetCompound.AddName(builder, Name);
    FB_WarPetCompound.AddId(builder, Id);
    return FB_WarPetCompound.EndFB_WarPetCompound(builder);
  }

  public static void StartFB_WarPetCompound(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(3, ItemCount, 0); }
  public static void AddDroBoxId(FlatBufferBuilder builder, int DroBoxId) { builder.AddInt(4, DroBoxId, 0); }
  public static void AddDroBoxIdSecond(FlatBufferBuilder builder, int DroBoxIdSecond) { builder.AddInt(5, DroBoxIdSecond, 0); }
  public static void AddSkillTabTipStrId(FlatBufferBuilder builder, int SkillTabTipStrId) { builder.AddInt(6, SkillTabTipStrId, 0); }
  public static void AddTianFuTabTipStrId(FlatBufferBuilder builder, int TianFuTabTipStrId) { builder.AddInt(7, TianFuTabTipStrId, 0); }
  public static void AddSkillSubTabStrId(FlatBufferBuilder builder, int SkillSubTabStrId) { builder.AddInt(8, SkillSubTabStrId, 0); }
  public static void AddTianFuSubTabStrId(FlatBufferBuilder builder, int TianFuSubTabStrId) { builder.AddInt(9, TianFuSubTabStrId, 0); }
  public static Offset<FB_WarPetCompound> EndFB_WarPetCompound(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetCompound>(o);
  }
};

public sealed class FB_WarPetCompoundContainer : Table {
  public static FB_WarPetCompoundContainer GetRootAsFB_WarPetCompoundContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetCompoundContainer(_bb, new FB_WarPetCompoundContainer()); }
  public static FB_WarPetCompoundContainer GetRootAsFB_WarPetCompoundContainer(ByteBuffer _bb, FB_WarPetCompoundContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetCompoundContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetCompoundContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetCompound GetItems(int j) { return GetItems(new FB_WarPetCompound(), j); }
  public FB_WarPetCompound GetItems(FB_WarPetCompound obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetCompoundContainer> CreateFB_WarPetCompoundContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetCompoundContainer.AddItems(builder, items);
    return FB_WarPetCompoundContainer.EndFB_WarPetCompoundContainer(builder);
  }

  public static void StartFB_WarPetCompoundContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetCompound>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetCompoundContainer> EndFB_WarPetCompoundContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetCompoundContainer>(o);
  }
  public static void FinishFB_WarPetCompoundContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetCompoundContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
