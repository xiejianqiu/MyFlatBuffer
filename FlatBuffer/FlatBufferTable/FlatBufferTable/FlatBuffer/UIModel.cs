// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_UIModel : Table {
  public static FB_UIModel GetRootAsFB_UIModel(ByteBuffer _bb) { return GetRootAsFB_UIModel(_bb, new FB_UIModel()); }
  public static FB_UIModel GetRootAsFB_UIModel(ByteBuffer _bb, FB_UIModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_UIModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AnimaId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float XOffSet { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YOffSet { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZOffset { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float XRotation { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float YRotation { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ZRotation { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }

  public static Offset<FB_UIModel> CreateFB_UIModel(FlatBufferBuilder builder,
      int Id = 0,
      int AnimaId = 0,
      float XOffSet = 0,
      float YOffSet = 0,
      float ZOffset = 0,
      float XRotation = 0,
      float YRotation = 0,
      float ZRotation = 0,
      float Scale = 1) {
    builder.StartObject(9);
    FB_UIModel.AddScale(builder, Scale);
    FB_UIModel.AddZRotation(builder, ZRotation);
    FB_UIModel.AddYRotation(builder, YRotation);
    FB_UIModel.AddXRotation(builder, XRotation);
    FB_UIModel.AddZOffset(builder, ZOffset);
    FB_UIModel.AddYOffSet(builder, YOffSet);
    FB_UIModel.AddXOffSet(builder, XOffSet);
    FB_UIModel.AddAnimaId(builder, AnimaId);
    FB_UIModel.AddId(builder, Id);
    return FB_UIModel.EndFB_UIModel(builder);
  }

  public static void StartFB_UIModel(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddAnimaId(FlatBufferBuilder builder, int AnimaId) { builder.AddInt(1, AnimaId, 0); }
  public static void AddXOffSet(FlatBufferBuilder builder, float XOffSet) { builder.AddFloat(2, XOffSet, 0); }
  public static void AddYOffSet(FlatBufferBuilder builder, float YOffSet) { builder.AddFloat(3, YOffSet, 0); }
  public static void AddZOffset(FlatBufferBuilder builder, float ZOffset) { builder.AddFloat(4, ZOffset, 0); }
  public static void AddXRotation(FlatBufferBuilder builder, float XRotation) { builder.AddFloat(5, XRotation, 0); }
  public static void AddYRotation(FlatBufferBuilder builder, float YRotation) { builder.AddFloat(6, YRotation, 0); }
  public static void AddZRotation(FlatBufferBuilder builder, float ZRotation) { builder.AddFloat(7, ZRotation, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(8, Scale, 1); }
  public static Offset<FB_UIModel> EndFB_UIModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UIModel>(o);
  }
};

public sealed class FB_UIModelContainer : Table {
  public static FB_UIModelContainer GetRootAsFB_UIModelContainer(ByteBuffer _bb) { return GetRootAsFB_UIModelContainer(_bb, new FB_UIModelContainer()); }
  public static FB_UIModelContainer GetRootAsFB_UIModelContainer(ByteBuffer _bb, FB_UIModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_UIModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_UIModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_UIModel GetItems(int j) { return GetItems(new FB_UIModel(), j); }
  public FB_UIModel GetItems(FB_UIModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_UIModelContainer> CreateFB_UIModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_UIModelContainer.AddItems(builder, items);
    return FB_UIModelContainer.EndFB_UIModelContainer(builder);
  }

  public static void StartFB_UIModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_UIModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_UIModelContainer> EndFB_UIModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UIModelContainer>(o);
  }
  public static void FinishFB_UIModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_UIModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
