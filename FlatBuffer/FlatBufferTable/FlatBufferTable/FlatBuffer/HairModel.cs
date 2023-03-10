// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HairModel : Table {
  public static FB_HairModel GetRootAsFB_HairModel(ByteBuffer _bb) { return GetRootAsFB_HairModel(_bb, new FB_HairModel()); }
  public static FB_HairModel GetRootAsFB_HairModel(ByteBuffer _bb, FB_HairModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HairModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ResPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public float Scale { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int ModelType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetDeyColorList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DeyColorListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HairModel> CreateFB_HairModel(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset ResPath = default(StringOffset),
      float Scale = 0,
      int ModelType = -1,
      VectorOffset DeyColorList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_HairModel.AddDeyColorList(builder, DeyColorList);
    FB_HairModel.AddModelType(builder, ModelType);
    FB_HairModel.AddScale(builder, Scale);
    FB_HairModel.AddResPath(builder, ResPath);
    FB_HairModel.AddName(builder, Name);
    FB_HairModel.AddId(builder, Id);
    return FB_HairModel.EndFB_HairModel(builder);
  }

  public static void StartFB_HairModel(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddResPath(FlatBufferBuilder builder, StringOffset ResPathOffset) { builder.AddOffset(2, ResPathOffset.Value, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(3, Scale, 0); }
  public static void AddModelType(FlatBufferBuilder builder, int ModelType) { builder.AddInt(4, ModelType, -1); }
  public static void AddDeyColorList(FlatBufferBuilder builder, VectorOffset DeyColorListOffset) { builder.AddOffset(5, DeyColorListOffset.Value, 0); }
  public static VectorOffset CreateDeyColorListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDeyColorListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HairModel> EndFB_HairModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HairModel>(o);
  }
};

public sealed class FB_HairModelContainer : Table {
  public static FB_HairModelContainer GetRootAsFB_HairModelContainer(ByteBuffer _bb) { return GetRootAsFB_HairModelContainer(_bb, new FB_HairModelContainer()); }
  public static FB_HairModelContainer GetRootAsFB_HairModelContainer(ByteBuffer _bb, FB_HairModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HairModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HairModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HairModel GetItems(int j) { return GetItems(new FB_HairModel(), j); }
  public FB_HairModel GetItems(FB_HairModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HairModelContainer> CreateFB_HairModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HairModelContainer.AddItems(builder, items);
    return FB_HairModelContainer.EndFB_HairModelContainer(builder);
  }

  public static void StartFB_HairModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HairModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HairModelContainer> EndFB_HairModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HairModelContainer>(o);
  }
  public static void FinishFB_HairModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_HairModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
