PGDMP  6    "                |           HoloRepository    16.3    16.3 h    3           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            4           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            5           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            6           1262    16399    HoloRepository    DATABASE     �   CREATE DATABASE "HoloRepository" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United Kingdom.1252';
     DROP DATABASE "HoloRepository";
                postgres    false            �            1259    24744 	   bwmodel3d    TABLE     {   CREATE TABLE public.bwmodel3d (
    bw_model_id integer NOT NULL,
    organ_id integer NOT NULL,
    bw_model_path text
);
    DROP TABLE public.bwmodel3d;
       public         heap    postgres    false            �            1259    24743    bwmodel3d_bw_model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.bwmodel3d_bw_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.bwmodel3d_bw_model_id_seq;
       public          postgres    false    237            7           0    0    bwmodel3d_bw_model_id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.bwmodel3d_bw_model_id_seq OWNED BY public.bwmodel3d.bw_model_id;
          public          postgres    false    236            �            1259    24763    colormodel3d    TABLE     �   CREATE TABLE public.colormodel3d (
    color_model_id integer NOT NULL,
    bw_model_id integer NOT NULL,
    color_model_path text
);
     DROP TABLE public.colormodel3d;
       public         heap    postgres    false            �            1259    24762    colormodel3d_color_model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.colormodel3d_color_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.colormodel3d_color_model_id_seq;
       public          postgres    false    239            8           0    0    colormodel3d_color_model_id_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.colormodel3d_color_model_id_seq OWNED BY public.colormodel3d.color_model_id;
          public          postgres    false    238            �            1259    16400 	   dicomfile    TABLE     u   CREATE TABLE public.dicomfile (
    dicom_id integer NOT NULL,
    organ_id integer NOT NULL,
    dicom_path text
);
    DROP TABLE public.dicomfile;
       public         heap    postgres    false            �            1259    16405    dicomfile_dicom_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dicomfile_dicom_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.dicomfile_dicom_id_seq;
       public          postgres    false    215            9           0    0    dicomfile_dicom_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNED BY public.dicomfile.dicom_id;
          public          postgres    false    216            �            1259    24730    dicomsegmentation    TABLE     �   CREATE TABLE public.dicomsegmentation (
    dicom_segmentation_id integer NOT NULL,
    dicom_id integer NOT NULL,
    segmentation_path text
);
 %   DROP TABLE public.dicomsegmentation;
       public         heap    postgres    false            �            1259    24729 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 B   DROP SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq;
       public          postgres    false    235            :           0    0 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE OWNED BY     {   ALTER SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq OWNED BY public.dicomsegmentation.dicom_segmentation_id;
          public          postgres    false    234            �            1259    16406    donor    TABLE     �   CREATE TABLE public.donor (
    donor_id integer NOT NULL,
    age integer NOT NULL,
    date_of_death date NOT NULL,
    cause_of_death text NOT NULL,
    "timestamp" timestamp with time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.donor;
       public         heap    postgres    false            �            1259    16411    donor_donor_id_seq    SEQUENCE     �   CREATE SEQUENCE public.donor_donor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.donor_donor_id_seq;
       public          postgres    false    217            ;           0    0    donor_donor_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.donor_donor_id_seq OWNED BY public.donor.donor_id;
          public          postgres    false    218            �            1259    16412    model3d    TABLE     j   CREATE TABLE public.model3d (
    model_id integer NOT NULL,
    organ_id integer,
    model_path text
);
    DROP TABLE public.model3d;
       public         heap    postgres    false            �            1259    16417    model3d_model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.model3d_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.model3d_model_id_seq;
       public          postgres    false    219            <           0    0    model3d_model_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.model3d_model_id_seq OWNED BY public.model3d.model_id;
          public          postgres    false    220            �            1259    16418    organ    TABLE     �   CREATE TABLE public.organ (
    organ_id integer NOT NULL,
    donor_id integer NOT NULL,
    organ_name_id integer,
    organ_side text
);
    DROP TABLE public.organ;
       public         heap    postgres    false            �            1259    16421    organ_organ_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organ_organ_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.organ_organ_id_seq;
       public          postgres    false    221            =           0    0    organ_organ_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.organ_organ_id_seq OWNED BY public.organ.organ_id;
          public          postgres    false    222            �            1259    16422 	   organname    TABLE     z   CREATE TABLE public.organname (
    organ_name_id integer NOT NULL,
    organ_name text,
    has_side boolean NOT NULL
);
    DROP TABLE public.organname;
       public         heap    postgres    false            �            1259    16427    organname_organ_name_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organname_organ_name_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.organname_organ_name_id_seq;
       public          postgres    false    223            >           0    0    organname_organ_name_id_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.organname_organ_name_id_seq OWNED BY public.organname.organ_name_id;
          public          postgres    false    224            �            1259    16428    organtag    TABLE     ]   CREATE TABLE public.organtag (
    organ_id integer NOT NULL,
    tag_id integer NOT NULL
);
    DROP TABLE public.organtag;
       public         heap    postgres    false            �            1259    16431    segmentation    TABLE     }   CREATE TABLE public.segmentation (
    segmentation_id integer NOT NULL,
    slice_id integer,
    segmentation_path text
);
     DROP TABLE public.segmentation;
       public         heap    postgres    false            �            1259    16436     segmentation_segmentation_id_seq    SEQUENCE     �   CREATE SEQUENCE public.segmentation_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.segmentation_segmentation_id_seq;
       public          postgres    false    226            ?           0    0     segmentation_segmentation_id_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNED BY public.segmentation.segmentation_id;
          public          postgres    false    227            �            1259    16437 
   sliceimage    TABLE     �   CREATE TABLE public.sliceimage (
    slice_id integer NOT NULL,
    organ_id integer,
    dicom_id integer,
    additional_info text,
    image_path text
);
    DROP TABLE public.sliceimage;
       public         heap    postgres    false            �            1259    16442    sliceimage_slice_id_seq    SEQUENCE     �   CREATE SEQUENCE public.sliceimage_slice_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.sliceimage_slice_id_seq;
       public          postgres    false    228            @           0    0    sliceimage_slice_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.sliceimage_slice_id_seq OWNED BY public.sliceimage.slice_id;
          public          postgres    false    229            �            1259    16443    tag    TABLE     U   CREATE TABLE public.tag (
    tag_id integer NOT NULL,
    tag_name text NOT NULL
);
    DROP TABLE public.tag;
       public         heap    postgres    false            �            1259    16448    tag_tag_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tag_tag_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.tag_tag_id_seq;
       public          postgres    false    230            A           0    0    tag_tag_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.tag_tag_id_seq OWNED BY public.tag.tag_id;
          public          postgres    false    231            �            1259    16449 
   texturemap    TABLE     x   CREATE TABLE public.texturemap (
    texture_id integer NOT NULL,
    segmentation_id integer,
    texture_path text
);
    DROP TABLE public.texturemap;
       public         heap    postgres    false            �            1259    16454    texturemap_texture_id_seq    SEQUENCE     �   CREATE SEQUENCE public.texturemap_texture_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.texturemap_texture_id_seq;
       public          postgres    false    232            B           0    0    texturemap_texture_id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.texturemap_texture_id_seq OWNED BY public.texturemap.texture_id;
          public          postgres    false    233            `           2604    24747    bwmodel3d bw_model_id    DEFAULT     ~   ALTER TABLE ONLY public.bwmodel3d ALTER COLUMN bw_model_id SET DEFAULT nextval('public.bwmodel3d_bw_model_id_seq'::regclass);
 D   ALTER TABLE public.bwmodel3d ALTER COLUMN bw_model_id DROP DEFAULT;
       public          postgres    false    237    236    237            a           2604    24766    colormodel3d color_model_id    DEFAULT     �   ALTER TABLE ONLY public.colormodel3d ALTER COLUMN color_model_id SET DEFAULT nextval('public.colormodel3d_color_model_id_seq'::regclass);
 J   ALTER TABLE public.colormodel3d ALTER COLUMN color_model_id DROP DEFAULT;
       public          postgres    false    238    239    239            U           2604    16455    dicomfile dicom_id    DEFAULT     x   ALTER TABLE ONLY public.dicomfile ALTER COLUMN dicom_id SET DEFAULT nextval('public.dicomfile_dicom_id_seq'::regclass);
 A   ALTER TABLE public.dicomfile ALTER COLUMN dicom_id DROP DEFAULT;
       public          postgres    false    216    215            _           2604    24733 '   dicomsegmentation dicom_segmentation_id    DEFAULT     �   ALTER TABLE ONLY public.dicomsegmentation ALTER COLUMN dicom_segmentation_id SET DEFAULT nextval('public.dicomsegmentation_dicom_segmentation_id_seq'::regclass);
 V   ALTER TABLE public.dicomsegmentation ALTER COLUMN dicom_segmentation_id DROP DEFAULT;
       public          postgres    false    234    235    235            V           2604    16456    donor donor_id    DEFAULT     p   ALTER TABLE ONLY public.donor ALTER COLUMN donor_id SET DEFAULT nextval('public.donor_donor_id_seq'::regclass);
 =   ALTER TABLE public.donor ALTER COLUMN donor_id DROP DEFAULT;
       public          postgres    false    218    217            X           2604    16457    model3d model_id    DEFAULT     t   ALTER TABLE ONLY public.model3d ALTER COLUMN model_id SET DEFAULT nextval('public.model3d_model_id_seq'::regclass);
 ?   ALTER TABLE public.model3d ALTER COLUMN model_id DROP DEFAULT;
       public          postgres    false    220    219            Y           2604    16458    organ organ_id    DEFAULT     p   ALTER TABLE ONLY public.organ ALTER COLUMN organ_id SET DEFAULT nextval('public.organ_organ_id_seq'::regclass);
 =   ALTER TABLE public.organ ALTER COLUMN organ_id DROP DEFAULT;
       public          postgres    false    222    221            Z           2604    16459    organname organ_name_id    DEFAULT     �   ALTER TABLE ONLY public.organname ALTER COLUMN organ_name_id SET DEFAULT nextval('public.organname_organ_name_id_seq'::regclass);
 F   ALTER TABLE public.organname ALTER COLUMN organ_name_id DROP DEFAULT;
       public          postgres    false    224    223            [           2604    16460    segmentation segmentation_id    DEFAULT     �   ALTER TABLE ONLY public.segmentation ALTER COLUMN segmentation_id SET DEFAULT nextval('public.segmentation_segmentation_id_seq'::regclass);
 K   ALTER TABLE public.segmentation ALTER COLUMN segmentation_id DROP DEFAULT;
       public          postgres    false    227    226            \           2604    16461    sliceimage slice_id    DEFAULT     z   ALTER TABLE ONLY public.sliceimage ALTER COLUMN slice_id SET DEFAULT nextval('public.sliceimage_slice_id_seq'::regclass);
 B   ALTER TABLE public.sliceimage ALTER COLUMN slice_id DROP DEFAULT;
       public          postgres    false    229    228            ]           2604    16462 
   tag tag_id    DEFAULT     h   ALTER TABLE ONLY public.tag ALTER COLUMN tag_id SET DEFAULT nextval('public.tag_tag_id_seq'::regclass);
 9   ALTER TABLE public.tag ALTER COLUMN tag_id DROP DEFAULT;
       public          postgres    false    231    230            ^           2604    16463    texturemap texture_id    DEFAULT     ~   ALTER TABLE ONLY public.texturemap ALTER COLUMN texture_id SET DEFAULT nextval('public.texturemap_texture_id_seq'::regclass);
 D   ALTER TABLE public.texturemap ALTER COLUMN texture_id DROP DEFAULT;
       public          postgres    false    233    232            .          0    24744 	   bwmodel3d 
   TABLE DATA           I   COPY public.bwmodel3d (bw_model_id, organ_id, bw_model_path) FROM stdin;
    public          postgres    false    237   �x       0          0    24763    colormodel3d 
   TABLE DATA           U   COPY public.colormodel3d (color_model_id, bw_model_id, color_model_path) FROM stdin;
    public          postgres    false    239   �x                 0    16400 	   dicomfile 
   TABLE DATA           C   COPY public.dicomfile (dicom_id, organ_id, dicom_path) FROM stdin;
    public          postgres    false    215   y       ,          0    24730    dicomsegmentation 
   TABLE DATA           _   COPY public.dicomsegmentation (dicom_segmentation_id, dicom_id, segmentation_path) FROM stdin;
    public          postgres    false    235   y                 0    16406    donor 
   TABLE DATA           Z   COPY public.donor (donor_id, age, date_of_death, cause_of_death, "timestamp") FROM stdin;
    public          postgres    false    217   <y                 0    16412    model3d 
   TABLE DATA           A   COPY public.model3d (model_id, organ_id, model_path) FROM stdin;
    public          postgres    false    219   �y                 0    16418    organ 
   TABLE DATA           N   COPY public.organ (organ_id, donor_id, organ_name_id, organ_side) FROM stdin;
    public          postgres    false    221   �y                  0    16422 	   organname 
   TABLE DATA           H   COPY public.organname (organ_name_id, organ_name, has_side) FROM stdin;
    public          postgres    false    223   �y       "          0    16428    organtag 
   TABLE DATA           4   COPY public.organtag (organ_id, tag_id) FROM stdin;
    public          postgres    false    225   Fz       #          0    16431    segmentation 
   TABLE DATA           T   COPY public.segmentation (segmentation_id, slice_id, segmentation_path) FROM stdin;
    public          postgres    false    226   cz       %          0    16437 
   sliceimage 
   TABLE DATA           _   COPY public.sliceimage (slice_id, organ_id, dicom_id, additional_info, image_path) FROM stdin;
    public          postgres    false    228   �z       '          0    16443    tag 
   TABLE DATA           /   COPY public.tag (tag_id, tag_name) FROM stdin;
    public          postgres    false    230   �z       )          0    16449 
   texturemap 
   TABLE DATA           O   COPY public.texturemap (texture_id, segmentation_id, texture_path) FROM stdin;
    public          postgres    false    232    {       C           0    0    bwmodel3d_bw_model_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.bwmodel3d_bw_model_id_seq', 1, false);
          public          postgres    false    236            D           0    0    colormodel3d_color_model_id_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.colormodel3d_color_model_id_seq', 1, false);
          public          postgres    false    238            E           0    0    dicomfile_dicom_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.dicomfile_dicom_id_seq', 1, false);
          public          postgres    false    216            F           0    0 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('public.dicomsegmentation_dicom_segmentation_id_seq', 1, false);
          public          postgres    false    234            G           0    0    donor_donor_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.donor_donor_id_seq', 1, true);
          public          postgres    false    218            H           0    0    model3d_model_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.model3d_model_id_seq', 1, false);
          public          postgres    false    220            I           0    0    organ_organ_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.organ_organ_id_seq', 1, true);
          public          postgres    false    222            J           0    0    organname_organ_name_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.organname_organ_name_id_seq', 6, true);
          public          postgres    false    224            K           0    0     segmentation_segmentation_id_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.segmentation_segmentation_id_seq', 1, false);
          public          postgres    false    227            L           0    0    sliceimage_slice_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.sliceimage_slice_id_seq', 1, false);
          public          postgres    false    229            M           0    0    tag_tag_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.tag_tag_id_seq', 6, true);
          public          postgres    false    231            N           0    0    texturemap_texture_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.texturemap_texture_id_seq', 1, false);
          public          postgres    false    233            y           2606    24751    bwmodel3d bwmodel3d_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.bwmodel3d
    ADD CONSTRAINT bwmodel3d_pkey PRIMARY KEY (bw_model_id);
 B   ALTER TABLE ONLY public.bwmodel3d DROP CONSTRAINT bwmodel3d_pkey;
       public            postgres    false    237            {           2606    24770    colormodel3d colormodel3d_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.colormodel3d
    ADD CONSTRAINT colormodel3d_pkey PRIMARY KEY (color_model_id);
 H   ALTER TABLE ONLY public.colormodel3d DROP CONSTRAINT colormodel3d_pkey;
       public            postgres    false    239            c           2606    16465    dicomfile dicomfile_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT dicomfile_pkey PRIMARY KEY (dicom_id);
 B   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT dicomfile_pkey;
       public            postgres    false    215            w           2606    24737 (   dicomsegmentation dicomsegmentation_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicomsegmentation_pkey PRIMARY KEY (dicom_segmentation_id);
 R   ALTER TABLE ONLY public.dicomsegmentation DROP CONSTRAINT dicomsegmentation_pkey;
       public            postgres    false    235            e           2606    16467    donor donor_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.donor
    ADD CONSTRAINT donor_pkey PRIMARY KEY (donor_id);
 :   ALTER TABLE ONLY public.donor DROP CONSTRAINT donor_pkey;
       public            postgres    false    217            g           2606    16469    model3d model3d_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT model3d_pkey PRIMARY KEY (model_id);
 >   ALTER TABLE ONLY public.model3d DROP CONSTRAINT model3d_pkey;
       public            postgres    false    219            i           2606    16471    organ organ_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_pkey PRIMARY KEY (organ_id);
 :   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_pkey;
       public            postgres    false    221            k           2606    16473    organname organname_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.organname
    ADD CONSTRAINT organname_pkey PRIMARY KEY (organ_name_id);
 B   ALTER TABLE ONLY public.organname DROP CONSTRAINT organname_pkey;
       public            postgres    false    223            m           2606    16475    organtag organtag_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organtag_pkey PRIMARY KEY (organ_id, tag_id);
 @   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organtag_pkey;
       public            postgres    false    225    225            o           2606    16477    segmentation segmentation_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT segmentation_pkey PRIMARY KEY (segmentation_id);
 H   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT segmentation_pkey;
       public            postgres    false    226            q           2606    16479    sliceimage sliceimage_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT sliceimage_pkey PRIMARY KEY (slice_id);
 D   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT sliceimage_pkey;
       public            postgres    false    228            s           2606    16481    tag tag_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.tag
    ADD CONSTRAINT tag_pkey PRIMARY KEY (tag_id);
 6   ALTER TABLE ONLY public.tag DROP CONSTRAINT tag_pkey;
       public            postgres    false    230            u           2606    16483    texturemap texturemap_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT texturemap_pkey PRIMARY KEY (texture_id);
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT texturemap_pkey;
       public            postgres    false    232            �           2606    24757 !   bwmodel3d bwmodel3d_organ_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.bwmodel3d
    ADD CONSTRAINT bwmodel3d_organ_id_fkey FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;
 K   ALTER TABLE ONLY public.bwmodel3d DROP CONSTRAINT bwmodel3d_organ_id_fkey;
       public          postgres    false    237    4713    221            �           2606    24771 *   colormodel3d colormodel3d_bw_model_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.colormodel3d
    ADD CONSTRAINT colormodel3d_bw_model_id_fkey FOREIGN KEY (bw_model_id) REFERENCES public.bwmodel3d(bw_model_id) ON UPDATE CASCADE ON DELETE CASCADE;
 T   ALTER TABLE ONLY public.colormodel3d DROP CONSTRAINT colormodel3d_bw_model_id_fkey;
       public          postgres    false    239    4729    237            �           2606    16484    sliceimage dicom_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT dicom_id;
       public          postgres    false    215    4707    228            �           2606    24738    dicomsegmentation dicom_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public.dicomsegmentation DROP CONSTRAINT dicom_id;
       public          postgres    false    215    235    4707            ~           2606    16562    organ donor_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT donor_id FOREIGN KEY (donor_id) REFERENCES public.donor(donor_id) ON UPDATE CASCADE ON DELETE CASCADE;
 8   ALTER TABLE ONLY public.organ DROP CONSTRAINT donor_id;
       public          postgres    false    221    4709    217            �           2606    16494    organtag organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 ;   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organ_id;
       public          postgres    false    225    221    4713            }           2606    16499    model3d organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.model3d DROP CONSTRAINT organ_id;
       public          postgres    false    219    221    4713            �           2606    16504    sliceimage organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT organ_id;
       public          postgres    false    221    228    4713            |           2606    16509    dicomfile organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 <   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT organ_id;
       public          postgres    false    221    4713    215                       2606    16514    organ organ_name_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_name_id FOREIGN KEY (organ_name_id) REFERENCES public.organname(organ_name_id);
 =   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_name_id;
       public          postgres    false    221    223    4715            �           2606    16519    texturemap segmentation_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT segmentation_id FOREIGN KEY (segmentation_id) REFERENCES public.segmentation(segmentation_id) ON DELETE CASCADE;
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT segmentation_id;
       public          postgres    false    4719    226    232            �           2606    16524    segmentation slice_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT slice_id FOREIGN KEY (slice_id) REFERENCES public.sliceimage(slice_id) ON DELETE CASCADE;
 ?   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT slice_id;
       public          postgres    false    226    4721    228            �           2606    16529    organtag tag_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT tag_id FOREIGN KEY (tag_id) REFERENCES public.tag(tag_id) ON DELETE CASCADE;
 9   ALTER TABLE ONLY public.organtag DROP CONSTRAINT tag_id;
       public          postgres    false    4723    230    225            .      x������ � �      0      x������ � �            x������ � �      ,      x������ � �         j   x�m�1
1k�郍�+G:��p\{E�_Ć@�����V<
��'�x_���-�D��@�0�=E+��-�M��]�O�:�[�����p���W��5������w"            x������ � �            x������ � �          F   x�3��HM,*�L�2��)�K�,�2���L�K�2M8}2�R�����NE��y@�gpI~nbr����� i<�      "      x������ � �      #      x������ � �      %      x������ � �      '   S   x�3�t��t�5��2�t�LLJ-I-�2��OJ-�,��2��M��+-)�,����2��HM�)ɨ�2�t�I�����,������ :u<      )      x������ � �     