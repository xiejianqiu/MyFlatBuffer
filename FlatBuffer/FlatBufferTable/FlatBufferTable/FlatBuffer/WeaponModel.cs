// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WeaponModel : Table {
  public static FB_WeaponModel GetRootAsFB_WeaponModel(ByteBuffer _bb) { return GetRootAsFB_WeaponModel(_bb, new FB_WeaponModel()); }
  public static FB_WeaponModel GetRootAsFB_WeaponModel(ByteBuffer _bb, FB_WeaponModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WeaponModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetResPathList(int j) { int o = __offset(6); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int ResPathListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public string GetBindPointList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int BindPointListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int SoundId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)143; } }
  public float Scale { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }

  public static Offset<FB_WeaponModel> CreateFB_WeaponModel(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ResPathList = default(VectorOffset),
      VectorOffset BindPointList = default(VectorOffset),
      int SoundId = 143,
      float Scale = 1) {
    builder.StartObject(5);
    FB_WeaponModel.AddScale(builder, Scale);
    FB_WeaponModel.AddSoundId(builder, SoundId);
    FB_WeaponModel.AddBindPointList(builder, BindPointList);
    FB_WeaponModel.AddResPathList(builder, ResPathList);
    FB_WeaponModel.AddId(builder, Id);
    return FB_WeaponModel.EndFB_WeaponModel(builder);
  }

  public static void StartFB_WeaponModel(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddResPathList(FlatBufferBuilder builder, VectorOffset ResPathListOffset) { builder.AddOffset(1, ResPathListOffset.Value, 0); }
  public static VectorOffset CreateResPathListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartResPathListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBindPointList(FlatBufferBuilder builder, VectorOffset BindPointListOffset) { builder.AddOffset(2, BindPointListOffset.Value, 0); }
  public static VectorOffset CreateBindPointListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBindPointListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSoundId(FlatBufferBuilder builder, int SoundId) { builder.AddInt(3, SoundId, 143); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(4, Scale, 1); }
  public static Offset<FB_WeaponModel> EndFB_WeaponModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeaponModel>(o);
  }
};

public sealed class FB_WeaponModelContainer : Table {
  public static FB_WeaponModelContainer GetRootAsFB_WeaponModelContainer(ByteBuffer _bb) { return GetRootAsFB_WeaponModelContainer(_bb, new FB_WeaponModelContainer()); }
  public static FB_WeaponModelContainer GetRootAsFB_WeaponModelContainer(ByteBuffer _bb, FB_WeaponModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WeaponModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WeaponModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WeaponModel GetItems(int j) { return GetItems(new FB_WeaponModel(), j); }
  public FB_WeaponModel GetItems(FB_WeaponModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WeaponModelContainer> CreateFB_WeaponModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WeaponModelContainer.AddItems(builder, items);
    return FB_WeaponModelContainer.EndFB_WeaponModelContainer(builder);
  }

  public static void StartFB_WeaponModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WeaponModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WeaponModelContainer> EndFB_WeaponModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WeaponModelContainer>(o);
  }
  public static void FinishFB_WeaponModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_WeaponModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
