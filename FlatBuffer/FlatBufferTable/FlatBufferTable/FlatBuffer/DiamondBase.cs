// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DiamondBase : Table {
  public static FB_DiamondBase GetRootAsFB_DiamondBase(ByteBuffer _bb) { return GetRootAsFB_DiamondBase(_bb, new FB_DiamondBase()); }
  public static FB_DiamondBase GetRootAsFB_DiamondBase(ByteBuffer _bb, FB_DiamondBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DiamondBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SetType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MountType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DiamondLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttributeIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttributeIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttributeValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttributeValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int StrID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Compound { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyConsume { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsOpen { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_DiamondBase> CreateFB_DiamondBase(FlatBufferBuilder builder,
      int Id = 0,
      int SetType = -1,
      int MountType = -1,
      int DiamondLevel = -1,
      VectorOffset AttributeIDList = default(VectorOffset),
      VectorOffset AttributeValueList = default(VectorOffset),
      int StrID = -1,
      int Compound = -1,
      int MoneyConsume = -1,
      bool IsOpen = false) {
    builder.StartObject(10);
    FB_DiamondBase.AddMoneyConsume(builder, MoneyConsume);
    FB_DiamondBase.AddCompound(builder, Compound);
    FB_DiamondBase.AddStrID(builder, StrID);
    FB_DiamondBase.AddAttributeValueList(builder, AttributeValueList);
    FB_DiamondBase.AddAttributeIDList(builder, AttributeIDList);
    FB_DiamondBase.AddDiamondLevel(builder, DiamondLevel);
    FB_DiamondBase.AddMountType(builder, MountType);
    FB_DiamondBase.AddSetType(builder, SetType);
    FB_DiamondBase.AddId(builder, Id);
    FB_DiamondBase.AddIsOpen(builder, IsOpen);
    return FB_DiamondBase.EndFB_DiamondBase(builder);
  }

  public static void StartFB_DiamondBase(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSetType(FlatBufferBuilder builder, int SetType) { builder.AddInt(1, SetType, -1); }
  public static void AddMountType(FlatBufferBuilder builder, int MountType) { builder.AddInt(2, MountType, -1); }
  public static void AddDiamondLevel(FlatBufferBuilder builder, int DiamondLevel) { builder.AddInt(3, DiamondLevel, -1); }
  public static void AddAttributeIDList(FlatBufferBuilder builder, VectorOffset AttributeIDListOffset) { builder.AddOffset(4, AttributeIDListOffset.Value, 0); }
  public static VectorOffset CreateAttributeIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttributeIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttributeValueList(FlatBufferBuilder builder, VectorOffset AttributeValueListOffset) { builder.AddOffset(5, AttributeValueListOffset.Value, 0); }
  public static VectorOffset CreateAttributeValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttributeValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStrID(FlatBufferBuilder builder, int StrID) { builder.AddInt(6, StrID, -1); }
  public static void AddCompound(FlatBufferBuilder builder, int Compound) { builder.AddInt(7, Compound, -1); }
  public static void AddMoneyConsume(FlatBufferBuilder builder, int MoneyConsume) { builder.AddInt(8, MoneyConsume, -1); }
  public static void AddIsOpen(FlatBufferBuilder builder, bool IsOpen) { builder.AddBool(9, IsOpen, false); }
  public static Offset<FB_DiamondBase> EndFB_DiamondBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondBase>(o);
  }
};

public sealed class FB_DiamondBaseContainer : Table {
  public static FB_DiamondBaseContainer GetRootAsFB_DiamondBaseContainer(ByteBuffer _bb) { return GetRootAsFB_DiamondBaseContainer(_bb, new FB_DiamondBaseContainer()); }
  public static FB_DiamondBaseContainer GetRootAsFB_DiamondBaseContainer(ByteBuffer _bb, FB_DiamondBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DiamondBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DiamondBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DiamondBase GetItems(int j) { return GetItems(new FB_DiamondBase(), j); }
  public FB_DiamondBase GetItems(FB_DiamondBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DiamondBaseContainer> CreateFB_DiamondBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DiamondBaseContainer.AddItems(builder, items);
    return FB_DiamondBaseContainer.EndFB_DiamondBaseContainer(builder);
  }

  public static void StartFB_DiamondBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DiamondBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DiamondBaseContainer> EndFB_DiamondBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DiamondBaseContainer>(o);
  }
  public static void FinishFB_DiamondBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_DiamondBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
