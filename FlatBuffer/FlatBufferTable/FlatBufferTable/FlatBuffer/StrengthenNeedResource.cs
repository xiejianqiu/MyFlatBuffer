// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrengthenNeedResource : Table {
  public static FB_StrengthenNeedResource GetRootAsFB_StrengthenNeedResource(ByteBuffer _bb) { return GetRootAsFB_StrengthenNeedResource(_bb, new FB_StrengthenNeedResource()); }
  public static FB_StrengthenNeedResource GetRootAsFB_StrengthenNeedResource(ByteBuffer _bb, FB_StrengthenNeedResource obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrengthenNeedResource __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Icon { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetDescribeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DescribeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int FuncBaseID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StrengthenNeedResource> CreateFB_StrengthenNeedResource(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Icon = -1,
      VectorOffset DescribeList = default(VectorOffset),
      int FuncBaseID = -1) {
    builder.StartObject(5);
    FB_StrengthenNeedResource.AddFuncBaseID(builder, FuncBaseID);
    FB_StrengthenNeedResource.AddDescribeList(builder, DescribeList);
    FB_StrengthenNeedResource.AddIcon(builder, Icon);
    FB_StrengthenNeedResource.AddName(builder, Name);
    FB_StrengthenNeedResource.AddID(builder, ID);
    return FB_StrengthenNeedResource.EndFB_StrengthenNeedResource(builder);
  }

  public static void StartFB_StrengthenNeedResource(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, int Icon) { builder.AddInt(2, Icon, -1); }
  public static void AddDescribeList(FlatBufferBuilder builder, VectorOffset DescribeListOffset) { builder.AddOffset(3, DescribeListOffset.Value, 0); }
  public static VectorOffset CreateDescribeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDescribeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFuncBaseID(FlatBufferBuilder builder, int FuncBaseID) { builder.AddInt(4, FuncBaseID, -1); }
  public static Offset<FB_StrengthenNeedResource> EndFB_StrengthenNeedResource(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenNeedResource>(o);
  }
};

public sealed class FB_StrengthenNeedResourceContainer : Table {
  public static FB_StrengthenNeedResourceContainer GetRootAsFB_StrengthenNeedResourceContainer(ByteBuffer _bb) { return GetRootAsFB_StrengthenNeedResourceContainer(_bb, new FB_StrengthenNeedResourceContainer()); }
  public static FB_StrengthenNeedResourceContainer GetRootAsFB_StrengthenNeedResourceContainer(ByteBuffer _bb, FB_StrengthenNeedResourceContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrengthenNeedResourceContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrengthenNeedResourceContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrengthenNeedResource GetItems(int j) { return GetItems(new FB_StrengthenNeedResource(), j); }
  public FB_StrengthenNeedResource GetItems(FB_StrengthenNeedResource obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrengthenNeedResourceContainer> CreateFB_StrengthenNeedResourceContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrengthenNeedResourceContainer.AddItems(builder, items);
    return FB_StrengthenNeedResourceContainer.EndFB_StrengthenNeedResourceContainer(builder);
  }

  public static void StartFB_StrengthenNeedResourceContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrengthenNeedResource>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrengthenNeedResourceContainer> EndFB_StrengthenNeedResourceContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrengthenNeedResourceContainer>(o);
  }
  public static void FinishFB_StrengthenNeedResourceContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrengthenNeedResourceContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
