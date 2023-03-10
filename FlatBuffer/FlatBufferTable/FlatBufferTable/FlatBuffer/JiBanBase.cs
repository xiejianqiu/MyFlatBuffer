// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiBanBase : Table {
  public static FB_JiBanBase GetRootAsFB_JiBanBase(ByteBuffer _bb) { return GetRootAsFB_JiBanBase(_bb, new FB_JiBanBase()); }
  public static FB_JiBanBase GetRootAsFB_JiBanBase(ByteBuffer _bb, FB_JiBanBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiBanBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Tips { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int InitQuality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCardIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CardIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiBanBase> CreateFB_JiBanBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Tips = default(StringOffset),
      int InitQuality = -1,
      VectorOffset CardIDList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JiBanBase.AddCardIDList(builder, CardIDList);
    FB_JiBanBase.AddInitQuality(builder, InitQuality);
    FB_JiBanBase.AddTips(builder, Tips);
    FB_JiBanBase.AddName(builder, Name);
    FB_JiBanBase.AddID(builder, ID);
    return FB_JiBanBase.EndFB_JiBanBase(builder);
  }

  public static void StartFB_JiBanBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(2, TipsOffset.Value, 0); }
  public static void AddInitQuality(FlatBufferBuilder builder, int InitQuality) { builder.AddInt(3, InitQuality, -1); }
  public static void AddCardIDList(FlatBufferBuilder builder, VectorOffset CardIDListOffset) { builder.AddOffset(4, CardIDListOffset.Value, 0); }
  public static VectorOffset CreateCardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiBanBase> EndFB_JiBanBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiBanBase>(o);
  }
};

public sealed class FB_JiBanBaseContainer : Table {
  public static FB_JiBanBaseContainer GetRootAsFB_JiBanBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JiBanBaseContainer(_bb, new FB_JiBanBaseContainer()); }
  public static FB_JiBanBaseContainer GetRootAsFB_JiBanBaseContainer(ByteBuffer _bb, FB_JiBanBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiBanBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiBanBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiBanBase GetItems(int j) { return GetItems(new FB_JiBanBase(), j); }
  public FB_JiBanBase GetItems(FB_JiBanBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiBanBaseContainer> CreateFB_JiBanBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiBanBaseContainer.AddItems(builder, items);
    return FB_JiBanBaseContainer.EndFB_JiBanBaseContainer(builder);
  }

  public static void StartFB_JiBanBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiBanBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiBanBaseContainer> EndFB_JiBanBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiBanBaseContainer>(o);
  }
  public static void FinishFB_JiBanBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiBanBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
