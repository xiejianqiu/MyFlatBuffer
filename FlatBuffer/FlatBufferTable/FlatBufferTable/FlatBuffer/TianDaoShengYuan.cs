// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TianDaoShengYuan : Table {
  public static FB_TianDaoShengYuan GetRootAsFB_TianDaoShengYuan(ByteBuffer _bb) { return GetRootAsFB_TianDaoShengYuan(_bb, new FB_TianDaoShengYuan()); }
  public static FB_TianDaoShengYuan GetRootAsFB_TianDaoShengYuan(ByteBuffer _bb, FB_TianDaoShengYuan obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TianDaoShengYuan __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetLabelList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int LabelListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public string Sprite { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int DropBoxS { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxA { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MFIDS { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MFIDA { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LabelStrId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_TianDaoShengYuan> CreateFB_TianDaoShengYuan(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset LabelList = default(VectorOffset),
      StringOffset Sprite = default(StringOffset),
      int DropBox_s = -1,
      int DropBox_a = -1,
      int MFID_S = -1,
      int MFID_A = -1,
      int LabelStrId = -1) {
    builder.StartObject(9);
    FB_TianDaoShengYuan.AddLabelStrId(builder, LabelStrId);
    FB_TianDaoShengYuan.AddMFIDA(builder, MFID_A);
    FB_TianDaoShengYuan.AddMFIDS(builder, MFID_S);
    FB_TianDaoShengYuan.AddDropBoxA(builder, DropBox_a);
    FB_TianDaoShengYuan.AddDropBoxS(builder, DropBox_s);
    FB_TianDaoShengYuan.AddSprite(builder, Sprite);
    FB_TianDaoShengYuan.AddLabelList(builder, LabelList);
    FB_TianDaoShengYuan.AddName(builder, Name);
    FB_TianDaoShengYuan.AddID(builder, ID);
    return FB_TianDaoShengYuan.EndFB_TianDaoShengYuan(builder);
  }

  public static void StartFB_TianDaoShengYuan(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLabelList(FlatBufferBuilder builder, VectorOffset LabelListOffset) { builder.AddOffset(2, LabelListOffset.Value, 0); }
  public static VectorOffset CreateLabelListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartLabelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSprite(FlatBufferBuilder builder, StringOffset SpriteOffset) { builder.AddOffset(3, SpriteOffset.Value, 0); }
  public static void AddDropBoxS(FlatBufferBuilder builder, int DropBoxS) { builder.AddInt(4, DropBoxS, -1); }
  public static void AddDropBoxA(FlatBufferBuilder builder, int DropBoxA) { builder.AddInt(5, DropBoxA, -1); }
  public static void AddMFIDS(FlatBufferBuilder builder, int MFIDS) { builder.AddInt(6, MFIDS, -1); }
  public static void AddMFIDA(FlatBufferBuilder builder, int MFIDA) { builder.AddInt(7, MFIDA, -1); }
  public static void AddLabelStrId(FlatBufferBuilder builder, int LabelStrId) { builder.AddInt(8, LabelStrId, -1); }
  public static Offset<FB_TianDaoShengYuan> EndFB_TianDaoShengYuan(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianDaoShengYuan>(o);
  }
};

public sealed class FB_TianDaoShengYuanContainer : Table {
  public static FB_TianDaoShengYuanContainer GetRootAsFB_TianDaoShengYuanContainer(ByteBuffer _bb) { return GetRootAsFB_TianDaoShengYuanContainer(_bb, new FB_TianDaoShengYuanContainer()); }
  public static FB_TianDaoShengYuanContainer GetRootAsFB_TianDaoShengYuanContainer(ByteBuffer _bb, FB_TianDaoShengYuanContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TianDaoShengYuanContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TianDaoShengYuanContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TianDaoShengYuan GetItems(int j) { return GetItems(new FB_TianDaoShengYuan(), j); }
  public FB_TianDaoShengYuan GetItems(FB_TianDaoShengYuan obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TianDaoShengYuanContainer> CreateFB_TianDaoShengYuanContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TianDaoShengYuanContainer.AddItems(builder, items);
    return FB_TianDaoShengYuanContainer.EndFB_TianDaoShengYuanContainer(builder);
  }

  public static void StartFB_TianDaoShengYuanContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TianDaoShengYuan>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TianDaoShengYuanContainer> EndFB_TianDaoShengYuanContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TianDaoShengYuanContainer>(o);
  }
  public static void FinishFB_TianDaoShengYuanContainerBuffer(FlatBufferBuilder builder, Offset<FB_TianDaoShengYuanContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
