// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TipsPreview : Table {
  public static FB_TipsPreview GetRootAsFB_TipsPreview(ByteBuffer _bb) { return GetRootAsFB_TipsPreview(_bb, new FB_TipsPreview()); }
  public static FB_TipsPreview GetRootAsFB_TipsPreview(ByteBuffer _bb, FB_TipsPreview obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TipsPreview __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UIModelId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CharModelId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WomanUIModelId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WomanCharModelId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool PlayTweenAnim { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_TipsPreview> CreateFB_TipsPreview(FlatBufferBuilder builder,
      int Id = 0,
      int Type = 0,
      int UIModelId = -1,
      int CharModelId = -1,
      int WomanUIModelId = -1,
      int WomanCharModelId = -1,
      bool PlayTweenAnim = true) {
    builder.StartObject(7);
    FB_TipsPreview.AddWomanCharModelId(builder, WomanCharModelId);
    FB_TipsPreview.AddWomanUIModelId(builder, WomanUIModelId);
    FB_TipsPreview.AddCharModelId(builder, CharModelId);
    FB_TipsPreview.AddUIModelId(builder, UIModelId);
    FB_TipsPreview.AddType(builder, Type);
    FB_TipsPreview.AddId(builder, Id);
    FB_TipsPreview.AddPlayTweenAnim(builder, PlayTweenAnim);
    return FB_TipsPreview.EndFB_TipsPreview(builder);
  }

  public static void StartFB_TipsPreview(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, 0); }
  public static void AddUIModelId(FlatBufferBuilder builder, int UIModelId) { builder.AddInt(2, UIModelId, -1); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(3, CharModelId, -1); }
  public static void AddWomanUIModelId(FlatBufferBuilder builder, int WomanUIModelId) { builder.AddInt(4, WomanUIModelId, -1); }
  public static void AddWomanCharModelId(FlatBufferBuilder builder, int WomanCharModelId) { builder.AddInt(5, WomanCharModelId, -1); }
  public static void AddPlayTweenAnim(FlatBufferBuilder builder, bool PlayTweenAnim) { builder.AddBool(6, PlayTweenAnim, true); }
  public static Offset<FB_TipsPreview> EndFB_TipsPreview(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TipsPreview>(o);
  }
};

public sealed class FB_TipsPreviewContainer : Table {
  public static FB_TipsPreviewContainer GetRootAsFB_TipsPreviewContainer(ByteBuffer _bb) { return GetRootAsFB_TipsPreviewContainer(_bb, new FB_TipsPreviewContainer()); }
  public static FB_TipsPreviewContainer GetRootAsFB_TipsPreviewContainer(ByteBuffer _bb, FB_TipsPreviewContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TipsPreviewContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TipsPreviewContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TipsPreview GetItems(int j) { return GetItems(new FB_TipsPreview(), j); }
  public FB_TipsPreview GetItems(FB_TipsPreview obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TipsPreviewContainer> CreateFB_TipsPreviewContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TipsPreviewContainer.AddItems(builder, items);
    return FB_TipsPreviewContainer.EndFB_TipsPreviewContainer(builder);
  }

  public static void StartFB_TipsPreviewContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TipsPreview>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TipsPreviewContainer> EndFB_TipsPreviewContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TipsPreviewContainer>(o);
  }
  public static void FinishFB_TipsPreviewContainerBuffer(FlatBufferBuilder builder, Offset<FB_TipsPreviewContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
