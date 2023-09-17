// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharModel : Table {
  public static FB_CharModel GetRootAsFB_CharModel(ByteBuffer _bb) { return GetRootAsFB_CharModel(_bb, new FB_CharModel()); }
  public static FB_CharModel GetRootAsFB_CharModel(ByteBuffer _bb, FB_CharModel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharModel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Title { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ResPath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string AnimPath { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string HeadPic { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public float ModelRadius { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float ModelHeight { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float HeadInfoHeight { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float DamageInfoHeight { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int ModelType { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetDeyColorList(int j) { int o = __offset(28); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DeyColorListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public float FresnelPower { get { int o = __offset(30); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FresnelSize { get { int o = __offset(32); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int FakeObjId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float CamZDis { get { int o = __offset(36); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float CamYDis { get { int o = __offset(38); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float CamYRota { get { int o = __offset(40); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int GetCharAnimEffectIdList(int j) { int o = __offset(42); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CharAnimEffectIdListLength { get { int o = __offset(42); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharModel> CreateFB_CharModel(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Title = default(StringOffset),
      StringOffset ResPath = default(StringOffset),
      StringOffset AnimPath = default(StringOffset),
      StringOffset HeadPic = default(StringOffset),
      float ModelRadius = 0,
      float ModelHeight = 0,
      float HeadInfoHeight = 0,
      float DamageInfoHeight = 0,
      float Scale = 0,
      int ModelType = -1,
      VectorOffset DeyColorList = default(VectorOffset),
      float FresnelPower = -1,
      float FresnelSize = -1,
      int FakeObjId = -1,
      float CamZDis = -1,
      float CamYDis = -1,
      float CamYRota = -1,
      VectorOffset CharAnimEffectIdList = default(VectorOffset)) {
    builder.StartObject(20);
    FB_CharModel.AddCharAnimEffectIdList(builder, CharAnimEffectIdList);
    FB_CharModel.AddCamYRota(builder, CamYRota);
    FB_CharModel.AddCamYDis(builder, CamYDis);
    FB_CharModel.AddCamZDis(builder, CamZDis);
    FB_CharModel.AddFakeObjId(builder, FakeObjId);
    FB_CharModel.AddFresnelSize(builder, FresnelSize);
    FB_CharModel.AddFresnelPower(builder, FresnelPower);
    FB_CharModel.AddDeyColorList(builder, DeyColorList);
    FB_CharModel.AddModelType(builder, ModelType);
    FB_CharModel.AddScale(builder, Scale);
    FB_CharModel.AddDamageInfoHeight(builder, DamageInfoHeight);
    FB_CharModel.AddHeadInfoHeight(builder, HeadInfoHeight);
    FB_CharModel.AddModelHeight(builder, ModelHeight);
    FB_CharModel.AddModelRadius(builder, ModelRadius);
    FB_CharModel.AddHeadPic(builder, HeadPic);
    FB_CharModel.AddAnimPath(builder, AnimPath);
    FB_CharModel.AddResPath(builder, ResPath);
    FB_CharModel.AddTitle(builder, Title);
    FB_CharModel.AddName(builder, Name);
    FB_CharModel.AddId(builder, Id);
    return FB_CharModel.EndFB_CharModel(builder);
  }

  public static void StartFB_CharModel(FlatBufferBuilder builder) { builder.StartObject(20); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset TitleOffset) { builder.AddOffset(2, TitleOffset.Value, 0); }
  public static void AddResPath(FlatBufferBuilder builder, StringOffset ResPathOffset) { builder.AddOffset(3, ResPathOffset.Value, 0); }
  public static void AddAnimPath(FlatBufferBuilder builder, StringOffset AnimPathOffset) { builder.AddOffset(4, AnimPathOffset.Value, 0); }
  public static void AddHeadPic(FlatBufferBuilder builder, StringOffset HeadPicOffset) { builder.AddOffset(5, HeadPicOffset.Value, 0); }
  public static void AddModelRadius(FlatBufferBuilder builder, float ModelRadius) { builder.AddFloat(6, ModelRadius, 0); }
  public static void AddModelHeight(FlatBufferBuilder builder, float ModelHeight) { builder.AddFloat(7, ModelHeight, 0); }
  public static void AddHeadInfoHeight(FlatBufferBuilder builder, float HeadInfoHeight) { builder.AddFloat(8, HeadInfoHeight, 0); }
  public static void AddDamageInfoHeight(FlatBufferBuilder builder, float DamageInfoHeight) { builder.AddFloat(9, DamageInfoHeight, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(10, Scale, 0); }
  public static void AddModelType(FlatBufferBuilder builder, int ModelType) { builder.AddInt(11, ModelType, -1); }
  public static void AddDeyColorList(FlatBufferBuilder builder, VectorOffset DeyColorListOffset) { builder.AddOffset(12, DeyColorListOffset.Value, 0); }
  public static VectorOffset CreateDeyColorListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDeyColorListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFresnelPower(FlatBufferBuilder builder, float FresnelPower) { builder.AddFloat(13, FresnelPower, -1); }
  public static void AddFresnelSize(FlatBufferBuilder builder, float FresnelSize) { builder.AddFloat(14, FresnelSize, -1); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(15, FakeObjId, -1); }
  public static void AddCamZDis(FlatBufferBuilder builder, float CamZDis) { builder.AddFloat(16, CamZDis, -1); }
  public static void AddCamYDis(FlatBufferBuilder builder, float CamYDis) { builder.AddFloat(17, CamYDis, -1); }
  public static void AddCamYRota(FlatBufferBuilder builder, float CamYRota) { builder.AddFloat(18, CamYRota, -1); }
  public static void AddCharAnimEffectIdList(FlatBufferBuilder builder, VectorOffset CharAnimEffectIdListOffset) { builder.AddOffset(19, CharAnimEffectIdListOffset.Value, 0); }
  public static VectorOffset CreateCharAnimEffectIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCharAnimEffectIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharModel> EndFB_CharModel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharModel>(o);
  }
};

public sealed class FB_CharModelContainer : Table {
  public static FB_CharModelContainer GetRootAsFB_CharModelContainer(ByteBuffer _bb) { return GetRootAsFB_CharModelContainer(_bb, new FB_CharModelContainer()); }
  public static FB_CharModelContainer GetRootAsFB_CharModelContainer(ByteBuffer _bb, FB_CharModelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharModelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharModelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharModel GetItems(int j) { return GetItems(new FB_CharModel(), j); }
  public FB_CharModel GetItems(FB_CharModel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharModelContainer> CreateFB_CharModelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharModelContainer.AddItems(builder, items);
    return FB_CharModelContainer.EndFB_CharModelContainer(builder);
  }

  public static void StartFB_CharModelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharModel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharModelContainer> EndFB_CharModelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharModelContainer>(o);
  }
  public static void FinishFB_CharModelContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharModelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
