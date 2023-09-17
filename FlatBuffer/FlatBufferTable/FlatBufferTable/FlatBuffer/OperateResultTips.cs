// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OperateResultTips : Table {
  public static FB_OperateResultTips GetRootAsFB_OperateResultTips(ByteBuffer _bb) { return GetRootAsFB_OperateResultTips(_bb, new FB_OperateResultTips()); }
  public static FB_OperateResultTips GetRootAsFB_OperateResultTips(ByteBuffer _bb, FB_OperateResultTips obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OperateResultTips __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Tips { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_OperateResultTips> CreateFB_OperateResultTips(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Tips = default(StringOffset)) {
    builder.StartObject(2);
    FB_OperateResultTips.AddTips(builder, Tips);
    FB_OperateResultTips.AddId(builder, Id);
    return FB_OperateResultTips.EndFB_OperateResultTips(builder);
  }

  public static void StartFB_OperateResultTips(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(1, TipsOffset.Value, 0); }
  public static Offset<FB_OperateResultTips> EndFB_OperateResultTips(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperateResultTips>(o);
  }
};

public sealed class FB_OperateResultTipsContainer : Table {
  public static FB_OperateResultTipsContainer GetRootAsFB_OperateResultTipsContainer(ByteBuffer _bb) { return GetRootAsFB_OperateResultTipsContainer(_bb, new FB_OperateResultTipsContainer()); }
  public static FB_OperateResultTipsContainer GetRootAsFB_OperateResultTipsContainer(ByteBuffer _bb, FB_OperateResultTipsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OperateResultTipsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OperateResultTipsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OperateResultTips GetItems(int j) { return GetItems(new FB_OperateResultTips(), j); }
  public FB_OperateResultTips GetItems(FB_OperateResultTips obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OperateResultTipsContainer> CreateFB_OperateResultTipsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OperateResultTipsContainer.AddItems(builder, items);
    return FB_OperateResultTipsContainer.EndFB_OperateResultTipsContainer(builder);
  }

  public static void StartFB_OperateResultTipsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OperateResultTips>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OperateResultTipsContainer> EndFB_OperateResultTipsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OperateResultTipsContainer>(o);
  }
  public static void FinishFB_OperateResultTipsContainerBuffer(FlatBufferBuilder builder, Offset<FB_OperateResultTipsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
