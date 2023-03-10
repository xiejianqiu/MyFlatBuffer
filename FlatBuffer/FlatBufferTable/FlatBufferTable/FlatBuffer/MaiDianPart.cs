// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MaiDianPart : Table {
  public static FB_MaiDianPart GetRootAsFB_MaiDianPart(ByteBuffer _bb) { return GetRootAsFB_MaiDianPart(_bb, new FB_MaiDianPart()); }
  public static FB_MaiDianPart GetRootAsFB_MaiDianPart(ByteBuffer _bb, FB_MaiDianPart obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MaiDianPart __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StateLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItemID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PayItem { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttributeIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttributeIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttributeValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttributeValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MaiDianPart> CreateFB_MaiDianPart(FlatBufferBuilder builder,
      int ID = 0,
      int StateLevel = -1,
      int PayItemID = -1,
      int PayItem = -1,
      VectorOffset AttributeIDList = default(VectorOffset),
      VectorOffset AttributeValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_MaiDianPart.AddAttributeValueList(builder, AttributeValueList);
    FB_MaiDianPart.AddAttributeIDList(builder, AttributeIDList);
    FB_MaiDianPart.AddPayItem(builder, PayItem);
    FB_MaiDianPart.AddPayItemID(builder, PayItemID);
    FB_MaiDianPart.AddStateLevel(builder, StateLevel);
    FB_MaiDianPart.AddID(builder, ID);
    return FB_MaiDianPart.EndFB_MaiDianPart(builder);
  }

  public static void StartFB_MaiDianPart(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStateLevel(FlatBufferBuilder builder, int StateLevel) { builder.AddInt(1, StateLevel, -1); }
  public static void AddPayItemID(FlatBufferBuilder builder, int PayItemID) { builder.AddInt(2, PayItemID, -1); }
  public static void AddPayItem(FlatBufferBuilder builder, int PayItem) { builder.AddInt(3, PayItem, -1); }
  public static void AddAttributeIDList(FlatBufferBuilder builder, VectorOffset AttributeIDListOffset) { builder.AddOffset(4, AttributeIDListOffset.Value, 0); }
  public static VectorOffset CreateAttributeIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttributeIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttributeValueList(FlatBufferBuilder builder, VectorOffset AttributeValueListOffset) { builder.AddOffset(5, AttributeValueListOffset.Value, 0); }
  public static VectorOffset CreateAttributeValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttributeValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MaiDianPart> EndFB_MaiDianPart(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianPart>(o);
  }
};

public sealed class FB_MaiDianPartContainer : Table {
  public static FB_MaiDianPartContainer GetRootAsFB_MaiDianPartContainer(ByteBuffer _bb) { return GetRootAsFB_MaiDianPartContainer(_bb, new FB_MaiDianPartContainer()); }
  public static FB_MaiDianPartContainer GetRootAsFB_MaiDianPartContainer(ByteBuffer _bb, FB_MaiDianPartContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MaiDianPartContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MaiDianPartContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MaiDianPart GetItems(int j) { return GetItems(new FB_MaiDianPart(), j); }
  public FB_MaiDianPart GetItems(FB_MaiDianPart obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MaiDianPartContainer> CreateFB_MaiDianPartContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MaiDianPartContainer.AddItems(builder, items);
    return FB_MaiDianPartContainer.EndFB_MaiDianPartContainer(builder);
  }

  public static void StartFB_MaiDianPartContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MaiDianPart>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MaiDianPartContainer> EndFB_MaiDianPartContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianPartContainer>(o);
  }
  public static void FinishFB_MaiDianPartContainerBuffer(FlatBufferBuilder builder, Offset<FB_MaiDianPartContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
