// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GodWordBase : Table {
  public static FB_GodWordBase GetRootAsFB_GodWordBase(ByteBuffer _bb) { return GetRootAsFB_GodWordBase(_bb, new FB_GodWordBase()); }
  public static FB_GodWordBase GetRootAsFB_GodWordBase(ByteBuffer _bb, FB_GodWordBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GodWordBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int HintID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DiamondCompoundLimit { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneMissionId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GodWordBase> CreateFB_GodWordBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int HintID = -1,
      int AdvancedLimit = -1,
      int EquipLevel = -1,
      int DiamondCompoundLimit = -1,
      int CopySceneID = -1,
      int CopySceneMissionId = -1) {
    builder.StartObject(8);
    FB_GodWordBase.AddCopySceneMissionId(builder, CopySceneMissionId);
    FB_GodWordBase.AddCopySceneID(builder, CopySceneID);
    FB_GodWordBase.AddDiamondCompoundLimit(builder, DiamondCompoundLimit);
    FB_GodWordBase.AddEquipLevel(builder, EquipLevel);
    FB_GodWordBase.AddAdvancedLimit(builder, AdvancedLimit);
    FB_GodWordBase.AddHintID(builder, HintID);
    FB_GodWordBase.AddName(builder, Name);
    FB_GodWordBase.AddId(builder, Id);
    return FB_GodWordBase.EndFB_GodWordBase(builder);
  }

  public static void StartFB_GodWordBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddHintID(FlatBufferBuilder builder, int HintID) { builder.AddInt(2, HintID, -1); }
  public static void AddAdvancedLimit(FlatBufferBuilder builder, int AdvancedLimit) { builder.AddInt(3, AdvancedLimit, -1); }
  public static void AddEquipLevel(FlatBufferBuilder builder, int EquipLevel) { builder.AddInt(4, EquipLevel, -1); }
  public static void AddDiamondCompoundLimit(FlatBufferBuilder builder, int DiamondCompoundLimit) { builder.AddInt(5, DiamondCompoundLimit, -1); }
  public static void AddCopySceneID(FlatBufferBuilder builder, int CopySceneID) { builder.AddInt(6, CopySceneID, -1); }
  public static void AddCopySceneMissionId(FlatBufferBuilder builder, int CopySceneMissionId) { builder.AddInt(7, CopySceneMissionId, -1); }
  public static Offset<FB_GodWordBase> EndFB_GodWordBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWordBase>(o);
  }
};

public sealed class FB_GodWordBaseContainer : Table {
  public static FB_GodWordBaseContainer GetRootAsFB_GodWordBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GodWordBaseContainer(_bb, new FB_GodWordBaseContainer()); }
  public static FB_GodWordBaseContainer GetRootAsFB_GodWordBaseContainer(ByteBuffer _bb, FB_GodWordBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GodWordBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GodWordBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GodWordBase GetItems(int j) { return GetItems(new FB_GodWordBase(), j); }
  public FB_GodWordBase GetItems(FB_GodWordBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWordBaseContainer> CreateFB_GodWordBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GodWordBaseContainer.AddItems(builder, items);
    return FB_GodWordBaseContainer.EndFB_GodWordBaseContainer(builder);
  }

  public static void StartFB_GodWordBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GodWordBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWordBaseContainer> EndFB_GodWordBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWordBaseContainer>(o);
  }
  public static void FinishFB_GodWordBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GodWordBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
