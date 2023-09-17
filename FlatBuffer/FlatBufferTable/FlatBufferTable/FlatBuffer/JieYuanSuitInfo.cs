// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JieYuanSuitInfo : Table {
  public static FB_JieYuanSuitInfo GetRootAsFB_JieYuanSuitInfo(ByteBuffer _bb) { return GetRootAsFB_JieYuanSuitInfo(_bb, new FB_JieYuanSuitInfo()); }
  public static FB_JieYuanSuitInfo GetRootAsFB_JieYuanSuitInfo(ByteBuffer _bb, FB_JieYuanSuitInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JieYuanSuitInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quailty { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActiveCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSuitIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SuitIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSuitInfo> CreateFB_JieYuanSuitInfo(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Quailty = 0,
      int ActiveCount = -1,
      VectorOffset SuitIDList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JieYuanSuitInfo.AddSuitIDList(builder, SuitIDList);
    FB_JieYuanSuitInfo.AddActiveCount(builder, ActiveCount);
    FB_JieYuanSuitInfo.AddQuailty(builder, Quailty);
    FB_JieYuanSuitInfo.AddName(builder, Name);
    FB_JieYuanSuitInfo.AddID(builder, ID);
    return FB_JieYuanSuitInfo.EndFB_JieYuanSuitInfo(builder);
  }

  public static void StartFB_JieYuanSuitInfo(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuailty(FlatBufferBuilder builder, int Quailty) { builder.AddInt(2, Quailty, 0); }
  public static void AddActiveCount(FlatBufferBuilder builder, int ActiveCount) { builder.AddInt(3, ActiveCount, -1); }
  public static void AddSuitIDList(FlatBufferBuilder builder, VectorOffset SuitIDListOffset) { builder.AddOffset(4, SuitIDListOffset.Value, 0); }
  public static VectorOffset CreateSuitIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSuitIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSuitInfo> EndFB_JieYuanSuitInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSuitInfo>(o);
  }
};

public sealed class FB_JieYuanSuitInfoContainer : Table {
  public static FB_JieYuanSuitInfoContainer GetRootAsFB_JieYuanSuitInfoContainer(ByteBuffer _bb) { return GetRootAsFB_JieYuanSuitInfoContainer(_bb, new FB_JieYuanSuitInfoContainer()); }
  public static FB_JieYuanSuitInfoContainer GetRootAsFB_JieYuanSuitInfoContainer(ByteBuffer _bb, FB_JieYuanSuitInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JieYuanSuitInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JieYuanSuitInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JieYuanSuitInfo GetItems(int j) { return GetItems(new FB_JieYuanSuitInfo(), j); }
  public FB_JieYuanSuitInfo GetItems(FB_JieYuanSuitInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JieYuanSuitInfoContainer> CreateFB_JieYuanSuitInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JieYuanSuitInfoContainer.AddItems(builder, items);
    return FB_JieYuanSuitInfoContainer.EndFB_JieYuanSuitInfoContainer(builder);
  }

  public static void StartFB_JieYuanSuitInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JieYuanSuitInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JieYuanSuitInfoContainer> EndFB_JieYuanSuitInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JieYuanSuitInfoContainer>(o);
  }
  public static void FinishFB_JieYuanSuitInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_JieYuanSuitInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
