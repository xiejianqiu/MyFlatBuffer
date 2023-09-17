// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityType : Table {
  public static FB_ActivityType GetRootAsFB_ActivityType(ByteBuffer _bb) { return GetRootAsFB_ActivityType(_bb, new FB_ActivityType()); }
  public static FB_ActivityType GetRootAsFB_ActivityType(ByteBuffer _bb, FB_ActivityType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetActiveIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ActiveIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityType> CreateFB_ActivityType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset ActiveIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ActivityType.AddActiveIDList(builder, ActiveIDList);
    FB_ActivityType.AddName(builder, Name);
    FB_ActivityType.AddId(builder, Id);
    return FB_ActivityType.EndFB_ActivityType(builder);
  }

  public static void StartFB_ActivityType(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddActiveIDList(FlatBufferBuilder builder, VectorOffset ActiveIDListOffset) { builder.AddOffset(2, ActiveIDListOffset.Value, 0); }
  public static VectorOffset CreateActiveIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartActiveIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityType> EndFB_ActivityType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityType>(o);
  }
};

public sealed class FB_ActivityTypeContainer : Table {
  public static FB_ActivityTypeContainer GetRootAsFB_ActivityTypeContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityTypeContainer(_bb, new FB_ActivityTypeContainer()); }
  public static FB_ActivityTypeContainer GetRootAsFB_ActivityTypeContainer(ByteBuffer _bb, FB_ActivityTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityType GetItems(int j) { return GetItems(new FB_ActivityType(), j); }
  public FB_ActivityType GetItems(FB_ActivityType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityTypeContainer> CreateFB_ActivityTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityTypeContainer.AddItems(builder, items);
    return FB_ActivityTypeContainer.EndFB_ActivityTypeContainer(builder);
  }

  public static void StartFB_ActivityTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityTypeContainer> EndFB_ActivityTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityTypeContainer>(o);
  }
  public static void FinishFB_ActivityTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
